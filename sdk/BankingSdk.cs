using System.Collections.Generic;
using Sdk.BankingApi;

namespace Sdk {
	public class BankingSdk {
		private Config config;

		public BankingSdk(Config config) {
			this.config = config;
		}

		// 
		//  Consulta o extrato por um período específico. O período máximo entre as datas é de 90 dias.
		// 
		//  @param dataInicial Data início da consulta de extrato. Formato: YYYY-MM-DD.
		//  @param dataFinal   Data fim da consulta de extrato. Formato: YYYY-MM-DD.
		//  @return lista de transações
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/extrato-1">Consultar extrato</a>
		//      
		public Extrato ConsultarExtrato(string dataInicial, string dataFinal) {
			return new ConsultarExtrato().Consultar(config, dataInicial, dataFinal);
		}

		// 
		//  Recupera o extrato em pdf por um período específico. O período máximo entre as datas é de 90 dias.
		// 
		//  @param dataInicial Data inicio da exportação de extrato. Formato: YYYY-MM-DD.
		//  @param dataFinal   Data fim da exportação de extrato. Formato: YYYY-MM-DD.
		//  @param arquivo     Arquivo PDF que será gravado.
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/extratoexport">Recuperar extrato em PDF</a>
		//      
		public void RecuperarExtratoPdf(string dataInicial, string dataFinal, string arquivo) {
			new RecuperarExtratoPdf().Recuperar(config, dataInicial, dataFinal, arquivo);
		}

		// 
		//  Consulta extrato enriquecido num intervalo de datas com os filtros especificados
		// 
		//  @param dataInicial data inicial para consulta. Formato: YYYY-MM-DD.
		//  @param dataFinal   data final para consulta. Formato: YYYY-MM-DD.
		//  @param filtro      filtros para consulta(opcional, pode ser null)
		//  @return lista de transações enriquecidas
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/extratocomplete">Consultar extrato enriquecido</a>
		//      
		public List<TransacaoEnriquecida> ConsultarExtratoEnriquecido(string dataInicial, string dataFinal, FiltroConsultarExtratoEnriquecido filtro) {
			return new ConsultarExtratoEnriquecido().Consultar(config, dataInicial, dataFinal, filtro);
		}

		// 
		//  Consulta extrato enriquecido com informações detalhadas de cada transação dado um período específico. O período máximo entre as datas é de 90 dias.
		// 
		//  @param dataInicial Data início da exportação de extrato. Formato: YYYY-MM-DD.
		//  @param dataFinal   Data fim da exportação de extrato. Formato: YYYY-MM-DD.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @param pagina      Número da página iniciando com 0.
		//  @return lista de transações enriquecidas
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/extratocomplete-1">Consultar extrato enriquecido</a>
		//      
		public PaginaExtratoEnriquecido ConsultarExtratoEnriquecido(string dataInicial, string dataFinal, FiltroConsultarExtratoEnriquecido filtro, int pagina) {
			return new ConsultarExtratoEnriquecido().Consultar(config, dataInicial, dataFinal, pagina, 0, filtro);
		}

		// 
		//  Consulta extrato enriquecido com informações detalhadas de cada transação dado um período específico. O período máximo entre as datas é de 90 dias.
		// 
		//  @param dataInicial   Data início da exportação de extrato. Formato: YYYY-MM-DD.
		//  @param dataFinal     Data fim da exportação de extrato. Formato: YYYY-MM-DD.
		//  @param filtro        Filtros para consulta(opcional, pode ser null).
		//  @param pagina        Número da página iniciando com 0.
		//  @param tamanhoPagina Tamanho da páfina, padrão = 50.
		//  @return lista de transações enriquecidas
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/extratocomplete-1">Consultar extrato enriquecido</a>
		//      
		public PaginaExtratoEnriquecido ConsultarExtratoEnriquecido(string dataInicial, string dataFinal, FiltroConsultarExtratoEnriquecido filtro, int pagina, int tamanhoPagina) {
			return new ConsultarExtratoEnriquecido().Consultar(config, dataInicial, dataFinal, pagina, tamanhoPagina, filtro);
		}

		// 
		//  Consulta o saldo atual.
		// 
		//  @return objeto com os saldos atuais da conta
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/saldo-3">Consultar saldo</a>
		//      
		public Saldo ConsultarSaldo() {
			return ConsultarSaldo(null);
		}

		// 
		//  Consulta o saldo por um período específico.
		// 
		//  @param dataSaldo Data de consulta para o saldo posicional. Formato: YYYY-MM-DD.
		//  @return objeto com os saldos da conta na data especificada
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/saldo-1">Consultar saldo</a>
		//      
		public Saldo ConsultarSaldo(string dataSaldo) {
			return new ConsultarSaldo().Consultar(config, dataSaldo);
		}

		// 
		//  Método para inclusão de um pagamento imediato ou agendamento do pagamento de boleto, convênio ou tributo com código de barras.
		// 
		//  @param pagamento Dados do pagamento
		//  @return objeto com quantidadeAprovadores, statusPagamento, codigoTransacao...
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/pagarboleto">Incluir pagamento com código de barras</a>
		//      
		public RespostaIncluirPagamento IncluirPagamento(PagamentoBoleto pagamento) {
			return new IncluirPagamento().Incluir(config, pagamento);
		}

		// 
		//  Busca informações de pagamentos de boleto.
		// 
		//  @param dataInicial Data inicio, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param dataFinal   Data Fim, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @return lista de pagamentos
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/buscarinformacoespagamentos">Buscar pagamentos</a>
		//      
		public List<Pagamento> BuscarPagamentos(string dataInicial, string dataFinal, FiltroBuscarPagamentos filtro) {
			return new BuscarPagamentos().Buscar(config, dataInicial, dataFinal, filtro);
		}

