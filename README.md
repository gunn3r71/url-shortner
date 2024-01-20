<h1>URL SHORTNER</h1>

<h2>O que é?</h2>

<p>É um serviço que tem como objetivo fornecer ao usuário uma forma simples e performática 
de encurtar URLs longas e torná-las compactas e fáceis de compartilhar.</p>

<iframe src="https://giphy.com/embed/33zX3zllJBGY8" width="480" height="382" frameBorder="0" class="giphy-embed" allowFullScreen></iframe>

<h2>Tecnologias utilizadas: </h2>
<ul>
  <li>API: A API foi construída em .NET 8, utilizando os recursos de minimal API</li>
  <li>Front-End: Nosso front-end utiliza de angular e bootstrap para permitir o cadastro e redirecionamento da URL encurtada</li>
  <li>Cache: Utilizamos redis para armazenar temporariamente as URL's encurtadas, otimizando o tempo de resposta da API</li>
  <li>Banco de Dados:  Utilizamos MongoDb como armazenamento de longa duração das URL's encurtadas. Optamos por um banco NoSQL pela velocidade e complexidade reduzida ao resgatar dados na API.</li>
  <li>Docker: Toda nossa aplicação roda com containers. É extremamente fácil de testar localmente</li>
</ul>

<div style="width:480px"><iframe allow="fullscreen" frameBorder="0" height="270" src="https://giphy.com/embed/lu01tsQqf1mJuHrFVq/video" width="480"></iframe><a href="https://giphy.com/channel/originals" rel="noopener noreferrer" style="clear:both;display:inline-block;height:36px;line-height:18px;margin:10px 0;padding:0 0 0 44px;position:relative" target="_blank"></div>

<h2>O que preciso para fazer funcionar?</h2>

<p>Para rodar a solução só é necessário ter o docker e o docker-compose instalado! (Super simples, não?)</p>

<iframe src="https://giphy.com/embed/3oEjI6hkw6nbYNQkz6" width="480" height="269" frameBorder="0" class="giphy-embed" allowFullScreen></iframe>

