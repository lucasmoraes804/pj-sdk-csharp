using System.Text;
using System.Collections.Generic;

namespace Sdk.PixApi {
	public class DesvincularLocation {
		public Location Desvincular(Config config, string id) {
			InterSdk.LogInfo("DesvincularLocation {0} id={1}", config.ClientId, id);
			string url = Constants.URL_PIX_LOCATIONS.Replace("AMBIENTE", config.Ambiente) + "/" + id + "/txid";
			string json = HttpUtils.CallDelete(config, url, Constants.ESCOPO_PIX_LOCATION_WRITE, "Erro ao desvincular location");
			return (Location) SdkUtils.Deserialize(typeof(Location), json);
		}

	}
}
