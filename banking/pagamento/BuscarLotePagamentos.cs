using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class BuscarLotePagamentos {
		public ProcessamentoLote Buscar(Config config, string idLote) {
			InterSdk.LogInfo("BuscarLotePagamentos {0} {1}", config.ClientId, idLote);
			string url = Constants.URL_BANKING_PAGAMENTO_LOTE.Replace("AMBIENTE", config.Ambiente) + "/" + idLote;
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_PAGAMENTOS_LOTE_READ, "Erro ao buscar lote");
			return (ProcessamentoLote) SdkUtils.Deserialize(typeof(ProcessamentoLote), json);
		}

	}
}
