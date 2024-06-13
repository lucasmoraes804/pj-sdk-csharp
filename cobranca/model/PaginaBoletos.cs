using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class PaginaBoletos {
		// 
		//  Quantidade total de páginas disponíveis para consulta.
		//      
		[DataMember(Name="totalPages", EmitDefaultValue = false)]
		public int TotalPaginas;
		// 
		//  Quantidade total de itens disponíveis de acordo com os parâmetros informados.
		//      
		[DataMember(Name="totalElements", EmitDefaultValue = false)]
		public int TotalElementos;
		// 
		//  Última página
		//      
		[DataMember(Name="last", EmitDefaultValue = false)]
		public bool UltimaPagina;
		// 
		//  Primeira página
		//      
		[DataMember(Name="first", EmitDefaultValue = false)]
		public bool PrimeiraPagina;
		// 
		//  Quantidade de registros por página, configurado na requisição.
		//      
		[DataMember(Name="size", EmitDefaultValue = false)]
		public int TamanhoPagina;
		// 
		//  Quantidade de registros retornado na página atual.
		//      
		[DataMember(Name="numberOfElements", EmitDefaultValue = false)]
		public int NumeroDeElementos;
		[DataMember(Name="content", EmitDefaultValue = false)]
		public List<BoletoDetalhado> Boletos;

		public static PaginaBoletos Builder() {
			return new PaginaBoletos();
		}

		public PaginaBoletos Build() {
			return this;
		}

		public PaginaBoletos SetTotalPaginas(int totalPaginas) {
			this.TotalPaginas = totalPaginas;
			return this;
		}

		public PaginaBoletos SetTotalElementos(int totalElementos) {
			this.TotalElementos = totalElementos;
			return this;
		}

		public PaginaBoletos SetUltimaPagina(bool ultimaPagina) {
			this.UltimaPagina = ultimaPagina;
			return this;
		}

		public PaginaBoletos SetPrimeiraPagina(bool primeiraPagina) {
			this.PrimeiraPagina = primeiraPagina;
			return this;
		}

		public PaginaBoletos SetTamanhoPagina(int tamanhoPagina) {
			this.TamanhoPagina = tamanhoPagina;
			return this;
		}

		public PaginaBoletos SetNumeroDeElementos(int numeroDeElementos) {
			this.NumeroDeElementos = numeroDeElementos;
			return this;
		}

		public PaginaBoletos SetBoletos(List<BoletoDetalhado> boletos) {
			this.Boletos = boletos;
			return this;
		}
	}
}
