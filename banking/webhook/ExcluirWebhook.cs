using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class ExcluirWebhook {
		public void Excluir(Config config, string tipoWebhook) {
			InterSdk.LogInfo("ExcluirWebhook banking {0} {1}", config.ClientId, tipoWebhook);
			string url = Constants.URL_BANKING_WEBHOOK.Replace("AMBIENTE", config.Ambiente) + "/" + tipoWebhook;
			HttpUtils.CallDelete(config, url, Constants.ESCOPO_BANKING_WEBHOOK_BANKING_WRITE, "Erro ao excluir webhook");
		}

	}
}
