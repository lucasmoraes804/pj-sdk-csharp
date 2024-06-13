using System.Text;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	public class CancelarBoleto {
		public void Cancelar(Config config, string nossoNumero, string motivoCancelamento) {
			InterSdk.LogInfo("CancelarBoleto {0} {1} {2}", config.ClientId, nossoNumero, motivoCancelamento);
			string url = Constants.URL_BOLETOS.Replace("AMBIENTE", config.Ambiente) + "/" + nossoNumero + "/cancelar";
			RequisicaoCancelarBoleto request = RequisicaoCancelarBoleto.Builder()
				.SetMotivoCancelamento(motivoCancelamento)
				.Build();
			string json = SdkUtils.Serialize(request);
			HttpUtils.CallPost(config, url, Constants.ESCOPO_BOLETO_COBRANCA_WRITE, "Erro ao cancelar boleto", json);
		}

	}
}
