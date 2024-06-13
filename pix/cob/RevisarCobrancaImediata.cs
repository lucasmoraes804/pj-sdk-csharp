using System.Text;
using System.Collections.Generic;

namespace Sdk.PixApi {
	public class RevisarCobrancaImediata {
		public CobrancaDetalhada Revisar(Config config, Cobranca cobranca) {
			InterSdk.LogInfo("RevisarCobrancaImediata {0} {1}", config.ClientId, cobranca.Txid);
			string url = Constants.URL_PIX_COBRANCAS_IMEDIATAS.Replace("AMBIENTE", config.Ambiente) + "/" + cobranca.Txid;
			string json = SdkUtils.Serialize(cobranca);
			json = HttpUtils.CallPatch(config, url, Constants.ESCOPO_PIX_COB_WRITE, "Erro ao revisar cobrança imediata", json);
			return (CobrancaDetalhada) SdkUtils.Deserialize(typeof(CobrancaDetalhada), json);
		}

	}
}
