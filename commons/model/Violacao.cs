using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk {
	[DataContract]
	public class Violacao {
		[DataMember(Name="razao", EmitDefaultValue = false)]
		public string Razao;
		[DataMember(Name="propriedade", EmitDefaultValue = false)]
		public string Propriedade;
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public string Valor;

		public static Violacao Builder() {
			return new Violacao();
		}

		public Violacao Build() {
			return this;
		}

		public Violacao SetRazao(string razao) {
			this.Razao = razao;
			return this;
		}

		public Violacao SetPropriedade(string propriedade) {
			this.Propriedade = propriedade;
			return this;
		}

		public Violacao SetValor(string valor) {
			this.Valor = valor;
			return this;
		}
	}
}
