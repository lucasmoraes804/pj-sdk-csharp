using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class Multa {
		// 
		//  Código de Multa do título.
		//      
		[DataMember(Name="codigo", EmitDefaultValue = false)]
		public string Codigo;
		// 
		//  Taxa Percentual de Multa do título. Obrigatória se informado código
		//  de multa PERCENTUAL
		//  <p>Deve ser 0 para código de multa NAOTEMMULTA</p>
		//      
		[DataMember(Name="taxa", EmitDefaultValue = false)]
		public double Taxa;
		// 
		//  Valor de Multa expresso na moeda do título.
		//  <p>Obrigatório se informado código de multa VALORFIXO</p>
		//  <p>Deve ser 0 para código de multa NAOTEMMULTA</p>
		//      
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public double Valor;

		public static Multa Builder() {
			return new Multa();
		}

		public Multa Build() {
			return this;
		}

		public Multa SetCodigo(string codigo) {
			this.Codigo = codigo;
			return this;
		}

		public Multa SetTaxa(double taxa) {
			this.Taxa = taxa;
			return this;
		}

		public Multa SetValor(double valor) {
			this.Valor = valor;
			return this;
		}
	}
}
