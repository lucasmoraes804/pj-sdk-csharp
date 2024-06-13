using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class CobrancaDetalhada : Cobranca {
		[DataMember(Name="location", EmitDefaultValue = false)]
		public string Location;
		// 
		//  ATIVA CONCLUIDA REMOVIDA_PELO_USUARIO_RECEBEDOR REMOVIDA_PELO_PSP
		//      
		[DataMember(Name="status", EmitDefaultValue = false)]
		public string Status;
		// 
		//  Este campo retorna o valor do Pix Copia e Cola correspondente à cobrança. Trata-se da sequência de caracteres que representa o BR Code.
		//      
		[DataMember(Name="pixCopiaECola", EmitDefaultValue = false)]
		public string PixCopiaECola;
		// 
		//  Denota a revisão da cobrança. Sempre começa em zero. Sempre varia em acréscimos de 1.
		//  O incremento em uma cobrança deve ocorrer sempre que um objeto da cobrança em questão for alterado.
		//  O campo loc é uma exceção a esta regra.
		//  Se em uma determinada alteração em uma cobrança, o único campo alterado for o campo loc,
		//  então esta operação não incrementa a revisão da cobrança.
		//      
		[DataMember(Name="revisao", EmitDefaultValue = false)]
		public int Revisao;
		[DataMember(Name="pix", EmitDefaultValue = false)]
		public List<Pix> Pix;

		public static CobrancaDetalhada Builder() {
			return new CobrancaDetalhada();
		}

		public CobrancaDetalhada Build() {
			return this;
		}

		public CobrancaDetalhada SetLocation(string location) {
			this.Location = location;
			return this;
		}

		public CobrancaDetalhada SetStatus(string status) {
			this.Status = status;
			return this;
		}

		public CobrancaDetalhada SetPixCopiaECola(string pixCopiaECola) {
			this.PixCopiaECola = pixCopiaECola;
			return this;
		}

		public CobrancaDetalhada SetRevisao(int revisao) {
			this.Revisao = revisao;
			return this;
		}

		public CobrancaDetalhada SetPix(List<Pix> pix) {
			this.Pix = pix;
			return this;
		}

		public CobrancaDetalhada SetTxid(string txid) {
			this.Txid = txid;
			return this;
		}

		public CobrancaDetalhada SetCalendario(Calendario calendario) {
			this.Calendario = calendario;
			return this;
		}

		public CobrancaDetalhada SetDevedor(Devedor devedor) {
			this.Devedor = devedor;
			return this;
		}

		public CobrancaDetalhada SetLoc(Location loc) {
			this.Loc = loc;
			return this;
		}

		public CobrancaDetalhada SetValor(Valor valor) {
			this.Valor = valor;
			return this;
		}

		public CobrancaDetalhada SetChave(string chave) {
			this.Chave = chave;
			return this;
		}

		public CobrancaDetalhada SetSolicitacaoPagador(string solicitacaoPagador) {
			this.SolicitacaoPagador = solicitacaoPagador;
			return this;
		}

		public CobrancaDetalhada SetInfoAdicionais(List<InfoAdicional> infoAdicionais) {
			this.InfoAdicionais = infoAdicionais;
			return this;
		}
	}
}
