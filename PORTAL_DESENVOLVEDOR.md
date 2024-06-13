## Pré-requisitos

### .NET

O SDK do C#, e a aplicação Demo do C# são disponibilizados de diferente formas:

- compilado com o Mono
    - pré-requisito: .NET Framework 4.0+
    - pré-requisito para Linux/Mac Os: Mono JIT compiler version 6.12.0.182+
- compilado com o .NET core
    - pré-requisito: .NET SDK 7.0.203+
- código fonte
    - projeto SDK: inter-sdk-csharp.csproj
    - projeto Demo: demo-sdk-csharp.csproj


### Download e configuração do InterSdk

[Clique aqui](/media/inter-sdk-csharp.zip) para baixar o projeto do SDK C#.

[Clique aqui](/media/inter-demo-csharp.zip) para baixar o projeto Demo C#.

[Clique aqui](/media/mono.zip) para baixar o compilado para Mono/.NET Framework

- mono.zip, distribuição para execução com o Mono ou no Windows com o .NET Framework 4.0+, contendo:
    - inter-sdk-csharp.dll e App.exe
        - execução com o mono:
            - mono App.exe
        - execução no Windows
            - App

[Clique aqui](/media/core.zip) para baixar o compilado para .NET Core

- core.zip, distribuição para execução com o .NET Core, contendo:
    - inter-sdk-csharp.dll, demo-sdk-csharp.dll, demo-sdk-csharp.runtimeconfig.json
        - execução:
            - dotnet demo-sdk-csharp.dll

### Download e configuração do certificado digital

Para baixar o seu certificado, siga as instruções desse documento: <https://developers.bancointer.com.br/v4/docs/onde-obter-o-certificado>

Verifique se possui o openssl instalado em sua maquina com o seguinte comando no terminal: openssl version.
Caso não tenha instalado, instale o openssl. Ele será necessário para gerar o arquivo do certificado no formato utilizado pelo C# (.pfx).

* Baixar OpenSSL para MAC: <https://www.macupdate.com/app/mac/62162/openssl>
* Baixar OpenSSL para Windows: <https://slproweb.com/products/Win32OpenSSL.html>
* Baixar OpenSSL para Linux: <https://help.dreamhost.com/hc/en-us/articles/360001435926-Installing-OpenSSL-locally-under-your-username>

Gere o arquivo .pfx (pkcs12) com o seguinte comando:

```
openssl pkcs12 -export -out NOME_DO_ARQUIVO.pfx -inkey "CHAVE.key" -in "CERTIFICADO.crt" -legacy -password pass:SENHA
```

Onde:

* NOME_DO_ARQUIVO = Nome do arquivo .pfx que será gerado (deverá ser informado na inicialização do InterSdk).
* CHAVE = Nome do arquivo .key baixado no portal do desenvolvedor.
* CERTIFICADO = Nome do arquivo .crt baixado no portal do desenvolvedor.
* SENHA = Senha para o arquivo .pfx (deverá ser informada na inicialização do InterSdk).

Exemplo:

```
openssl pkcs12 -export -out inter.pfx -inkey "Inter API_Chave.key" -in "Inter API_Certificado.crt" -legacy -password pass:intersdk
```

Para usar o certificado (arquivo .pfx), basta colocá-lo dentro do projeto da sua aplicação. Esse passo não é obrigatório mas poderá simplificar a inicialização do InterSdk.

## Como utilizar e recursos do InterSdk

### Inicialização

Antes de executar os comandos disponibilizados pelo InterSdk, é necessário inicializa-lo. Para isso, basta passar os seguintes parâmetros no construtor:

