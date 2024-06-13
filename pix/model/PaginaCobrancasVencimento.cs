using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class PaginaCobrancasVencimento {
		[DataMember(Name="parametros", EmitDefaultValue = false)]
		public Parametros Parametros;
		[DataMember(Name="cobs", EmitDefaultValue = false)]
		public List<CobrancaVencimentoDetalhada> Cobrancas;

		public static PaginaCobrancasVencimento Builder() {
			return new PaginaCobrancasVencimento();
		}

		public PaginaCobrancasVencimento Build() {
			return this;
		}

		public PaginaCobrancasVencimento SetParametros(Parametros parametros) {
			this.Parametros = parametros;
			return this;
		}

		public PaginaCobrancasVencimento SetCobrancas(List<CobrancaVencimentoDetalhada> cobrancas) {
			this.Cobrancas = cobrancas;
			return this;
		}
	}
}
