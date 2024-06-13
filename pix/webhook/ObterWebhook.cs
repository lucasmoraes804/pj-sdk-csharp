using System.Text;
using System.Collections.Generic;

namespace Sdk.PixApi {
	public class ObterWebhook {
		public Webhook Obter(Config config, string chave) {
			InterSdk.LogInfo("ObterWebhook pix {0} {1}", config.ClientId, chave);
			string url = Constants.URL_PIX_WEBHOOK.Replace("AMBIENTE", config.Ambiente) + "/" + chave;
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_PIX_WEBHOOK_READ, "Erro ao obter webhook");
			return (Webhook) SdkUtils.Deserialize(typeof(Webhook), json);
		}

	}
}
