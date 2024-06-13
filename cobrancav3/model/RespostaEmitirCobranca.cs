using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class RespostaEmitirCobranca {
		// 
		//  Código Solicitação Nosso Número, atribuído automaticamente pelo banco na emissão do título.
		//      
		[DataMember(Name="codigoSolicitacao", EmitDefaultValue = false)]
		public string CodigoSolicitacao;

		public static RespostaEmitirCobranca Builder() {
			return new RespostaEmitirCobranca();
		}

		public RespostaEmitirCobranca Build() {
			return this;
		}

		public RespostaEmitirCobranca SetCodigoSolicitacao(string codigoSolicitacao) {
			this.CodigoSolicitacao = codigoSolicitacao;
			return this;
		}
	}
}
