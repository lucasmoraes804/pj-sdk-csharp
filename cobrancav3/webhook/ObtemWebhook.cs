using System.Text;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	public class ObtemWebhook {
		public Webhook Obter(Config config) {
			InterSdk.LogInfo("ObterWebhook cobrançaV3 {0}", config.ClientId);
			string url = Constants.URL_COBRANCAS_WEBHOOK.Replace("AMBIENTE", config.Ambiente);
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_BOLETO_COBRANCA_READ, "Erro ao obter webhook");
			return (Webhook) SdkUtils.Deserialize(typeof(Webhook), json);
		}

	}
}
