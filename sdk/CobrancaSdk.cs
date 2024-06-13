using System.Collections.Generic;
using Sdk.CobrancaApi;

namespace Sdk {
	public class CobrancaSdk {
		private Config config;

		public CobrancaSdk(Config config) {
			this.config = config;
		}

		// 
		//  Emite um novo boleto registrado.
		//  <p>O boleto emitido estará disponível para consulta e pagamento, após um tempo apróximado de 5
		//  minutos da sua inclusão. Esse tempo é necessário para o registro do boleto na CIP.</p>
		// 
		//  @param boleto Dados do boleto a ser emitido
		//  @return objeto com nossoNumero, codigoBarras e linhaDigitavel
		//      
		public RespostaEmitirBoleto EmitirBoleto(Boleto boleto) {
			return new EmitirBoleto().Emitir(config, boleto);
		}

		// 
		//  Recupera uma coleção de Boletos por um período específico, de acordo com os parâmetros informados.
		// 
		//  @param dataInicial Data inicial, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param dataFinal   Data final, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @param ordenacao   Ordenação do resultado(opcional, pode ser null).
		//  @return lista de boletos
		//      
		public List<BoletoDetalhado> RecuperarBoletos(string dataInicial, string dataFinal, FiltroRecuperarBoletos filtro, Ordenacao ordenacao) {
			return new RecuperarBoletos().Recuperar(config, dataInicial, dataFinal, filtro, ordenacao);
		}

		// 
		//  Recupera uma coleção de Boletos por um período específico, de acordo com os parâmetros informados, com paginação.
		// 
		//  @param dataInicial Data inicial, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param dataFinal   Data final, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @param ordenacao   Ordenação do resultado(opcional, pode ser null).
		//  @param pagina      Número da página iniciando com 0
		//  @return página com lista de boletos
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/pesquisarboletos">Recuperar coleção de boletos</a>
		//      
		public PaginaBoletos RecuperarBoletos(string dataInicial, string dataFinal, FiltroRecuperarBoletos filtro, Ordenacao ordenacao, int pagina) {
			return new RecuperarBoletos().Recuperar(config, dataInicial, dataFinal, pagina, 0, filtro, ordenacao);
		}

		// 
		//  Recupera uma coleção de Boletos por um período específico, de acordo com os parâmetros informados, com paginação.
		// 
		//  @param dataInicial   Data inicial, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param dataFinal     Data final, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param filtro        Filtros para consulta(opcional, pode ser null).
		//  @param ordenacao     Ordenação do resultado(opcional, pode ser null).
		//  @param pagina        Número da página iniciando com 0
		//  @param tamanhoPagina Tamanho da página, padrão = 100.
		//  @return página com lista de boletos
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/pesquisarboletos">Recuperar coleção de boletos</a>
		//      
		public PaginaBoletos RecuperarBoletos(string dataInicial, string dataFinal, FiltroRecuperarBoletos filtro, Ordenacao ordenacao, int pagina, int tamanhoPagina) {
			return new RecuperarBoletos().Recuperar(config, dataInicial, dataFinal, pagina, tamanhoPagina, filtro, ordenacao);
		}

		// 
		//  Recupera o sumário de uma coleção de Boletos por um período específico, de acordo com os parâmetros informados.
		// 
		//  @param dataInicial Data inicial, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param dataFinal   Data final, em acordo com o campo "filtrarDataPor". Formato aceito: YYYY-MM-DD.
		//  @param filtro      Filtros para consulta(opcional, pode ser null).
		//  @return sumário
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/consultarsumario-1">Recuperar sumário de boletos</a>
		//      
		public Sumario RecuperarSumarioBoletos(string dataInicial, string dataFinal, FiltroRecuperarSumarioBoletos filtro) {
			return new RecuperarSumarioBoletos().Recuperar(config, dataInicial, dataFinal, filtro);
		}

		// 
		//  Recupera um boleto detalhado de acordo com o parâmetro nossoNumero informado.
		// 
		//  @param nossoNumero Nosso número associado ao boleto.
		//  @return boleto detalhado
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/consultarboleto-1">Recuperar boleto detalhado</a>
		//      
		public BoletoDetalhado RecuperarBoletoDetalhado(string nossoNumero) {
			return new RecuperarBoletoDetalhado().Recuperar(config, nossoNumero);
		}

		// 
		//  Recupera um boleto em pdf de acordo com o parâmetro nossoNumero informado.
		// 
		//  @param nossoNumero Nosso número associado ao boleto.
		//  @param arquivo     Arquivo PDF que será gravado
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/descarregarpdfboleto-1">Recuperar boleto em PDF</a>
		//      
		public void RecuperarBoletoPdf(string nossoNumero, string arquivo) {
			new RecuperarBoletoPdf().Recuperar(config, nossoNumero, arquivo);
		}

		// 
		//  Cancela um boleto.
		// 
		//  @param nossoNumero        Nosso número associado ao boleto
		//  @param motivoCancelamento Domínio que descreve o tipo de cancelamento sendo solicitado.
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/baixarboleto-1">Cancelar boleto</a>
		//      
		public void CancelarBoleto(string nossoNumero, string motivoCancelamento) {
			new CancelarBoleto().Cancelar(config, nossoNumero, motivoCancelamento);
		}

		// 
		//  Método destinado a criar um webhook para receber notificações de boletos pagos e cancelados (callbacks)
		// 
		//  @param webhookUrl
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/webhookput">Criar webhook</a>
		//      
		public void CriarWebhook(string webhookUrl) {
			new CriarWebhook().Criar(config, webhookUrl);
		}

		// 
		//  Obter webhook cadastrado
		// 
		//  @return webhook
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/webhookget">Obter webhook cadastrado</a>
		//      
		public Webhook ObterWebhook() {
			return new ObterWebhook().Obter(config);
		}

		// 
		//  Exclui o webhook
		// 
		//  @see <a href="https://developers.bancointer.com.br/v4/reference/webhookdelete">Excluir webhook</a>
		//      
		public void ExcluirWebhook() {
			new ExcluirWebhook().Excluir(config);
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
			return new ConsultarCallbacks().Recuperar(config, dataHoraInicio, dataHoraFim, filtro);
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
			return new ConsultarCallbacks().Recuperar(config, dataHoraInicio, dataHoraFim, pagina, 0, filtro);
		}

	}
}
