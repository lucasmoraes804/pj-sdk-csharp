using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class Extrato {
		[DataMember(Name="transacoes", EmitDefaultValue = false)]
		public List<Transacao> Transacoes;

		public static Extrato Builder() {
			return new Extrato();
		}

		public Extrato Build() {
			return this;
		}

		public Extrato SetTransacoes(List<Transacao> transacoes) {
			this.Transacoes = transacoes;
			return this;
		}
	}
}
