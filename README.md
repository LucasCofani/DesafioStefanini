# DesafioStefanini

Respositorio com base na proposta do <a href="https://github.com/Adenilsonlj/desafio_backend_stefanini">Desafio</a>.

Possui uma versão com o Front-End em Blazor (DesafioStefanini\Client) e uma versão em Angular (AngularClient).

Para executar é necessario ter os sequintes requisitos:
- Dotnet 6.1;
- Docker com ambiente linux (ou sql server instalado);
- Nodejs e Angular;

Como executar:
- Ativar o servidor SQL server;
- Alterar o arquivo "DesafioStefanini\Server\appsettings.json" para a connection string de acordo com o usuario e senha;
- Executar "dotnet run" no servidor (DesafioStefanini\Server);
- Executar o client Angular;

