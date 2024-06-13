using System.Text;
using System.Collections.Generic;

namespace Sdk.PixApi {
	public class ConsultarCobrancaComVencimento {
		public CobrancaVencimentoDetalhada Consultar(Config config, string txId) {
			InterSdk.LogInfo("ConsultarCobrancaComVencimento {0} txId={1}", config.ClientId, txId);
			string url = Constants.URL_PIX_COBRANCA_COM_VENCIMENTO.Replace("AMBIENTE", config.Ambiente) + "/" + txId;
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_PIX_COBV_READ, "Erro ao consultar cobrança com vencimento");
			return (CobrancaVencimentoDetalhada) SdkUtils.Deserialize(typeof(CobrancaVencimentoDetalhada), json);
		}

	}
}
