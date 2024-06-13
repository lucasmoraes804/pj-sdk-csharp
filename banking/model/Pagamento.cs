using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class Pagamento {
		[DataMember(Name="codigoTransacao", EmitDefaultValue = false)]
		public string CodigoTransacao;
		[DataMember(Name="codigoBarra", EmitDefaultValue = false)]
		public string CodigoBarra;
		[DataMember(Name="tipo", EmitDefaultValue = false)]
		public string Tipo;
		[DataMember(Name="dataVencimentoDigitada", EmitDefaultValue = false)]
		public string DataVencimentoDigitada;
		[DataMember(Name="dataVencimentoTitulo", EmitDefaultValue = false)]
		public string DataVencimentoTitulo;
		[DataMember(Name="dataInclusao", EmitDefaultValue = false)]
		public string DataInclusao;
		[DataMember(Name="dataPagamento", EmitDefaultValue = false)]
		public string DataPagamento;
		[DataMember(Name="valorPago", EmitDefaultValue = false)]
		public double ValorPago;
		[DataMember(Name="valorNominal", EmitDefaultValue = false)]
		public double ValorNominal;
		// 
		//  REALIZADO AGENDADO AGUARDANDO_APROVACAO APROVADO AGENDADO_REALIZADO
		//      
		[DataMember(Name="statusPagamento", EmitDefaultValue = false)]
		public string StatusPagamento;
		[DataMember(Name="aprovacoesNecessarias", EmitDefaultValue = false)]
		public int AprovacoesNecessarias;
		[DataMember(Name="aprovacoesRealizadas", EmitDefaultValue = false)]
		public int AprovacoesRealizadas;
		[DataMember(Name="cpfCnpjBeneficiario", EmitDefaultValue = false)]
		public string CpfCnpjBeneficiario;
		[DataMember(Name="nomeBeneficiario", EmitDefaultValue = false)]
		public string NomeBeneficiario;
		[DataMember(Name="contaCorrente", EmitDefaultValue = false)]
		public string ContaCorrente;

		public static Pagamento Builder() {
			return new Pagamento();
		}

		public Pagamento Build() {
			return this;
		}

		public Pagamento SetCodigoTransacao(string codigoTransacao) {
			this.CodigoTransacao = codigoTransacao;
			return this;
		}

		public Pagamento SetCodigoBarra(string codigoBarra) {
			this.CodigoBarra = codigoBarra;
			return this;
		}

		public Pagamento SetTipo(string tipo) {
			this.Tipo = tipo;
			return this;
		}

		public Pagamento SetDataVencimentoDigitada(string dataVencimentoDigitada) {
			this.DataVencimentoDigitada = dataVencimentoDigitada;
			return this;
		}

		public Pagamento SetDataVencimentoTitulo(string dataVencimentoTitulo) {
			this.DataVencimentoTitulo = dataVencimentoTitulo;
			return this;
		}

		public Pagamento SetDataInclusao(string dataInclusao) {
			this.DataInclusao = dataInclusao;
			return this;
		}

		public Pagamento SetDataPagamento(string dataPagamento) {
			this.DataPagamento = dataPagamento;
			return this;
		}

		public Pagamento SetValorPago(double valorPago) {
			this.ValorPago = valorPago;
			return this;
		}

		public Pagamento SetValorNominal(double valorNominal) {
			this.ValorNominal = valorNominal;
			return this;
		}

		public Pagamento SetStatusPagamento(string statusPagamento) {
			this.StatusPagamento = statusPagamento;
			return this;
		}

		public Pagamento SetAprovacoesNecessarias(int aprovacoesNecessarias) {
			this.AprovacoesNecessarias = aprovacoesNecessarias;
			return this;
		}

		public Pagamento SetAprovacoesRealizadas(int aprovacoesRealizadas) {
			this.AprovacoesRealizadas = aprovacoesRealizadas;
			return this;
		}

		public Pagamento SetCpfCnpjBeneficiario(string cpfCnpjBeneficiario) {
			this.CpfCnpjBeneficiario = cpfCnpjBeneficiario;
			return this;
		}

		public Pagamento SetNomeBeneficiario(string nomeBeneficiario) {
			this.NomeBeneficiario = nomeBeneficiario;
			return this;
		}

		public Pagamento SetContaCorrente(string contaCorrente) {
			this.ContaCorrente = contaCorrente;
			return this;
		}
	}
}
