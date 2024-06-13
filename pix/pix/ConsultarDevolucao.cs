using System.Text;
using System.Collections.Generic;

namespace Sdk.PixApi {
	public class ConsultarDevolucao {
		public DevolucaoDetalhada Consultar(Config config, string e2eId, string id) {
			InterSdk.LogInfo("ConsultarDevolucao {0} e2eId={1} id={2}", config.ClientId, e2eId, id);
			string url = Constants.URL_PIX_PIX.Replace("AMBIENTE", config.Ambiente) + "/" + e2eId + "/devolucao/" + id;
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_PIX_PIX_READ, "Erro ao consultar devolução");
			return (DevolucaoDetalhada) SdkUtils.Deserialize(typeof(DevolucaoDetalhada), json);
		}

	}
}
