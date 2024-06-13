using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class BoletoDetalhado : Boleto {
		// 
		//  Nome do beneficiário.
		//      
		[DataMember(Name="nomeBeneficiario", EmitDefaultValue = false)]
		public string NomeBeneficiario;
		// 
		//  CNPJ do beneficiário.
		//      
		[DataMember(Name="cnpjCpfBeneficiario", EmitDefaultValue = false)]
		public string CnpjCpfBeneficiario;
		// 
		//  tipoPessoaBeneficiario
		//      
		[DataMember(Name="tipoPessoaBeneficiario", EmitDefaultValue = false)]
		public string TipoPessoaBeneficiario;
		// 
		//  Conta corrente do boleto emitido
		//      
		[DataMember(Name="contaCorrente", EmitDefaultValue = false)]
		public string ContaCorrente;
		// 
		//  Identificador único do boleto emitido.
		//      
		[DataMember(Name="nossoNumero", EmitDefaultValue = false)]
		public string NossoNumero;
		// 
		//  Situacao do boleto.
		//      
		[DataMember(Name="situacao", EmitDefaultValue = false)]
		public string Situacao;
		// 
		//  Data referente à situação do boleto.
		//  Formato aceito: YYYY-MM-DD
		//      
		[DataMember(Name="dataHoraSituacao", EmitDefaultValue = false)]
		public string DataHoraSituacao;
		// 
		//  Data referente à emissão do boleto.
		//  Formato aceito: YYYY-MM-DD
		//      
		[DataMember(Name="dataEmissao", EmitDefaultValue = false)]
		public string DataEmissao;
		// 
		//  Data referente ao limite de pagamento do boleto.
		//  Formato aceito: YYYY-MM-DD
		//      
		[DataMember(Name="dataLimite", EmitDefaultValue = false)]
		public string DataLimite;
		// 
		//  Codigo de Espécie do boleto.
		//      
		[DataMember(Name="codigoEspecie", EmitDefaultValue = false)]
		public string CodigoEspecie;
		// 
		//  Codigo de barras do boleto.
		//      
		[DataMember(Name="codigoBarras", EmitDefaultValue = false)]
		public string CodigoBarras;
		// 
		//  Linha digitável do boleto.
		//      
		[DataMember(Name="linhaDigitavel", EmitDefaultValue = false)]
		public string LinhaDigitavel;
		// 
		//  Origem da requisição que gerou o boleto.
		//      
		[DataMember(Name="origem", EmitDefaultValue = false)]
		public string Origem;
		// 
		//  Motivo do cancelamento.
		//      
		[DataMember(Name="motivoCancelamento", EmitDefaultValue = false)]
		public string MotivoCancelamento;

		public static BoletoDetalhado Builder() {
			return new BoletoDetalhado();
		}

		public BoletoDetalhado Build() {
			return this;
		}

		public BoletoDetalhado SetNomeBeneficiario(string nomeBeneficiario) {
			this.NomeBeneficiario = nomeBeneficiario;
			return this;
		}

		public BoletoDetalhado SetCnpjCpfBeneficiario(string cnpjCpfBeneficiario) {
			this.CnpjCpfBeneficiario = cnpjCpfBeneficiario;
			return this;
		}

		public BoletoDetalhado SetTipoPessoaBeneficiario(string tipoPessoaBeneficiario) {
			this.TipoPessoaBeneficiario = tipoPessoaBeneficiario;
			return this;
		}

		public BoletoDetalhado SetContaCorrente(string contaCorrente) {
			this.ContaCorrente = contaCorrente;
			return this;
		}

		public BoletoDetalhado SetNossoNumero(string nossoNumero) {
			this.NossoNumero = nossoNumero;
			return this;
		}

		public BoletoDetalhado SetSituacao(string situacao) {
			this.Situacao = situacao;
			return this;
		}

		public BoletoDetalhado SetDataHoraSituacao(string dataHoraSituacao) {
			this.DataHoraSituacao = dataHoraSituacao;
			return this;
		}

		public BoletoDetalhado SetDataEmissao(string dataEmissao) {
			this.DataEmissao = dataEmissao;
			return this;
		}

		public BoletoDetalhado SetDataLimite(string dataLimite) {
			this.DataLimite = dataLimite;
			return this;
		}

		public BoletoDetalhado SetCodigoEspecie(string codigoEspecie) {
			this.CodigoEspecie = codigoEspecie;
			return this;
		}

		public BoletoDetalhado SetCodigoBarras(string codigoBarras) {
			this.CodigoBarras = codigoBarras;
			return this;
		}

		public BoletoDetalhado SetLinhaDigitavel(string linhaDigitavel) {
			this.LinhaDigitavel = linhaDigitavel;
			return this;
		}

		public BoletoDetalhado SetOrigem(string origem) {
			this.Origem = origem;
			return this;
		}

		public BoletoDetalhado SetMotivoCancelamento(string motivoCancelamento) {
			this.MotivoCancelamento = motivoCancelamento;
			return this;
		}

		public BoletoDetalhado SetSeuNumero(string seuNumero) {
			this.SeuNumero = seuNumero;
			return this;
		}

		public BoletoDetalhado SetValorNominal(double valorNominal) {
			this.ValorNominal = valorNominal;
			return this;
		}

		public BoletoDetalhado SetValorAbatimento(double valorAbatimento) {
			this.ValorAbatimento = valorAbatimento;
			return this;
		}

		public BoletoDetalhado SetDataVencimento(string dataVencimento) {
			this.DataVencimento = dataVencimento;
			return this;
		}

		public BoletoDetalhado SetNumDiasAgenda(int numDiasAgenda) {
			this.NumDiasAgenda = numDiasAgenda;
			return this;
		}

		public BoletoDetalhado SetPagador(Pessoa pagador) {
			this.Pagador = pagador;
			return this;
		}

		public BoletoDetalhado SetMensagem(Mensagem mensagem) {
			this.Mensagem = mensagem;
			return this;
		}

		public BoletoDetalhado SetDesconto1(Desconto desconto1) {
			this.Desconto1 = desconto1;
			return this;
		}

		public BoletoDetalhado SetDesconto2(Desconto desconto2) {
			this.Desconto2 = desconto2;
			return this;
		}

		public BoletoDetalhado SetDesconto3(Desconto desconto3) {
			this.Desconto3 = desconto3;
			return this;
		}

		public BoletoDetalhado SetMulta(Multa multa) {
			this.Multa = multa;
			return this;
		}

		public BoletoDetalhado SetMora(Mora mora) {
			this.Mora = mora;
			return this;
		}

		public BoletoDetalhado SetBeneficiarioFinal(Pessoa beneficiarioFinal) {
			this.BeneficiarioFinal = beneficiarioFinal;
			return this;
		}
	}
}
