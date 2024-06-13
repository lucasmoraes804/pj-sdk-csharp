using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class FiltroBuscarPagamentos {
		[DataMember(Name="codBarraLinhaDigitavel", EmitDefaultValue = false)]
		public string CodBarraLinhaDigitavel;
		[DataMember(Name="codigoTransacao", EmitDefaultValue = false)]
		public string CodigoTransacao;
		[DataMember(Name="filtrarDataPor", EmitDefaultValue = false)]
		public string FiltrarDataPor;

		public static FiltroBuscarPagamentos Builder() {
			return new FiltroBuscarPagamentos();
		}

		public FiltroBuscarPagamentos Build() {
			return this;
		}

		public FiltroBuscarPagamentos SetCodBarraLinhaDigitavel(string codBarraLinhaDigitavel) {
			this.CodBarraLinhaDigitavel = codBarraLinhaDigitavel;
			return this;
		}

		public FiltroBuscarPagamentos SetCodigoTransacao(string codigoTransacao) {
			this.CodigoTransacao = codigoTransacao;
			return this;
		}

		public FiltroBuscarPagamentos SetFiltrarDataPor(string filtrarDataPor) {
			this.FiltrarDataPor = filtrarDataPor;
			return this;
		}
	}
}
