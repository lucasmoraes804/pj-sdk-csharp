using System.Text;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	public class RecuperaCobranca {
		public CobrancaRecuperada Recuperar(Config config, string codigoSolicitacao) {
			InterSdk.LogInfo("RecuperarCobranca {0} codigoSolicitacao={1}", config.ClientId, codigoSolicitacao);
			string url = Constants.URL_COBRANCAS.Replace("AMBIENTE", config.Ambiente) + "/" + codigoSolicitacao;
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_BOLETO_COBRANCA_READ, "Erro ao recuperar cobrança");
			return (CobrancaRecuperada) SdkUtils.Deserialize(typeof(CobrancaRecuperada), json);
		}

	}
}
