#  Projeto de Tela para testes de Login - Backend

## Propósito do repositorio
Este repositório guarda uma API simples utilizando ASP.NET 8.0 e a intenção desse projeto é servir de resposta a requisições para login.

## Como utilizar essa API

Sugiro criar um template ASP.NET Core vazio no visual studio 2022 e basicamente será necessário adicionar os arquivos LoginController.cs, LoginRequest.cs e Program.cs. Depois disso basta entrar executar a aplicação localmente e testar. 
Essa API possui apenas uma rota chamada "login" afinal o uso dela por enquanto foi pensando com essa única função. É importante que em testes locais seja verificado o local em que a aplicação vai rodar, para ver isso basta olhar ou modificar no launchSetting.json, dentro da pasta propriedades.

Para rodar a aplicação basta utilizar o terminar, no meu caso usei o terminal do próprio Visual Studio acessar a pasta que contém a aplicação e usei o camando `dotnet run`

## Como testar

Nos meus testes utilizei o próprio curl que já é uma solucação nativa do OS que estou utilizando e bastante útil, basicamente você pode testar a aplicação localmente e utilizar o comando:

`curl -X POST http://localhost:portNumber/login -H "Content-Type: application/json" -d "{\"username\": \"admin\", \"password\": \"1234\"}"`

No momento, essa API ainda aceita apenas uma credencial, mas pretendo fazer alterações para deixar o projeto mais interessante nessa questão.

## Observações

O CORS está abilitado para qualquer origem, para liberar de maneira bastante permissiva a integração com o front-end.