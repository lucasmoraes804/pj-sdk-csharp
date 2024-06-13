using System.Text;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	public class CancelaCobranca {
		public void Cancelar(Config config, string codigoSolicitacao, string motivoCancelamento) {
			InterSdk.LogInfo("CancelarCobranca {0} {1} {2}", config.ClientId, codigoSolicitacao, motivoCancelamento);
			string url = Constants.URL_COBRANCAS.Replace("AMBIENTE", config.Ambiente) + "/" + codigoSolicitacao + "/cancelar";
			RequisicaoCancelarCobranca request = RequisicaoCancelarCobranca.Builder()
				.SetMotivoCancelamento(motivoCancelamento)
				.Build();
			string json = SdkUtils.Serialize(request);
			HttpUtils.CallPost(config, url, Constants.ESCOPO_BOLETO_COBRANCA_WRITE, "Erro ao cancelar cobranca", json);
		}

	}
}
