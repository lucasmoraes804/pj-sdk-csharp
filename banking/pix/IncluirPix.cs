using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class IncluirPix {
		public RespostaIncluirPix Incluir(Config config, Pix pix) {
			InterSdk.LogInfo("IncluirPix {0} {1}", config.ClientId, pix.Descricao);
			string url = Constants.URL_BANKING_PAGAMENTO_PIX.Replace("AMBIENTE", config.Ambiente);
			string json = SdkUtils.Serialize(pix);
			json = HttpUtils.CallPost(config, url, Constants.ESCOPO_PAGAMENTO_PIX_WRITE, "Erro ao incluir pix", json);
			return (RespostaIncluirPix) SdkUtils.Deserialize(typeof(RespostaIncluirPix), json);
		}

	}
}
