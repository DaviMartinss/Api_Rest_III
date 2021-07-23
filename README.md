# API_REST/OBS
**Descrição** </br>
Nessa  API foi implementado um sistema de gerenciamento de um Supermercado e tal  api possui as seguintes funcionalidades: CRUD( Quatros funções básicas de um sistema que
trabalha com banco de dadoas) do Usuário, Produto e Categoria. Além disso, foi utilizado injenção de dependencias, mapeamento, direcionamentos das rotas do banco de dados,
tokens de autenticação e padrões de projetos, como Unit Of Work e Request/Response.

# Sumário
<ul>
  <li><a href = "#Maquina"> Configuração de Máquina</a></li>
  <li><a href = "#VsCode"> Configuração do VS Code</a></li>
  <li><a href = "#rota"> Rotas</a></li>
  
 </ul>
 
<h1 id="Maquina"> Configuração de Máquina</h1>

Para realizar a execução desse projeto na sua máquina é necessário que você realize a instalação do [.Net 5.0 SDK](https://dotnet.microsoft.com/download/visual-studio-sdks),  [PostgreSQL 12](https://www.enterprisedb.com/downloads/postgres-postgresql-downloads) e do [POSTMAN](https://www.postman.com/downloads/).  
OBS: Se o Visual Studio estiver instalado na sua máquina, é recomendado atualiza-lo ou desinstala-lo antes da instalação do SDK.

 <h1 id="VsCode"> Configuração do VS Code</h1>
<ul>
  <li><a href="https://www.nuget.org/packages/AutoMapper/10.1.1">AutoMapper</a></li> 
  <li><a href="https://www.nuget.org/packages/AutoMapper.Extensions.Microsoft.DependencyInjection/6.0.0?_src=template">AutoMapper.Extensions.Microsoft.DependencyInjection</a></li>
  <li><a href="https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/3.1.12">Microsoft.EntityFrameworkCore</a></li>
  <li><a href="https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Abstractions/3.1.12">Microsoft.EntityFrameworkCore.Abstractions</a></li> 
  <li><a href="https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Analyzers/3.1.12">Microsoft.EntityFrameworkCore.Analyzers</a></li> 
  <li><a href="https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.InMemory/3.1.12">Microsoft.EntityFrameworkCore.InMemory</a></li>
  <li><a href="https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Relational/3.1.12">Microsoft.EntityFrameworkCore.Relational</a></li>
  <li><a href="https://www.nuget.org/packages/Newtonsoft.Json/12.0.3">Newtonsoft.Json</a></li>
  <li><a href="https://www.nuget.org/packages/Swashbuckle.AspNetCore/5.6.3">Swashbuckle.AspNetCore</a></li>
  <li><a href="https://www.nuget.org/packages/System.IdentityModel.Tokens.Jwt/6.8.0">System.IdentityModel.Tokens.Jwt</a</li>
  <li><a href="https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer/3.1.12">Microsoft.AspNetCore.Authentication.JwtBearer</a></li>
  <li><a href="https://www.nuget.org/packages/Npgsql/4.1.3">Npgsql</a></li>
  <li><a href="https://www.nuget.org/packages/Npgsql.EntityFrameworkCore.PostgreSQL/3.1.3">Npgsql.EntityFrameworkCore.PostgreSQL</a></li>
  <li><a href="https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/3.1.11">Microsoft.EntityFrameworkCore.Design</a></li>
  <li><a href="https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp">C#</a></li>
  <li><a href="https://marketplace.visualstudio.com/items?itemName=jchannon.csharpextensions">C# Extensions</a></li>
  <li><a href="https://marketplace.visualstudio.com/items?itemName=k--kato.docomment">C# XML Documentation</a></li>
  
</ul>

### Rodando o Projeto
Abra o PgAdim 4, no Visual Studio Code, abra o terminal e digite o seguinte comando: dotnet ef database update. Após digitar tal comando o banco de dados da aplicação deverá está no PgAdim, caso contrário verifique o Server e a port.
    <ul>
        <li> Execução pelo terminal do Visual Studio Code: Abra o Terminal, entre na pasta da aplicação, e por último, digite o seguinte comando: dotnet run.
        <li> Abra o Postman e importe o arquivo api_rest.postman_collection.json que está na pasta api_Rest Postman. Em seguinda, dentro do POST USER você terá que enviar uma requição com o a api em execução. Tal requição irá gerar um token que será usado em todas as requisições feitas nas demais rotas, mas antes você deverá ir no campo de Authorization e em value faça a substituição pelo o token atual.
    </ul>

<h1 id="rota"> Rotas Para o Direcionamento</h1>
 <ul>
   
   <li>  POST </li>
   <ol>
     <li> Category:  https://localhost:5001/api/category</li>
     <li> Product:  https://localhost:5001/api/product</li>
     <li> User:  https://localhost:5001/api/User</li>
   </ol>
  
   <li>  PUT </li>
   <ol>
     <li> Category:  https://localhost:5001/api/category/[ID DA CATEGORIA]</li>
     <li> Product:  https://localhost:5001/api/product/[ID DO PRODUCT]</li>
     <li> User:  https://localhost:5001/api/User/[ID DO USUARIO]</li>
   </ol>
  
   <li>  GET </li>
   <ol>
     <li> Category:  https://localhost:5001/api/category</li>
     <li> Product:  https://localhost:5001/api/product</li>
     <li> User:  https://localhost:5001/api/User</li>
   </ol>
   
   <li>  DELETE </li>
   <ol>
     <li> Category:  https://localhost:5001/api/category/[ID DA CATEGORIA]</li>
     <li> Product:  https://localhost:5001/api/product/[ID DO PRODUCT]</li>
     <li> User:  https://localhost:5001/api/User/[ID DO USUARIO]</li>
   </ol>
 </ul