		// 
		//  Método para inclusão de um pagamento imediato de DARF sem código de barras.
		// 
		//  @param pagamento Dados do pagamento
		//  @return objeto com autenticacao, nroOperacao, tipoRetorno, codigoTransacao...
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/pagamentosdarf-1">Incluir pagamento de DARF</a>
		//      
		public RespostaIncluirPagamentoDarf IncluirPagamentoDarf(PagamentoDarf pagamento) {
			return new IncluirPagamentoDarf().Incluir(config, pagamento);
		}

		// 
		//  Busca informações de pagamento de DARF.
		// 
		//  @param dataInicial Data inicio, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param dataFinal   Data Fim, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @return lista de pagamentos
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/buscarinformacoespagamentodarf">Buscar pagamentos de DARF</a>
		//      
		public List<RetornoPagamentoDarf> BuscarPagamentosDarf(string dataInicial, string dataFinal, FiltroBuscarPagamentosDarf filtro) {
			return new BuscarPagamentosDarf().Buscar(config, dataInicial, dataFinal, filtro);
		}

		// 
		//  Inclusão de um lote de pagamentos digitados pelo cliente
		// 
		//  @param meuIdentificador Identificador do lote para o cliente.
		//  @param pagamentos       Pagamentos a serem efetuados.
		//  @return informações do processamento do lote
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/pagamentoslote">Incluir pagamentos em lote</a>
		//      
		public RespostaIncluirPagamentosLote IncluirPagamentosLote(string meuIdentificador, List<ItemLote> pagamentos) {
			return new IncluirPagamentosLote().Incluir(config, meuIdentificador, pagamentos);
		}

		// 
		//  Inclusão de um lote de pagamentos digitados pelo cliente
		// 
		//  @param idLote Identificador do lote.
		//  @return informações do processamento do lote
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/buscarinformacoespagamentolote">Buscar lote de pagamentos</a>
		//      
		public ProcessamentoLote BuscarLotePagamentos(string idLote) {
			return new BuscarLotePagamentos().Buscar(config, idLote);
		}

		// 
		//  Método para inclusão de um pagamento/transferência Pix utilizando dados bancários ou chave.
		// 
		//  @param pix Dados do pix
		//  @return objeto com endToEndId...
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/realizarpagamentopix-1">Incluir Pix</a>
		//      
		public RespostaIncluirPix IncluirPix(Pix pix) {
			return new IncluirPix().Incluir(config, pix);
		}

		// 
		//  Método destinado a criar um webhook para receber notificações de confirmação de envio de pix (callbacks).
		// 
		//  @param webhookUrl A URL do servidor https do cliente
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/webhookput">Criar webhook</a>
		//      
		public void CriarWebhook(string tipoWebhook, string webhookUrl) {
			new CriarWebhook().Criar(config, tipoWebhook, webhookUrl);
		}

		// 
		//  Obter webhook cadastrado
		// 
		//  @return webhook
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/webhookget-3">Obter webhook cadastrado</a>
		//      
		public Webhook ObterWebhook(string tipoWebhook) {
			return new ObterWebhook().Obter(config, tipoWebhook);
		}

		// 
		//  Exclui o webhook
		// 
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/webhookdelete-3">Excluir webhook</a>
		//      
		public void ExcluirWebhook(string tipoWebhook) {
			new ExcluirWebhook().Excluir(config, tipoWebhook);
		}

		// 
		//  Recupera uma coleção de callbacks por um período específico, de acordo com os parâmetros informados, sem paginação.
		// 
		//  @param dataHoraInicio Data inicial, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param dataHoraFim    Data final, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param filtro         Filtros para consulta(opcional, pode ser null).
		//  @param ordenacao      Ordenação do resultado(opcional, pode ser null).
		//  @return página com lista de boletos
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/pesquisarboletos">Recuperar coleção de boletos</a>
		//      
		public List<RespostaBuscarCallbacks> ConsultarCallbacks(string tipoWebhook, string dataHoraInicio, string dataHoraFim, FiltroBuscarCallbacks filtro, Ordenacao ordenacao) {
			return new ConsultarCallbacks().Recuperar(config, tipoWebhook, dataHoraInicio, dataHoraFim, filtro);
		}

		// 
		//  Recupera uma coleção de Boletos por um período específico, de acordo com os parâmetros informados, com paginação.
		// 
		//  @param dataHoraInicio Data inicial, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param dataHoraFim    Data final, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param filtro         Filtros para consulta(opcional, pode ser null).
		//  @param ordenacao      Ordenação do resultado(opcional, pode ser null).
		//  @return página com lista de boletos
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/pesquisarboletos">Recuperar coleção de boletos</a>
		//      
		public PaginaCallbacks ConsultarCallbacks(string tipoWebhook, string dataHoraInicio, string dataHoraFim, FiltroBuscarCallbacks filtro, int pagina, Ordenacao ordenacao) {
			return new ConsultarCallbacks().Recuperar(config, tipoWebhook, dataHoraInicio, dataHoraFim, pagina, 0, filtro);
		}

		// 
		//  Cancela o agendamento de um pagamento.
		// 
		//  @param codigoTransacao Código único da transacação
		//  @throws SdkException
		//      
		public void CancelaAgendamentoPagamento(string codigoTransacao) {
			new CancelaAgendamentoPagamento().Cancelar(config, codigoTransacao);
		}

	}
}
