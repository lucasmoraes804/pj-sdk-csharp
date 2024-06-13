using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class DescontoDataFixa {
		[DataMember(Name="valorPerc", EmitDefaultValue = false)]
		public string ValorPerc;
		[DataMember(Name="data", EmitDefaultValue = false)]
		public string Data;

		public static DescontoDataFixa Builder() {
			return new DescontoDataFixa();
		}

		public DescontoDataFixa Build() {
			return this;
		}

		public DescontoDataFixa SetValorPerc(string valorPerc) {
			this.ValorPerc = valorPerc;
			return this;
		}

		public DescontoDataFixa SetData(string data) {
			this.Data = data;
			return this;
		}
	}
}
