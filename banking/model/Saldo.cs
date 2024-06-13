using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class Saldo {
		[DataMember(Name="disponivel", EmitDefaultValue = false)]
		public double Disponivel;
		[DataMember(Name="bloqueadoCheque", EmitDefaultValue = false)]
		public double BloqueadoCheque;
		[DataMember(Name="bloqueadoJudicialmente", EmitDefaultValue = false)]
		public double BloqueadoJudicialmente;
		[DataMember(Name="bloqueadoAdministrativo", EmitDefaultValue = false)]
		public double BloqueadoAdministrativo;
		[DataMember(Name="limite", EmitDefaultValue = false)]
		public double Limite;

		public static Saldo Builder() {
			return new Saldo();
		}

		public Saldo Build() {
			return this;
		}

		public Saldo SetDisponivel(double disponivel) {
			this.Disponivel = disponivel;
			return this;
		}

		public Saldo SetBloqueadoCheque(double bloqueadoCheque) {
			this.BloqueadoCheque = bloqueadoCheque;
			return this;
		}

		public Saldo SetBloqueadoJudicialmente(double bloqueadoJudicialmente) {
			this.BloqueadoJudicialmente = bloqueadoJudicialmente;
			return this;
		}

		public Saldo SetBloqueadoAdministrativo(double bloqueadoAdministrativo) {
			this.BloqueadoAdministrativo = bloqueadoAdministrativo;
			return this;
		}

		public Saldo SetLimite(double limite) {
			this.Limite = limite;
			return this;
		}
	}
}
