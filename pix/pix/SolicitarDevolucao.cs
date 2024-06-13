using System.Text;
using System.Collections.Generic;

namespace Sdk.PixApi {
	public class SolicitarDevolucao {
		public DevolucaoDetalhada Solicitar(Config config, string e2eId, string id, RequisicaoBodyDevolucao requisicaoBodyDevolucao) {
			InterSdk.LogInfo("SolicitarDevolucao {0} e2eId={1} id={2}", config.ClientId, e2eId, id);
			string url = Constants.URL_PIX_PIX.Replace("AMBIENTE", config.Ambiente) + "/" + e2eId + "/devolucao/" + id;
			string json = SdkUtils.Serialize(requisicaoBodyDevolucao);
			json = HttpUtils.CallPut(config, url, Constants.ESCOPO_PIX_PIX_WRITE, "Erro ao solicitar devolução", json);
			return (DevolucaoDetalhada) SdkUtils.Deserialize(typeof(DevolucaoDetalhada), json);
		}

	}
}
