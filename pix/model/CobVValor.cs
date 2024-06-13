using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class CobVValor {
		[DataMember(Name="original", EmitDefaultValue = false)]
		public string Original;
		[DataMember(Name="multa", EmitDefaultValue = false)]
		public Multa Multa;
		[DataMember(Name="juros", EmitDefaultValue = false)]
		public Juros Juros;
		[DataMember(Name="abatimento", EmitDefaultValue = false)]
		public Abatimento Abatimento;
		[DataMember(Name="desconto", EmitDefaultValue = false)]
		public Desconto Desconto;

		public static CobVValor Builder() {
			return new CobVValor();
		}

		public CobVValor Build() {
			return this;
		}

		public CobVValor SetOriginal(string original) {
			this.Original = original;
			return this;
		}

		public CobVValor SetMulta(Multa multa) {
			this.Multa = multa;
			return this;
		}

		public CobVValor SetJuros(Juros juros) {
			this.Juros = juros;
			return this;
		}

		public CobVValor SetAbatimento(Abatimento abatimento) {
			this.Abatimento = abatimento;
			return this;
		}

		public CobVValor SetDesconto(Desconto desconto) {
			this.Desconto = desconto;
			return this;
		}
	}
}
