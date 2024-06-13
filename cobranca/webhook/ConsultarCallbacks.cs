using System.Text;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	public class ConsultarCallbacks {
		public PaginaCallbacks Recuperar(Config config, string dataHoraInicio, string dataHoraFim, int pagina, int tamanhoPagina, FiltroBuscarCallbacks filtro) {
			InterSdk.LogInfo("ConsultarCallbacks {0} {1}-{2}", config.ClientId, dataHoraInicio, dataHoraFim);
			return GetPage(config, dataHoraInicio, dataHoraFim, pagina, tamanhoPagina, filtro);
		}

		public List<RespostaBuscarCallbacks> Recuperar(Config config, string dataHoraInicio, string dataHoraFim, FiltroBuscarCallbacks filtro) {
			InterSdk.LogInfo("ConsultarCallbacks {0} {1}-{2}", config.ClientId, dataHoraInicio, dataHoraFim);
			int pagina = 0;
			PaginaCallbacks paginaCallbacks;
			List<RespostaBuscarCallbacks> callbacks = new List<RespostaBuscarCallbacks>();
			do {
				paginaCallbacks = GetPage(config, dataHoraInicio, dataHoraFim, pagina, 0, filtro);
				callbacks.AddRange(paginaCallbacks.Data);
				pagina++;
			} while (pagina < paginaCallbacks.TotalPaginas);
			return callbacks;
		}

		public PaginaCallbacks GetPage(Config config, string dataHoraInicio, string dataHoraFim, int pagina, int tamanhoPagina, FiltroBuscarCallbacks filtro) {
			string url = Constants.URL_BOLETOS_WEBHOOK_CALLBACKS.Replace("AMBIENTE", config.Ambiente) + "?dataHoraInicio=" + dataHoraInicio + "&dataHoraFim=" + dataHoraFim + "&pagina=" + pagina + SdkUtils.PrmTamanhoPagina(tamanhoPagina) + Addfilters(filtro);
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_BOLETO_COBRANCA_READ, "Erro ao recuperar callbacks");
			return (PaginaCallbacks) SdkUtils.Deserialize(typeof(PaginaCallbacks), json);
		}

		public string Addfilters(FiltroBuscarCallbacks filtro) {
			if (filtro == null ) {
				return "";
			}
			StringBuilder filter = new StringBuilder();
			if (filtro.NossoNumero != null ) {
				filter.Append("&nossoNumero").Append("=").Append(filtro.NossoNumero);
			}
			return filter.ToString();
		}

	}
}
