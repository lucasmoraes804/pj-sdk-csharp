using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class FiltroBaseRecuperarCobrancas {
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
		[DataMember(Name="pessoaPagadora", EmitDefaultValue = false)]
		public string PessoaPagadora;
		// 
		//  Campo para informar o cpf ou cnpj do pagador
		//      
		[DataMember(Name="cpfCnpjPessoaPagadora", EmitDefaultValue = false)]
		public string CpfCnpjPessoaPagadora;
		// 
		//  Campo para informar o código seuNumero
		//      
		[DataMember(Name="seuNumero", EmitDefaultValue = false)]
		public string SeuNumero;
		// 
		//  Campo para informar o tipo da cobrança
		//      
		[DataMember(Name="tipoCobranca", EmitDefaultValue = false)]
		public string TipoCobranca;

		public static FiltroBaseRecuperarCobrancas Builder() {
			return new FiltroBaseRecuperarCobrancas();
		}

		public FiltroBaseRecuperarCobrancas Build() {
			return this;
		}

		public FiltroBaseRecuperarCobrancas SetFiltrarDataPor(string filtrarDataPor) {
			this.FiltrarDataPor = filtrarDataPor;
			return this;
		}

		public FiltroBaseRecuperarCobrancas SetSituacao(string situacao) {
			this.Situacao = situacao;
			return this;
		}

		public FiltroBaseRecuperarCobrancas SetPessoaPagadora(string pessoaPagadora) {
			this.PessoaPagadora = pessoaPagadora;
			return this;
		}

		public FiltroBaseRecuperarCobrancas SetCpfCnpjPessoaPagadora(string cpfCnpjPessoaPagadora) {
			this.CpfCnpjPessoaPagadora = cpfCnpjPessoaPagadora;
			return this;
		}

		public FiltroBaseRecuperarCobrancas SetSeuNumero(string seuNumero) {
			this.SeuNumero = seuNumero;
			return this;
		}

		public FiltroBaseRecuperarCobrancas SetTipoCobranca(string tipoCobranca) {
			this.TipoCobranca = tipoCobranca;
			return this;
		}
	}
}
