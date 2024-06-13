using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class RespostaIncluirPagamentoDarf {
		[DataMember(Name="autenticacao", EmitDefaultValue = false)]
		public string Autenticacao;
		[DataMember(Name="dataPagamento", EmitDefaultValue = false)]
		public string DataPagamento;
		[DataMember(Name="mensagemDetalhe", EmitDefaultValue = false)]
		public string MensagemDetalhe;
		[DataMember(Name="nroOperacao", EmitDefaultValue = false)]
		public int NroOperacao;
		// 
		//  PAGAMENTO AGENDAMENTO APROVACAO_PAGAMENTO APROVACAO_AGENDAMENTO
		//      
		[DataMember(Name="tipoRetorno", EmitDefaultValue = false)]
		public string TipoRetorno;
		[DataMember(Name="codigoTransacao", EmitDefaultValue = false)]
		public string CodigoTransacao;

		public static RespostaIncluirPagamentoDarf Builder() {
			return new RespostaIncluirPagamentoDarf();
		}

		public RespostaIncluirPagamentoDarf Build() {
			return this;
		}

		public RespostaIncluirPagamentoDarf SetAutenticacao(string autenticacao) {
			this.Autenticacao = autenticacao;
			return this;
		}

		public RespostaIncluirPagamentoDarf SetDataPagamento(string dataPagamento) {
			this.DataPagamento = dataPagamento;
			return this;
		}

		public RespostaIncluirPagamentoDarf SetMensagemDetalhe(string mensagemDetalhe) {
			this.MensagemDetalhe = mensagemDetalhe;
			return this;
		}

		public RespostaIncluirPagamentoDarf SetNroOperacao(int nroOperacao) {
			this.NroOperacao = nroOperacao;
			return this;
		}

		public RespostaIncluirPagamentoDarf SetTipoRetorno(string tipoRetorno) {
			this.TipoRetorno = tipoRetorno;
			return this;
		}

		public RespostaIncluirPagamentoDarf SetCodigoTransacao(string codigoTransacao) {
			this.CodigoTransacao = codigoTransacao;
			return this;
		}
	}
}
