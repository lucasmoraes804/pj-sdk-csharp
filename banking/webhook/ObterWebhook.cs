using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class ObterWebhook {
		public Webhook Obter(Config config, string tipoWebhook) {
			InterSdk.LogInfo("ObterWebhook banking {0} {1}", config.ClientId, tipoWebhook);
			string url = Constants.URL_BANKING_WEBHOOK.Replace("AMBIENTE", config.Ambiente) + "/" + tipoWebhook;
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_BANKING_WEBHOOK_BANKING_READ, "Erro ao obter webhook");
			return (Webhook) SdkUtils.Deserialize(typeof(Webhook), json);
		}

	}
}
