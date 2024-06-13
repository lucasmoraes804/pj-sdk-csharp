using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class TransacaoEnriquecida {
		[DataMember(Name="cpmf", EmitDefaultValue = false)]
		public string Cpmf;
		[DataMember(Name="idTransacao", EmitDefaultValue = false)]
		public string IdTransacao;
		[DataMember(Name="dataInclusao", EmitDefaultValue = false)]
		public string DataInclusao;
		[DataMember(Name="dataTransacao", EmitDefaultValue = false)]
		public string DataTransacao;
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
		[DataMember(Name="detalhes", EmitDefaultValue = false)]
		public DetalhesTransacao Detalhes;

		public static TransacaoEnriquecida Builder() {
			return new TransacaoEnriquecida();
		}

		public TransacaoEnriquecida Build() {
			return this;
		}

		public TransacaoEnriquecida SetCpmf(string cpmf) {
			this.Cpmf = cpmf;
			return this;
		}

		public TransacaoEnriquecida SetIdTransacao(string idTransacao) {
			this.IdTransacao = idTransacao;
			return this;
		}

		public TransacaoEnriquecida SetDataInclusao(string dataInclusao) {
			this.DataInclusao = dataInclusao;
			return this;
		}

		public TransacaoEnriquecida SetDataTransacao(string dataTransacao) {
			this.DataTransacao = dataTransacao;
			return this;
		}

		public TransacaoEnriquecida SetTipoTransacao(string tipoTransacao) {
			this.TipoTransacao = tipoTransacao;
			return this;
		}

		public TransacaoEnriquecida SetTipoOperacao(string tipoOperacao) {
			this.TipoOperacao = tipoOperacao;
			return this;
		}

		public TransacaoEnriquecida SetValor(string valor) {
			this.Valor = valor;
			return this;
		}

		public TransacaoEnriquecida SetTitulo(string titulo) {
			this.Titulo = titulo;
			return this;
		}

		public TransacaoEnriquecida SetDescricao(string descricao) {
			this.Descricao = descricao;
			return this;
		}

		public TransacaoEnriquecida SetDetalhes(DetalhesTransacao detalhes) {
			this.Detalhes = detalhes;
			return this;
		}
	}
}
