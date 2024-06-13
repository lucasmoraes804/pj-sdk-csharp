using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class FiltroBuscarCallbacks {
		[DataMember(Name="nossoNumero", EmitDefaultValue = false)]
		public string NossoNumero;

		public static FiltroBuscarCallbacks Builder() {
			return new FiltroBuscarCallbacks();
		}

		public FiltroBuscarCallbacks Build() {
			return this;
		}

		public FiltroBuscarCallbacks SetNossoNumero(string nossoNumero) {
			this.NossoNumero = nossoNumero;
			return this;
		}
	}
}
