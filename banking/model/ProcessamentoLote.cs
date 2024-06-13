using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class ProcessamentoLote {
		// 
		//  Conta corrente responsável pelo pagamento do lote.
		//      
		[DataMember(Name="contaCorrente", EmitDefaultValue = false)]
		public string ContaCorrente;
		[DataMember(Name="dataCriacao", EmitDefaultValue = false)]
		public string DataCriacao;
		[DataMember(Name="pagamentos", EmitDefaultValue = false)]
		public List<ItemLote> Pagamentos;
		// 
		//  Id do pagamento de um lote específico.
		//      
		[DataMember(Name="idLote", EmitDefaultValue = false)]
		public string IdLote;
		// 
		//  EMPROCESSAMENTO PROCESSADOCOMERRO PROCESSADOSEMERRO
		//      
		[DataMember(Name="status", EmitDefaultValue = false)]
		public string Status;
		// 
		//  Identificador do lote
		//      
		[DataMember(Name="meuIdentificador", EmitDefaultValue = false)]
		public string MeuIdentificador;
		// 
		//  Qtde de pagamentos existentes no lote.
		//      
		[DataMember(Name="qtdePagamentos", EmitDefaultValue = false)]
		public int QtdePagamentos;

		public static ProcessamentoLote Builder() {
			return new ProcessamentoLote();
		}

		public ProcessamentoLote Build() {
			return this;
		}

		public ProcessamentoLote SetContaCorrente(string contaCorrente) {
			this.ContaCorrente = contaCorrente;
			return this;
		}

		public ProcessamentoLote SetDataCriacao(string dataCriacao) {
			this.DataCriacao = dataCriacao;
			return this;
		}

		public ProcessamentoLote SetPagamentos(List<ItemLote> pagamentos) {
			this.Pagamentos = pagamentos;
			return this;
		}

		public ProcessamentoLote SetIdLote(string idLote) {
			this.IdLote = idLote;
			return this;
		}

		public ProcessamentoLote SetStatus(string status) {
			this.Status = status;
			return this;
		}

		public ProcessamentoLote SetMeuIdentificador(string meuIdentificador) {
			this.MeuIdentificador = meuIdentificador;
			return this;
		}

		public ProcessamentoLote SetQtdePagamentos(int qtdePagamentos) {
			this.QtdePagamentos = qtdePagamentos;
			return this;
		}
	}
}
