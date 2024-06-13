using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Juros {
		[DataMember(Name="modalidade", EmitDefaultValue = false)]
		public int Modalidade;
		[DataMember(Name="valorPerc", EmitDefaultValue = false)]
		public string ValorPerc;

		public static Juros Builder() {
			return new Juros();
		}

		public Juros Build() {
			return this;
		}

		public Juros SetModalidade(int modalidade) {
			this.Modalidade = modalidade;
			return this;
		}

		public Juros SetValorPerc(string valorPerc) {
			this.ValorPerc = valorPerc;
			return this;
		}
	}
}
