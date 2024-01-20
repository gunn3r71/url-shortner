<h1>URL SHORTNER</h1>

<h2>O que é?</h2>

<p>É um serviço que tem como objetivo fornecer ao usuário uma forma simples e performática 
de encurtar URLs longas e torná-las compactas e fáceis de compartilhar.</p>

![]([https://giphy.com/embed/33zX3zllJBGY8])

<h2>Tecnologias utilizadas: </h2>
<ul>
  <li>API: A API foi construída em .NET 8, utilizando os recursos de minimal API</li>
  <li>Front-End: Nosso front-end utiliza de angular e bootstrap para permitir o cadastro e redirecionamento da URL encurtada</li>
  <li>Cache: Utilizamos redis para armazenar temporariamente as URL's encurtadas, otimizando o tempo de resposta da API</li>
  <li>Banco de Dados:  Utilizamos MongoDb como armazenamento de longa duração das URL's encurtadas. Optamos por um banco NoSQL pela velocidade e complexidade reduzida ao resgatar dados na API.</li>
  <li>Docker: Toda nossa aplicação roda com containers. É extremamente fácil de testar localmente</li>
</ul>

<h2>O que preciso para fazer funcionar?</h2>

<p>Para rodar a solução só é necessário ter o docker e o docker-compose instalado! (Super simples, não?)</p>

![]([https://giphy.com/embed/3oEjI6hkw6nbYNQkz6])

