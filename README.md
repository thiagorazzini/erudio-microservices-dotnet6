<h3>O que são werbservices ?</h3>


Webservices são aplicações que compartilham informações entre outas e é hospedada em um servidor onde ela pode ser acessada através do protocolo HTTP. Os clientes que são mais comummente usados como meio de acesso com o protocolo HTTP são os browsers, mas também pode ser feita requisições através de um browser, de um client e até mesmo por linha de comando (powershell ou linux). 

<h4>Simplificando a explicação</h4>

Webservices são somente legíveis por maquinas ou por outros sistemas, usando um exemplo do dia a dia:

Um carro corsa utiliza o filtro de ar do modelo A47b, então esse mesmo filtro pode ser reaproveitado para outo modelo de carro como por exemplo o Cruze. É a ideia de reutilização do services  e usando essa ideia em desenvolvimento de software, teremos a seguinte ideia:
Imagine o desenvolvimento de uma aplicação webservice que faça a busca e validação do CPF, uma aplicação desktop pode usar essa aplicação para esse tipo de ação, da mesma forma que uma aplicação mobile pode fazer o mesmo. Tudo isso acontece utilizando o HTTP!


<h4>SOAP x REST</h4>
Diferenças de protocolo entre elas:
 - SOAP utiliza o HTTP para fazer chamadas RPC trafegando XML
 - REST utiliza o HTTP para fazer as chamadas e suporta diferentes formatos de arquivo

