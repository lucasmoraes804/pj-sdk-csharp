using System.Text;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	public class RecuperarBoletoPdf {
		public void Recuperar(Config config, string nossoNumero, string arquivo) {
			InterSdk.LogInfo("RecuperarBoletoPdf {0} nossoNumero={1}", config.ClientId, nossoNumero);
			string url = Constants.URL_BOLETOS.Replace("AMBIENTE", config.Ambiente) + "/" + nossoNumero + "/pdf";
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_BOLETO_COBRANCA_READ, "Erro ao recuperar boleto pdf");
			RetornoPdf retornoPdf = (RetornoPdf) SdkUtils.Deserialize(typeof(RetornoPdf), json);
			SdkUtils.WritePdf(retornoPdf.Pdf, arquivo);
		}

	}
}
