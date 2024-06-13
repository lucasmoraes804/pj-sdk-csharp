using System.Text;
using System.Collections.Generic;

namespace Sdk.PixApi {
	public class CriarCobrancaImediata {
		public CobrancaDetalhada Criar(Config config, Cobranca cobranca) {
			InterSdk.LogInfo("CriarCobrancaImediata {0} {1}", config.ClientId, cobranca.Txid);
			string url = Constants.URL_PIX_COBRANCAS_IMEDIATAS.Replace("AMBIENTE", config.Ambiente);
			string json = SdkUtils.Serialize(cobranca);
			if (cobranca.Txid == null ) {
				json = HttpUtils.CallPost(config, url, Constants.ESCOPO_PIX_COB_WRITE, "Erro ao criar cobrança imediata", json);
			} else {
				url = url + "/" + cobranca.Txid;
				json = HttpUtils.CallPut(config, url, Constants.ESCOPO_PIX_COB_WRITE, "Erro ao criar cobrança imediata", json);
			}
			return (CobrancaDetalhada) SdkUtils.Deserialize(typeof(CobrancaDetalhada), json);
		}

	}
}
