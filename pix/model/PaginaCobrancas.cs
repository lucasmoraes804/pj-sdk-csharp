using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class PaginaCobrancas {
		[DataMember(Name="parametros", EmitDefaultValue = false)]
		public Parametros Parametros;
		[DataMember(Name="cobs", EmitDefaultValue = false)]
		public List<CobrancaDetalhada> Cobrancas;

		public static PaginaCobrancas Builder() {
			return new PaginaCobrancas();
		}

		public PaginaCobrancas Build() {
			return this;
		}

		public PaginaCobrancas SetParametros(Parametros parametros) {
			this.Parametros = parametros;
			return this;
		}

		public PaginaCobrancas SetCobrancas(List<CobrancaDetalhada> cobrancas) {
			this.Cobrancas = cobrancas;
			return this;
		}
	}
}
