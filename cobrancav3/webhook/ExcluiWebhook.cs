using System.Text;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	public class ExcluiWebhook {
		public void Excluir(Config config) {
			InterSdk.LogInfo("ExcluirWebhook cobrançaV3 {0}", config.ClientId);
			string url = Constants.URL_COBRANCAS_WEBHOOK.Replace("AMBIENTE", config.Ambiente);
			HttpUtils.CallDelete(config, url, Constants.ESCOPO_BOLETO_COBRANCA_WRITE, "Erro ao excluir webhook");
		}

	}
}
