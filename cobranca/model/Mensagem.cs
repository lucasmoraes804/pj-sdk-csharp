using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class Mensagem {
		[DataMember(Name="linha1", EmitDefaultValue = false)]
		public string Linha1;
		[DataMember(Name="linha2", EmitDefaultValue = false)]
		public string Linha2;
		[DataMember(Name="linha3", EmitDefaultValue = false)]
		public string Linha3;
		[DataMember(Name="linha4", EmitDefaultValue = false)]
		public string Linha4;
		[DataMember(Name="linha5", EmitDefaultValue = false)]
		public string Linha5;

		public static Mensagem Builder() {
			return new Mensagem();
		}

		public Mensagem Build() {
			return this;
		}

		public Mensagem SetLinha1(string linha1) {
			this.Linha1 = linha1;
			return this;
		}

		public Mensagem SetLinha2(string linha2) {
			this.Linha2 = linha2;
			return this;
		}

		public Mensagem SetLinha3(string linha3) {
			this.Linha3 = linha3;
			return this;
		}

		public Mensagem SetLinha4(string linha4) {
			this.Linha4 = linha4;
			return this;
		}

		public Mensagem SetLinha5(string linha5) {
			this.Linha5 = linha5;
			return this;
		}
	}
}
