using System.Text;
using System.Collections.Generic;

namespace Sdk.PixApi {
	public class RecuperarLocation {
		public Location Recuperar(Config config, string id) {
			InterSdk.LogInfo("RecuperarLocation {0} id={1}", config.ClientId, id);
			string url = Constants.URL_PIX_LOCATIONS.Replace("AMBIENTE", config.Ambiente) + "/" + id;
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_PIX_LOCATION_READ, "Erro ao recuperar location");
			return (Location) SdkUtils.Deserialize(typeof(Location), json);
		}

	}
}
