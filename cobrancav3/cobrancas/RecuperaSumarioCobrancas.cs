using System.Text;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	public class RecuperaSumarioCobrancas {
		public Sumario Recuperar(Config config, string dataInicial, string dataFinal, FiltroRecuperarSumarioCobrancas filtro) {
			InterSdk.LogInfo("RecuperarSumarioCobrancas {0} {1}-{2}", config.ClientId, dataInicial, dataFinal);
			string url = Constants.URL_COBRANCAS_SUMARIO.Replace("AMBIENTE", config.Ambiente) + "?dataInicial=" + dataInicial + "&dataFinal=" + dataFinal + Addfilters(filtro);
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_BOLETO_COBRANCA_READ, "Erro ao recuperar sumário de cobrancas");
			return (Sumario) SdkUtils.Deserialize(typeof(Sumario), json);
		}

		public string Addfilters(FiltroRecuperarSumarioCobrancas filtro) {
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
			if (filtro.PessoaPagadora != null ) {
				filter.Append("&pessoaPagadora").Append("=").Append(filtro.PessoaPagadora);
			}
			if (filtro.CpfCnpjPessoaPagadora != null ) {
				filter.Append("&cpfCnpjPessoaPagadora").Append("=").Append(filtro.CpfCnpjPessoaPagadora);
			}
			if (filtro.SeuNumero != null ) {
				filter.Append("&seuNumero").Append("=").Append(filtro.SeuNumero);
			}
			if (filtro.TipoCobranca != null ) {
				filter.Append("&tipoCobranca").Append("=").Append(filtro.TipoCobranca);
			}
			return filter.ToString();
		}

	}
}
