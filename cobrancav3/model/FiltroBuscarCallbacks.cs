using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class FiltroBuscarCallbacks {
		[DataMember(Name="codigoSolicitacao", EmitDefaultValue = false)]
		public string CodigoSolicitacao;

		public static FiltroBuscarCallbacks Builder() {
			return new FiltroBuscarCallbacks();
		}

		public FiltroBuscarCallbacks Build() {
			return this;
		}

		public FiltroBuscarCallbacks SetCodigoSolicitacao(string codigoSolicitacao) {
			this.CodigoSolicitacao = codigoSolicitacao;
			return this;
		}
	}
}
