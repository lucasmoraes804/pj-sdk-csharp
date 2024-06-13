all: inter-sdk-csharp.dll

clean: 
	rm -f inter-sdk-csharp.dll

SDK= \
sdk/BankingSdk.cs \
sdk/CobrancaSdk.cs \
sdk/CobrancaV3Sdk.cs \
sdk/Constants.cs \
sdk/PixSdk.cs \
sdk/InterSdk.cs \
sdk/HttpUtils.cs \
sdk/SdkException.cs \
sdk/TokenUtils.cs \
sdk/Utils.cs

MODEL_COBRANCA= \
cobranca/model/Boleto.cs \
cobranca/model/BoletoDetalhado.cs \
cobranca/model/Desconto.cs \
cobranca/model/FiltroBaseRecuperarBoletos.cs \
cobranca/model/FiltroBuscarCallbacks.cs \
cobranca/model/FiltroRecuperarBoletos.cs \
cobranca/model/FiltroRecuperarSumarioBoletos.cs \
cobranca/model/ItemSumario.cs \
cobranca/model/Mensagem.cs \
cobranca/model/Mora.cs \
cobranca/model/Multa.cs \
cobranca/model/Ordenacao.cs \
cobranca/model/PaginaBoletos.cs \
cobranca/model/PaginaCallbacks.cs \
cobranca/model/Payload.cs \
cobranca/model/Pessoa.cs \
cobranca/model/RequisicaoCancelarBoleto.cs \
cobranca/model/RespostaBuscarCallbacks.cs \
cobranca/model/RespostaEmitirBoleto.cs \
cobranca/model/Sumario.cs \
cobranca/model/enums/CodigoDesconto.cs \
cobranca/model/enums/CodigoMora.cs \
cobranca/model/enums/CodigoMulta.cs \
cobranca/model/enums/MotivoCancelamento.cs \
cobranca/model/enums/OrdenadoPor.cs \
cobranca/model/enums/SituacaoBoleto.cs \
cobranca/model/enums/TipoDataBoleto.cs \
cobranca/model/enums/TipoOrdenacao.cs \
cobranca/model/enums/TipoPessoa.cs

COBRANCA= \
cobranca/boletos/CancelarBoleto.cs \
cobranca/boletos/EmitirBoleto.cs \
cobranca/boletos/RecuperarBoletoDetalhado.cs \
cobranca/boletos/RecuperarBoletoPdf.cs \
cobranca/boletos/RecuperarBoletos.cs \
cobranca/boletos/RecuperarSumarioBoletos.cs \
cobranca/webhook/ConsultarCallbacks.cs \
cobranca/webhook/CriarWebhook.cs \
cobranca/webhook/ExcluirWebhook.cs \
cobranca/webhook/ObterWebhook.cs

MODEL_COBRANCAV3= \
cobrancav3/model/CobrancaRecuperada.cs \
cobrancav3/model/Desconto.cs \
cobrancav3/model/FiltroBaseRecuperarCobrancas.cs \
cobrancav3/model/FiltroBuscarCallbacks.cs \
cobrancav3/model/FiltroRecuperarCobrancas.cs \
cobrancav3/model/FiltroRecuperarSumarioCobrancas.cs \
cobrancav3/model/ItemSumario.cs \
cobrancav3/model/Mensagem.cs \
cobrancav3/model/Mora.cs \
cobrancav3/model/Multa.cs \
cobrancav3/model/Ordenacao.cs \
cobrancav3/model/PaginaCallbacks.cs \
cobrancav3/model/PaginaCobrancas.cs \
cobrancav3/model/Payload.cs \
cobrancav3/model/Pessoa.cs \
cobrancav3/model/RequisicaoCancelarCobranca.cs \
cobrancav3/model/RequisicaoEmitirCobranca.cs \
cobrancav3/model/RespostaBuscarCallbacks.cs \
cobrancav3/model/RespostaEmitirCobranca.cs \
cobrancav3/model/RespostaRecuperarCobrancaBoleto.cs \
cobrancav3/model/RespostaRecuperarCobrancaCobranca.cs \
cobrancav3/model/RespostaRecuperarCobrancaPix.cs \
cobrancav3/model/Sumario.cs \
cobrancav3/model/enums/CodigoDesconto.cs \
cobrancav3/model/enums/CodigoMora.cs \
cobrancav3/model/enums/CodigoMulta.cs \
cobrancav3/model/enums/OrdenadoPor.cs \
cobrancav3/model/enums/OrigemRecebimento.cs \
cobrancav3/model/enums/SituacaoCobranca.cs \
cobrancav3/model/enums/TipoCobranca.cs \
cobrancav3/model/enums/TipoDataCobranca.cs \
cobrancav3/model/enums/TipoOrdenacao.cs \
cobrancav3/model/enums/TipoPessoa.cs

