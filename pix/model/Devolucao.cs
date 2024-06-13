using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Devolucao {
		[DataMember(Name="id", EmitDefaultValue = false)]
		public string Id;
		[DataMember(Name="rtrId", EmitDefaultValue = false)]
		public string RtrId;
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public string Valor;
		[DataMember(Name="horario", EmitDefaultValue = false)]
		public DevolucaoHorario Horario;
		[DataMember(Name="status", EmitDefaultValue = false)]
		public string Status;
		[DataMember(Name="motivo", EmitDefaultValue = false)]
		public string Motivo;

		public static Devolucao Builder() {
			return new Devolucao();
		}

		public Devolucao Build() {
			return this;
		}

		public Devolucao SetId(string id) {
			this.Id = id;
			return this;
		}

		public Devolucao SetRtrId(string rtrId) {
			this.RtrId = rtrId;
			return this;
		}

		public Devolucao SetValor(string valor) {
			this.Valor = valor;
			return this;
		}

		public Devolucao SetHorario(DevolucaoHorario horario) {
			this.Horario = horario;
			return this;
		}

		public Devolucao SetStatus(string status) {
			this.Status = status;
			return this;
		}

		public Devolucao SetMotivo(string motivo) {
			this.Motivo = motivo;
			return this;
		}
	}
}
