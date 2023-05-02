<div>
  <h3> Links Úteis</h3>
 
   <ul>
    <li> <a href="https://github.com/SilasSousadeJesus/marlin-challenge-front-end">Repositório do front-end</a></li>
    <li> <a href="https://marlin-challenge-front-end.vercel.app/home">Clique e utilize o Deploy</a></li>
  </ul>
   <br>
  <h3> Requisitos do Negócio</h3>
 
   <ul>
    <li>HTML/CSS estático e responsivo de acordo com a imagem em anexo</li>
    <li>Projeto com Angular 9+ e Consumindo as informações com WebAPI (https://jsonplaceholder.typicode.com/posts).</li>
    <li>Uuma página para cadastrar novos post (noticias) e outra para o detalhe</li>
    <li>Não utilizar frameworks prontos como Bootstrap.</li>
  </ul>
   <br>

</div>

<div>
  <h2 >Tecnologias & Ferramentas utilizadas </h2>
  <div >
    <img src="https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white" >
    <img src="https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white" >
    <img src="https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white" >
    <img src="https://img.shields.io/badge/TypeScript-007ACC?style=for-the-badge&logo=typescript&logoColor=white" >
    <img src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white" >
    <img src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white" >
  </div>
</div>

  <br/>
  <h3>Para usar este projeto siga os seguintes passos: </h3>
  <ul >
    <li>Faça um git clone ou baixe manualmente o projeto.</li>
    <li> Abra o projeto no Microsoft Visual Studio. </li>
    <li> Procure o arquivo appsettings, dentro dele ache o item DataBase e coloque a sua string de conexão com o banco de dados.</li>
     <li>Procure o arquivo chamado Program, dentro dele ache o item options.WithOrigins e  coloque a url do seu front-end.</li>
     <li>No seu console de gerenciador de pacotes rode o comando: Add-Migration Initial-DB -Context MarlinDbContext.</li>
     <li>Por último,  rode o comando:  Update-Database -Context MarlinDbContext.</li>
     <li>Pronto, Api funcionando!</li>
  </ul>
