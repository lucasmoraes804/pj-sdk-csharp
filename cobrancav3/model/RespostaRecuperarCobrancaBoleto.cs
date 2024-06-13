using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class RespostaRecuperarCobrancaBoleto {
		[DataMember(Name="nossoNumero", EmitDefaultValue = false)]
		public string NossoNumero;
		[DataMember(Name="codigoBarras", EmitDefaultValue = false)]
		public string CodigoBarras;
		[DataMember(Name="linhaDigitavel", EmitDefaultValue = false)]
		public string LinhaDigitavel;

		public static RespostaRecuperarCobrancaBoleto Builder() {
			return new RespostaRecuperarCobrancaBoleto();
		}

		public RespostaRecuperarCobrancaBoleto Build() {
			return this;
		}

		public RespostaRecuperarCobrancaBoleto SetNossoNumero(string nossoNumero) {
			this.NossoNumero = nossoNumero;
			return this;
		}

		public RespostaRecuperarCobrancaBoleto SetCodigoBarras(string codigoBarras) {
			this.CodigoBarras = codigoBarras;
			return this;
		}

		public RespostaRecuperarCobrancaBoleto SetLinhaDigitavel(string linhaDigitavel) {
			this.LinhaDigitavel = linhaDigitavel;
			return this;
		}
	}
}
