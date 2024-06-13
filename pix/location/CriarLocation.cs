using System.Text;
using System.Collections.Generic;

namespace Sdk.PixApi {
	public class CriarLocation {
		public Location Criar(Config config, string tipoCob) {
			InterSdk.LogInfo("CriarLocation pix {0} {1}", config.ClientId, tipoCob);
			string url = Constants.URL_PIX_LOCATIONS.Replace("AMBIENTE", config.Ambiente);
			CriarLocationRequest request = CriarLocationRequest.Builder()
				.SetTipoCob(tipoCob)
				.Build();
			string json = SdkUtils.Serialize(request);
			json = HttpUtils.CallPost(config, url, Constants.ESCOPO_PIX_LOCATION_WRITE, "Erro ao criar location", json);
			return (Location) SdkUtils.Deserialize(typeof(Location), json);
		}

	}
}
