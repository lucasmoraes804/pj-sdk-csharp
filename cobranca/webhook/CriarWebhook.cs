using System.Text;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	public class CriarWebhook {
		public void Criar(Config config, string webhookUrl) {
			InterSdk.LogInfo("CriarWebhook cobrança {0} {1}", config.ClientId, webhookUrl);
			string url = Constants.URL_BOLETOS_WEBHOOK.Replace("AMBIENTE", config.Ambiente);
			CriarWebhookRequest request = CriarWebhookRequest.Builder()
				.SetWebhookUrl(webhookUrl)
				.Build();
			string json = SdkUtils.Serialize(request);
			HttpUtils.CallPut(config, url, Constants.ESCOPO_BOLETO_COBRANCA_WRITE, "Erro ao criar webhook", json);
		}

	}
}
