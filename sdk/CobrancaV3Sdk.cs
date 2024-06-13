using System.Collections.Generic;
using Sdk.Cobrancav3Api;

namespace Sdk {
	public class CobrancaV3Sdk {
		private Config config;

		public CobrancaV3Sdk(Config config) {
			this.config = config;
		}

		// 
		//  Cancela uma cobrança.
		// 
		//  @param codigoSolicitacao  Código de solicitação da cobrança
		//  @param motivoCancelamento Texto livre com o motivo do cancelamento sendo solicitado.
		//  @see <a href="https://developers.inter.co/references/cobranca-bolepix#tag/Cobranca/operation/cancelarCobranca">Cancelar cobrança</a>
		//      
		public void CancelarCobranca(string codigoSolicitacao, string motivoCancelamento) {
			new CancelaCobranca().Cancelar(config, codigoSolicitacao, motivoCancelamento);
		}

		// 
		//  Emite uma nova Cobrança.
		//  <p>A cobrança emitida estará disponível para consulta e pagamento, após um tempo apróximado de 5
		//  minutos da sua inclusão. Esse tempo é necessário para o registro do boleto na CIP.</p>
		// 
		//  @param cobranca Dados da cobranca a ser emitida
		//  @return objeto com codigoSolicitacao
		//  @see <a href="https://developers.inter.co/references/cobranca-bolepix#tag/Cobranca/operation/emitirCobrancaAsync">Emitir cobrança</a>
		//      
		public RespostaEmitirCobranca EmitirCobranca(RequisicaoEmitirCobranca cobranca) {
			return new EmiteCobranca().Emitir(config, cobranca);
		}

		// 
		//  Recupera uma cobrança de acordo com o parâmetro codigoSolicitacao informado.
		// 
		//  @param codigoSolicitacao Códido da solicitação de emissao da cobrança.
		//  @return Cobrança detalhada
		//  @see <a href="https://developers.inter.co/references/cobranca-bolepix#tag/Cobranca/operation/recuperarCobrancaDetalhada">Recuperar cobrança detalhado</a>
		//      
		public CobrancaRecuperada RecuperarCobranca(string codigoSolicitacao) {
			return new RecuperaCobranca().Recuperar(config, codigoSolicitacao);
		}

		// 
		//  Recupera uma coleção de Boletos por um período específico, de acordo com os parâmetros informados, com paginação.
		// 
		//  @param dataInicial Data inicial, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param dataFinal   Data final, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @param ordenacao   Ordenação do resultado(opcional, pode ser null).
		//  @return página com lista de boletos
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/pesquisarboletos">Recuperar coleção de boletos</a>
		//      
		public List<CobrancaRecuperada> RecuperarCobrancas(string dataInicial, string dataFinal, FiltroRecuperarCobrancas filtro, Ordenacao ordenacao) {
			return new RecuperaColecaoCobrancas().Recuperar(config, dataInicial, dataFinal, filtro, ordenacao);
		}

		// 
		//  Recupera uma coleção de Boletos por um período específico, de acordo com os parâmetros informados, com paginação.
		// 
		//  @param dataInicial Data inicial, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param dataFinal   Data final, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @param ordenacao   Ordenação do resultado(opcional, pode ser null).
		//  @return página com lista de boletos
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/pesquisarboletos">Recuperar coleção de boletos</a>
		//      
		public PaginaCobrancas RecuperarCobrancas(string dataInicial, string dataFinal, FiltroRecuperarCobrancas filtro, int pagina, Ordenacao ordenacao) {
			return new RecuperaColecaoCobrancas().Recuperar(config, dataInicial, dataFinal, pagina, 0, filtro, ordenacao);
		}

		// 
		//  Recupera uma coleção de Cobranças por um período específico, de acordo com os parâmetros informados, com paginação.
		// 
		//  @param dataInicial   Data inicial, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param dataFinal     Data final, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param filtro        Filtros para consulta(opcional, pode ser null).
		//  @param ordenacao     Ordenação do resultado(opcional, pode ser null).
		//  @param pagina        Número da página iniciando com 0
		//  @param tamanhoPagina Tamanho da página, padrão = 100.
		//  @return página com lista de Cobranças
		//  @see <a href="https://developers.inter.co/references/cobranca-bolepix#tag/Cobranca/operation/pesquisaCobranca">Recuperar coleção de Cobranças</a>
		//      
		public PaginaCobrancas RecuperarCobrancas(string dataInicial, string dataFinal, FiltroRecuperarCobrancas filtro, Ordenacao ordenacao, int pagina, int tamanhoPagina) {
			return new RecuperaColecaoCobrancas().Recuperar(config, dataInicial, dataFinal, pagina, tamanhoPagina, filtro, ordenacao);
		}

