using System.Text;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	public class RecuperaCobrancaPdf {
		public void Recuperar(Config config, string codigoSolicitacao, string arquivo) {
			InterSdk.LogInfo("RecuperarCobrancaPdf {0} codigoSolicitacao={1}", config.ClientId, codigoSolicitacao);
			string url = Constants.URL_COBRANCAS.Replace("AMBIENTE", config.Ambiente) + "/" + codigoSolicitacao + "/pdf";
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_BOLETO_COBRANCA_READ, "Erro ao recuperar cobrança pdf");
			RetornoPdf retornoPdf = (RetornoPdf) SdkUtils.Deserialize(typeof(RetornoPdf), json);
			SdkUtils.WritePdf(retornoPdf.Pdf, arquivo);
		}

	}
}
