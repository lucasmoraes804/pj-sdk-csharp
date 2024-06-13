using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class IncluirPagamentoDarf {
		public RespostaIncluirPagamentoDarf Incluir(Config config, PagamentoDarf pagamento) {
			InterSdk.LogInfo("IncluirPagamentoDarf {0} {1}", config.ClientId, pagamento.CodigoReceita);
			string url = Constants.URL_BANKING_PAGAMENTO_DARF.Replace("AMBIENTE", config.Ambiente);
			string json = SdkUtils.Serialize(pagamento);
			json = HttpUtils.CallPost(config, url, Constants.ESCOPO_PAGAMENTO_DARF_WRITE, "Erro ao incluir pagamento de darf", json);
			return (RespostaIncluirPagamentoDarf) SdkUtils.Deserialize(typeof(RespostaIncluirPagamentoDarf), json);
		}

	}
}