		// 
		//  Recupera uma cobrança em pdf de acordo com o parâmetro codigoSolicitacao informado.
		// 
		//  @param codigoSolicitacao Código da Solicitacao associada à cobrança.
		//  @param arquivo     Arquivo PDF que será gravado
		//  @see <a href="https://developers.inter.co/references/cobranca-bolepix#tag/Cobranca/operation/obterPdfCobranca>Recuperar cobrança em PDF</a>
		//      
		public void RecuperarCobrancaPdf(string codigoSolicitacao, string arquivo) {
			new RecuperaCobrancaPdf().Recuperar(config, codigoSolicitacao, arquivo);
		}

		// 
		//  Recupera o sumário de uma coleção de cobranças por um período específico, de acordo com os parâmetros informados.
		// 
		//  @param dataInicial Data inicial, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param dataFinal   Data final, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @return sumário
		//  @see <a href="https://developers.inter.co/references/cobranca-bolepix#tag/Cobranca/operation/consultarSumario">Recuperar sumário de cobranças</a>
		//      
		public Sumario RecuperarSumarioCobrancas(string dataInicial, string dataFinal, FiltroRecuperarSumarioCobrancas filtro) {
			return new RecuperaSumarioCobrancas().Recuperar(config, dataInicial, dataFinal, filtro);
		}

		// 
		//  Método destinado a criar um webhook para receber notificações de cobranças pagos e cancelados (callbacks)
		// 
		//  @param webhookUrl
		//  @see <a href="https://developers.inter.co/references/cobranca-bolepix#tag/Webhook/operation/webhookPut">Criar webhook</a>
		//      
		public void CriarWebhook(string webhookUrl) {
			new CriaWebhook().Criar(config, webhookUrl);
		}

		// 
		//  Obter webhook cadastrado
		// 
		//  @return webhook
		//  @see <a href="https://developers.inter.co/references/cobranca-bolepix#tag/Webhook/operation/webhookGet">Obter webhook cadastrado</a>
		//      
		public Webhook ObterWebhook() {
			return new ObtemWebhook().Obter(config);
		}

		// 
		//  Exclui o webhook
		// 
		//  @see <a href="https://developers.inter.co/references/cobranca-bolepix#tag/Webhook/operation/webhookDelete">Excluir webhook</a>
		//      
		public void ExcluirWebhook() {
			new ExcluiWebhook().Excluir(config);
		}

		// 
		//  Consulta a lista de callbackspor um período específico, de acordo com os parâmetros informados, com paginação.
		// 
		//  @param dataHoraInicio   Data inicial, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param dataHoraFim     Data final, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param filtro        Filtros para consulta(opcional, pode ser null).
		//  @param pagina        Número da página, iniciando com 0
		//  @param tamanhoPagina Tamanho da página, padrão = 100.
		//  @return página com lista de Cobranças
		//  @see <a href="https://developers.inter.co/references/cobranca-bolepix#tag/Webhook/operation/callbacksFilter">Recuperar coleção de Cobranças</a>
		//      
		public PaginaCallbacks ConsultarCallbacks(string dataHoraInicio, string dataHoraFim, FiltroBuscarCallbacks filtro, int pagina, int tamanhoPagina) {
			return new ConsultaCallbacks().Recuperar(config, dataHoraInicio, dataHoraFim, pagina, tamanhoPagina, filtro);
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
		public List<RespostaBuscarCallbacks> ConsultarCallbacks(string dataHoraInicio, string dataHoraFim, FiltroBuscarCallbacks filtro, Ordenacao ordenacao) {
			return new ConsultaCallbacks().Recuperar(config, dataHoraInicio, dataHoraFim, filtro);
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
		public PaginaCallbacks ConsultarCallbacks(string dataHoraInicio, string dataHoraFim, FiltroBuscarCallbacks filtro, int pagina, Ordenacao ordenacao) {
			return new ConsultaCallbacks().Recuperar(config, dataHoraInicio, dataHoraFim, pagina, 0, filtro);
		}

	}
}
