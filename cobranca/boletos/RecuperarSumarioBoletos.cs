using System.Text;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	public class RecuperarSumarioBoletos {
		public Sumario Recuperar(Config config, string dataInicial, string dataFinal, FiltroRecuperarSumarioBoletos filtro) {
			InterSdk.LogInfo("RecuperarSumarioBoletos {0} {1}-{2}", config.ClientId, dataInicial, dataFinal);
			string url = Constants.URL_BOLETOS_SUMARIO.Replace("AMBIENTE", config.Ambiente) + "?dataInicial=" + dataInicial + "&dataFinal=" + dataFinal + Addfilters(filtro);
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_BOLETO_COBRANCA_READ, "Erro ao recuperar sumário de boletos");
			return (Sumario) SdkUtils.Deserialize(typeof(Sumario), json);
		}

		public string Addfilters(FiltroRecuperarSumarioBoletos filtro) {
			if (filtro == null ) {
				return "";
			}
			StringBuilder filter = new StringBuilder();
			if (filtro.FiltrarDataPor != null ) {
				filter.Append("&filtrarDataPor").Append("=").Append(filtro.FiltrarDataPor.ToString());
			}
			if (filtro.Situacao != null ) {
				filter.Append("&situacao").Append("=").Append(filtro.Situacao.ToString());
			}
			if (filtro.Nome != null ) {
				filter.Append("&nome").Append("=").Append(filtro.Nome);
			}
			if (filtro.Email != null ) {
				filter.Append("&email").Append("=").Append(filtro.Email);
			}
			if (filtro.CpfCnpj != null ) {
				filter.Append("&cpfCnpj").Append("=").Append(filtro.CpfCnpj);
			}
			return filter.ToString();
		}

	}
}
