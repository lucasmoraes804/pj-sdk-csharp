using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class Payload {
		[DataMember(Name="codigoSolicitacao", EmitDefaultValue = false)]
		public string CodigoSolicitacao;
		[DataMember(Name="seuNumero", EmitDefaultValue = false)]
		public string SeuNumero;
		[DataMember(Name="situacao", EmitDefaultValue = false)]
		public string Situacao;
		[DataMember(Name="dataHoraSituacao", EmitDefaultValue = false)]
		public string DataHoraSituacao;
		[DataMember(Name="valorTotalRecebido", EmitDefaultValue = false)]
		public string ValorTotalRecebido;
		[DataMember(Name="origemRecebimento", EmitDefaultValue = false)]
		public string OrigemRecebimento;
		[DataMember(Name="nossoNumero", EmitDefaultValue = false)]
		public string NossoNumero;
		[DataMember(Name="codigoBarras", EmitDefaultValue = false)]
		public string CodigoBarras;
		[DataMember(Name="linhaDigitavel", EmitDefaultValue = false)]
		public string LinhaDigitavel;
		[DataMember(Name="txid", EmitDefaultValue = false)]
		public string Txid;
		[DataMember(Name="pixCopiaECola", EmitDefaultValue = false)]
		public string PixCopiaECola;

		public static Payload Builder() {
			return new Payload();
		}

		public Payload Build() {
			return this;
		}

		public Payload SetCodigoSolicitacao(string codigoSolicitacao) {
			this.CodigoSolicitacao = codigoSolicitacao;
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

		public Payload SetValorTotalRecebido(string valorTotalRecebido) {
			this.ValorTotalRecebido = valorTotalRecebido;
			return this;
		}

		public Payload SetOrigemRecebimento(string origemRecebimento) {
			this.OrigemRecebimento = origemRecebimento;
			return this;
		}

		public Payload SetNossoNumero(string nossoNumero) {
			this.NossoNumero = nossoNumero;
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

		public Payload SetTxid(string txid) {
			this.Txid = txid;
			return this;
		}

		public Payload SetPixCopiaECola(string pixCopiaECola) {
			this.PixCopiaECola = pixCopiaECola;
			return this;
		}
	}
}
