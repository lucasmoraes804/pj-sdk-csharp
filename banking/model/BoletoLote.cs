using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class BoletoLote : PagamentoBoleto , ItemLote {
		[DataMember(Name="tipoPagamento", EmitDefaultValue = false)]
		public string TipoPagamento;
		[DataMember(Name="detalhe", EmitDefaultValue = false)]
		public string Detalhe;
		// 
		//  Identificador único do pagamento ao ser registrado.
		//      
		[DataMember(Name="idTransacao", EmitDefaultValue = false)]
		public string IdTransacao;
		// 
		//  EMPROCESSAMENTO não representa um estado do serviço de pagamentos. É o estado inicial do pagamento
		//  EMPROCESSAMENTO REALIZADO AGENDADO AGUARDANDO_APROVACAO APROVADO CANCELADO ERRO NAO_COMPENSADO APROVADO_NOVO_PAGAMENTO AGENDADO_REALIZADO AGENDADO_CANCELADO APROVACAO_EXPIRADA ERRO_PAGAMENTO PAGO PAGAMENTO_AGENDADO
		//      
		[DataMember(Name="status", EmitDefaultValue = false)]
		public string Status;

		public static BoletoLote Builder() {
			return new BoletoLote();
		}

		public BoletoLote Build() {
			return this;
		}

		public BoletoLote SetTipoPagamento(string tipoPagamento) {
			this.TipoPagamento = tipoPagamento;
			return this;
		}

		public BoletoLote SetDetalhe(string detalhe) {
			this.Detalhe = detalhe;
			return this;
		}

		public BoletoLote SetIdTransacao(string idTransacao) {
			this.IdTransacao = idTransacao;
			return this;
		}

		public BoletoLote SetStatus(string status) {
			this.Status = status;
			return this;
		}

		public BoletoLote SetCodBarraLinhaDigitavel(string codBarraLinhaDigitavel) {
			this.CodBarraLinhaDigitavel = codBarraLinhaDigitavel;
			return this;
		}

		public BoletoLote SetValorPagar(double valorPagar) {
			this.ValorPagar = valorPagar;
			return this;
		}

		public BoletoLote SetDataPagamento(string dataPagamento) {
			this.DataPagamento = dataPagamento;
			return this;
		}

		public BoletoLote SetDataVencimento(string dataVencimento) {
			this.DataVencimento = dataVencimento;
			return this;
		}
	}
}