![image](https://github.com/thiagorazzini/Microservices_dotNet/assets/30513646/9233702d-50a6-4140-ad47-545dcb765e2a)

<h4>O que é REST ?</h4>
Estado representacional de transferência

REST tem suas restrições, são elas:

![[Pasted image 20231105170601.png]]

Vantagens de utilizar o REST
![[Pasted image 20231105170830.png]]


<h4>Entendendo  Request e Response</h4>
Para entender o request, vamos pegar o exemplo de um uso diário que é a utilização do Chrome, quando  executamos o uso para acessar um site, realizamos  o HTTP request  e o servidor vai até a base de dados, faz a ação de acordo com o verbo http que foi realizado o request e devolve utilizando utilizando o HTTP response.
![[Pasted image 20231105171656.png]]


Represetando uma request:
![[Pasted image 20231105171823.png]]

Representando o response:
![[Pasted image 20231105171900.png]]

<h4>Os tipos de parâmetros usados no REST</h4>

<strong>Paths params:</strong>
Parâmetros que são passados pela URL e que são obrigatórios, caso não exista esses parâmetros será lançado uma exceção ou fará um operação similar mas que utiliza o mesmo verbo.

Exemplo

![[Pasted image 20231106075939.png]]

podemos entender nessa URL a existência de 3 parâmetros na busca de livros:
1 - asc: Ordenação crescente do nome dos livros;
2 - 10: 10 itens por página;
3 - 1: Index da página acessada

<strong>Query params:</strong>

Parâmetros passados por URL  mas não obrigatórios, então iniciamos a URL como já conhecido e colocamos um ponto de interrogação,  após a interrogação inserimos os parâmetros desejado

![[Pasted image 20231106080349.png]]

Entendendo os parâmetros, ficaria assim:
- firstName=Clean: primeiro colocamos o nome do parâmetros, depois o sinal de atribuição e em seguida o valor.
- Para colocar mais parâmetros, devemos inserir o & e repetir nome do parâmetro, sinal de atribuição "=" e o valor do parâmetro

<h4>Header Params</h4>
São enviados no cabeçalho da requisição, eles não podem ser enviados via browser, devemos utilizar um client(postman), nele podemos colocar algumas keys como tipo de arquivo(Accept), Content-Type, Authorizathion.


![[Pasted image 20231106081056.png]]

<h4>Parâmetros do body</h4>
São usados para envio de informações completas, podendo ser enviado via JSON e entre vários outros formatos aceito pela API REST  .

Exemplo utilizando JSON:
![[Pasted image 20231106081226.png]]

<h4>HTTP Status Code</h4>
Aqui podemos encontrar o retorno da ação realizada, para verificar o que aconteceu depois da demanda ser executada:

São 5 tipos de status code:
![[Pasted image 20231106082038.png]]


Status code 2xx Sucesso muito utilizados:
![[Pasted image 20231106082147.png]]

Status code 4xx Erro do client:
![[Pasted image 20231106082403.png]]

400: Retornado quando o client envia um request que não existe
401: sem autorização
403: Client não tem autorização para aquele endpoint 
404: Retornado quando o endpoint não é encontado

<strong>HTTP Status Codes em Serviços REST</strong>


Destacando os mais vistos no dia a dia

200 OK - Criação ou deleção executada com sucesso
201 Created: Criação de uma fila, tópico ou qualquer coisa que será executada posteriormente para ser executada/consumida
204 No content: Deleção de uma fila, tópico, sessão bem sucedida mas sem retorno de conteúdo

400 Bad Reques: Client faz endereço errado, ou uma busca de Id que não existe mais ai retorna um bad request.
401 Unauthorized: Cliente sem autorização para executar a requisição na operação em questão.
403 Forbiden: Não tem permissão para executar a requisição em questão.
404 Not Found: Não encontrado o item que foi buscado pois o objeto não existe
405 Mathod Not Allowed - O usuário não tem permissão de acesso que foi submetido
409 Conflict: Ja existe o objeto criado e voce esta tendando criar o mesmo objeto


500 Internal Erro de Server: Ocorreu um erro de execução no servidor

<h4>Os verbos HTTP eo REST</h4>
POST -> criação de objetos

GET -> Buscar o Objeto

PUT -> Atualizar o objeto

DELETE -> Remover o recurso

![[Pasted image 20231106083538.png]]


<strong>GET</h4>

Usado para recuperar um recurso, quando temos sucesso  recuperamos uma representação do objeto em formato XML ou JSON  + HTTP 200(OK). Quando da erro ele retorna 404(not found) ou 400(Bad Request).

Suporte parâmetros via URL (PATH ou QUERY) ou via HEADER. Ele é o unico verbo que não aceita o parâmetros vida BODY.

<strong>POST - CREATE</post>
É o mais utilizado para criar novos recursos e inserir um novo item na base

Na hora de sucesso devemos retornar o status code 200 ou 201

Suporta parâmetros:
- Via URL(PATH ou Query)
- Via Header
- Via Body
Recomendação de uso é sempre passar parâmetros para o BODY na hora de utilizar o POST

<strong>PUT - UPDATE</strong>

É comumente usado para realizar atualizações, usando os parâmetros de body, inserimos no campo as informações coletadas substituindo as informações desejadas. Geralmente usamos o ID como chave primária a ser mantida e alteramos todo o resto.

Um update bem sucedido retorna status code 200 ou 204 quando não é necessário retorna nenhum conteúdo no Body.

É bom retornar as alterações no body, para melhor visualização do que foi alterado.

Isso tudo depende da arquitetura definida.

Suporta parâmetros:
- Via URL(PATH ou Query)
- Via Header
- Via Body -> De preferência 

<strong> Delete - Remove</strong>

Como é sugestivo, ele serve para deletar um recurso, e em uma deleção bem sucedida deve ser retornada 200(ok) e um response do body (representação do item removido, que acaba consumindo mais banda) ou um response customizado.

Recomendação melhor é retornar um 204 no content.

Suporta parâmetros:
- Via URL(PATH ou Query) -> De preferência passando para PATH
- Via Header
- Via Body 
<h4>Outros verbos menos conhecidos</h4>
<strong>Patch</strong>

O verbo é utilizado para realizar updates parciais. Como por exemplo a alteração apenas de um campo em um recurso, invés de executar o POST com todo o seu conteúdo, gerando mais consumo de banda, usamos o PATCH para realizar a alteração do conteúdo sem consumir tanta banda da API.

<strong>Contras</strong>
Use com moderação pois pode ter colisões com múltiplas PATCH request, porque ele exige que o cliente tenha informações básicas do recurso, caso ao contrário podemos corromper o recurso.

<strong>HEAD</strong>
Serve para a mesma função do patch, porém o servidor retorna um response line e headers, mas não retorna um entity-body.

<strong>Trace</strong>
Usado como recuperador de conteúdo de uma requisição HTTP de volta podendo ser usado com o propósito de debug durante o processo de desenvolvimento.

<strong>Options</strong>
Serve para listar as operações HTTP suportadas pelo servidor. O Cliente pode especificar na URL o ponto que você quer ver para o verbo OPTIONS ou um * para refletir em todo o servidor.

<strong>Connect</strong>
Verbo usado para estabelecer uma conexão entre o servidor e o Client HTTP.

<h4>Níveis de maturidade de Richardson</h4>
Existe 4 níveis de maturidade para  classificar a maturidade do REST, sendo o RESTFull  o mais alto de maturidade. Sua API pode ser REST mas não ser RESTFull, porém todo RESTFull é REST, para que ser RESTFull a api deve atender os 4 níveis de maturidade da escala Richardson

![[Pasted image 20231108073520.png]]


nível 0: Pantano de XML -> Todas as ações da api esta atrelado em apenas 1 endpoint e a única coisa que separa para ele ser um REST é que ele utiliza o HTTP para trafegar o JSON ou XML.

Nível 1: Separação de Recursos -> Temos um endpoint para cada ação desejada e está mais organizado, porém não tem uma preocupação de usar os verbos adequados para realizar as ações, somente GET e POST.

Nível 2: Uso do verbo HTTP -> Já existe uma preocupação do uso correto dos verbos, ele pega tudo que há de bom no nível 1 e incrementa mais  detalhes.

Nível 3: Uso de Hypermedia contros -> Acessar a listagem em um objeto que contém verbos HTTP dentro de objetos.

Se a arquitetura REST não estiver orientada ao hipertexto, não poderá ser considerada uma APIRESTful por completo.

<h4>HATEOS</h4>
É a prática onde desenvolvemos hyperlinks dentro das APIs que permite realizar a nevageação entre os endpoints de forma dinâmica, visto que incluí links as respostas.Na prática,  a API retorna informações que o client irá precisar para realizar os proximos passos.


Podemos ver que nesse exemplo abaixo, tivemos um retorno do recurso com links dos endpoinsts para executar  proxima ação se desejar.

![[Pasted image 20231108074449.png]]
