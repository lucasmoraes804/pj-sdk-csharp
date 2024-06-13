using System.Text;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	public class ObterWebhook {
		public Webhook Obter(Config config) {
			InterSdk.LogInfo("ObterWebhook cobrança {0}", config.ClientId);
			string url = Constants.URL_BOLETOS_WEBHOOK.Replace("AMBIENTE", config.Ambiente);
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_BOLETO_COBRANCA_READ, "Erro ao obter webhook");
			return (Webhook) SdkUtils.Deserialize(typeof(Webhook), json);
		}

	}
}
