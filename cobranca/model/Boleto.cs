using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class Boleto {
		// 
		//  REQUERIDO
		//  <p><Campo Seu Número do título</p>
		//      
		[DataMember(Name="seuNumero", EmitDefaultValue = false)]
		public string SeuNumero;
		// 
		//  REQUERIDO
		//  <p>Valor Nominal do título</p>
		//  <p>O valor nominal deve ser maior ou igual à R$2.50</p>
		//      
		[DataMember(Name="valorNominal", EmitDefaultValue = false)]
		public double ValorNominal;
		// 
		//  Valor de abatimento do título, expresso na mesma moeda do Valor Nominal
		//      
		[DataMember(Name="valorAbatimento", EmitDefaultValue = false)]
		public double ValorAbatimento;
		// 
		//  REQUERIDO
		//  <p>Data de vencimento do título</p>
		//  <p>Formato aceito: YYYY-MM-DD</p>
		//      
		[DataMember(Name="dataVencimento", EmitDefaultValue = false)]
		public string DataVencimento;
		// 
		//  REQUERIDO
		//  REQUERIDO-ZERO (enviar mesmo se o valor for 0)
		//  <p>Número de dias corridos após o vencimento para o cancelamento efetivo automático do boleto. (de 0 até 60)</p>
		//      
		[DataMember(Name="numDiasAgenda", EmitDefaultValue = true)]
		public int NumDiasAgenda;
		// 
		//  REQUERIDO
		//      
		[DataMember(Name="pagador", EmitDefaultValue = false)]
		public Pessoa Pagador;
		[DataMember(Name="mensagem", EmitDefaultValue = false)]
		public Mensagem Mensagem;
		[DataMember(Name="desconto1", EmitDefaultValue = false)]
		public Desconto Desconto1;
		[DataMember(Name="desconto2", EmitDefaultValue = false)]
		public Desconto Desconto2;
		[DataMember(Name="desconto3", EmitDefaultValue = false)]
		public Desconto Desconto3;
		[DataMember(Name="multa", EmitDefaultValue = false)]
		public Multa Multa;
		[DataMember(Name="mora", EmitDefaultValue = false)]
		public Mora Mora;
		[DataMember(Name="beneficiarioFinal", EmitDefaultValue = false)]
		public Pessoa BeneficiarioFinal;

		public static Boleto Builder() {
			return new Boleto();
		}

		public Boleto Build() {
			return this;
		}

		public Boleto SetSeuNumero(string seuNumero) {
			this.SeuNumero = seuNumero;
			return this;
		}

		public Boleto SetValorNominal(double valorNominal) {
			this.ValorNominal = valorNominal;
			return this;
		}

		public Boleto SetValorAbatimento(double valorAbatimento) {
			this.ValorAbatimento = valorAbatimento;
			return this;
		}

		public Boleto SetDataVencimento(string dataVencimento) {
			this.DataVencimento = dataVencimento;
			return this;
		}

		public Boleto SetNumDiasAgenda(int numDiasAgenda) {
			this.NumDiasAgenda = numDiasAgenda;
			return this;
		}

		public Boleto SetPagador(Pessoa pagador) {
			this.Pagador = pagador;
			return this;
		}

		public Boleto SetMensagem(Mensagem mensagem) {
			this.Mensagem = mensagem;
			return this;
		}

		public Boleto SetDesconto1(Desconto desconto1) {
			this.Desconto1 = desconto1;
			return this;
		}

		public Boleto SetDesconto2(Desconto desconto2) {
			this.Desconto2 = desconto2;
			return this;
		}

		public Boleto SetDesconto3(Desconto desconto3) {
			this.Desconto3 = desconto3;
			return this;
		}

		public Boleto SetMulta(Multa multa) {
			this.Multa = multa;
			return this;
		}

		public Boleto SetMora(Mora mora) {
			this.Mora = mora;
			return this;
		}

		public Boleto SetBeneficiarioFinal(Pessoa beneficiarioFinal) {
			this.BeneficiarioFinal = beneficiarioFinal;
			return this;
		}
	}
}
