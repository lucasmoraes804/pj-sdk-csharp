using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Abatimento {
		[DataMember(Name="modalidade", EmitDefaultValue = false)]
		public int Modalidade;
		[DataMember(Name="valorPerc", EmitDefaultValue = false)]
		public string ValorPerc;

		public static Abatimento Builder() {
			return new Abatimento();
		}

		public Abatimento Build() {
			return this;
		}

		public Abatimento SetModalidade(int modalidade) {
			this.Modalidade = modalidade;
			return this;
		}

		public Abatimento SetValorPerc(string valorPerc) {
			this.ValorPerc = valorPerc;
			return this;
		}
	}
}
