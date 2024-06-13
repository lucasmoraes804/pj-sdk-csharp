using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class ItemSumario {
		[DataMember(Name="quantidade", EmitDefaultValue = false)]
		public int Quantidade;
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public double Valor;

		public static ItemSumario Builder() {
			return new ItemSumario();
		}

		public ItemSumario Build() {
			return this;
		}

		public ItemSumario SetQuantidade(int quantidade) {
			this.Quantidade = quantidade;
			return this;
		}

		public ItemSumario SetValor(double valor) {
			this.Valor = valor;
			return this;
		}
	}
}
