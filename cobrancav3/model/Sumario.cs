using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class Sumario : List<ItemSumario> {

		public static Sumario Builder() {
			return new Sumario();
		}

		public Sumario Build() {
			return this;
		}
	}
}
