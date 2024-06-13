using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class RecuperarExtratoPdf {
		public void Recuperar(Config config, string dataInicial, string dataFinal, string arquivo) {
			InterSdk.LogInfo("RecuperarExtratoPdf {0} {1}-{2}", config.ClientId, dataInicial, dataFinal);
			string url = Constants.URL_BANKING_EXTRATO_PDF.Replace("AMBIENTE", config.Ambiente) + "?dataInicio=" + dataInicial + "&dataFim=" + dataFinal;
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_EXTRATO_READ, "Erro ao consultar extrato pdf");
			RetornoPdf retornoPdf = (RetornoPdf) SdkUtils.Deserialize(typeof(RetornoPdf), json);
			SdkUtils.WritePdf(retornoPdf.Pdf, arquivo);
		}

	}
}
