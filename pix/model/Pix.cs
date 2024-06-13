using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Pix {
		[DataMember(Name="endToEndId", EmitDefaultValue = false)]
		public string EndToEndId;
		[DataMember(Name="txid", EmitDefaultValue = false)]
		public string Txid;
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public string Valor;
		[DataMember(Name="chave", EmitDefaultValue = false)]
		public string Chave;
		[DataMember(Name="horario", EmitDefaultValue = false)]
		public string Horario;
		[DataMember(Name="infoPagador", EmitDefaultValue = false)]
		public string InfoPagador;
		[DataMember(Name="devolucoes", EmitDefaultValue = false)]
		public List<DevolucaoDetalhada> Devolucoes;

		public static Pix Builder() {
			return new Pix();
		}

		public Pix Build() {
			return this;
		}

		public Pix SetEndToEndId(string endToEndId) {
			this.EndToEndId = endToEndId;
			return this;
		}

		public Pix SetTxid(string txid) {
			this.Txid = txid;
			return this;
		}

		public Pix SetValor(string valor) {
			this.Valor = valor;
			return this;
		}

		public Pix SetChave(string chave) {
			this.Chave = chave;
			return this;
		}

		public Pix SetHorario(string horario) {
			this.Horario = horario;
			return this;
		}

		public Pix SetInfoPagador(string infoPagador) {
			this.InfoPagador = infoPagador;
			return this;
		}

		public Pix SetDevolucoes(List<DevolucaoDetalhada> devolucoes) {
			this.Devolucoes = devolucoes;
			return this;
		}
	}
}
