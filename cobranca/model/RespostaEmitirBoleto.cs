using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class RespostaEmitirBoleto {
		// 
		//  Seu Número, enviado na requisição para inclusão do título.
		//      
		[DataMember(Name="seuNumero", EmitDefaultValue = false)]
		public string SeuNumero;
		// 
		//  Nosso Número, atribuído automaticamente pelo banco na emissão do título.
		//      
		[DataMember(Name="nossoNumero", EmitDefaultValue = false)]
		public string NossoNumero;
		// 
		//  Representação numérica do código de barras do título emitido. (44 dígitos)
		//      
		[DataMember(Name="codigoBarras", EmitDefaultValue = false)]
		public string CodigoBarras;
		// 
		//  Contém os mesmos dados do código de barras dispostos em ordem diferente e acrescido de dígitos verificadores. (47 dígitos)
		//      
		[DataMember(Name="linhaDigitavel", EmitDefaultValue = false)]
		public string LinhaDigitavel;

		public static RespostaEmitirBoleto Builder() {
			return new RespostaEmitirBoleto();
		}

		public RespostaEmitirBoleto Build() {
			return this;
		}

		public RespostaEmitirBoleto SetSeuNumero(string seuNumero) {
			this.SeuNumero = seuNumero;
			return this;
		}

		public RespostaEmitirBoleto SetNossoNumero(string nossoNumero) {
			this.NossoNumero = nossoNumero;
			return this;
		}

		public RespostaEmitirBoleto SetCodigoBarras(string codigoBarras) {
			this.CodigoBarras = codigoBarras;
			return this;
		}

		public RespostaEmitirBoleto SetLinhaDigitavel(string linhaDigitavel) {
			this.LinhaDigitavel = linhaDigitavel;
			return this;
		}
	}
}
