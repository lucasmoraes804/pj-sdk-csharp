using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class Sumario {
		[DataMember(Name="pagos", EmitDefaultValue = false)]
		public ItemSumario Pagos;
		[DataMember(Name="abertos", EmitDefaultValue = false)]
		public ItemSumario Abertos;
		[DataMember(Name="vencidos", EmitDefaultValue = false)]
		public ItemSumario Vencidos;
		[DataMember(Name="cancelados", EmitDefaultValue = false)]
		public ItemSumario Cancelados;
		[DataMember(Name="expirados", EmitDefaultValue = false)]
		public ItemSumario Expirados;

		public static Sumario Builder() {
			return new Sumario();
		}

		public Sumario Build() {
			return this;
		}

		public Sumario SetPagos(ItemSumario pagos) {
			this.Pagos = pagos;
			return this;
		}

		public Sumario SetAbertos(ItemSumario abertos) {
			this.Abertos = abertos;
			return this;
		}

		public Sumario SetVencidos(ItemSumario vencidos) {
			this.Vencidos = vencidos;
			return this;
		}

		public Sumario SetCancelados(ItemSumario cancelados) {
			this.Cancelados = cancelados;
			return this;
		}

		public Sumario SetExpirados(ItemSumario expirados) {
			this.Expirados = expirados;
			return this;
		}
	}
}
