using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class IncluirPagamento {
		public RespostaIncluirPagamento Incluir(Config config, PagamentoBoleto pagamento) {
			InterSdk.LogInfo("IncluirPagamento {0} {1}", config.ClientId, pagamento.CodBarraLinhaDigitavel);
			string url = Constants.URL_BANKING_PAGAMENTO.Replace("AMBIENTE", config.Ambiente);
			string json = SdkUtils.Serialize(pagamento);
			json = HttpUtils.CallPost(config, url, Constants.ESCOPO_PAGAMENTO_BOLETO_WRITE, "Erro ao incluir pagamento", json);
			return (RespostaIncluirPagamento) SdkUtils.Deserialize(typeof(RespostaIncluirPagamento), json);
		}

	}
}