```
InterSdk interSdk = new InterSdk(
    "CLIENT_ID", // Pode ser obtido no detalhe da tela de aplicações do Internet Banking
    "CLIENT_SECRET", // Pode ser obtido no detalhe da tela de aplicações no Internet Banking
    "CAMINHO_ARQUIVO_PFX", // Caminho do arquivo .pfx gerado (utilizando o openssl)
    "SENHA_ARQUIVO_PFX" // Senha utilizada na geração do certificado .pfx
);

// EXEMPLO:

InterSdk interSdk = new InterSdk(
    "2179676f-3069-44de-96c3-07739bcded35",
    "29f8fe86-efab-4b31-a5f6-6d22ebcb2014",
    "inter.pfx",
    "intersdk"
);
```

### Tratamento de erros

Em caso de erros, todos os métodos do InterSdk lançam exceções. Dessa forma, se a chamada do método passar sem exceções, pode-se considerar que foi uma chamada com sucesso.

As exceções podem ser separadas em dois grupos: _SdkException_ e _outras exceções_.

Todas as exceções descendentes da SdkException terão um objeto de erro. Esse objeto terá título, detalhe, data e uma lista de violações:

```
public class Erro {
    public string Title;
    public string Detail;
    public DateTime Timestamp;
    public List<Violacao> Violacoes;
    ...
}

public class Violacao {
    private String razao;
    private String propriedade;
    private String valor;
    ...
}
```

Exemplo de tratamento de erros:
```
        try {
            interSdk.BankingSdk().ConsultarExtrato(dataInicial, dataFinal);
        } catch (SdkException e) {
            Console.WriteLine("Titulo: {0}", e.Erro.Title);
            Console.WriteLine("Detalhes: {0}", e.Erro.Detail);
            foreach (Violacao violacao in e.Erro.Violacoes) {
                Console.WriteLine("Violacao Razao: {0}", violacao.Razao);
                Console.WriteLine("Violacao Propriedade: {0}", violacao.Propriedade);
                Console.WriteLine("Violacao Valor: {0}", violacao.Valor);
            }
        }
    }

Saída:
Titulo: A presente requisicao nao respeita o schema ou não faz sentido semanticamente.
Detalhes: Requisicao invalida.
Violacao Razao: Periodo maximo entre as datas é de 90 dias.
Violacao Propriedade: Data inicio, Data Fim
Violacao Valor: 
```

### Múltiplas contas

Caso sua aplicação seja associada a mais de uma conta, você poderá a qualquer momento mudar e consultar a conta que será utilizada pelo InterSdk.

```
    // Seta a conta
    interSdk.SetContaCorrente("123456");
    // Mostra a conta selecionada
    fmt.Println(interSdk.GetContaCorrente());
    // Executa comando na conta selecionada
    saldo := interSdk.ConsultarSaldo();
    interSdk.SetContaCorrente("098765");
    // Executa comando na nova conta selecionada
    saldo := interSdk.ConsultarSaldo();
}
```

### Geração de logs

O InterSdk grava logs dos comandos executados, com o objetivo de auxiliar na identificação de possíveis erros.

Os arquivos de log ficam armazenados na pasta "logs", dentro do diretório de execução da aplicação. Se a pasta "logs" não existir ela será criada automaticamente.

Será criado um arquivo de log para cada dia da semana.  O log do dia seguinte ao dia atual será sempre removido no primeiro acesso do dia, sendo assim, a pasta poderá ter até 6 arquivos.

Ex.: inter-sdk-Monday.log, inter-sdk-Tuesday.log

### Modo debug

O modo debug por padrão é desabilitado.

Se o modo debug estiver habilitado, os logs gerados conterão as requisições e as respostas das chamadas das APIs do Inter que são feitas internamente pelo InterSdk.

Para habilitar/desabilitar basta executar o seguinte método:

```
interSdk.SetDebug(true);
```

### Controle de rate limit

Os endpoints das APIs do Inter tem um limite máximo de chamadas permitidas por minuto (rate limit).

Se esse limite for ultrapassado, o InterSdk vai retornar o seguinte erro:

```
title="HTTP/1.1 429 Too Many Requests"
```

