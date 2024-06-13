using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Parametros {
		[DataMember(Name="paginacao", EmitDefaultValue = false)]
		public Paginacao Paginacao;

		public static Parametros Builder() {
			return new Parametros();
		}

		public Parametros Build() {
			return this;
		}

		public Parametros SetPaginacao(Paginacao paginacao) {
			this.Paginacao = paginacao;
			return this;
		}
	}
}
