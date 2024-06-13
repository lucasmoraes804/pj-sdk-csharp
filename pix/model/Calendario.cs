using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Calendario {
		// 
		//  Tempo de vida da cobrança, especificado em segundos a partir da data de criação
		//      
		[DataMember(Name="expiracao", EmitDefaultValue = false)]
		public int Expiracao;
		[DataMember(Name="criacao", EmitDefaultValue = false)]
		public string Criacao;

		public static Calendario Builder() {
			return new Calendario();
		}

		public Calendario Build() {
			return this;
		}

		public Calendario SetExpiracao(int expiracao) {
			this.Expiracao = expiracao;
			return this;
		}

		public Calendario SetCriacao(string criacao) {
			this.Criacao = criacao;
			return this;
		}
	}
}
