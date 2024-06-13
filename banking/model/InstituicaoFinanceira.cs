using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class InstituicaoFinanceira {
		[DataMember(Name="codigo", EmitDefaultValue = false)]
		public string Codigo;
		[DataMember(Name="nome", EmitDefaultValue = false)]
		public string Nome;
		// 
		//  Código ISPB, de 8 dígitos, dos bancos
		//      
		[DataMember(Name="ispb", EmitDefaultValue = false)]
		public string Ispb;
		// 
		//  Tipos de pagamentos que podem ser realizados. Por chave pix ou por dados bancários.
		//      
		[DataMember(Name="tipo", EmitDefaultValue = false)]
		public string Tipo;

		public static InstituicaoFinanceira Builder() {
			return new InstituicaoFinanceira();
		}

		public InstituicaoFinanceira Build() {
			return this;
		}

		public InstituicaoFinanceira SetCodigo(string codigo) {
			this.Codigo = codigo;
			return this;
		}

		public InstituicaoFinanceira SetNome(string nome) {
			this.Nome = nome;
			return this;
		}

		public InstituicaoFinanceira SetIspb(string ispb) {
			this.Ispb = ispb;
			return this;
		}

		public InstituicaoFinanceira SetTipo(string tipo) {
			this.Tipo = tipo;
			return this;
		}
	}
}
