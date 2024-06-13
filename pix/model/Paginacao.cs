using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Paginacao {
		[DataMember(Name="paginaAtual", EmitDefaultValue = false)]
		public int PaginaAtual;
		[DataMember(Name="itensPorPagina", EmitDefaultValue = false)]
		public int ItensPorPagina;
		[DataMember(Name="quantidadeDePaginas", EmitDefaultValue = false)]
		public int QuantidadeDePaginas;
		[DataMember(Name="quantidadeTotalDeItens", EmitDefaultValue = false)]
		public int QuantidadeTotalDeItens;

		public static Paginacao Builder() {
			return new Paginacao();
		}

		public Paginacao Build() {
			return this;
		}

		public Paginacao SetPaginaAtual(int paginaAtual) {
			this.PaginaAtual = paginaAtual;
			return this;
		}

		public Paginacao SetItensPorPagina(int itensPorPagina) {
			this.ItensPorPagina = itensPorPagina;
			return this;
		}

		public Paginacao SetQuantidadeDePaginas(int quantidadeDePaginas) {
			this.QuantidadeDePaginas = quantidadeDePaginas;
			return this;
		}

		public Paginacao SetQuantidadeTotalDeItens(int quantidadeTotalDeItens) {
			this.QuantidadeTotalDeItens = quantidadeTotalDeItens;
			return this;
		}
	}
}
