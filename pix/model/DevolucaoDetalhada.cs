using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class DevolucaoDetalhada {
		// 
		//  Id gerado pelo cliente para representar unicamente uma devolução.
		//      
		[DataMember(Name="id", EmitDefaultValue = false)]
		public string Id;
		// 
		//  ReturnIdentification que transita na PACS004.
		//      
		[DataMember(Name="rtrId", EmitDefaultValue = false)]
		public string RtrId;
		// 
		//  Valor a devolver.
		//      
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public string Valor;
		// 
		//  Status da devolução.
		//  <ul>
		//      <li>EM_PROCESSAMENTO</li>
		//      <li>DEVOLVIDO</li>
		//      <li>NAO_REALIZADO</li>
		//  </ul>
		//      
		[DataMember(Name="status", EmitDefaultValue = false)]
		public string Status;
		// 
		//  Campo opcional que pode ser utilizado pelo PSP recebedor para detalhar os motivos
		//  de a devolução ter atingido o status em questão.
		//  Pode ser utilizado, por exemplo, para detalhar o motivo de a devolução não ter sido realizada.
		//      
		[DataMember(Name="motivo", EmitDefaultValue = false)]
		public string Motivo;

		public static DevolucaoDetalhada Builder() {
			return new DevolucaoDetalhada();
		}

		public DevolucaoDetalhada Build() {
			return this;
		}

		public DevolucaoDetalhada SetId(string id) {
			this.Id = id;
			return this;
		}

		public DevolucaoDetalhada SetRtrId(string rtrId) {
			this.RtrId = rtrId;
			return this;
		}

		public DevolucaoDetalhada SetValor(string valor) {
			this.Valor = valor;
			return this;
		}

		public DevolucaoDetalhada SetStatus(string status) {
			this.Status = status;
			return this;
		}

		public DevolucaoDetalhada SetMotivo(string motivo) {
			this.Motivo = motivo;
			return this;
		}
	}
}
