using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class FiltroRecuperarSumarioCobrancas : FiltroBaseRecuperarCobrancas {

		public static FiltroRecuperarSumarioCobrancas Builder() {
			return new FiltroRecuperarSumarioCobrancas();
		}

		public FiltroRecuperarSumarioCobrancas Build() {
			return this;
		}

		public FiltroRecuperarSumarioCobrancas SetFiltrarDataPor(string filtrarDataPor) {
			this.FiltrarDataPor = filtrarDataPor;
			return this;
		}

		public FiltroRecuperarSumarioCobrancas SetSituacao(string situacao) {
			this.Situacao = situacao;
			return this;
		}

		public FiltroRecuperarSumarioCobrancas SetPessoaPagadora(string pessoaPagadora) {
			this.PessoaPagadora = pessoaPagadora;
			return this;
		}

		public FiltroRecuperarSumarioCobrancas SetCpfCnpjPessoaPagadora(string cpfCnpjPessoaPagadora) {
			this.CpfCnpjPessoaPagadora = cpfCnpjPessoaPagadora;
			return this;
		}

		public FiltroRecuperarSumarioCobrancas SetSeuNumero(string seuNumero) {
			this.SeuNumero = seuNumero;
			return this;
		}

		public FiltroRecuperarSumarioCobrancas SetTipoCobranca(string tipoCobranca) {
			this.TipoCobranca = tipoCobranca;
			return this;
		}
	}
}
