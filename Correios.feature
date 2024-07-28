Funcionalidade: Correios
	Para pesquisar um endereço
	Como usuário
	Eu quero poder pesquisar com um CEP

	Cenario: Pesquisar Endereço
		Dado que estou na página "https://www2.correios.com.br/sistemas/buscacep/buscaCepEndereco.cfm"
		Quando eu digito o CEP 807000000 no campo CEP correto
		E eu clico no botão "Buscar"
		Então eu recebo a mensagem "Dados não encontrado"
		E ao clicar no link "CEP ou Endereço"
		Então retorna para a tela inicial de busca CEP


	Cenário: Voltar a tela inicial de busca CEP
		Dado que ao estar na tela do CEP que não foi encontrado
		E clicar no link "CEP ou Endereço"
		Então retorna para a tela inicial de busca ao CEP
