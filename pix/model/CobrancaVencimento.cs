using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class CobrancaVencimento {
		[DataMember(Name="chave", EmitDefaultValue = false)]
		public string Chave;
		[DataMember(Name="solicitacaoPagador", EmitDefaultValue = false)]
		public string SolicitacaoPagador;
		[DataMember(Name="infoAdicionais", EmitDefaultValue = false)]
		public List<InfoAdicional> InfoAdicionais;
		[DataMember(Name="devedor", EmitDefaultValue = false)]
		public Devedor Devedor;
		[DataMember(Name="loc", EmitDefaultValue = false)]
		public Location Loc;
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public CobVValor Valor;
		[DataMember(Name="calendario", EmitDefaultValue = false)]
		public CalendarioCobV Calendario;
		[DataMember(Name="txid", EmitDefaultValue = false)]
		public string Txid;

		public static CobrancaVencimento Builder() {
			return new CobrancaVencimento();
		}

		public CobrancaVencimento Build() {
			return this;
		}

		public CobrancaVencimento SetChave(string chave) {
			this.Chave = chave;
			return this;
		}

		public CobrancaVencimento SetSolicitacaoPagador(string solicitacaoPagador) {
			this.SolicitacaoPagador = solicitacaoPagador;
			return this;
		}

		public CobrancaVencimento SetInfoAdicionais(List<InfoAdicional> infoAdicionais) {
			this.InfoAdicionais = infoAdicionais;
			return this;
		}

		public CobrancaVencimento SetDevedor(Devedor devedor) {
			this.Devedor = devedor;
			return this;
		}

		public CobrancaVencimento SetLoc(Location loc) {
			this.Loc = loc;
			return this;
		}

		public CobrancaVencimento SetValor(CobVValor valor) {
			this.Valor = valor;
			return this;
		}

		public CobrancaVencimento SetCalendario(CalendarioCobV calendario) {
			this.Calendario = calendario;
			return this;
		}

		public CobrancaVencimento SetTxid(string txid) {
			this.Txid = txid;
			return this;
		}
	}
}
