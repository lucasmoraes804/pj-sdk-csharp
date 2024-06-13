using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class DetalhesTransacao {
		[DataMember(Name="tipoDetalhe", EmitDefaultValue = false)]
		public string TipoDetalhe;

		public static DetalhesTransacao Builder() {
			return new DetalhesTransacao();
		}

		public DetalhesTransacao Build() {
			return this;
		}

		public DetalhesTransacao SetTipoDetalhe(string tipoDetalhe) {
			this.TipoDetalhe = tipoDetalhe;
			return this;
		}
	}
}
