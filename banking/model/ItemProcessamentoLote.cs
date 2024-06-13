using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class ItemProcessamentoLote {
		// 
		//  EMPROCESSAMENTO não representa um estado do serviço de pagamentos. É o estado inicial do pagamento
		//  EMPROCESSAMENTO REALIZADO AGENDADO AGUARDANDO_APROVACAO APROVADO CANCELADO ERRO NAO_COMPENSADO APROVADO_NOVO_PAGAMENTO AGENDADO_REALIZADO AGENDADO_CANCELADO APROVACAO_EXPIRADA ERRO_PAGAMENTO PAGO PAGAMENTO_AGENDADO
		//      
		[DataMember(Name="status", EmitDefaultValue = false)]
		public string Status;
		// 
		//  Código de barras ou linha digitável
		//      
		[DataMember(Name="codBarraLinhaDigitavel", EmitDefaultValue = false)]
		public string CodBarraLinhaDigitavel;
		// 
		//  Valor a ser pago.
		//      
		[DataMember(Name="valorPagar", EmitDefaultValue = false)]
		public double ValorPagar;
		// 
		//  Data em que será pago o título.
		//  Formato aceito: YYYY-MM-DD
		//      
		[DataMember(Name="dataPagamento", EmitDefaultValue = false)]
		public string DataPagamento;
		// 
		//  Data de vencimento do título.
		//  Formato aceito: YYYY-MM-DD
		//      
		[DataMember(Name="dataVencimento", EmitDefaultValue = false)]
		public string DataVencimento;
		// 
		//  BOLETO DARF
		//      
		[DataMember(Name="tipoPagamento", EmitDefaultValue = false)]
		public string TipoPagamento;
		[DataMember(Name="detalhe", EmitDefaultValue = false)]
		public string Detalhe;
		// 
		//  Identificador único do pagamento ao ser registrado.
		//      
		[DataMember(Name="idTransacao", EmitDefaultValue = false)]
		public string IdTransacao;

		public static ItemProcessamentoLote Builder() {
			return new ItemProcessamentoLote();
		}

		public ItemProcessamentoLote Build() {
			return this;
		}

		public ItemProcessamentoLote SetStatus(string status) {
			this.Status = status;
			return this;
		}

		public ItemProcessamentoLote SetCodBarraLinhaDigitavel(string codBarraLinhaDigitavel) {
			this.CodBarraLinhaDigitavel = codBarraLinhaDigitavel;
			return this;
		}

		public ItemProcessamentoLote SetValorPagar(double valorPagar) {
			this.ValorPagar = valorPagar;
			return this;
		}

		public ItemProcessamentoLote SetDataPagamento(string dataPagamento) {
			this.DataPagamento = dataPagamento;
			return this;
		}

		public ItemProcessamentoLote SetDataVencimento(string dataVencimento) {
			this.DataVencimento = dataVencimento;
			return this;
		}

		public ItemProcessamentoLote SetTipoPagamento(string tipoPagamento) {
			this.TipoPagamento = tipoPagamento;
			return this;
		}

		public ItemProcessamentoLote SetDetalhe(string detalhe) {
			this.Detalhe = detalhe;
			return this;
		}

		public ItemProcessamentoLote SetIdTransacao(string idTransacao) {
			this.IdTransacao = idTransacao;
			return this;
		}
	}
}
