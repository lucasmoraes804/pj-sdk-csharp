using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Retirada {
		[DataMember(Name="saque", EmitDefaultValue = false)]
		public Saque Saque;
		[DataMember(Name="troco", EmitDefaultValue = false)]
		public Troco Troco;

		public static Retirada Builder() {
			return new Retirada();
		}

		public Retirada Build() {
			return this;
		}

		public Retirada SetSaque(Saque saque) {
			this.Saque = saque;
			return this;
		}

		public Retirada SetTroco(Troco troco) {
			this.Troco = troco;
			return this;
		}
	}
}
