using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class CobrancaRecuperada {
		[DataMember(Name="cobranca", EmitDefaultValue = false)]
		public RespostaRecuperarCobrancaCobranca Cobranca;
		[DataMember(Name="boleto", EmitDefaultValue = false)]
		public RespostaRecuperarCobrancaBoleto Boleto;
		[DataMember(Name="pix", EmitDefaultValue = false)]
		public RespostaRecuperarCobrancaPix Pix;

		public static CobrancaRecuperada Builder() {
			return new CobrancaRecuperada();
		}

		public CobrancaRecuperada Build() {
			return this;
		}

		public CobrancaRecuperada SetCobranca(RespostaRecuperarCobrancaCobranca cobranca) {
			this.Cobranca = cobranca;
			return this;
		}

		public CobrancaRecuperada SetBoleto(RespostaRecuperarCobrancaBoleto boleto) {
			this.Boleto = boleto;
			return this;
		}

		public CobrancaRecuperada SetPix(RespostaRecuperarCobrancaPix pix) {
			this.Pix = pix;
			return this;
		}
	}
}
