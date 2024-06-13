using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class CalendarioCobV {
		[DataMember(Name="criacao", EmitDefaultValue = false)]
		public string Criacao;
		[DataMember(Name="validadeAposVencimento", EmitDefaultValue = false)]
		public int ValidadeAposVencimento;
		[DataMember(Name="dataDeVencimento", EmitDefaultValue = false)]
		public string DataDeVencimento;

		public static CalendarioCobV Builder() {
			return new CalendarioCobV();
		}

		public CalendarioCobV Build() {
			return this;
		}

		public CalendarioCobV SetCriacao(string criacao) {
			this.Criacao = criacao;
			return this;
		}

		public CalendarioCobV SetValidadeAposVencimento(int validadeAposVencimento) {
			this.ValidadeAposVencimento = validadeAposVencimento;
			return this;
		}

		public CalendarioCobV SetDataDeVencimento(string dataDeVencimento) {
			this.DataDeVencimento = dataDeVencimento;
			return this;
		}
	}
}
