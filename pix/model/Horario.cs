using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Horario {
		[DataMember(Name="solicitacao", EmitDefaultValue = false)]
		public string Solicitacao;
		[DataMember(Name="liquidacao", EmitDefaultValue = false)]
		public string Liquidacao;

		public static Horario Builder() {
			return new Horario();
		}

		public Horario Build() {
			return this;
		}

		public Horario SetSolicitacao(string solicitacao) {
			this.Solicitacao = solicitacao;
			return this;
		}

		public Horario SetLiquidacao(string liquidacao) {
			this.Liquidacao = liquidacao;
			return this;
		}
	}
}
