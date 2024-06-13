using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class Cobranca {
		[DataMember(Name="txid", EmitDefaultValue = false)]
		public string Txid;
		// 
		//  REQUERIDO
		//      
		[DataMember(Name="calendario", EmitDefaultValue = false)]
		public Calendario Calendario;
		[DataMember(Name="devedor", EmitDefaultValue = false)]
		public Devedor Devedor;
		// 
		//  Identificador da localização do payload.
		//      
		[DataMember(Name="loc", EmitDefaultValue = false)]
		public Location Loc;
		// 
		//  REQUERIDO
		//  valores monetários referentes à cobrança.
		//      
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public Valor Valor;
		// 
		//  REQUERIDO
		//  O campo chave determina a chave Pix do recebedor que será utilizada para a cobrança.
		//  Os tipos de chave podem ser: telefone, e-mail, cpf/cnpj ou EVP.
		//  O formato das chaves pode ser encontrado na seção "Formatação das chaves do DICT no BR Code" do Manual de Padrões para iniciação do Pix.
		//      
		[DataMember(Name="chave", EmitDefaultValue = false)]
		public string Chave;
		// 
		//  O campo solicitacaoPagador determina um texto a ser apresentado ao pagador para que ele possa digitar uma informação correlata,
		//  em formato livre, a ser enviada ao recebedor. Esse texto está limitado a 140 caracteres.
		//      
		[DataMember(Name="solicitacaoPagador", EmitDefaultValue = false)]
		public string SolicitacaoPagador;
		// 
		//  Cada respectiva informação adicional contida na lista (nome e valor) deve ser apresentada ao pagador.
		//      
		[DataMember(Name="infoAdicionais", EmitDefaultValue = false)]
		public List<InfoAdicional> InfoAdicionais;

		public static Cobranca Builder() {
			return new Cobranca();
		}

		public Cobranca Build() {
			return this;
		}

		public Cobranca SetTxid(string txid) {
			this.Txid = txid;
			return this;
		}

		public Cobranca SetCalendario(Calendario calendario) {
			this.Calendario = calendario;
			return this;
		}

		public Cobranca SetDevedor(Devedor devedor) {
			this.Devedor = devedor;
			return this;
		}

		public Cobranca SetLoc(Location loc) {
			this.Loc = loc;
			return this;
		}

		public Cobranca SetValor(Valor valor) {
			this.Valor = valor;
			return this;
		}

		public Cobranca SetChave(string chave) {
			this.Chave = chave;
			return this;
		}

		public Cobranca SetSolicitacaoPagador(string solicitacaoPagador) {
			this.SolicitacaoPagador = solicitacaoPagador;
			return this;
		}

		public Cobranca SetInfoAdicionais(List<InfoAdicional> infoAdicionais) {
			this.InfoAdicionais = infoAdicionais;
			return this;
		}
	}
}
