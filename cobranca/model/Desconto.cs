using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class Desconto {
		// 
		//  Código de Desconto do título.
		//      
		[DataMember(Name="codigoDesconto", EmitDefaultValue = false)]
		public string CodigoDesconto;
		// 
		//  Data de Desconto do título.
		//  <p>Obrigatório para códigos de desconto VALORFIXODATAINFORMADA e PERCENTUALDATAINFORMADA. Não informar para os demais</p>
		//  <p>Formato aceito: YYYY-MM-DD</p>
		//      
		[DataMember(Name="data", EmitDefaultValue = false)]
		public string Data;
		// 
		//  Taxa Percentual de Desconto do título.
		//  <p>Obrigatório para códigos de desconto PERCENTUALDATAINFORMADA,
		//  PERCENTUALVALORNOMINALDIACORRIDO e PERCENTUALVALORNOMINALDIAUTIL</p>
		//      
		[DataMember(Name="taxa", EmitDefaultValue = false)]
		public double Taxa;
		// 
		//  Valor de Desconto, expresso na moeda do título.
		//  <p>Obrigatório para códigos de desconto VALORFIXODATAINFORMADA,
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

		public Desconto SetCodigoDesconto(string codigoDesconto) {
			this.CodigoDesconto = codigoDesconto;
			return this;
		}

		public Desconto SetData(string data) {
			this.Data = data;
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