O SDK, por padrão, trata automaticamente esse erro. Caso o rate limit seta ultrapassado, o SDK vai fazer uma pausa de um minuto e vai tentar novamente.

Para desativar essa funcionalidade utilize o seguinte comando:
```
interSdk.SetControleRateLimit(false);
```

### Avisos

O InterSdk tem o recurso de retornar avisos para o usuário.
Os avisos tem o objetivo de prever problemas futuros, por exemplo, se o certificado digital estiver próximo de expirar, o InterSdk vai gerar um aviso para isso.

```
InterSdk interSdk = new InterSdk(clientId, clientSecret, certificado, senha);
foreach (string aviso in interSdk.ListaAvisos()) {
    Console.WriteLine(aviso);
}
```

### Classes modelo

O InterSdk oferece classes de modelo para todos os dados enviados e recebidos.

Com essas classes fica fácil de saber quais dados e quais tipos de dados são utilizados em cada método.

Por exemplo, a consulta de saldo retorna um objeto do tipo Saldo:

```
public class Saldo {
    public double Disponivel;
    public double BloqueadoCheque;
    public double BloqueadoJudicialmente;
    public double BloqueadoAdministrativo;
    public double Limite;
    ...
}

Console.WriteLine("Saldo disponível: {0:F}", saldo.Disponivel);
```

Da mesma forma, ao emitir um boleto, precisamos enviar um objeto do tipo Boleto, que por sua vez, contém outros objetos, como o pagador e o beneficiário final que são do tipo Pessoa:

```
RespostaEmitirBoleto resposta = interSdk.CobrancaSdk().EmitirBoleto(boleto);

public class Boleto {
    // 
    //  REQUERIDO
    //  <p><Campo Seu Número do título</p>
    //      
    public string SeuNumero;
    // 
    //  REQUERIDO
    //  <p>Valor Nominal do título</p>
    //  <p>O valor nominal deve ser maior ou igual à R$2.50</p>
    //      
    public double ValorNominal;
    // 
    //  Valor de abatimento do título, expresso na mesma moeda do Valor Nominal
    //      
    public double ValorAbatimento;
    // 
    //  REQUERIDO
    //  <p>Data de vencimento do título</p>
    //  <p>Formato aceito: YYYY-MM-DD</p>
    //      
    public string DataVencimento;
    // 
    //  REQUERIDO
    //  <p>Número de dias corridos após o vencimento para o cancelamento efetivo automático do boleto. (de 0 até 60)</p>
    //      
    public int NumDiasAgenda;
    // 
    //  REQUERIDO
    //      
    public Pessoa Pagador;
    public Mensagem Mensagem;
    public Desconto Desconto1;
    public Desconto Desconto2;
    public Desconto Desconto3;
    public Multa Multa;
    public Mora Mora;
    public Pessoa BeneficiarioFinal;
    ...
}
```

Para alguns campos, que possuem um domínio definido, o InterSdk os define como enums. Exemplo:

```
.TipoPessoa(TipoPessoa.FISICA)

public enum TipoPessoa {
    FISICA,
    JURIDICA
}
```

Todas as classes, implementam o padrão Builder, facilitando a criação de objetos. Exemplo:

```
Boleto boleto = Boleto.Builder()
        .SetSeuNumero(seuNumero)
        .SetValorNominal(valor)
        .SetDataVencimento(dataVencimento)
        .SetNumDiasAgenda(0)
        .SetPagador(pagador)
        .Build();
```

## Projeto exemplo

### Código e documentação dos exemplos de uso do InterSdk

Disponibilizamos um projeto de exemplo nesse link: [demo-sdk-csharp.zip](/media/demo-sdk-csharp.zip). O objetivo dele é mostrar as funcionalidades do InterSdk, bem como a utilização e execução dos seus modelos e métodos.

Durante a execução dessa aplicação, algumas informações serão solicitadas e outra menos relevantes estão fixas no código.
