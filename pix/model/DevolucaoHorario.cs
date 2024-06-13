using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class DevolucaoHorario {
		[DataMember(Name="solicitacao", EmitDefaultValue = false)]
		public DateTimeOffset Solicitacao;
		[DataMember(Name="liquidacao", EmitDefaultValue = false)]
		public DateTimeOffset Liquidacao;

		public static DevolucaoHorario Builder() {
			return new DevolucaoHorario();
		}

		public DevolucaoHorario Build() {
			return this;
		}

		public DevolucaoHorario SetSolicitacao(DateTimeOffset solicitacao) {
			this.Solicitacao = solicitacao;
			return this;
		}

		public DevolucaoHorario SetLiquidacao(DateTimeOffset liquidacao) {
			this.Liquidacao = liquidacao;
			return this;
		}
	}
}
