using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class Mora {
		// 
		//  Código de Mora do título.
		//      
		[DataMember(Name="codigo", EmitDefaultValue = false)]
		public string Codigo;
		// 
		//  Percentual de Mora do título.
		//  <p>Obrigatória se informado código de mora TAXAMENSAL</p>
		//      
		[DataMember(Name="taxa", EmitDefaultValue = false)]
		public double Taxa;
		// 
		//  Valor de Mora expresso na moeda do título.
		//  <p>Obrigatório se informado código de mora TAXAMENSAL</p>
		//  <p>Deve ser 0 para código de mora ISENTO</p>
		//      
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public double Valor;

		public static Mora Builder() {
			return new Mora();
		}

		public Mora Build() {
			return this;
		}

		public Mora SetCodigo(string codigo) {
			this.Codigo = codigo;
			return this;
		}

		public Mora SetTaxa(double taxa) {
			this.Taxa = taxa;
			return this;
		}

		public Mora SetValor(double valor) {
			this.Valor = valor;
			return this;
		}
	}
}
