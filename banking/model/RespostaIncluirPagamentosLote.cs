using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class RespostaIncluirPagamentosLote {
		[DataMember(Name="idLote", EmitDefaultValue = false)]
		public string IdLote;
		// 
		//  EMPROCESSAMENTO PROCESSADOCOMERRO PROCESSADOSEMERRO
		//      
		[DataMember(Name="status", EmitDefaultValue = false)]
		public string Status;
		[DataMember(Name="meuIdentificador", EmitDefaultValue = false)]
		public string MeuIdentificador;
		[DataMember(Name="qtdePagamentos", EmitDefaultValue = false)]
		public int QtdePagamentos;

		public static RespostaIncluirPagamentosLote Builder() {
			return new RespostaIncluirPagamentosLote();
		}

		public RespostaIncluirPagamentosLote Build() {
			return this;
		}

		public RespostaIncluirPagamentosLote SetIdLote(string idLote) {
			this.IdLote = idLote;
			return this;
		}

		public RespostaIncluirPagamentosLote SetStatus(string status) {
			this.Status = status;
			return this;
		}

		public RespostaIncluirPagamentosLote SetMeuIdentificador(string meuIdentificador) {
			this.MeuIdentificador = meuIdentificador;
			return this;
		}

		public RespostaIncluirPagamentosLote SetQtdePagamentos(int qtdePagamentos) {
			this.QtdePagamentos = qtdePagamentos;
			return this;
		}
	}
}
