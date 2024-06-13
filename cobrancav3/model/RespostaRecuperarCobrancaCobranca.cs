using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.Cobrancav3Api {
	[DataContract]
	public class RespostaRecuperarCobrancaCobranca {
		[DataMember(Name="codigoSolicitacao", EmitDefaultValue = false)]
		public string CodigoSolicitacao;
		[DataMember(Name="seuNumero", EmitDefaultValue = false)]
		public string SeuNumero;
		[DataMember(Name="dataEmissao", EmitDefaultValue = false)]
		public string DataEmissao;
		[DataMember(Name="dataVencimento", EmitDefaultValue = false)]
		public string DataVencimento;
		[DataMember(Name="valorNominal", EmitDefaultValue = false)]
		public double ValorNominal;
		[DataMember(Name="tipoCobranca", EmitDefaultValue = false)]
		public string TipoCobranca;
		[DataMember(Name="situacao", EmitDefaultValue = false)]
		public string Situacao;
		[DataMember(Name="dataSituacao", EmitDefaultValue = false)]
		public string DataSituacao;
		[DataMember(Name="valorTotalRecebido", EmitDefaultValue = false)]
		public string ValorTotalRecebido;
		[DataMember(Name="origemRecebimento", EmitDefaultValue = false)]
		public string OrigemRecebimento;
		[DataMember(Name="motivoCancelamento", EmitDefaultValue = false)]
		public string MotivoCancelamento;
		[DataMember(Name="arquivada", EmitDefaultValue = false)]
		public bool Arquivada;
		[DataMember(Name="descontos", EmitDefaultValue = false)]
		public List<Desconto> Descontos;
		[DataMember(Name="multa", EmitDefaultValue = false)]
		public Multa Multa;
		[DataMember(Name="mora", EmitDefaultValue = false)]
		public Mora Mora;
		[DataMember(Name="pagador", EmitDefaultValue = false)]
		public Pessoa Pagador;

		public static RespostaRecuperarCobrancaCobranca Builder() {
			return new RespostaRecuperarCobrancaCobranca();
		}

		public RespostaRecuperarCobrancaCobranca Build() {
			return this;
		}

		public RespostaRecuperarCobrancaCobranca SetCodigoSolicitacao(string codigoSolicitacao) {
			this.CodigoSolicitacao = codigoSolicitacao;
			return this;
		}

		public RespostaRecuperarCobrancaCobranca SetSeuNumero(string seuNumero) {
			this.SeuNumero = seuNumero;
			return this;
		}

		public RespostaRecuperarCobrancaCobranca SetDataEmissao(string dataEmissao) {
			this.DataEmissao = dataEmissao;
			return this;
		}

		public RespostaRecuperarCobrancaCobranca SetDataVencimento(string dataVencimento) {
			this.DataVencimento = dataVencimento;
			return this;
		}

		public RespostaRecuperarCobrancaCobranca SetValorNominal(double valorNominal) {
			this.ValorNominal = valorNominal;
			return this;
		}

		public RespostaRecuperarCobrancaCobranca SetTipoCobranca(string tipoCobranca) {
			this.TipoCobranca = tipoCobranca;
			return this;
		}

		public RespostaRecuperarCobrancaCobranca SetSituacao(string situacao) {
			this.Situacao = situacao;
			return this;
		}

		public RespostaRecuperarCobrancaCobranca SetDataSituacao(string dataSituacao) {
			this.DataSituacao = dataSituacao;
			return this;
		}

		public RespostaRecuperarCobrancaCobranca SetValorTotalRecebido(string valorTotalRecebido) {
			this.ValorTotalRecebido = valorTotalRecebido;
			return this;
		}

		public RespostaRecuperarCobrancaCobranca SetOrigemRecebimento(string origemRecebimento) {
			this.OrigemRecebimento = origemRecebimento;
			return this;
		}

		public RespostaRecuperarCobrancaCobranca SetMotivoCancelamento(string motivoCancelamento) {
			this.MotivoCancelamento = motivoCancelamento;
			return this;
		}

		public RespostaRecuperarCobrancaCobranca SetArquivada(bool arquivada) {
			this.Arquivada = arquivada;
			return this;
		}

		public RespostaRecuperarCobrancaCobranca SetDescontos(List<Desconto> descontos) {
			this.Descontos = descontos;
			return this;
		}

		public RespostaRecuperarCobrancaCobranca SetMulta(Multa multa) {
			this.Multa = multa;
			return this;
		}

		public RespostaRecuperarCobrancaCobranca SetMora(Mora mora) {
			this.Mora = mora;
			return this;
		}

		public RespostaRecuperarCobrancaCobranca SetPagador(Pessoa pagador) {
			this.Pagador = pagador;
			return this;
		}
	}
}
