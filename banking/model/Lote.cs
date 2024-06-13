using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class Lote {
		[DataMember(Name="meuIdentificador", EmitDefaultValue = false)]
		public string MeuIdentificador;
		[DataMember(Name="pagamentos", EmitDefaultValue = false)]
		public List<ItemLote> Pagamentos;

		public static Lote Builder() {
			return new Lote();
		}

		public Lote Build() {
			return this;
		}

		public Lote SetMeuIdentificador(string meuIdentificador) {
			this.MeuIdentificador = meuIdentificador;
			return this;
		}

		public Lote SetPagamentos(List<ItemLote> pagamentos) {
			this.Pagamentos = pagamentos;
			return this;
		}
	}
}
