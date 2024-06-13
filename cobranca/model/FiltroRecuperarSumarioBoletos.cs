using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class FiltroRecuperarSumarioBoletos : FiltroBaseRecuperarBoletos {

		public static FiltroRecuperarSumarioBoletos Builder() {
			return new FiltroRecuperarSumarioBoletos();
		}

		public FiltroRecuperarSumarioBoletos Build() {
			return this;
		}

		public FiltroRecuperarSumarioBoletos SetFiltrarDataPor(string filtrarDataPor) {
			this.FiltrarDataPor = filtrarDataPor;
			return this;
		}

		public FiltroRecuperarSumarioBoletos SetSituacao(string situacao) {
			this.Situacao = situacao;
			return this;
		}

		public FiltroRecuperarSumarioBoletos SetNome(string nome) {
			this.Nome = nome;
			return this;
		}

		public FiltroRecuperarSumarioBoletos SetEmail(string email) {
			this.Email = email;
			return this;
		}

		public FiltroRecuperarSumarioBoletos SetCpfCnpj(string cpfCnpj) {
			this.CpfCnpj = cpfCnpj;
			return this;
		}
	}
}
