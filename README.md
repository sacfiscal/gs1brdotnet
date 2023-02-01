# GS1BrDotNet
## Biblioteca de consulta GTIN na api GS1Br

![Badge](https://img.shields.io/static/v1?label=csharp&message=language&color=blue&style=for-the-badge&logo=csharp)
![Badge](https://img.shields.io/static/v1?label=.net6&message=framework&color=blue&style=for-the-badge&logo=.net)

[![Nuget count](https://img.shields.io/nuget/v/gs1brdotnet)](https://www.nuget.org/packages/Gs1BrDotNet/2022.8.1)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

## Sobre o projeto 
  Este projeto é uma biblioteca que auxilia a consulta de GTIN na api GS1Br(https://www.gs1br.org/).

Este projeto é mantido utilizando a linguagem CSharp com .Net Standard e tem o projeto de exemplo validando os resultados. 

## Recursos

- Consulta e validação de GTIN an api da GS1Br

Para consumir a API GS1Br é necessário fazer a associação para obter as credencias.

## Utilização
```sh
ConsultaGtin consulta = new ConsultaGtin();
RetornoConsultaGtinGs1Br retornoGtin = consulta.ConsultarGtin("07896412802546", retorno);
Product produto = retornoGtin.product;
Console.WriteLine($@"Produto: {produto.LerDescricao()}
{produto.LerUrlFoto()}
{produto.LerMarca()}
{produto.LerClassificacaoGPC()}
{produto.LerNCM()}
{produto.LerCEST()}
{produto.LerEmbalagem()}");
```

## Suporte
<img src="https://www.sacfiscal.com.br/biosac64.png">
Nossa empresa é especializada em suporte técnico e tributário para software houses.
Acesse: https://www.sacfiscal.com.br

| Tecnologias | Frameworks |
| ------ | ------ |
| C# | ZeusDFe <https://github.com/ZeusAutomacao/DFe.NET> UniNFe <https://github.com/Unimake/DFe> OpenAC <https://github.com/OpenAC-Net> |
| Delphi | ACBr <https://projetoacbr.com.br/> |
| Lazarus | ACBr <https://projetoacbr.com.br/> |
| PHP | SPEDNFe <https://github.com/nfephp-org/sped-nfe> |


## Curso de Arquitetura Fiscal em Software
ARQUITETURA FISCAL EM SOFTWARE <https://www.arquiteturafiscal.com.br>
<br>O mais completo treinamento de tributação e regras fiscais para programadores e software houses

## Licença

GPL
