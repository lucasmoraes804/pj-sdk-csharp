using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class PaginaCobrancas {
		[DataMember(Name="totalPaginas", EmitDefaultValue = false)]
		public int TotalPaginas;
		[DataMember(Name="totalElementos", EmitDefaultValue = false)]
		public int TotalElementos;
		[DataMember(Name="ultimaPagina", EmitDefaultValue = false)]
		public bool UltimaPagina;
		[DataMember(Name="primeiraPagina", EmitDefaultValue = false)]
		public bool PrimeiraPagina;
		[DataMember(Name="tamanhoPagina", EmitDefaultValue = false)]
		public int TamanhoPagina;
		[DataMember(Name="numeroDeElementos", EmitDefaultValue = false)]
		public int NumeroDeElementos;
		[DataMember(Name="cobrancas", EmitDefaultValue = false)]
		public List<CobrancaRecuperada> Cobrancas;

		public static PaginaCobrancas Builder() {
			return new PaginaCobrancas();
		}

		public PaginaCobrancas Build() {
			return this;
		}

		public PaginaCobrancas SetTotalPaginas(int totalPaginas) {
			this.TotalPaginas = totalPaginas;
			return this;
		}

		public PaginaCobrancas SetTotalElementos(int totalElementos) {
			this.TotalElementos = totalElementos;
			return this;
		}

		public PaginaCobrancas SetUltimaPagina(bool ultimaPagina) {
			this.UltimaPagina = ultimaPagina;
			return this;
		}

		public PaginaCobrancas SetPrimeiraPagina(bool primeiraPagina) {
			this.PrimeiraPagina = primeiraPagina;
			return this;
		}

		public PaginaCobrancas SetTamanhoPagina(int tamanhoPagina) {
			this.TamanhoPagina = tamanhoPagina;
			return this;
		}

		public PaginaCobrancas SetNumeroDeElementos(int numeroDeElementos) {
			this.NumeroDeElementos = numeroDeElementos;
			return this;
		}

		public PaginaCobrancas SetCobrancas(List<CobrancaRecuperada> cobrancas) {
			this.Cobrancas = cobrancas;
			return this;
		}
	}
}
