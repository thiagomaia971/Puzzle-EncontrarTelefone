#language: pt-BR

Funcionalidade: Converter uma frase em um número telefonico
	Para que possa ligar para este numero
	Eu, como usuário
	Desejo converter a frase.

Cenário: Converter todas as letras para os correspontes números
	Dado Eu tenha passado a frase
	E  Que o programa tenha mapeado as letras
	Quando Eu executar o programa
	Então O resultado será o número telefone correspondente a frase.
