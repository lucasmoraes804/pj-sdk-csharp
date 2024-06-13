using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Recebedor {
		[DataMember(Name="nome", EmitDefaultValue = false)]
		public string Nome;
		[DataMember(Name="cnpj", EmitDefaultValue = false)]
		public string Cnpj;
		[DataMember(Name="nomeFantasia", EmitDefaultValue = false)]
		public string NomeFantasia;
		[DataMember(Name="cidade", EmitDefaultValue = false)]
		public string Cidade;
		[DataMember(Name="uf", EmitDefaultValue = false)]
		public string Uf;
		[DataMember(Name="cep", EmitDefaultValue = false)]
		public string Cep;
		[DataMember(Name="logradouro", EmitDefaultValue = false)]
		public string Logradouro;

		public static Recebedor Builder() {
			return new Recebedor();
		}

		public Recebedor Build() {
			return this;
		}

		public Recebedor SetNome(string nome) {
			this.Nome = nome;
			return this;
		}

		public Recebedor SetCnpj(string cnpj) {
			this.Cnpj = cnpj;
			return this;
		}

		public Recebedor SetNomeFantasia(string nomeFantasia) {
			this.NomeFantasia = nomeFantasia;
			return this;
		}

		public Recebedor SetCidade(string cidade) {
			this.Cidade = cidade;
			return this;
		}

		public Recebedor SetUf(string uf) {
			this.Uf = uf;
			return this;
		}

		public Recebedor SetCep(string cep) {
			this.Cep = cep;
			return this;
		}

		public Recebedor SetLogradouro(string logradouro) {
			this.Logradouro = logradouro;
			return this;
		}
	}
}
