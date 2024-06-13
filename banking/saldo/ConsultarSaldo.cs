using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class ConsultarSaldo {
		public Saldo Consultar(Config config, string dataSaldo) {
			InterSdk.LogInfo("ConsultarSaldo {0} {1}", config.ClientId, dataSaldo);
			string url = Constants.URL_BANKING_SALDO.Replace("AMBIENTE", config.Ambiente);
			if (dataSaldo != null ) {
				url = url + "?dataSaldo=" + dataSaldo;
			}
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_EXTRATO_READ, "Erro ao consultar saldo");
			return (Saldo) SdkUtils.Deserialize(typeof(Saldo), json);
		}

	}
}
