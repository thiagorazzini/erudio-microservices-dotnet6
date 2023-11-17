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
- Camada DAO se assemelha com o modelo de dados, conforme está estruturada no modelo de banco de dados, temos objetos DAO para cada tabela. Portanto temos DAOS para cliente, cartão de crédito, Itens dentre outros.

## Os desafios das aplicações monolíticas

Quando as applicações web foram difundidas, o número de dispositivo que acessava a aplicação era limitado, hoje o cenário está diferente, temos smartphones,  video games, smartwatch dentre outras aplicações.
Os controllers não eram desenvolvidos para suportar novos clients.
- Outro ponto é que hoje temos diferentes tipos de banco de dados com desempenho  muito superior.
-  Podemos ter diferentes bancos de dados para se conectar ao sistema, cada banco pode ser utilizado de acordo com a necessidade que vai surgindo, por exemplo, podemos usar um banco de dados NO SQL como mongo DB para acessar o método de busca e o redis onde usamos chave e valor para armazenar as informações de carrinho de compras.
-  Com a evolução da tecnologia, não utilizamos somente o banco de dados para acessar e salvar informações, usaremos diversas outras aplicações para isso.
- ![[Pasted image 20231117074754.png]]

- Uma aplicação monolítica tem somente uma única base de código
- Por ser uma base pequena é muito mais fácil para um unico time implementar features;
- Facil de gerenciar codigos com git ou svn
- Fácil de implementar um pipeline de entrega continua;
- Problemas: Quando se torna necessário a entrega de features novas numa velocidade consideravelmente rápida, vamos precesidar de uma equipe maior e será gerado uma grande base de código e isso dificulta o gerenciamento.
![[Pasted image 20231117075450.png]]

- Para gerenciar uma equipe grande desse tipo, devemos realizar a divisão dos times, manter cada um com sua base de código separadas e cada um responsável por suas entregas de features.
- Para essa abordagem temos a necessidade de um time responsável para realizar o merge, juntar as peças de cada modulo independentes e rodar a integração de entrega contínua;
- O problema encontrado nesse modo de trabalho é que um bug é descoberto nos testes de aceitação de usuário e não podemos implementar a aplicação.


![[Pasted image 20231117080243.png]]


