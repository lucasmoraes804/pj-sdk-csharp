using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class Chave : Destinatario {
		[DataMember(Name="tipo", EmitDefaultValue = false)]
		public string Tipo;
		[DataMember(Name="chave", EmitDefaultValue = false)]
		public string _Chave;

		public static Chave Builder() {
			return new Chave();
		}

		public Chave Build() {
			return this;
		}

		public Chave SetTipo(string tipo) {
			this.Tipo = tipo;
			return this;
		}

		public Chave SetChave(string _Chave) {
			this._Chave = _Chave;
			return this;
		}
	}
}
