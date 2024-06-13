using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class FiltroBaseRecuperarBoletos {
		// 
		//  Caso o campo situacao seja:
		//  <ul>
		//      <li>EXPIRADO as datas corresponderão a data de expiração dos boletos;</li>
		//      <li>VENCIDO(default) as datas corresponderão a data de vencimento dos boletos;</li>
		//      <li>EMABERTO as datas corresponderão a data de emissão dos boletos;</li>
		//      <li>PAGO as datas corresponderão a data de pagamento dos boletos;</li>
		//      <li>CANCELADO as datas corresponderão a data de cancelamento dos boletos;</li>
		//  </ul>
		//      
		[DataMember(Name="filtrarDataPor", EmitDefaultValue = false)]
		public string FiltrarDataPor;
		// 
		//  Filtro pela situação da cobrança.
		//      
		[DataMember(Name="situacao", EmitDefaultValue = false)]
		public string Situacao;
		// 
		//  Filtro pelo nome do pagador
		//      
		[DataMember(Name="nome", EmitDefaultValue = false)]
		public string Nome;
		// 
		//  Filtro pelo email do pagador
		//      
		[DataMember(Name="email", EmitDefaultValue = false)]
		public string Email;
		// 
		//  Campo para informar o cpf ou cnpj do pagador
		//      
		[DataMember(Name="cpfCnpj", EmitDefaultValue = false)]
		public string CpfCnpj;

		public static FiltroBaseRecuperarBoletos Builder() {
			return new FiltroBaseRecuperarBoletos();
		}

		public FiltroBaseRecuperarBoletos Build() {
			return this;
		}

		public FiltroBaseRecuperarBoletos SetFiltrarDataPor(string filtrarDataPor) {
			this.FiltrarDataPor = filtrarDataPor;
			return this;
		}

		public FiltroBaseRecuperarBoletos SetSituacao(string situacao) {
			this.Situacao = situacao;
			return this;
		}

		public FiltroBaseRecuperarBoletos SetNome(string nome) {
			this.Nome = nome;
			return this;
		}

		public FiltroBaseRecuperarBoletos SetEmail(string email) {
			this.Email = email;
			return this;
		}

		public FiltroBaseRecuperarBoletos SetCpfCnpj(string cpfCnpj) {
			this.CpfCnpj = cpfCnpj;
			return this;
		}
	}
}
