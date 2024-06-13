using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class RequisicaoCancelarBoleto {
		// 
		//  Domínio que descreve o tipo de cancelamento sendo solicitado.
		//      
		[DataMember(Name="motivoCancelamento", EmitDefaultValue = false)]
		public string MotivoCancelamento;

		public static RequisicaoCancelarBoleto Builder() {
			return new RequisicaoCancelarBoleto();
		}

		public RequisicaoCancelarBoleto Build() {
			return this;
		}

		public RequisicaoCancelarBoleto SetMotivoCancelamento(string motivoCancelamento) {
			this.MotivoCancelamento = motivoCancelamento;
			return this;
		}
	}
}
