# Correios

## Projeto C#

Este é um projeto de Automação de Tela com BDD, no site dos correios.

##  Requisitos
 * Specflow v3.9+
 * NUnit framework v4.1+
 * Visual Studio 2022
 
## Como executar a aplicação 

Abra o Visual Studio e abra o projeto "Correios". Execute todos os testes.


## Casos de Testes

O arquivo "Correios.feature" possui todos os cenários descritos em linguagem Gherkin. Abaixo a lista de cenários:

1. Busca CEP 80700000
2. Voltar a tela inicial de busca CEP
3. Busca CEP 01013-001
4. Voltar a tela inicial
5. Rastreio com código


## Observação

Para criar a automação dos testes no site dos Correios, foi utilizada uma página antiga de busca de CEP em que não há atualização com campo Captcha. 

Infelizmente, a tela de rastreamento tem este campo Captcha, e não há uma versão sua "desatualizada" sem o mesmo.

Portanto. o cenário "Rastreio com código" não pode ser concluído conforme o solicitado. Conforme as boas práticas de automação, este tipo de campo não foi feito para ser automatizado.

Em casos de automação com sistemas desenvolvidos pela empresa, normalmente este campo é desabilitado.
