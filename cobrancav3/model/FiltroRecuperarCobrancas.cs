using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class FiltroRecuperarCobrancas : FiltroBaseRecuperarCobrancas {
		[DataMember(Name="pagina", EmitDefaultValue = false)]
		public int Pagina;
		[DataMember(Name="itensPorPagina", EmitDefaultValue = false)]
		public int ItensPorPagina;

		public static FiltroRecuperarCobrancas Builder() {
			return new FiltroRecuperarCobrancas();
		}

		public FiltroRecuperarCobrancas Build() {
			return this;
		}

		public FiltroRecuperarCobrancas SetPagina(int pagina) {
			this.Pagina = pagina;
			return this;
		}

		public FiltroRecuperarCobrancas SetItensPorPagina(int itensPorPagina) {
			this.ItensPorPagina = itensPorPagina;
			return this;
		}

		public FiltroRecuperarCobrancas SetFiltrarDataPor(string filtrarDataPor) {
			this.FiltrarDataPor = filtrarDataPor;
			return this;
		}

		public FiltroRecuperarCobrancas SetSituacao(string situacao) {
			this.Situacao = situacao;
			return this;
		}

		public FiltroRecuperarCobrancas SetPessoaPagadora(string pessoaPagadora) {
			this.PessoaPagadora = pessoaPagadora;
			return this;
		}

		public FiltroRecuperarCobrancas SetCpfCnpjPessoaPagadora(string cpfCnpjPessoaPagadora) {
			this.CpfCnpjPessoaPagadora = cpfCnpjPessoaPagadora;
			return this;
		}

		public FiltroRecuperarCobrancas SetSeuNumero(string seuNumero) {
			this.SeuNumero = seuNumero;
			return this;
		}

		public FiltroRecuperarCobrancas SetTipoCobranca(string tipoCobranca) {
			this.TipoCobranca = tipoCobranca;
			return this;
		}
	}
}
