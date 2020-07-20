	INSERT INTO public.funcionarios(
		ativo, nome, email, 
		telefone, endereco, data_nascimento, 
		tipo_pessoa, observacoes, dados_bancarios, cpf, 
		rg, rg_local_expedicao, rg_data_expedicao, 
		inscricao_estadual, inscricao_municipal, escolaridade, 
		ocupacao, pais_natal, estado_natal, 
		cidade_natal, nome_pai, nome_mae, 
		estado_civil, matricula, ctps, 
		nis, admissao)
	VALUES (
		true, 'Administrador', 'admin@admin.com', 
		'3198887766', '{ "logradouro" : "Rua administradora", "numero" : "Rua administradora", "bairro" : "administradora" }', '01/01/2000', 
		2, 'Adminstrador do sistema', '{ "banco" : "000", "agencia" : "0001", "conta" : "0000000-1" }', '00000000191', 
		'000000000000-0', 'RJ', '01/01/2000', 
		'00000000', '0000000', 'Ensino Medio', 
		'Administrador do Sistema', '1058', 'MG', 
		'Belo Horizonte', 'Administrador Pai', 'Adminstrador Mãe', 
		1, '0001', '000000', '
		000000000000', '{ "data" : "01/10/2000", "registro" : "0001", "ferias" : "01/11/2000"}');