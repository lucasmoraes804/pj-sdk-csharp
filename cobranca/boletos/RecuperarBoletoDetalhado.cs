using System.Text;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	public class RecuperarBoletoDetalhado {
		public BoletoDetalhado Recuperar(Config config, string nossoNumero) {
			InterSdk.LogInfo("RecuperarBoletoDetalhado {0} nossoNumero={1}", config.ClientId, nossoNumero);
			string url = Constants.URL_BOLETOS.Replace("AMBIENTE", config.Ambiente) + "/" + nossoNumero;
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_BOLETO_COBRANCA_READ, "Erro ao recuperar boleto detalhado");
			return (BoletoDetalhado) SdkUtils.Deserialize(typeof(BoletoDetalhado), json);
		}

	}
}
