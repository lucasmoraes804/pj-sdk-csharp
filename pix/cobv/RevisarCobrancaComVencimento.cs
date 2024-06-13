using System.Text;
using System.Collections.Generic;

namespace Sdk.PixApi {
	public class RevisarCobrancaComVencimento {
		public CobrancaVencimentoDetalhada Revisar(Config config, string txid, CobrancaVencimento cobranca) {
			InterSdk.LogInfo("RevisarCobrancaImediata {0} {1}", config.ClientId, txid);
			string url = Constants.URL_PIX_COBRANCA_COM_VENCIMENTO.Replace("AMBIENTE", config.Ambiente) + "/" + txid;
			string json = SdkUtils.Serialize(cobranca);
			json = HttpUtils.CallPatch(config, url, Constants.ESCOPO_PIX_COBV_WRITE, "Erro ao revisar cobrança com vencimento", json);
			return (CobrancaVencimentoDetalhada) SdkUtils.Deserialize(typeof(CobrancaVencimentoDetalhada), json);
		}

	}
}
