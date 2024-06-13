using System.Text;
using System.Collections.Generic;

namespace Sdk.PixApi {
	public class CriarWebhook {
		public void Criar(Config config, string webhookUrl, string chave) {
			InterSdk.LogInfo("CriarWebhook pix {0} {1} {2}", config.ClientId, webhookUrl, chave);
			string url = Constants.URL_PIX_WEBHOOK.Replace("AMBIENTE", config.Ambiente) + "/" + chave;
			CriarWebhookRequest request = CriarWebhookRequest.Builder()
				.SetWebhookUrl(webhookUrl)
				.Build();
			string json = SdkUtils.Serialize(request);
			HttpUtils.CallPut(config, url, Constants.ESCOPO_PIX_WEBHOOK_WRITE, "Erro ao criar webhook", json);
		}

	}
}
