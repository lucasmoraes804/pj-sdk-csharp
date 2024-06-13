using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class CriarLocationRequest {
		[DataMember(Name="tipoCob", EmitDefaultValue = false)]
		public string TipoCob;

		public static CriarLocationRequest Builder() {
			return new CriarLocationRequest();
		}

		public CriarLocationRequest Build() {
			return this;
		}

		public CriarLocationRequest SetTipoCob(string tipoCob) {
			this.TipoCob = tipoCob;
			return this;
		}
	}
}
