using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class BuscarPagamentosDarf {
		public List<RetornoPagamentoDarf> Buscar(Config config, string dataInicial, string dataFinal, FiltroBuscarPagamentosDarf filtro) {
			InterSdk.LogInfo("BuscarPagamentosDarf {0} {1}-{2}", config.ClientId, dataInicial, dataFinal);
			string url = Constants.URL_BANKING_PAGAMENTO_DARF.Replace("AMBIENTE", config.Ambiente) + "?dataInicio=" + dataInicial + "&dataFim=" + dataFinal + Addfilters(filtro);
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_PAGAMENTO_BOLETO_READ, "Erro ao buscar pagamentos de DARF");
			return (List<RetornoPagamentoDarf>) SdkUtils.Deserialize(typeof(List<RetornoPagamentoDarf>), json);
		}

		public string Addfilters(FiltroBuscarPagamentosDarf filtro) {
			if (filtro == null ) {
				return "";
			}
			StringBuilder filter = new StringBuilder();
			if (filtro.CodigoTransacao != null ) {
				filter.Append("&codigoTransacao").Append("=").Append(filtro.CodigoTransacao);
			}
			if (filtro.CodigoReceita != null ) {
				filter.Append("&codigoReceita").Append("=").Append(filtro.CodigoReceita);
			}
			if (filtro.FiltrarDataPor != null ) {
				filter.Append("&filtrarDataPor").Append("=").Append(filtro.FiltrarDataPor.ToString());
			}
			return filter.ToString();
		}

	}
}
