using System.Text;
using System.Collections.Generic;

namespace Sdk.PixApi {
	public class CriarCobrancaComVencimento {
		public CobrancaVencimentoDetalhada Criar(Config config, string txid, CobrancaVencimento cobranca) {
			InterSdk.LogInfo("CriarCobrancaComVencimento {0} {1}", config.ClientId, txid);
			string url = Constants.URL_PIX_COBRANCA_COM_VENCIMENTO.Replace("AMBIENTE", config.Ambiente) + "/" + txid;
			string json = SdkUtils.Serialize(cobranca);
			json = HttpUtils.CallPut(config, url, Constants.ESCOPO_PIX_COBV_WRITE, "Erro ao criar cobrança com vencimento", json);
			return (CobrancaVencimentoDetalhada) SdkUtils.Deserialize(typeof(CobrancaVencimentoDetalhada), json);
		}

	}
}
