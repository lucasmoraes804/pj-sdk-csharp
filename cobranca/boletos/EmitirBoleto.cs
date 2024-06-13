using System.Text;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	public class EmitirBoleto {
		public RespostaEmitirBoleto Emitir(Config config, Boleto boleto) {
			InterSdk.LogInfo("EmitirBoleto {0} {1}", config.ClientId, boleto.SeuNumero);
			string url = Constants.URL_BOLETOS.Replace("AMBIENTE", config.Ambiente);
			string json = SdkUtils.Serialize(boleto);
			json = HttpUtils.CallPost(config, url, Constants.ESCOPO_BOLETO_COBRANCA_WRITE, "Erro ao emitir boleto", json);
			return (RespostaEmitirBoleto) SdkUtils.Deserialize(typeof(RespostaEmitirBoleto), json);
		}

	}
}
