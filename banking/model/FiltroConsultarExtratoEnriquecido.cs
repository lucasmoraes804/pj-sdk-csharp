using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class FiltroConsultarExtratoEnriquecido {
		[DataMember(Name="tipoOperacao", EmitDefaultValue = false)]
		public string TipoOperacao;
		[DataMember(Name="tipoTransacao", EmitDefaultValue = false)]
		public string TipoTransacao;

		public static FiltroConsultarExtratoEnriquecido Builder() {
			return new FiltroConsultarExtratoEnriquecido();
		}

		public FiltroConsultarExtratoEnriquecido Build() {
			return this;
		}

		public FiltroConsultarExtratoEnriquecido SetTipoOperacao(string tipoOperacao) {
			this.TipoOperacao = tipoOperacao;
			return this;
		}

		public FiltroConsultarExtratoEnriquecido SetTipoTransacao(string tipoTransacao) {
			this.TipoTransacao = tipoTransacao;
			return this;
		}
	}
}
