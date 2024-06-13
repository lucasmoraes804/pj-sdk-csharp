using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class Transacao {
		[DataMember(Name="cpmf", EmitDefaultValue = false)]
		public string Cpmf;
		[DataMember(Name="dataEntrada", EmitDefaultValue = false)]
		public string DataEntrada;
		[DataMember(Name="tipoTransacao", EmitDefaultValue = false)]
		public string TipoTransacao;
		[DataMember(Name="tipoOperacao", EmitDefaultValue = false)]
		public string TipoOperacao;
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public string Valor;
		[DataMember(Name="titulo", EmitDefaultValue = false)]
		public string Titulo;
		[DataMember(Name="descricao", EmitDefaultValue = false)]
		public string Descricao;

		public static Transacao Builder() {
			return new Transacao();
		}

		public Transacao Build() {
			return this;
		}

		public Transacao SetCpmf(string cpmf) {
			this.Cpmf = cpmf;
			return this;
		}

		public Transacao SetDataEntrada(string dataEntrada) {
			this.DataEntrada = dataEntrada;
			return this;
		}

		public Transacao SetTipoTransacao(string tipoTransacao) {
			this.TipoTransacao = tipoTransacao;
			return this;
		}

		public Transacao SetTipoOperacao(string tipoOperacao) {
			this.TipoOperacao = tipoOperacao;
			return this;
		}

		public Transacao SetValor(string valor) {
			this.Valor = valor;
			return this;
		}

		public Transacao SetTitulo(string titulo) {
			this.Titulo = titulo;
			return this;
		}

		public Transacao SetDescricao(string descricao) {
			this.Descricao = descricao;
			return this;
		}
	}
}
