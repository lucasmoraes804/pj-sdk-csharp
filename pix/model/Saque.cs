using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Saque {
		// 
		//  REQUERIDO
		//  Valor do saque efetuado
		//      
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public string Valor;
		// 
		//  Modalidade de alteração de valor do saque. Quando não preenchido o valor assumido é o 0 (zero).
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

		public static Saque Builder() {
			return new Saque();
		}

		public Saque Build() {
			return this;
		}

		public Saque SetValor(string valor) {
			this.Valor = valor;
			return this;
		}

		public Saque SetModalidadeAlteracao(int modalidadeAlteracao) {
			this.ModalidadeAlteracao = modalidadeAlteracao;
			return this;
		}

		public Saque SetModalidadeAgente(string modalidadeAgente) {
			this.ModalidadeAgente = modalidadeAgente;
			return this;
		}

		public Saque SetPrestadorDoServicoDeSaque(string prestadorDoServicoDeSaque) {
			this.PrestadorDoServicoDeSaque = prestadorDoServicoDeSaque;
			return this;
		}
	}
}
