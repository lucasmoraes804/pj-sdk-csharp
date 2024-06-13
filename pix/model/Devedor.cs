using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Devedor {
		// 
		//  REQUERIDO se for PF
		//  CPF do usuário.
		//      
		[DataMember(Name="cpf", EmitDefaultValue = false)]
		public string Cpf;
		// 
		//  REQUERIDO se for PJ
		//  CNPJ do usuário.
		//      
		[DataMember(Name="cnpj", EmitDefaultValue = false)]
		public string Cnpj;
		// 
		//  REQUERIDO
		//  Nome do usuário.
		//      
		[DataMember(Name="nome", EmitDefaultValue = false)]
		public string Nome;
		[DataMember(Name="email", EmitDefaultValue = false)]
		public string Email;
		[DataMember(Name="cidade", EmitDefaultValue = false)]
		public string Cidade;
		[DataMember(Name="uf", EmitDefaultValue = false)]
		public string Uf;
		[DataMember(Name="cep", EmitDefaultValue = false)]
		public string Cep;
		[DataMember(Name="logradouro", EmitDefaultValue = false)]
		public string Logradouro;

		public static Devedor Builder() {
			return new Devedor();
		}

		public Devedor Build() {
			return this;
		}

		public Devedor SetCpf(string cpf) {
			this.Cpf = cpf;
			return this;
		}

		public Devedor SetCnpj(string cnpj) {
			this.Cnpj = cnpj;
			return this;
		}

		public Devedor SetNome(string nome) {
			this.Nome = nome;
			return this;
		}

		public Devedor SetEmail(string email) {
			this.Email = email;
			return this;
		}

		public Devedor SetCidade(string cidade) {
			this.Cidade = cidade;
			return this;
		}

		public Devedor SetUf(string uf) {
			this.Uf = uf;
			return this;
		}

		public Devedor SetCep(string cep) {
			this.Cep = cep;
			return this;
		}

		public Devedor SetLogradouro(string logradouro) {
			this.Logradouro = logradouro;
			return this;
		}
	}
}
