using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class Mora {
		// 
		//  Código de Mora do título.
		//      
		[DataMember(Name="codigoMora", EmitDefaultValue = false)]
		public string CodigoMora;
		// 
		//  Data da Mora do título.
		//  <p>Obrigatório se informado código de mora VALORDIA, TAXAMENSAL ou CONTROLEDOBANCO.</p>
		//  <p>Deve ser maior que o vencimento e marca a data de início de cobrança
		//  de mora (incluindo essa data)</p>
		//  <p>Formato aceito: YYYY-MM-DD</p>
		//      
		[DataMember(Name="data", EmitDefaultValue = false)]
		public string Data;
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

		public Mora SetCodigoMora(string codigoMora) {
			this.CodigoMora = codigoMora;
			return this;
		}

		public Mora SetData(string data) {
			this.Data = data;
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
