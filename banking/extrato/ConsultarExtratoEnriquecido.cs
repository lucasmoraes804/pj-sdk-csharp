using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class ConsultarExtratoEnriquecido {
		public PaginaExtratoEnriquecido Consultar(Config config, string dataInicial, string dataFinal, int pagina, int tamanhoPagina, FiltroConsultarExtratoEnriquecido filtro) {
			InterSdk.LogInfo("ConsultarExtratoEnriquecido {0} {1}-{2}", config.ClientId, dataInicial, dataFinal);
			return GetPage(config, dataInicial, dataFinal, pagina, tamanhoPagina, filtro);
		}

		public List<TransacaoEnriquecida> Consultar(Config config, string dataInicial, string dataFinal, FiltroConsultarExtratoEnriquecido filtro) {
			InterSdk.LogInfo("ConsultarExtratoEnriquecido {0} {1}-{2}", config.ClientId, dataInicial, dataFinal);
			int pagina = 0;
			PaginaExtratoEnriquecido paginaTransacoes;
			List<TransacaoEnriquecida> transacoes = new List<TransacaoEnriquecida>();
			do {
				paginaTransacoes = GetPage(config, dataInicial, dataFinal, pagina, 0, filtro);
				transacoes.AddRange(paginaTransacoes.Transacoes);
				pagina++;
			} while (pagina < paginaTransacoes.TotalPaginas);
			return transacoes;
		}

		public PaginaExtratoEnriquecido GetPage(Config config, string dataInicial, string dataFinal, int pagina, int tamanhoPagina, FiltroConsultarExtratoEnriquecido filtro) {
			string url = Constants.URL_BANKING_EXTRATO_ENRIQUECIDO.Replace("AMBIENTE", config.Ambiente) + "?dataInicio=" + dataInicial + "&dataFim=" + dataFinal + "&pagina=" + pagina + SdkUtils.PrmTamanhoPagina(tamanhoPagina) + Addfilters(filtro);
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_EXTRATO_READ, "Erro ao consultar extrato enriquecido");
			return (PaginaExtratoEnriquecido) SdkUtils.Deserialize(typeof(PaginaExtratoEnriquecido), json);
		}

		public string Addfilters(FiltroConsultarExtratoEnriquecido filtro) {
			if (filtro == null ) {
				return "";
			}
			StringBuilder filter = new StringBuilder();
			if (filtro.TipoOperacao != null ) {
				filter.Append("&tipoOperacao").Append("=").Append(filtro.TipoOperacao.ToString());
			}
			if (filtro.TipoTransacao != null ) {
				filter.Append("&tipoTransacao").Append("=").Append(filtro.TipoTransacao.ToString());
			}
			return filter.ToString();
		}

	}
}
