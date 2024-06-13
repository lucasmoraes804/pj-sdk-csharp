using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class Ordenacao {
		[DataMember(Name="ordenarPor", EmitDefaultValue = false)]
		public string OrdenarPor;
		[DataMember(Name="tipoOrdenacao", EmitDefaultValue = false)]
		public string TipoOrdenacao;

		public static Ordenacao Builder() {
			return new Ordenacao();
		}

		public Ordenacao Build() {
			return this;
		}

		public Ordenacao SetOrdenarPor(string ordenarPor) {
			this.OrdenarPor = ordenarPor;
			return this;
		}

		public Ordenacao SetTipoOrdenacao(string tipoOrdenacao) {
			this.TipoOrdenacao = tipoOrdenacao;
			return this;
		}
	}
}
