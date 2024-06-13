using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class InfoAdicional {
		[DataMember(Name="nome", EmitDefaultValue = false)]
		public string Nome;
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public string Valor;

		public static InfoAdicional Builder() {
			return new InfoAdicional();
		}

		public InfoAdicional Build() {
			return this;
		}

		public InfoAdicional SetNome(string nome) {
			this.Nome = nome;
			return this;
		}

		public InfoAdicional SetValor(string valor) {
			this.Valor = valor;
			return this;
		}
	}
}
