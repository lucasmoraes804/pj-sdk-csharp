using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class FiltroBuscarCallbacks {
		[DataMember(Name="txid", EmitDefaultValue = false)]
		public string Txid;

		public static FiltroBuscarCallbacks Builder() {
			return new FiltroBuscarCallbacks();
		}

		public FiltroBuscarCallbacks Build() {
			return this;
		}

		public FiltroBuscarCallbacks SetTxid(string txid) {
			this.Txid = txid;
			return this;
		}
	}
}
