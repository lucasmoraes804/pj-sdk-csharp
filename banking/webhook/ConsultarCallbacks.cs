using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class ConsultarCallbacks {
		public PaginaCallbacks Recuperar(Config config, string tipoWebhook, string dataHoraInicio, string dataHoraFim, int pagina, int tamanhoPagina, FiltroBuscarCallbacks filtro) {
			InterSdk.LogInfo("ConsultarCallbacks {0} {1}-{2}", config.ClientId, dataHoraInicio, dataHoraFim);
			return GetPage(config, tipoWebhook, dataHoraInicio, dataHoraFim, pagina, tamanhoPagina, filtro);
		}

		public List<RespostaBuscarCallbacks> Recuperar(Config config, string tipoWebhook, string dataInicial, string dataFinal, FiltroBuscarCallbacks filtro) {
			InterSdk.LogInfo("ConsultarCallbacks {0} {1}-{2}", config.ClientId, dataInicial, dataFinal);
			int pagina = 0;
			PaginaCallbacks paginaCallbacks;
			List<RespostaBuscarCallbacks> callbacks = new List<RespostaBuscarCallbacks>();
			do {
				paginaCallbacks = GetPage(config, tipoWebhook, dataInicial, dataFinal, pagina, 0, filtro);
				callbacks.AddRange(paginaCallbacks.Data);
				pagina++;
			} while (pagina < paginaCallbacks.TotalPaginas);
			return callbacks;
		}

		public PaginaCallbacks GetPage(Config config, string tipoWebhook, string dataHoraInicio, string dataHoraFim, int pagina, int tamanhoPagina, FiltroBuscarCallbacks filtro) {
			string url1 = Constants.URL_BANKING_WEBHOOK.Replace("AMBIENTE", config.Ambiente);
			string url2 = url1 + "/" + tipoWebhook + "/callbacks";
			string url = url2 + "?dataHoraInicio=" + dataHoraInicio + "&dataHoraFim=" + dataHoraFim + "&pagina=" + pagina + SdkUtils.PrmTamanhoPagina(tamanhoPagina) + Addfilters(filtro);
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_BANKING_WEBHOOK_BANKING_READ, "Erro ao recuperar callbacks");
			return (PaginaCallbacks) SdkUtils.Deserialize(typeof(PaginaCallbacks), json);
		}

		public string Addfilters(FiltroBuscarCallbacks filtro) {
			if (filtro == null ) {
				return "";
			}
			StringBuilder filter = new StringBuilder();
			if (filtro.CodigoTransacao != null ) {
				filter.Append("&codigoTransacao").Append("=").Append(filtro.CodigoTransacao);
			}
			if (filtro.EndToEnd != null ) {
				filter.Append("&endToEnd").Append("=").Append(filtro.EndToEnd);
			}
			return filter.ToString();
		}

	}
}
