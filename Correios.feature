Funcionalidade: Correios
	Para pesquisar um endereço
	Como usuário
	Eu quero poder pesquisar com um CEP

	Cenário: Busca CEP 807000000
		Dado que ao acessar o site "https://www2.correios.com.br/sistemas/buscacep/buscaCepEndereco.cfm"
		Quando eu digito o CEP 807000000 no campo CEP correto
		E eu clico no botão "Buscar"
		Então eu recebo a mensagem "Dados não encontrado"


	Cenário: Voltar a tela inicial de busca CEP
		Dado que ao acessar o site "https://www2.correios.com.br/sistemas/buscacep/buscaCepEndereco.cfm"
		E eu digito o CEP 807000000 no campo CEP correto
		E eu clico no botão "Buscar"
		E eu recebo a mensagem "Dados não encontrado"
		Quando clicar no menu "CEP ou Endereço"
		Então retorna para a tela inicial de busca ao CEP


	Cenário: Busca CEP 01013001
		Dado que ao acessar o site "https://www2.correios.com.br/sistemas/buscacep/buscaCepEndereco.cfm"
		Quando eu digito o CEP 01013001 no campo CEP correto
		E eu clico no botão "Buscar"
		Então eu vejo na tabela de resultados "Rua Quinze de Novembro - lado ímpar"

	
	Cenário: Voltar a tela inicial
		Dado que ao acessar o site "https://www2.correios.com.br/sistemas/buscacep/buscaCepEndereco.cfm"
		E eu digito o CEP 01013001 no campo CEP correto
		E eu clico no botão "Buscar"
		E eu vejo na tabela de resultados "Rua Quinze de Novembro - lado ímpar"
		Quando clicar no logo dos Correios
		Então retorna para a tela inicial do site dos Correios

	
	Cenário: Rastreio com código
		Dado que ao acessar o site "https://rastreamento.correios.com.br/app/index.php"
		E digitar o código de rastreamento "SS987654321BR"
		Quando eu clico para consultar rastreio
		Então retorna uma mensagem informando "Preencha o campo captcha"
		E fechar a aba do browser