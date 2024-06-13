using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class ComponenteValor {
		[DataMember(Name="original", EmitDefaultValue = false)]
		public ValorComponente Original;
		[DataMember(Name="troco", EmitDefaultValue = false)]
		public ValorComponente Troco;
		[DataMember(Name="abatimento", EmitDefaultValue = false)]
		public ValorComponente Abatimento;
		[DataMember(Name="desconto", EmitDefaultValue = false)]
		public ValorComponente Desconto;
		[DataMember(Name="juros", EmitDefaultValue = false)]
		public ValorComponente Juros;
		[DataMember(Name="multa", EmitDefaultValue = false)]
		public ValorComponente Multa;

		public static ComponenteValor Builder() {
			return new ComponenteValor();
		}

		public ComponenteValor Build() {
			return this;
		}

		public ComponenteValor SetOriginal(ValorComponente original) {
			this.Original = original;
			return this;
		}

		public ComponenteValor SetTroco(ValorComponente troco) {
			this.Troco = troco;
			return this;
		}

		public ComponenteValor SetAbatimento(ValorComponente abatimento) {
			this.Abatimento = abatimento;
			return this;
		}

		public ComponenteValor SetDesconto(ValorComponente desconto) {
			this.Desconto = desconto;
			return this;
		}

		public ComponenteValor SetJuros(ValorComponente juros) {
			this.Juros = juros;
			return this;
		}

		public ComponenteValor SetMulta(ValorComponente multa) {
			this.Multa = multa;
			return this;
		}
	}
}
