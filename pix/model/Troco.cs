using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Troco {
		// 
		//  REQUERIDO
		//  Valor do troco efetuado
		//      
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public string Valor;
		// 
		//  Modalidade de alteração de valor do saque/troco. Quando não preenchido o valor assumido é o 0 (zero).
		//      
		[DataMember(Name="modalidadeAlteracao", EmitDefaultValue = false)]
		public int ModalidadeAlteracao;
		// 
		//  REQUERIDO
		//      
		[DataMember(Name="modalidadeAgente", EmitDefaultValue = false)]
		public string ModalidadeAgente;
		// 
		//  REQUERIDO
		//  SPB do Facilitador de Serviço de Saque
		//      
		[DataMember(Name="prestadorDoServicoDeSaque", EmitDefaultValue = false)]
		public string PrestadorDoServicoDeSaque;

		public static Troco Builder() {
			return new Troco();
		}

		public Troco Build() {
			return this;
		}

		public Troco SetValor(string valor) {
			this.Valor = valor;
			return this;
		}

		public Troco SetModalidadeAlteracao(int modalidadeAlteracao) {
			this.ModalidadeAlteracao = modalidadeAlteracao;
			return this;
		}

		public Troco SetModalidadeAgente(string modalidadeAgente) {
			this.ModalidadeAgente = modalidadeAgente;
			return this;
		}

		public Troco SetPrestadorDoServicoDeSaque(string prestadorDoServicoDeSaque) {
			this.PrestadorDoServicoDeSaque = prestadorDoServicoDeSaque;
			return this;
		}
	}
}
