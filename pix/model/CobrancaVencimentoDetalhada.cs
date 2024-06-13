using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class CobrancaVencimentoDetalhada : CobrancaVencimento {
		[DataMember(Name="pixCopiaECola", EmitDefaultValue = false)]
		public string PixCopiaECola;
		[DataMember(Name="recebedor", EmitDefaultValue = false)]
		public Recebedor Recebedor;
		[DataMember(Name="status", EmitDefaultValue = false)]
		public string Status;
		[DataMember(Name="revisao", EmitDefaultValue = false)]
		public int Revisao;
		[DataMember(Name="pix", EmitDefaultValue = false)]
		public List<Pix> Pix;

		public static CobrancaVencimentoDetalhada Builder() {
			return new CobrancaVencimentoDetalhada();
		}

		public CobrancaVencimentoDetalhada Build() {
			return this;
		}

		public CobrancaVencimentoDetalhada SetPixCopiaECola(string pixCopiaECola) {
			this.PixCopiaECola = pixCopiaECola;
			return this;
		}

		public CobrancaVencimentoDetalhada SetRecebedor(Recebedor recebedor) {
			this.Recebedor = recebedor;
			return this;
		}

		public CobrancaVencimentoDetalhada SetStatus(string status) {
			this.Status = status;
			return this;
		}

		public CobrancaVencimentoDetalhada SetRevisao(int revisao) {
			this.Revisao = revisao;
			return this;
		}

		public CobrancaVencimentoDetalhada SetPix(List<Pix> pix) {
			this.Pix = pix;
			return this;
		}

		public CobrancaVencimentoDetalhada SetChave(string chave) {
			this.Chave = chave;
			return this;
		}

		public CobrancaVencimentoDetalhada SetSolicitacaoPagador(string solicitacaoPagador) {
			this.SolicitacaoPagador = solicitacaoPagador;
			return this;
		}

		public CobrancaVencimentoDetalhada SetInfoAdicionais(List<InfoAdicional> infoAdicionais) {
			this.InfoAdicionais = infoAdicionais;
			return this;
		}

		public CobrancaVencimentoDetalhada SetDevedor(Devedor devedor) {
			this.Devedor = devedor;
			return this;
		}

		public CobrancaVencimentoDetalhada SetLoc(Location loc) {
			this.Loc = loc;
			return this;
		}

		public CobrancaVencimentoDetalhada SetValor(CobVValor valor) {
			this.Valor = valor;
			return this;
		}

		public CobrancaVencimentoDetalhada SetCalendario(CalendarioCobV calendario) {
			this.Calendario = calendario;
			return this;
		}

		public CobrancaVencimentoDetalhada SetTxid(string txid) {
			this.Txid = txid;
			return this;
		}
	}
}
