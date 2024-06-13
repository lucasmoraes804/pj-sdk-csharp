using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class Payload {
		[DataMember(Name="codigoSolicitacao", EmitDefaultValue = false)]
		public string CodigoSolicitacao;
		[DataMember(Name="dataHoraMovimento", EmitDefaultValue = false)]
		public string DataHoraMovimento;
		[DataMember(Name="dataHoraSolicitacao", EmitDefaultValue = false)]
		public string DataHoraSolicitacao;
		[DataMember(Name="endToEnd", EmitDefaultValue = false)]
		public string EndToEnd;
		[DataMember(Name="recebedor", EmitDefaultValue = false)]
		public Recebedor Recebedor;
		[DataMember(Name="status", EmitDefaultValue = false)]
		public string Status;
		[DataMember(Name="tipoMovimentacao", EmitDefaultValue = false)]
		public string TipoMovimentacao;
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public string Valor;

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

		public Payload SetDataHoraMovimento(string dataHoraMovimento) {
			this.DataHoraMovimento = dataHoraMovimento;
			return this;
		}

		public Payload SetDataHoraSolicitacao(string dataHoraSolicitacao) {
			this.DataHoraSolicitacao = dataHoraSolicitacao;
			return this;
		}

		public Payload SetEndToEnd(string endToEnd) {
			this.EndToEnd = endToEnd;
			return this;
		}

		public Payload SetRecebedor(Recebedor recebedor) {
			this.Recebedor = recebedor;
			return this;
		}

		public Payload SetStatus(string status) {
			this.Status = status;
			return this;
		}

		public Payload SetTipoMovimentacao(string tipoMovimentacao) {
			this.TipoMovimentacao = tipoMovimentacao;
			return this;
		}

		public Payload SetValor(string valor) {
			this.Valor = valor;
			return this;
		}
	}
}
