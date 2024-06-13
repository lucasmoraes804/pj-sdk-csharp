using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class FiltroBuscarPagamentosDarf {
		[DataMember(Name="codigoTransacao", EmitDefaultValue = false)]
		public string CodigoTransacao;
		[DataMember(Name="codigoReceita", EmitDefaultValue = false)]
		public string CodigoReceita;
		[DataMember(Name="filtrarDataPor", EmitDefaultValue = false)]
		public string FiltrarDataPor;

		public static FiltroBuscarPagamentosDarf Builder() {
			return new FiltroBuscarPagamentosDarf();
		}

		public FiltroBuscarPagamentosDarf Build() {
			return this;
		}

		public FiltroBuscarPagamentosDarf SetCodigoTransacao(string codigoTransacao) {
			this.CodigoTransacao = codigoTransacao;
			return this;
		}

		public FiltroBuscarPagamentosDarf SetCodigoReceita(string codigoReceita) {
			this.CodigoReceita = codigoReceita;
			return this;
		}

		public FiltroBuscarPagamentosDarf SetFiltrarDataPor(string filtrarDataPor) {
			this.FiltrarDataPor = filtrarDataPor;
			return this;
		}
	}
}
