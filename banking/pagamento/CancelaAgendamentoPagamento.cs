using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class CancelaAgendamentoPagamento {
		public void Cancelar(Config config, string codigoTransacao) {
			InterSdk.LogInfo("Cancelando Agendamento de Pagamento {0} {1}", config.ClientId, codigoTransacao);
			string url = Constants.URL_BANKING_PAGAMENTO.Replace("AMBIENTE", config.Ambiente) + "/" + codigoTransacao;
			HttpUtils.CallDelete(config, url, Constants.ESCOPO_PAGAMENTO_BOLETO_WRITE, "Erro ao cancelar agendamento");
		}

	}
}
