using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class BuscarPagamentos {
		public List<Pagamento> Buscar(Config config, string dataInicial, string dataFinal, FiltroBuscarPagamentos filtro) {
			InterSdk.LogInfo("BuscarPagamentos {0} {1}-{2}", config.ClientId, dataInicial, dataFinal);
			string url = Constants.URL_BANKING_PAGAMENTO.Replace("AMBIENTE", config.Ambiente) + "?dataInicio=" + dataInicial + "&dataFim=" + dataFinal + Addfilters(filtro);
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_PAGAMENTO_BOLETO_READ, "Erro ao buscar pagamentos");
			return (List<Pagamento>) SdkUtils.Deserialize(typeof(List<Pagamento>), json);
		}

		public string Addfilters(FiltroBuscarPagamentos filtro) {
			if (filtro == null ) {
				return "";
			}
			StringBuilder filter = new StringBuilder();
			if (filtro.CodBarraLinhaDigitavel != null ) {
				filter.Append("&codBarraLinhaDigitavel").Append("=").Append(filtro.CodBarraLinhaDigitavel);
			}
			if (filtro.CodigoTransacao != null ) {
				filter.Append("&codigoTransacao").Append("=").Append(filtro.CodigoTransacao);
			}
			if (filtro.FiltrarDataPor != null ) {
				filter.Append("&filtrarDataPor").Append("=").Append(filtro.FiltrarDataPor.ToString());
			}
			return filter.ToString();
		}

	}
}
