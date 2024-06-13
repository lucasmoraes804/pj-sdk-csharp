using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class ItemPayload {
		[DataMember(Name="chave", EmitDefaultValue = false)]
		public string Chave;
		[DataMember(Name="componentesValor", EmitDefaultValue = false)]
		public ComponenteValor ComponentesValor;
		[DataMember(Name="devolucoes", EmitDefaultValue = false)]
		public List<RequisicaoBodyDevolucao> Devolucoes;
		[DataMember(Name="endToEndId", EmitDefaultValue = false)]
		public string EndToEndId;
		[DataMember(Name="horario", EmitDefaultValue = false)]
		public string Horario;
		[DataMember(Name="infoPagador", EmitDefaultValue = false)]
		public string InfoPagador;
		[DataMember(Name="txid", EmitDefaultValue = false)]
		public string Txid;
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public string Valor;

		public static ItemPayload Builder() {
			return new ItemPayload();
		}

		public ItemPayload Build() {
			return this;
		}

		public ItemPayload SetChave(string chave) {
			this.Chave = chave;
			return this;
		}

		public ItemPayload SetComponentesValor(ComponenteValor componentesValor) {
			this.ComponentesValor = componentesValor;
			return this;
		}

		public ItemPayload SetDevolucoes(List<RequisicaoBodyDevolucao> devolucoes) {
			this.Devolucoes = devolucoes;
			return this;
		}

		public ItemPayload SetEndToEndId(string endToEndId) {
			this.EndToEndId = endToEndId;
			return this;
		}

		public ItemPayload SetHorario(string horario) {
			this.Horario = horario;
			return this;
		}

		public ItemPayload SetInfoPagador(string infoPagador) {
			this.InfoPagador = infoPagador;
			return this;
		}

		public ItemPayload SetTxid(string txid) {
			this.Txid = txid;
			return this;
		}

		public ItemPayload SetValor(string valor) {
			this.Valor = valor;
			return this;
		}
	}
}
