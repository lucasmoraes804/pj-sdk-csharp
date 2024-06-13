using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class Payload {
		[DataMember(Name="nossoNumero", EmitDefaultValue = false)]
		public string NossoNumero;
		[DataMember(Name="seuNumero", EmitDefaultValue = false)]
		public string SeuNumero;
		[DataMember(Name="situacao", EmitDefaultValue = false)]
		public string Situacao;
		[DataMember(Name="dataHoraSituacao", EmitDefaultValue = false)]
		public string DataHoraSituacao;
		[DataMember(Name="valorTotalRecebimento", EmitDefaultValue = false)]
		public double ValorTotalRecebimento;
		[DataMember(Name="valorNominal", EmitDefaultValue = false)]
		public double ValorNominal;
		[DataMember(Name="codigoBarras", EmitDefaultValue = false)]
		public string CodigoBarras;
		[DataMember(Name="linhaDigitavel", EmitDefaultValue = false)]
		public string LinhaDigitavel;

		public static Payload Builder() {
			return new Payload();
		}

		public Payload Build() {
			return this;
		}

		public Payload SetNossoNumero(string nossoNumero) {
			this.NossoNumero = nossoNumero;
			return this;
		}

		public Payload SetSeuNumero(string seuNumero) {
			this.SeuNumero = seuNumero;
			return this;
		}

		public Payload SetSituacao(string situacao) {
			this.Situacao = situacao;
			return this;
		}

		public Payload SetDataHoraSituacao(string dataHoraSituacao) {
			this.DataHoraSituacao = dataHoraSituacao;
			return this;
		}

		public Payload SetValorTotalRecebimento(double valorTotalRecebimento) {
			this.ValorTotalRecebimento = valorTotalRecebimento;
			return this;
		}

		public Payload SetValorNominal(double valorNominal) {
			this.ValorNominal = valorNominal;
			return this;
		}

		public Payload SetCodigoBarras(string codigoBarras) {
			this.CodigoBarras = codigoBarras;
			return this;
		}

		public Payload SetLinhaDigitavel(string linhaDigitavel) {
			this.LinhaDigitavel = linhaDigitavel;
			return this;
		}
	}
}
