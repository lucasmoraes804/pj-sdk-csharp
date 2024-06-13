using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class RequisicaoCancelarCobranca {
		// 
		//  Domínio que descreve o tipo de cancelamento sendo solicitado.
		//      
		[DataMember(Name="motivoCancelamento", EmitDefaultValue = false)]
		public string MotivoCancelamento;

		public static RequisicaoCancelarCobranca Builder() {
			return new RequisicaoCancelarCobranca();
		}

		public RequisicaoCancelarCobranca Build() {
			return this;
		}

		public RequisicaoCancelarCobranca SetMotivoCancelamento(string motivoCancelamento) {
			this.MotivoCancelamento = motivoCancelamento;
			return this;
		}
	}
}
