## Padrão de projeto VO(Value Object)

Utilizando o VO temos maior segurança, sem o VO, estamos expondo a mesma entidade que representa a mesma estrutura do banco, isso deixa os nossos clientes saberem exatamente como é o nosso banco.

O VO é uma estrutura intermediária responsável pela expoxisão dos nossos dados.
- Utilizando o POST sem o VO, mandamos um JSON que representa a entidade
	- Na prática, os clients não saberão a forma que é a entidade
- Enviamos um VO no body, podendo ser diferente da entidade (podendo ter atributos com mais ou menos atributos)
- Após chegar na nossa API, o VO é processado numa classe adpter e transforma o VO para uma entidade que será persistida na base de dados;
- A persistência é feita no repositório, que pega a entidade e grava no banco de dados


- Utilizando o GetById, fazemos o caminho inverso, 
	- Os dados saem do banco de dados e se transforma em uma entidade
	- A entidade passa pelo service(addapeter) e se transforma em um VO 
	- Que por sua vez retorna o VO para o controller e o controller é enviado para o client


***Vantagens de usar um VO
- O Client só conhece o VO e não tem conhecimento das entidades, assim protegemos os dados
- Uma entidade pode ter um atributo como "NomeCompleto" e o VO pode separar isso com FirstName e LastName
- A lógica pode ser diferente também, no banco pode estar Firstname,Lastname e no VO estar como NomeCOmpleto tudo junto
- Facilita o versionamento dos Endpoints
	- Por exemplo, inserimos o Nome da mãe no banco de cadastro
		- Caso não seja alterada o que estamos passando no endpoint, podemos quebrar a aplicação nos pontos que utilizamos a entidade de cadastro
		- Com o VO, podemos utilizar o versionamento do endpoint e expor essa informação para os clients que desejarmos.
- O VO cria uma transparência para os clients e além de encapsular as informações da base de dados.