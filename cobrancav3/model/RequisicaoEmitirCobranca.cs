using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class RequisicaoEmitirCobranca {
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
		[DataMember(Name="desconto", EmitDefaultValue = false)]
		public Desconto Desconto;
		[DataMember(Name="multa", EmitDefaultValue = false)]
		public Multa Multa;
		[DataMember(Name="mora", EmitDefaultValue = false)]
		public Mora Mora;
		[DataMember(Name="mensagem", EmitDefaultValue = false)]
		public Mensagem Mensagem;
		[DataMember(Name="beneficiarioFinal", EmitDefaultValue = false)]
		public Pessoa BeneficiarioFinal;

		public static RequisicaoEmitirCobranca Builder() {
			return new RequisicaoEmitirCobranca();
		}

		public RequisicaoEmitirCobranca Build() {
			return this;
		}

		public RequisicaoEmitirCobranca SetSeuNumero(string seuNumero) {
			this.SeuNumero = seuNumero;
			return this;
		}

		public RequisicaoEmitirCobranca SetValorNominal(double valorNominal) {
			this.ValorNominal = valorNominal;
			return this;
		}

		public RequisicaoEmitirCobranca SetDataVencimento(string dataVencimento) {
			this.DataVencimento = dataVencimento;
			return this;
		}

		public RequisicaoEmitirCobranca SetNumDiasAgenda(int numDiasAgenda) {
			this.NumDiasAgenda = numDiasAgenda;
			return this;
		}

		public RequisicaoEmitirCobranca SetPagador(Pessoa pagador) {
			this.Pagador = pagador;
			return this;
		}

		public RequisicaoEmitirCobranca SetDesconto(Desconto desconto) {
			this.Desconto = desconto;
			return this;
		}

		public RequisicaoEmitirCobranca SetMulta(Multa multa) {
			this.Multa = multa;
			return this;
		}

		public RequisicaoEmitirCobranca SetMora(Mora mora) {
			this.Mora = mora;
			return this;
		}

		public RequisicaoEmitirCobranca SetMensagem(Mensagem mensagem) {
			this.Mensagem = mensagem;
			return this;
		}

		public RequisicaoEmitirCobranca SetBeneficiarioFinal(Pessoa beneficiarioFinal) {
			this.BeneficiarioFinal = beneficiarioFinal;
			return this;
		}
	}
}
