using System.Text;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	public class EmiteCobranca {
		public RespostaEmitirCobranca Emitir(Config config, RequisicaoEmitirCobranca requisicaoEmitirCobranca) {
			InterSdk.LogInfo("EmitirCobranca {0} {1}", config.ClientId, requisicaoEmitirCobranca.SeuNumero);
			string url = Constants.URL_COBRANCAS.Replace("AMBIENTE", config.Ambiente);
			string json = SdkUtils.Serialize(requisicaoEmitirCobranca);
			json = HttpUtils.CallPost(config, url, Constants.ESCOPO_BOLETO_COBRANCA_WRITE, "Erro ao emitir cobrança", json);
			return (RespostaEmitirCobranca) SdkUtils.Deserialize(typeof(RespostaEmitirCobranca), json);
		}

	}
}
