using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class Desconto {
		// 
		//  Código de Desconto do título.
		//      
		[DataMember(Name="codigo", EmitDefaultValue = false)]
		public string Codigo;
		// 
		//  Quantidade de dias antes do vencimento que será aplicado o desconto..
		//      
		[DataMember(Name="quantidadeDias", EmitDefaultValue = false)]
		public int QuantidadeDias;
		// 
		//  Taxa Percentual de Desconto do título.
		//  <p>A ser informado quando o código de desconto for PERCENTUALDATAINFORMADA,
		//  PERCENTUALVALORNOMINALDIACORRIDO e PERCENTUALVALORNOMINALDIAUTIL</p>
		//      
		[DataMember(Name="taxa", EmitDefaultValue = false)]
		public double Taxa;
		// 
		//  Valor de Desconto, expresso na moeda do título.
		//  <p>A ser informada quando o código de desconto for VALORFIXODATAINFORMADA,
		//  VALORANTECIPACAODIACORRIDO e VALORANTECIPACAODIAUTIL</p>
		//      
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public double Valor;

		public static Desconto Builder() {
			return new Desconto();
		}

		public Desconto Build() {
			return this;
		}

		public Desconto SetCodigo(string codigo) {
			this.Codigo = codigo;
			return this;
		}

		public Desconto SetQuantidadeDias(int quantidadeDias) {
			this.QuantidadeDias = quantidadeDias;
			return this;
		}

		public Desconto SetTaxa(double taxa) {
			this.Taxa = taxa;
			return this;
		}

		public Desconto SetValor(double valor) {
			this.Valor = valor;
			return this;
		}
	}
}
