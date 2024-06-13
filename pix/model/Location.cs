using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Location {
		[DataMember(Name="tipoCob", EmitDefaultValue = false)]
		public string TipoCob;
		// 
		//  Identificador da location a ser informada na criação da cobrança .
		//      
		[DataMember(Name="id", EmitDefaultValue = false)]
		public long Id;
		// 
		//  Localização do Payload a ser informada na criação da cobrança.
		//      
		[DataMember(Name="location", EmitDefaultValue = false)]
		public string _Location;
		// 
		//  Data e hora em que a location foi criada. Respeita RFC 3339.
		//      
		[DataMember(Name="criacao", EmitDefaultValue = false)]
		public string Criacao;

		public static Location Builder() {
			return new Location();
		}

		public Location Build() {
			return this;
		}

		public Location SetTipoCob(string tipoCob) {
			this.TipoCob = tipoCob;
			return this;
		}

		public Location SetId(long id) {
			this.Id = id;
			return this;
		}

		public Location SetLocation(string _Location) {
			this._Location = _Location;
			return this;
		}

		public Location SetCriacao(string criacao) {
			this.Criacao = criacao;
			return this;
		}
	}
}
