using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class DadosBancarios : Destinatario {
		[DataMember(Name="tipo", EmitDefaultValue = false)]
		public string Tipo;
		[DataMember(Name="contaCorrente", EmitDefaultValue = false)]
		public string ContaCorrente;
		[DataMember(Name="tipoConta", EmitDefaultValue = false)]
		public string TipoConta;
		[DataMember(Name="cpfCnpj", EmitDefaultValue = false)]
		public string CpfCnpj;
		[DataMember(Name="agencia", EmitDefaultValue = false)]
		public string Agencia;
		[DataMember(Name="nome", EmitDefaultValue = false)]
		public string Nome;
		[DataMember(Name="instituicaoFinanceira", EmitDefaultValue = false)]
		public InstituicaoFinanceira InstituicaoFinanceira;

		public static DadosBancarios Builder() {
			return new DadosBancarios();
		}

		public DadosBancarios Build() {
			return this;
		}

		public DadosBancarios SetTipo(string tipo) {
			this.Tipo = tipo;
			return this;
		}

		public DadosBancarios SetContaCorrente(string contaCorrente) {
			this.ContaCorrente = contaCorrente;
			return this;
		}

		public DadosBancarios SetTipoConta(string tipoConta) {
			this.TipoConta = tipoConta;
			return this;
		}

		public DadosBancarios SetCpfCnpj(string cpfCnpj) {
			this.CpfCnpj = cpfCnpj;
			return this;
		}

		public DadosBancarios SetAgencia(string agencia) {
			this.Agencia = agencia;
			return this;
		}

		public DadosBancarios SetNome(string nome) {
			this.Nome = nome;
			return this;
		}

		public DadosBancarios SetInstituicaoFinanceira(InstituicaoFinanceira instituicaoFinanceira) {
			this.InstituicaoFinanceira = instituicaoFinanceira;
			return this;
		}
	}
}
