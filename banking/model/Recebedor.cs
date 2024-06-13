using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class Recebedor {
		[DataMember(Name="codAgencia", EmitDefaultValue = false)]
		public string CodAgencia;
		[DataMember(Name="codIspb", EmitDefaultValue = false)]
		public string CodIspb;
		[DataMember(Name="cpfCnpj", EmitDefaultValue = false)]
		public string CpfCnpj;
		[DataMember(Name="nome", EmitDefaultValue = false)]
		public string Nome;
		[DataMember(Name="nroConta", EmitDefaultValue = false)]
		public string NroConta;
		[DataMember(Name="tipoConta", EmitDefaultValue = false)]
		public string TipoConta;

		public static Recebedor Builder() {
			return new Recebedor();
		}

		public Recebedor Build() {
			return this;
		}

		public Recebedor SetCodAgencia(string codAgencia) {
			this.CodAgencia = codAgencia;
			return this;
		}

		public Recebedor SetCodIspb(string codIspb) {
			this.CodIspb = codIspb;
			return this;
		}

		public Recebedor SetCpfCnpj(string cpfCnpj) {
			this.CpfCnpj = cpfCnpj;
			return this;
		}

		public Recebedor SetNome(string nome) {
			this.Nome = nome;
			return this;
		}

		public Recebedor SetNroConta(string nroConta) {
			this.NroConta = nroConta;
			return this;
		}

		public Recebedor SetTipoConta(string tipoConta) {
			this.TipoConta = tipoConta;
			return this;
		}
	}
}
