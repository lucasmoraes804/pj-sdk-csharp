using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Desconto {
		[DataMember(Name="modalidade", EmitDefaultValue = false)]
		public int Modalidade;
		[DataMember(Name="valorPerc", EmitDefaultValue = false)]
		public string ValorPerc;
		[DataMember(Name="descontoDataFixa", EmitDefaultValue = false)]
		public List<DescontoDataFixa> DescontoDataFixa;

		public static Desconto Builder() {
			return new Desconto();
		}

		public Desconto Build() {
			return this;
		}

		public Desconto SetModalidade(int modalidade) {
			this.Modalidade = modalidade;
			return this;
		}

		public Desconto SetValorPerc(string valorPerc) {
			this.ValorPerc = valorPerc;
			return this;
		}

		public Desconto SetDescontoDataFixa(List<DescontoDataFixa> descontoDataFixa) {
			this.DescontoDataFixa = descontoDataFixa;
			return this;
		}
	}
}
