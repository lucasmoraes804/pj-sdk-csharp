using System.Text;
using System.Collections.Generic;

namespace Sdk.PixApi {
	public class ConsultarCobrancaImediata {
		public CobrancaDetalhada Consultar(Config config, string txId) {
			InterSdk.LogInfo("ConsultarCobrancaImediata {0} txId={1}", config.ClientId, txId);
			string url = Constants.URL_PIX_COBRANCAS_IMEDIATAS.Replace("AMBIENTE", config.Ambiente) + "/" + txId;
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_PIX_COB_READ, "Erro ao consultar cobrança imediata");
			return (CobrancaDetalhada) SdkUtils.Deserialize(typeof(CobrancaDetalhada), json);
		}

	}
}
