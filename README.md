## O que são Microsserviços ?

Microsserviços são melhor definidos como um estilo arquitetural, diferente do sistema monolítico onde a aplicação é desenvolvida  como um conjunto só (um grande objeto que não pode ser desacoplado) a arquitetura de microsserviços é criado em partes, onde cada pequeno conjunto de serviços são executados como um processo independente e cada um se comunica com outro através de um protocolo.

Em resumo, microsserviços é uma aplicação desenvolvida  com conjuntos menores, cada um microsserviço tem seu próprio processo e executa de forma independente. A comunicação é realizada com meios abertos ou amplamente conhecidos como Http e REST.

Microserviços são escritos, implantados, dimensionados e mantidos separadamente e isso possibilita o desenvolvimento em diferentes linguagem para cada microserviço. Eles são usados para encapsular funcionalidades do sistema ou  melhor dizendo, regras de negócios.

Os serviços pode ser desenvolvidos e atualizados de forma independente.

## O que microsserviços não são ?

Microsserviços não são arquitetura orientada a serviços, embora tem uma similaridade, SOA diz respeito a integração de várias aplicações corportativas, enquanto microsserviços são a decomposição de uma unica aplicação em múltiplas aplicações menores e trabalhando em conjunto.

O microsserviço não é uma bala de prata, não é possível resolver todos os problemas com esse tipo de arquitetura, na verdade em alguns casos, utilizar microsserviços podem gerar mais problemas do que solução.

Microsserviços não é uma novidade, existem muitas aplicações onde ocorre a execução em processos separados independentes e se comunicando entre si.


## Entendendo como as aplicações monolíticas funcionam
Aplicação de carrinho de compras monolítico:
Usando  no formato de bolo em camadas, teríamos a conexão de banco de dados tradicional. Primeiro teríamos uma camada de DAO'S (Que seria o repository) se comunicando com o BD e lidando com a persistência, camada de serviços para os casos de uso e por fim uma camada de controller para gerenciar os acesso via clients ou web browsers.

![[Pasted image 20231117072944.png]]

- Na estrutura monolítica é um desenvolvimento  que teríamos  diferentes tipos de controllers para cada parte da aplicação.
- A camada de serviços tenta modelar a  camada de casos de uso, onde é criado métodos de pesquisa, catalogo, feedback.
- Camada DAO se assemelha com o modelo de dados, conforme está estruturada no modelo de banco de dados, temos objetos DAO para cada tabela. Portanto temos DAOS para cliente, cartão de crédito, Itens dentre outros