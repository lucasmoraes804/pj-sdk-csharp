using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Payload {
		[DataMember(Name="pix", EmitDefaultValue = false)]
		public List<ItemPayload> Pix;

		public static Payload Builder() {
			return new Payload();
		}

		public Payload Build() {
			return this;
		}

		public Payload SetPix(List<ItemPayload> pix) {
			this.Pix = pix;
			return this;
		}
	}
}
