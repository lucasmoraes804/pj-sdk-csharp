using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class PaginaExtratoEnriquecido {
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
		[DataMember(Name="transacoes", EmitDefaultValue = false)]
		public List<TransacaoEnriquecida> Transacoes;

		public static PaginaExtratoEnriquecido Builder() {
			return new PaginaExtratoEnriquecido();
		}

		public PaginaExtratoEnriquecido Build() {
			return this;
		}

		public PaginaExtratoEnriquecido SetTotalPaginas(int totalPaginas) {
			this.TotalPaginas = totalPaginas;
			return this;
		}

		public PaginaExtratoEnriquecido SetTotalElementos(int totalElementos) {
			this.TotalElementos = totalElementos;
			return this;
		}

		public PaginaExtratoEnriquecido SetUltimaPagina(bool ultimaPagina) {
			this.UltimaPagina = ultimaPagina;
			return this;
		}

		public PaginaExtratoEnriquecido SetPrimeiraPagina(bool primeiraPagina) {
			this.PrimeiraPagina = primeiraPagina;
			return this;
		}

		public PaginaExtratoEnriquecido SetTamanhoPagina(int tamanhoPagina) {
			this.TamanhoPagina = tamanhoPagina;
			return this;
		}

		public PaginaExtratoEnriquecido SetNumeroDeElementos(int numeroDeElementos) {
			this.NumeroDeElementos = numeroDeElementos;
			return this;
		}

		public PaginaExtratoEnriquecido SetTransacoes(List<TransacaoEnriquecida> transacoes) {
			this.Transacoes = transacoes;
			return this;
		}
	}
}
