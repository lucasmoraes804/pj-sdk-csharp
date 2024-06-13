using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Multa {
		[DataMember(Name="modalidade", EmitDefaultValue = false)]
		public int Modalidade;
		[DataMember(Name="valorPerc", EmitDefaultValue = false)]
		public string ValorPerc;

		public static Multa Builder() {
			return new Multa();
		}

		public Multa Build() {
			return this;
		}

		public Multa SetModalidade(int modalidade) {
			this.Modalidade = modalidade;
			return this;
		}

		public Multa SetValorPerc(string valorPerc) {
			this.ValorPerc = valorPerc;
			return this;
		}
	}
}
