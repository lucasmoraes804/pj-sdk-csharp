using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class RespostaIncluirPagamento {
		[DataMember(Name="quantidadeAprovadores", EmitDefaultValue = false)]
		public int QuantidadeAprovadores;
		[DataMember(Name="dataAgendamento", EmitDefaultValue = false)]
		public string DataAgendamento;
		// 
		//  REALIZADO AGENDADO AGUARDANDO_APROVACAO APROVADO AGENDADO_REALIZADO
		//      
		[DataMember(Name="statusPagamento", EmitDefaultValue = false)]
		public string StatusPagamento;
		[DataMember(Name="codigoTransacao", EmitDefaultValue = false)]
		public string CodigoTransacao;

		public static RespostaIncluirPagamento Builder() {
			return new RespostaIncluirPagamento();
		}

		public RespostaIncluirPagamento Build() {
			return this;
		}

		public RespostaIncluirPagamento SetQuantidadeAprovadores(int quantidadeAprovadores) {
			this.QuantidadeAprovadores = quantidadeAprovadores;
			return this;
		}

		public RespostaIncluirPagamento SetDataAgendamento(string dataAgendamento) {
			this.DataAgendamento = dataAgendamento;
			return this;
		}

		public RespostaIncluirPagamento SetStatusPagamento(string statusPagamento) {
			this.StatusPagamento = statusPagamento;
			return this;
		}

		public RespostaIncluirPagamento SetCodigoTransacao(string codigoTransacao) {
			this.CodigoTransacao = codigoTransacao;
			return this;
		}
	}
}
