using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class RetornoPagamentoDarf {
		[DataMember(Name="codigoTransacao", EmitDefaultValue = false)]
		public string CodigoTransacao;
		[DataMember(Name="tipoDarf", EmitDefaultValue = false)]
		public string TipoDarf;
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public double Valor;
		[DataMember(Name="valorMulta", EmitDefaultValue = false)]
		public double ValorMulta;
		[DataMember(Name="valorJuros", EmitDefaultValue = false)]
		public double ValorJuros;
		[DataMember(Name="valorTotal", EmitDefaultValue = false)]
		public double ValorTotal;
		[DataMember(Name="tipo", EmitDefaultValue = false)]
		public string Tipo;
		[DataMember(Name="periodoApuracao", EmitDefaultValue = false)]
		public string PeriodoApuracao;
		[DataMember(Name="dataPagamento", EmitDefaultValue = false)]
		public string DataPagamento;
		[DataMember(Name="referencia", EmitDefaultValue = false)]
		public string Referencia;
		[DataMember(Name="dataVencimento", EmitDefaultValue = false)]
		public string DataVencimento;
		[DataMember(Name="codigoReceita", EmitDefaultValue = false)]
		public string CodigoReceita;
		// 
		//  REALIZADO AGENDADO AGUARDANDO_APROVACAO APROVADO AGENDADO_REALIZADO
		//      
		[DataMember(Name="statusPagamento", EmitDefaultValue = false)]
		public string StatusPagamento;
		[DataMember(Name="dataInclusao", EmitDefaultValue = false)]
		public string DataInclusao;

		public static RetornoPagamentoDarf Builder() {
			return new RetornoPagamentoDarf();
		}

		public RetornoPagamentoDarf Build() {
			return this;
		}

		public RetornoPagamentoDarf SetCodigoTransacao(string codigoTransacao) {
			this.CodigoTransacao = codigoTransacao;
			return this;
		}

		public RetornoPagamentoDarf SetTipoDarf(string tipoDarf) {
			this.TipoDarf = tipoDarf;
			return this;
		}

		public RetornoPagamentoDarf SetValor(double valor) {
			this.Valor = valor;
			return this;
		}

		public RetornoPagamentoDarf SetValorMulta(double valorMulta) {
			this.ValorMulta = valorMulta;
			return this;
		}

		public RetornoPagamentoDarf SetValorJuros(double valorJuros) {
			this.ValorJuros = valorJuros;
			return this;
		}

		public RetornoPagamentoDarf SetValorTotal(double valorTotal) {
			this.ValorTotal = valorTotal;
			return this;
		}

		public RetornoPagamentoDarf SetTipo(string tipo) {
			this.Tipo = tipo;
			return this;
		}

		public RetornoPagamentoDarf SetPeriodoApuracao(string periodoApuracao) {
			this.PeriodoApuracao = periodoApuracao;
			return this;
		}

		public RetornoPagamentoDarf SetDataPagamento(string dataPagamento) {
			this.DataPagamento = dataPagamento;
			return this;
		}

		public RetornoPagamentoDarf SetReferencia(string referencia) {
			this.Referencia = referencia;
			return this;
		}

		public RetornoPagamentoDarf SetDataVencimento(string dataVencimento) {
			this.DataVencimento = dataVencimento;
			return this;
		}

		public RetornoPagamentoDarf SetCodigoReceita(string codigoReceita) {
			this.CodigoReceita = codigoReceita;
			return this;
		}

		public RetornoPagamentoDarf SetStatusPagamento(string statusPagamento) {
			this.StatusPagamento = statusPagamento;
			return this;
		}

		public RetornoPagamentoDarf SetDataInclusao(string dataInclusao) {
			this.DataInclusao = dataInclusao;
			return this;
		}
	}
}
