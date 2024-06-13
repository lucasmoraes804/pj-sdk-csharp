using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class RespostaIncluirPix {
		[DataMember(Name="tipoRetorno", EmitDefaultValue = false)]
		public string TipoRetorno;
		// 
		//  Id transação do pagamento Pix
		//      
		[DataMember(Name="endToEndId", EmitDefaultValue = false)]
		public string EndToEndId;
		// 
		//  Id da tabela pagamento ou devolução Pix para aprovação
		//      
		[DataMember(Name="codigoAgendamento", EmitDefaultValue = false)]
		public string CodigoAgendamento;
		[DataMember(Name="dataPagamento", EmitDefaultValue = false)]
		public string DataPagamento;
		[DataMember(Name="dataOperacao", EmitDefaultValue = false)]
		public string DataOperacao;
		[DataMember(Name="idAprovacao", EmitDefaultValue = false)]
		public string IdAprovacao;

		public static RespostaIncluirPix Builder() {
			return new RespostaIncluirPix();
		}

		public RespostaIncluirPix Build() {
			return this;
		}

		public RespostaIncluirPix SetTipoRetorno(string tipoRetorno) {
			this.TipoRetorno = tipoRetorno;
			return this;
		}

		public RespostaIncluirPix SetEndToEndId(string endToEndId) {
			this.EndToEndId = endToEndId;
			return this;
		}

		public RespostaIncluirPix SetCodigoAgendamento(string codigoAgendamento) {
			this.CodigoAgendamento = codigoAgendamento;
			return this;
		}

		public RespostaIncluirPix SetDataPagamento(string dataPagamento) {
			this.DataPagamento = dataPagamento;
			return this;
		}

		public RespostaIncluirPix SetDataOperacao(string dataOperacao) {
			this.DataOperacao = dataOperacao;
			return this;
		}

		public RespostaIncluirPix SetIdAprovacao(string idAprovacao) {
			this.IdAprovacao = idAprovacao;
			return this;
		}
	}
}