COBRANCAV3= \
cobrancav3/cobrancas/CancelaCobranca.cs \
cobrancav3/cobrancas/EmiteCobranca.cs \
cobrancav3/cobrancas/RecuperaCobranca.cs \
cobrancav3/cobrancas/RecuperaCobrancaPdf.cs \
cobrancav3/cobrancas/RecuperaColecaoCobrancas.cs \
cobrancav3/cobrancas/RecuperaSumarioCobrancas.cs \
cobrancav3/webhook/ConsultaCallbacks.cs \
cobrancav3/webhook/CriaWebhook.cs \
cobrancav3/webhook/ExcluiWebhook.cs \
cobrancav3/webhook/ObtemWebhook.cs

MODEL_BANKING= \
banking/model/BoletoLote.cs \
banking/model/Chave.cs \
banking/model/DadosBancarios.cs \
banking/model/DarfLote.cs \
banking/model/Destinatario.cs \
banking/model/DetalhesTransacao.cs \
banking/model/Extrato.cs \
banking/model/Favorecido.cs \
banking/model/FiltroBuscarCallbacks.cs \
banking/model/FiltroBuscarPagamentos.cs \
banking/model/FiltroBuscarPagamentosDarf.cs \
banking/model/FiltroConsultarExtratoEnriquecido.cs \
banking/model/InstituicaoFinanceira.cs \
banking/model/ItemLote.cs \
banking/model/ItemProcessamentoLote.cs \
banking/model/Lote.cs \
banking/model/Ordenacao.cs \
banking/model/Pagamento.cs \
banking/model/PagamentoBoleto.cs \
banking/model/PagamentoDarf.cs \
banking/model/PaginaCallbacks.cs \
banking/model/PaginaExtratoEnriquecido.cs \
banking/model/Payload.cs \
banking/model/Pix.cs \
banking/model/PixDetalhado.cs \
banking/model/ProcessamentoLote.cs \
banking/model/Recebedor.cs \
banking/model/RespostaBuscarCallbacks.cs \
banking/model/RespostaIncluirPagamento.cs \
banking/model/RespostaIncluirPagamentoDarf.cs \
banking/model/RespostaIncluirPagamentosLote.cs \
banking/model/RespostaIncluirPix.cs \
banking/model/RetornoPagamentoDarf.cs \
banking/model/Saldo.cs \
banking/model/Transacao.cs \
banking/model/TransacaoEnriquecida.cs \
banking/model/enums/OrigemLogin.cs \
banking/model/enums/TipoConta.cs \
banking/model/enums/TipoDataPagamento.cs \
banking/model/enums/TipoDataPagamentoDarf.cs \
banking/model/enums/TipoOperacao.cs \
banking/model/enums/TipoTransacao.cs \
banking/model/enums/TipoTransferencia.cs

BANKING= \
banking/extrato/ConsultarExtrato.cs \
banking/extrato/ConsultarExtratoEnriquecido.cs \
banking/extrato/RecuperarExtratoPdf.cs \
banking/pagamento/BuscarLotePagamentos.cs \
banking/pagamento/BuscarPagamentos.cs \
banking/pagamento/BuscarPagamentosDarf.cs \
banking/pagamento/CancelaAgendamentoPagamento.cs \
banking/pagamento/IncluirPagamento.cs \
banking/pagamento/IncluirPagamentoDarf.cs \
banking/pagamento/IncluirPagamentosLote.cs \
banking/pix/IncluirPix.cs \
banking/saldo/ConsultarSaldo.cs \
banking/webhook/ConsultarCallbacks.cs \
banking/webhook/CriarWebhook.cs \
banking/webhook/ExcluirWebhook.cs \
banking/webhook/ObterWebhook.cs 

