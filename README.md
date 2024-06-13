## inter-sdk-csharp

### Atualização
O SDK C# é gerado pelo inter-sdk-converter.

O inter-sdk-converter converte o SDK java para C#.

Os fontes gerados pelo conversor não são adicionados ao git desse projeto. No caso de alterações/evoluções das APIs, os fontes do java deverão ser ajustados e então o SDK do C# deverá ser regerado e recompilado.

Para atualizar o projeto com os fontes convertidos:

```
make update
```

### Compilação com o mono
```
make clean
make
```

### Compilação com o dotnet core
```
dotnet build
```

Nesse projeto a compilação é apenas para verificar se deu algum problema na conversão. O projeto inter-sdk-csharp será compilado como dependência durante a compilação do demo-sdk-csharp.

