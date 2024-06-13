using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class ValorComponente {
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public string Valor;
		[DataMember(Name="modalidadeAgente", EmitDefaultValue = false)]
		public string ModalidadeAgente;
		[DataMember(Name="prestadorDoServicoDeSaque", EmitDefaultValue = false)]
		public string PrestadorDoServicoDeSaque;

		public static ValorComponente Builder() {
			return new ValorComponente();
		}

		public ValorComponente Build() {
			return this;
		}

		public ValorComponente SetValor(string valor) {
			this.Valor = valor;
			return this;
		}

		public ValorComponente SetModalidadeAgente(string modalidadeAgente) {
			this.ModalidadeAgente = modalidadeAgente;
			return this;
		}

		public ValorComponente SetPrestadorDoServicoDeSaque(string prestadorDoServicoDeSaque) {
			this.PrestadorDoServicoDeSaque = prestadorDoServicoDeSaque;
			return this;
		}
	}
}
