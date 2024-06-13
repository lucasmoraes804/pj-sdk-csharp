using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class RespostaRecuperarCobrancaPix {
		[DataMember(Name="txid", EmitDefaultValue = false)]
		public string Txid;
		[DataMember(Name="pixCopiaECola", EmitDefaultValue = false)]
		public string PixCopiaECola;

		public static RespostaRecuperarCobrancaPix Builder() {
			return new RespostaRecuperarCobrancaPix();
		}

		public RespostaRecuperarCobrancaPix Build() {
			return this;
		}

		public RespostaRecuperarCobrancaPix SetTxid(string txid) {
			this.Txid = txid;
			return this;
		}

		public RespostaRecuperarCobrancaPix SetPixCopiaECola(string pixCopiaECola) {
			this.PixCopiaECola = pixCopiaECola;
			return this;
		}
	}
}
