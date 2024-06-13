using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class DarfLote : PagamentoDarf , ItemLote {
		[DataMember(Name="tipoPagamento", EmitDefaultValue = false)]
		public string TipoPagamento;
		[DataMember(Name="detalhe", EmitDefaultValue = false)]
		public string Detalhe;
		// 
		//  Identificador único do pagamento ao ser registrado.
		//      
		[DataMember(Name="idTransacao", EmitDefaultValue = false)]
		public string IdTransacao;
		// 
		//  EMPROCESSAMENTO não representa um estado do serviço de pagamentos. É o estado inicial do pagamento
		//  EMPROCESSAMENTO REALIZADO AGENDADO AGUARDANDO_APROVACAO APROVADO CANCELADO ERRO NAO_COMPENSADO APROVADO_NOVO_PAGAMENTO AGENDADO_REALIZADO AGENDADO_CANCELADO APROVACAO_EXPIRADA ERRO_PAGAMENTO PAGO PAGAMENTO_AGENDADO
		//      
		[DataMember(Name="status", EmitDefaultValue = false)]
		public string Status;

		public static DarfLote Builder() {
			return new DarfLote();
		}

		public DarfLote Build() {
			return this;
		}

		public DarfLote SetTipoPagamento(string tipoPagamento) {
			this.TipoPagamento = tipoPagamento;
			return this;
		}

		public DarfLote SetDetalhe(string detalhe) {
			this.Detalhe = detalhe;
			return this;
		}

		public DarfLote SetIdTransacao(string idTransacao) {
			this.IdTransacao = idTransacao;
			return this;
		}

		public DarfLote SetStatus(string status) {
			this.Status = status;
			return this;
		}

		public DarfLote SetCnpjCpf(string cnpjCpf) {
			this.CnpjCpf = cnpjCpf;
			return this;
		}

		public DarfLote SetCodigoReceita(string codigoReceita) {
			this.CodigoReceita = codigoReceita;
			return this;
		}

		public DarfLote SetDataVencimento(string dataVencimento) {
			this.DataVencimento = dataVencimento;
			return this;
		}

		public DarfLote SetDescricao(string descricao) {
			this.Descricao = descricao;
			return this;
		}

		public DarfLote SetNomeEmpresa(string nomeEmpresa) {
			this.NomeEmpresa = nomeEmpresa;
			return this;
		}

		public DarfLote SetTelefoneEmpresa(string telefoneEmpresa) {
			this.TelefoneEmpresa = telefoneEmpresa;
			return this;
		}

		public DarfLote SetPeriodoApuracao(string periodoApuracao) {
			this.PeriodoApuracao = periodoApuracao;
			return this;
		}

		public DarfLote SetValorPrincipal(string valorPrincipal) {
			this.ValorPrincipal = valorPrincipal;
			return this;
		}

		public DarfLote SetValorMulta(string valorMulta) {
			this.ValorMulta = valorMulta;
			return this;
		}

		public DarfLote SetValorJuros(string valorJuros) {
			this.ValorJuros = valorJuros;
			return this;
		}

		public DarfLote SetReferencia(string referencia) {
			this.Referencia = referencia;
			return this;
		}
	}
}
