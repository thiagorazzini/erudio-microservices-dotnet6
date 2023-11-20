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


## Aplicações monolíticas
- Um único executável da aplicação
	- Fácil de compreender, mas difícil de assimilar(codigos diferentes para BD diferentes)
	- Deve ser escrito em uma única linguagem(utilizando uma única linguagem, limitamos que será criado uma única tecnologia sendo que partes dos sistema poderiam ser criadas com outra tecnologia que se adequasse a necessidade);
- **Modularização de acordo com linguagem ou framework;
	-  Limitamos nossa aplicação ás estruturas da linguagem ( se a aplicação for em java, limitamos em pacotes, classes, jars, wars, functions, namespaces, frameworks etc);
	- Vamos limitar também os serviços/tecnologias de armazenamento e serviços que estamos trabalhando
	- Exemplificando a situação monolitica, vamos imaginar uma necessidade de associar a uma aplicação microsoft sharepoint, no caso do monolítico em Java, não será capaz de realizarmos essa modificação, pois não permite que desenvolvemos o sistema com outra tecnologia e nesse caso, seria necessário o desenvolvimento com o .Net

- **Vantagens de um monolítico
	- Fácil de compreender(não de assimilar)
	- Fácil de testar como uma única unidade (até certo ponto);
	- Fácil de implantar como uma única unidade.
	- Fácil de gerenciar mudanças (até certo ponto);
	- Fácil de gerenciar mudanças(até certo ponto);
	- Fácil de escalar(se tomarmos os devidos cuidados,);
	- Complexidade gerenciada de acordo com as estruturas da linguagem.
- **Desvantagens
	- Preso em uma linguagem
		- A Aplicação estará presa em uma única stack, sem liberdade alguma para experimentar novas tecnologias
	- Assimilação
		- Um único desenvolvedor não consegue assimilar uma grande base de código
		- Uma única equipe não pode gerenciar uma única aplicação grande( Regra das 2 pizzas da amazon)
	- **Implantação como unidade única
		- Sem possibilidade de implantar novas features de forma independente
		- As mudanças são reféns de outas mudanças
## Entendendo uma arquitetura de microsserviço

Microserviços são sistemas pequenos e independentes criadas para áreas funcionais e individuais do sistema, quando precisam se comunicar entre sí, eles fazem isso através de protocolos abertos.

Como são relativamente pequenos, eles se conectam com 1 ou mais tecnologias de persistência e usam a linguagem e base de dados mais adequados para a regra de negocio

No atual senário, temos diversos dispositivos que trabalham como client e precisam consumir nossos servirços, pode gerar diversos problemas de comuniocação

Normalmente para lidar com esse problema, temos o API Gateway, ele serve para facilitar as interfaces para serem consumidas pelo client e lidar com toda a complexidade apresentanda pelo consumo de API do lado do servidor
API Gateway  pode lidar tbm com caches, autenticação entre outros.

 ![[Pasted image 20231118181958.png]]
## Componentização por meio de serviços

Quando desenvolvemos uma aplicação com serviços separados e sem usar a estrutura de uma linguagem especificas, criamos aplicações independentes ou pequenas aplicações que podem ser implantadas independentemente.

Quando quebramos uma aplicação dessa, devemos ser cautelosos e disciplinados na hora de estruturar suas interface, não podemos negligenciar e colocar tudo em uma única aplicação.  Além disso, qualquer alteração na aplicação, devemos ter como escopo o serviço afetado. 
![[Pasted image 20231119100630.png]]

Exemplificando: Quando queremos realizar uma alteração no escopo de Payment, não deveriamos estar preocupado se a alteração de Catalog esteja pronta, não precisamos nos preocupar com branchs, versões, feature toggles entre outros.


Como microsserviços são independentes e são implantados independente de outros serviços, cada serviço pode ser implementado com outras linguagens ou frameworks.

Microsserviços se comunicam através de protocolos abertos, bem como HTTP, UDP, TCP além das tecnologias de mensageria como AMQP, RABBITMQ. Os content types sãoo abertos e podemos usar o JSON, XML, Google Protocol buffers ou qualquer tecnologia interessante.

## Objetivo principal dos microsserviços

O intuito de microsserviços é encapsular  funcionalidades de negocios,  diferente das aplicações monolíticas onde encapsulamos funcionalidades técnicas(separada em camadas: DAO, Repository, Controller) e em microsserviços fatiamos a camada da aplicação em funcionalidade ou regra de negocio.
Tudo relacionado em pesquisa, vai para o serviço de pesquisa, tudo relacionado a carrinho, vai para o serviço de carrinho e ainda podemos ter serviços puramente técnico, como por exemplo o serviço de e-mail. Nos microsserviços  podemos ter os DAOS e CONTROLLERS dentro do microsserviço.


A ênfase dos microsserviços é a separação em serviços independentes de acordo com  as regras de negócios, e isso é perceptível quando olhamos para o serviço e enxergamos que ele está focado em uma pequena ou em uma microparte da operação.
![[Pasted image 20231119102246.png]]
Olhando para a imagem acima, podemos enxergar que o carrinho tem suas próprias operações e se colocarmos um checkout, teríamos um microsserviço somente para as operações de checkout

- Microsserviços são de fácil gerenciamento, compreensão e o desenvolvedor que entrar no primeiro dia, já pode realizar operações no código
- Um time pequeno ou um time de um homem só, pode realizar diversas operações no código, como por exemplo: refatorar, testar e até mesmo reescrever o microsserviço com uma tecnologia diferente.
- De Ponto de vista de equipes tem mais flexibilidade, por exemplo: uma equipe  que faz os códigos de pesquisa, tem uma atenção mais focada e então trabalha só nele, já o time de reviews e carrinho o trabalho é menor, então essa equipe divide a atenção em dois serviços.
![[Pasted image 20231119103348.png]]

## Governança Descentralizada
- Podemos realizar o desenvolvimento do  serviço em linguagem diferente, velocidades de desenvolvimento e implantação em fases ou ritmos diferentes;
- Devemos respeitar alguns princípios, como Tolerant Readers(Relativamente resiliente as mudanças do serviço que consomem, portanto, caso um novo atributo for adicionado num objeto json, não se deve causar uma falha) por outro lado, devemos tratar a exposição de interfaces por qualquer serviço como um contrato escrito com as necessidades do consumers e com isso devemos pensar como será consumido e como vai afeta-los
- Os serviços não ser orquestrados, mas sim coreografados 
	- Imaginando um trafego de carros, temos  regras e sinalizadores para os carros não baterem, como por exemplo: semáforo, placas e faixas pintada no chão como pare, pedestre, de a preferência  entre outros
	- Ja com os pedestres, notamos uma coreográfia, onde vemos os pedestres regulando a velocidade da passada, parando conforma  necessidade entre outros.
- Nossos microssistemas individuais devem se comportar como um pedestre


## Persistência Poliglota

É a liberdade para usar a ferramenta mais adequada para cada serviço (depende de como está distribuído as responsabilidades da organização )
- Em algumas organizações, DBA'S não gostam desse modo de trabalho, porque preferem ter mais controle do que está sendo realizado e com isso optam por centralizar em uma unica fonte de dados relacional