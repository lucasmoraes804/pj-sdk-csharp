using System.Text;
using System.Collections.Generic;

namespace Sdk.PixApi {
	public class ConsultarPix {
		public Pix Consultar(Config config, string e2eId) {
			InterSdk.LogInfo("ConsultarPix {0} e2eId={1}", config.ClientId, e2eId);
			string url = Constants.URL_PIX_PIX.Replace("AMBIENTE", config.Ambiente) + "/" + e2eId;
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_PIX_PIX_READ, "Erro ao consultar pix");
			return (Pix) SdkUtils.Deserialize(typeof(Pix), json);
		}

	}
}
