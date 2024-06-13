using System.Text;
using System.Collections.Generic;

namespace Sdk.PixApi {
	public class ExcluirWebhook {
		public void Excluir(Config config, string chave) {
			InterSdk.LogInfo("ExcluirWebhook pix {0} {1}", config.ClientId, chave);
			string url = Constants.URL_PIX_WEBHOOK.Replace("AMBIENTE", config.Ambiente) + "/" + chave;
			HttpUtils.CallDelete(config, url, Constants.ESCOPO_PIX_WEBHOOK_WRITE, "Erro ao excluir webhook");
		}

	}
}
