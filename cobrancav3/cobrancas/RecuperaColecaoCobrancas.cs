using System.Text;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	public class RecuperaColecaoCobrancas {
		public PaginaCobrancas Recuperar(Config config, string dataInicial, string dataFinal, int pagina, int tamanhoPagina, FiltroRecuperarCobrancas filtro, Ordenacao ordenacao) {
			InterSdk.LogInfo("RecuperarColecaoCobrancas {0} {1}-{2}", config.ClientId, dataInicial, dataFinal);
			return GetPage(config, dataInicial, dataFinal, pagina, tamanhoPagina, filtro, ordenacao);
		}

		public List<CobrancaRecuperada> Recuperar(Config config, string dataInicial, string dataFinal, FiltroRecuperarCobrancas filtro, Ordenacao ordenacao) {
			InterSdk.LogInfo("RecuperarColecaoCobrancas {0} {1}-{2}", config.ClientId, dataInicial, dataFinal);
			int pagina = 0;
			PaginaCobrancas paginaCobrancas;
			List<CobrancaRecuperada> cobrancas = new List<CobrancaRecuperada>();
			do {
				paginaCobrancas = GetPage(config, dataInicial, dataFinal, pagina, 0, filtro, ordenacao);
				cobrancas.AddRange(paginaCobrancas.Cobrancas);
				pagina++;
			} while (pagina < paginaCobrancas.TotalPaginas);
			return cobrancas;
		}

		public PaginaCobrancas GetPage(Config config, string dataInicial, string dataFinal, int pagina, int tamanhoPagina, FiltroRecuperarCobrancas filtro, Ordenacao ordenacao) {
			string url = Constants.URL_COBRANCAS.Replace("AMBIENTE", config.Ambiente) + "?dataInicial=" + dataInicial + "&dataFinal=" + dataFinal + "&paginacao.paginaAtual=" + pagina + SdkUtils.PrmTamanhoPagina(tamanhoPagina) + Addfilters(filtro) + AddSort(ordenacao);
			string json = HttpUtils.CallGet(config, url, Constants.ESCOPO_BOLETO_COBRANCA_READ, "Erro ao recuperar cobranças");
			return (PaginaCobrancas) SdkUtils.Deserialize(typeof(PaginaCobrancas), json);
		}

		public string Addfilters(FiltroRecuperarCobrancas filtro) {
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

		public string AddSort(Ordenacao ordenacao) {
			if (ordenacao == null ) {
				return "";
			}
			StringBuilder order = new StringBuilder();
			if (ordenacao.OrdenarPor != null ) {
				order.Append("&ordenarPor").Append("=").Append(ordenacao.OrdenarPor.ToString());
			}
			if (ordenacao.TipoOrdenacao != null ) {
				order.Append("&tipoOrdenacao").Append("=").Append(ordenacao.TipoOrdenacao.ToString());
			}
			return order.ToString();
		}

	}
}
