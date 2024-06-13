using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class Pessoa {
		// 
		//  REQUERIDO
		//  <p>CPF/CNPJ do pagador do título</p>
		//  <p>CNPJ: NNNNNNNNNFFFFCC</p>
		//  <p>CPF : 0000NNNNNNNNNCC,</p>
		//  <p>NNNNNNNNN é a raiz do CNPJ/CPF</p>
		//  <p>FFFF = filial do CNPJ</p>
		//  <p>CC = dígitos de controle</p>
		//      
		[DataMember(Name="cpfCnpj", EmitDefaultValue = false)]
		public string CpfCnpj;
		// 
		//  REQUERIDO
		//  <p>Tipo do pagador</p>
		//      
		[DataMember(Name="tipoPessoa", EmitDefaultValue = false)]
		public string TipoPessoa;
		// 
		//  REQUERIDO
		//      
		[DataMember(Name="nome", EmitDefaultValue = false)]
		public string Nome;
		// 
		//  REQUERIDO
		//      
		[DataMember(Name="endereco", EmitDefaultValue = false)]
		public string Endereco;
		[DataMember(Name="numero", EmitDefaultValue = false)]
		public string Numero;
		[DataMember(Name="complemento", EmitDefaultValue = false)]
		public string Complemento;
		[DataMember(Name="bairro", EmitDefaultValue = false)]
		public string Bairro;
		// 
		//  REQUERIDO
		//      
		[DataMember(Name="cidade", EmitDefaultValue = false)]
		public string Cidade;
		// 
		//  REQUERIDO
		//      
		[DataMember(Name="uf", EmitDefaultValue = false)]
		public string Uf;
		// 
		//  REQUERIDO
		//      
		[DataMember(Name="cep", EmitDefaultValue = false)]
		public string Cep;
		[DataMember(Name="email", EmitDefaultValue = false)]
		public string Email;
		[DataMember(Name="ddd", EmitDefaultValue = false)]
		public string Ddd;
		[DataMember(Name="telefone", EmitDefaultValue = false)]
		public string Telefone;

		public static Pessoa Builder() {
			return new Pessoa();
		}

		public Pessoa Build() {
			return this;
		}

		public Pessoa SetCpfCnpj(string cpfCnpj) {
			this.CpfCnpj = cpfCnpj;
			return this;
		}

		public Pessoa SetTipoPessoa(string tipoPessoa) {
			this.TipoPessoa = tipoPessoa;
			return this;
		}

		public Pessoa SetNome(string nome) {
			this.Nome = nome;
			return this;
		}

		public Pessoa SetEndereco(string endereco) {
			this.Endereco = endereco;
			return this;
		}

		public Pessoa SetNumero(string numero) {
			this.Numero = numero;
			return this;
		}

		public Pessoa SetComplemento(string complemento) {
			this.Complemento = complemento;
			return this;
		}

		public Pessoa SetBairro(string bairro) {
			this.Bairro = bairro;
			return this;
		}

		public Pessoa SetCidade(string cidade) {
			this.Cidade = cidade;
			return this;
		}

		public Pessoa SetUf(string uf) {
			this.Uf = uf;
			return this;
		}

		public Pessoa SetCep(string cep) {
			this.Cep = cep;
			return this;
		}

		public Pessoa SetEmail(string email) {
			this.Email = email;
			return this;
		}

		public Pessoa SetDdd(string ddd) {
			this.Ddd = ddd;
			return this;
		}

		public Pessoa SetTelefone(string telefone) {
			this.Telefone = telefone;
			return this;
		}
	}
}
