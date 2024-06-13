using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class PixDetalhado {
		[DataMember(Name="nome", EmitDefaultValue = false)]
		public string Nome;
		[DataMember(Name="cpfCnpj", EmitDefaultValue = false)]
		public string CpfCnpj;
		[DataMember(Name="nroContaRecebedor", EmitDefaultValue = false)]
		public string NroContaRecebedor;
		[DataMember(Name="codAgenciaRecebedor", EmitDefaultValue = false)]
		public string CodAgenciaRecebedor;
		[DataMember(Name="nomeInstituicao", EmitDefaultValue = false)]
		public string NomeInstituicao;
		[DataMember(Name="ispb", EmitDefaultValue = false)]
		public string Ispb;
		[DataMember(Name="dataMovimento", EmitDefaultValue = false)]
		public string DataMovimento;
		[DataMember(Name="data", EmitDefaultValue = false)]
		public string Data;
		[DataMember(Name="hora", EmitDefaultValue = false)]
		public string Hora;
		[DataMember(Name="identificador", EmitDefaultValue = false)]
		public string Identificador;
		// 
		//  Descrição complementar ao movimento
		//      
		[DataMember(Name="descricao", EmitDefaultValue = false)]
		public string Descricao;
		[DataMember(Name="numeroMovimento", EmitDefaultValue = false)]
		public string NumeroMovimento;
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public double Valor;
		// 
		//  Valor disponível de devolucao. Em caso de pix troco esse campo representa o valor da compra para devolução
		//      
		[DataMember(Name="valorDisponivelDevolucao", EmitDefaultValue = false)]
		public double ValorDisponivelDevolucao;
		// 
		//  Indicador de movimento elegível para devolução, se verdadeiro pode ser realizada uma devolução parcial ou total do movimento
		//      
		[DataMember(Name="isElegivelDevolucao", EmitDefaultValue = false)]
		public bool IsElegivelDevolucao;
		// 
		//  Indicador de movimento de devolução
		//      
		[DataMember(Name="isDevolucao", EmitDefaultValue = false)]
		public bool IsDevolucao;
		// 
		//  Natureza do movimento: [C|D]
		//      
		[DataMember(Name="natureza", EmitDefaultValue = false)]
		public string Natureza;
		// 
		//  Origem do movimento: [MANUAL|QR_CODE|CHAVE|DEVOLUCAO]
		//  <p>MANUAL QR_CODE DEVOLUCAO CHAVE INIC_PAG INIC_PAG_QR_CODE INIC_PAG_MANU INIC_PAG_CHAVE</p>
		//      
		[DataMember(Name="origemMovimento", EmitDefaultValue = false)]
		public string OrigemMovimento;
		// 
		//  Número único de operação.
		//      
		[DataMember(Name="endToEnd", EmitDefaultValue = false)]
		public string EndToEnd;
		// 
		//  End To End Original - Para operações de devolução.
		//      
		[DataMember(Name="endToEndOriginal", EmitDefaultValue = false)]
		public string EndToEndOriginal;
		// 
		//  Referência Interna Obtida do Processamento de QR Code
		//      
		[DataMember(Name="referenciaInterna", EmitDefaultValue = false)]
		public string ReferenciaInterna;
		// 
		//  Chave de endereçamento
		//      
		[DataMember(Name="chave", EmitDefaultValue = false)]
		public string Chave;
		// 
		//  Tipo da chava utilizada no pagamento
		//      
		[DataMember(Name="tipoChave", EmitDefaultValue = false)]
		public string TipoChave;
		// 
		//  Campo livre para informações do pagador ao recebedor
		//      
		[DataMember(Name="campoLivre", EmitDefaultValue = false)]
		public string CampoLivre;
		// 
		//  Instituição que iniciou o pagamento via OpenBanking
		//      
		[DataMember(Name="instituicaoIniciadora", EmitDefaultValue = false)]
		public string InstituicaoIniciadora;
		// 
		//  Forma de pagamento quando OpenBanking (default PIX)
		//      
		[DataMember(Name="formaPagamento", EmitDefaultValue = false)]
		public string FormaPagamento;
		// 
		//  Forma pagamento quando Openbanking (default OpenBanking)
		//      
		[DataMember(Name="pagoVia", EmitDefaultValue = false)]
		public string PagoVia;
		// 
		//  IPAY GSCB OTHR
		//      
		[DataMember(Name="finalidade", EmitDefaultValue = false)]
		public string Finalidade;
		// 
		//  Valor em espécie
		//      
		[DataMember(Name="valorEmEspecie", EmitDefaultValue = false)]
		public double ValorEmEspecie;
		// 
		//  Valor da compra
		//      
		[DataMember(Name="valorDaCompra", EmitDefaultValue = false)]
		public double ValorDaCompra;
		// 
		//  Para pix saque e pix troco esse campo representa o valor em espécie para devolução
		//      
		[DataMember(Name="valorEmEspecieDisponivelDevolucao", EmitDefaultValue = false)]
		public double ValorEmEspecieDisponivelDevolucao;
		[DataMember(Name="multa", EmitDefaultValue = false)]
		public double Multa;
		[DataMember(Name="juros", EmitDefaultValue = false)]
		public double Juros;
		[DataMember(Name="desconto", EmitDefaultValue = false)]
		public double Desconto;

		public static PixDetalhado Builder() {
			return new PixDetalhado();
		}

		public PixDetalhado Build() {
			return this;
		}

		public PixDetalhado SetNome(string nome) {
			this.Nome = nome;
			return this;
		}

		public PixDetalhado SetCpfCnpj(string cpfCnpj) {
			this.CpfCnpj = cpfCnpj;
			return this;
		}

		public PixDetalhado SetNroContaRecebedor(string nroContaRecebedor) {
			this.NroContaRecebedor = nroContaRecebedor;
			return this;
		}

		public PixDetalhado SetCodAgenciaRecebedor(string codAgenciaRecebedor) {
			this.CodAgenciaRecebedor = codAgenciaRecebedor;
			return this;
		}

		public PixDetalhado SetNomeInstituicao(string nomeInstituicao) {
			this.NomeInstituicao = nomeInstituicao;
			return this;
		}

		public PixDetalhado SetIspb(string ispb) {
			this.Ispb = ispb;
			return this;
		}

		public PixDetalhado SetDataMovimento(string dataMovimento) {
			this.DataMovimento = dataMovimento;
			return this;
		}

		public PixDetalhado SetData(string data) {
			this.Data = data;
			return this;
		}

		public PixDetalhado SetHora(string hora) {
			this.Hora = hora;
			return this;
		}

		public PixDetalhado SetIdentificador(string identificador) {
			this.Identificador = identificador;
			return this;
		}

		public PixDetalhado SetDescricao(string descricao) {
			this.Descricao = descricao;
			return this;
		}

		public PixDetalhado SetNumeroMovimento(string numeroMovimento) {
			this.NumeroMovimento = numeroMovimento;
			return this;
		}

		public PixDetalhado SetValor(double valor) {
			this.Valor = valor;
			return this;
		}

		public PixDetalhado SetValorDisponivelDevolucao(double valorDisponivelDevolucao) {
			this.ValorDisponivelDevolucao = valorDisponivelDevolucao;
			return this;
		}

		public PixDetalhado SetIsElegivelDevolucao(bool isElegivelDevolucao) {
			this.IsElegivelDevolucao = isElegivelDevolucao;
			return this;
		}

		public PixDetalhado SetIsDevolucao(bool isDevolucao) {
			this.IsDevolucao = isDevolucao;
			return this;
		}

		public PixDetalhado SetNatureza(string natureza) {
			this.Natureza = natureza;
			return this;
		}

		public PixDetalhado SetOrigemMovimento(string origemMovimento) {
			this.OrigemMovimento = origemMovimento;
			return this;
		}

		public PixDetalhado SetEndToEnd(string endToEnd) {
			this.EndToEnd = endToEnd;
			return this;
		}

		public PixDetalhado SetEndToEndOriginal(string endToEndOriginal) {
			this.EndToEndOriginal = endToEndOriginal;
			return this;
		}

		public PixDetalhado SetReferenciaInterna(string referenciaInterna) {
			this.ReferenciaInterna = referenciaInterna;
			return this;
		}

		public PixDetalhado SetChave(string chave) {
			this.Chave = chave;
			return this;
		}

		public PixDetalhado SetTipoChave(string tipoChave) {
			this.TipoChave = tipoChave;
			return this;
		}

		public PixDetalhado SetCampoLivre(string campoLivre) {
			this.CampoLivre = campoLivre;
			return this;
		}

		public PixDetalhado SetInstituicaoIniciadora(string instituicaoIniciadora) {
			this.InstituicaoIniciadora = instituicaoIniciadora;
			return this;
		}

		public PixDetalhado SetFormaPagamento(string formaPagamento) {
			this.FormaPagamento = formaPagamento;
			return this;
		}

		public PixDetalhado SetPagoVia(string pagoVia) {
			this.PagoVia = pagoVia;
			return this;
		}

		public PixDetalhado SetFinalidade(string finalidade) {
			this.Finalidade = finalidade;
			return this;
		}

		public PixDetalhado SetValorEmEspecie(double valorEmEspecie) {
			this.ValorEmEspecie = valorEmEspecie;
			return this;
		}

		public PixDetalhado SetValorDaCompra(double valorDaCompra) {
			this.ValorDaCompra = valorDaCompra;
			return this;
		}

		public PixDetalhado SetValorEmEspecieDisponivelDevolucao(double valorEmEspecieDisponivelDevolucao) {
			this.ValorEmEspecieDisponivelDevolucao = valorEmEspecieDisponivelDevolucao;
			return this;
		}

		public PixDetalhado SetMulta(double multa) {
			this.Multa = multa;
			return this;
		}

		public PixDetalhado SetJuros(double juros) {
			this.Juros = juros;
			return this;
		}

		public PixDetalhado SetDesconto(double desconto) {
			this.Desconto = desconto;
			return this;
		}
	}
}
