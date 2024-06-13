using System.Text;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	public class IncluirPagamentosLote {
		public RespostaIncluirPagamentosLote Incluir(Config config, string meuIdentificador, List<ItemLote> pagamentos) {
			InterSdk.LogInfo("IncluirPagamentosLote {0} {1} {2}", config.ClientId, meuIdentificador, pagamentos.Count.ToString());
			string url = Constants.URL_BANKING_PAGAMENTO_LOTE.Replace("AMBIENTE", config.Ambiente);
			Lote request = Lote.Builder()
				.SetMeuIdentificador(meuIdentificador)
				.SetPagamentos(pagamentos)
				.Build();
			string json = SdkUtils.Serialize(request);
			json = HttpUtils.CallPost(config, url, Constants.ESCOPO_PAGAMENTOS_LOTE_WRITE, "Erro ao incluir pagamentos em lote", json);
			return (RespostaIncluirPagamentosLote) SdkUtils.Deserialize(typeof(RespostaIncluirPagamentosLote), json);
		}

	}
}
