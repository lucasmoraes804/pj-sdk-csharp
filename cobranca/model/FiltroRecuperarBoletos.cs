using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class FiltroRecuperarBoletos : FiltroBaseRecuperarBoletos {
		// 
		//  Filtro pelo campo nossoNumero da cobrança
		//      
		[DataMember(Name="nossoNumero", EmitDefaultValue = false)]
		public string NossoNumero;

		public static FiltroRecuperarBoletos Builder() {
			return new FiltroRecuperarBoletos();
		}

		public FiltroRecuperarBoletos Build() {
			return this;
		}

		public FiltroRecuperarBoletos SetNossoNumero(string nossoNumero) {
			this.NossoNumero = nossoNumero;
			return this;
		}

		public FiltroRecuperarBoletos SetFiltrarDataPor(string filtrarDataPor) {
			this.FiltrarDataPor = filtrarDataPor;
			return this;
		}

		public FiltroRecuperarBoletos SetSituacao(string situacao) {
			this.Situacao = situacao;
			return this;
		}

		public FiltroRecuperarBoletos SetNome(string nome) {
			this.Nome = nome;
			return this;
		}

		public FiltroRecuperarBoletos SetEmail(string email) {
			this.Email = email;
			return this;
		}

		public FiltroRecuperarBoletos SetCpfCnpj(string cpfCnpj) {
			this.CpfCnpj = cpfCnpj;
			return this;
		}
	}
}
