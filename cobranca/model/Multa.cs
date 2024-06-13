using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class Multa {
		// 
		//  Código de Multa do título.
		//      
		[DataMember(Name="codigoMulta", EmitDefaultValue = false)]
		public string CodigoMulta;
		// 
		//  Data da Multa do título.
		//  <p>Obrigatório se informado código de multa VALORFIXO ou PERCENTUAL.</p>
		//  <p>Deve ser maior que o vencimento e marca a data de início de cobrança
		//  de multa (incluindo essa data)</p>
		//  <p>Formato aceito: YYYY-MM-DD</p>
		//      
		[DataMember(Name="data", EmitDefaultValue = false)]
		public string Data;
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

		public Multa SetCodigoMulta(string codigoMulta) {
			this.CodigoMulta = codigoMulta;
			return this;
		}

		public Multa SetData(string data) {
			this.Data = data;
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