MODEL_PIX= \
pix/model/Abatimento.cs \
pix/model/Calendario.cs \
pix/model/CalendarioCobV.cs \
pix/model/CobVValor.cs \
pix/model/Cobranca.cs \
pix/model/CobrancaDetalhada.cs \
pix/model/CobrancaVencimento.cs \
pix/model/CobrancaVencimentoDetalhada.cs \
pix/model/ComponenteValor.cs \
pix/model/CriarLocationRequest.cs \
pix/model/Desconto.cs \
pix/model/DescontoDataFixa.cs \
pix/model/Devedor.cs \
pix/model/Devolucao.cs \
pix/model/DevolucaoDetalhada.cs \
pix/model/DevolucaoHorario.cs \
pix/model/FiltroBuscarCallbacks.cs \
pix/model/FiltroConsultarCobrancasComVencimento.cs \
pix/model/FiltroConsultarCobrancasImediatas.cs \
pix/model/FiltroConsultarLocations.cs \
pix/model/FiltroConsultarPixRecebidos.cs \
pix/model/Horario.cs \
pix/model/InfoAdicional.cs \
pix/model/ItemPayload.cs \
pix/model/Juros.cs \
pix/model/Location.cs \
pix/model/Multa.cs \
pix/model/Ordenacao.cs \
pix/model/PaginaCallbacks.cs \
pix/model/PaginaCobrancas.cs \
pix/model/PaginaCobrancasVencimento.cs \
pix/model/PaginaLocations.cs \
pix/model/PaginaPix.cs \
pix/model/Paginacao.cs \
pix/model/Parametros.cs \
pix/model/Payload.cs \
pix/model/Pix.cs \
pix/model/Recebedor.cs \
pix/model/RequisicaoBodyDevolucao.cs \
pix/model/RespostaBuscarCallbacks.cs \
pix/model/Retirada.cs \
pix/model/Saque.cs \
pix/model/Troco.cs \
pix/model/Valor.cs \
pix/model/ValorComponente.cs \
pix/model/enums/ModalidadeAgente.cs \
pix/model/enums/NaturezaDevolucao.cs \
pix/model/enums/StatusCobranca.cs \
pix/model/enums/StatusPixCobranca.cs \
pix/model/enums/TipoCob.cs

PIX= \
pix/cob/ConsultarCobrancaImediata.cs \
pix/cob/ConsultarCobrancasImediatas.cs \
pix/cob/CriarCobrancaImediata.cs \
pix/cob/RevisarCobrancaImediata.cs \
pix/cobv/ConsultarCobrancaComVencimento.cs \
pix/cobv/ConsultarCobrancasComVencimento.cs \
pix/cobv/CriarCobrancaComVencimento.cs \
pix/cobv/RevisarCobrancaComVencimento.cs \
pix/location/ConsultarLocationsCadastradas.cs \
pix/location/CriarLocation.cs \
pix/location/DesvincularLocation.cs \
pix/location/RecuperarLocation.cs \
pix/pix/ConsultarDevolucao.cs \
pix/pix/ConsultarPix.cs \
pix/pix/ConsultarPixRecebidos.cs \
pix/pix/SolicitarDevolucao.cs \
pix/webhook/ConsultarCallbacks.cs \
pix/webhook/CriarWebhook.cs \
pix/webhook/ExcluirWebhook.cs \
pix/webhook/ObterWebhook.cs 

MODEL_COMMONS= \
commons/model/Config.cs \
commons/model/CriarWebhookRequest.cs \
commons/model/Erro.cs \
commons/model/RespostaObterToken.cs \
commons/model/RetornoPdf.cs \
commons/model/Violacao.cs \
commons/model/Webhook.cs 

inter-sdk-csharp.dll: $(SDK) $(MODEL_COBRANCA) $(MODEL_COBRANCAV3) $(MODEL_BANKING) $(MODEL_PIX) $(MODEL_COMMONS) $(COBRANCA) $(COBRANCAV3) $(BANKING) $(PIX)
	csc -w:0 -target:library /out:inter-sdk-csharp.dll $(SDK) $(MODEL_COBRANCA) $(MODEL_COBRANCAV3) $(MODEL_BANKING) $(MODEL_PIX) $(MODEL_COMMONS) $(COBRANCA) $(COBRANCAV3) $(BANKING) $(PIX) 

