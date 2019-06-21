# Projeto desenvolvido utilizando C# Windows Forms (GUI) e API feita em Nodejs (express), com banco de dados MySQL

![captureScreenSystem](https://user-images.githubusercontent.com/44484286/59908123-08711a00-93e3-11e9-83be-d1f0a3c8f8a9.PNG)

# 1° - API 🚀
## Instalando os pacotes:
* Em seu terminal, entre na pasta 'API' e digite:
* >$ npm i
## Com os pacotes instalados, suba a API digitando:
* >$ npm start

### Após estes passos a API estará pronta.

# 2° - Banco de Dados 🖥️
## Para rodar a aplicação, é necessario que você tenha um DATABASE e a TABELA com o nome 'products' em seu MySql.
### Você pode criar o DATABASE rodando o comando:
* >$ CREATE DATABASE products;

### Crie a tabela dentro desse database usando a query abaixo:
*CREATE TABLE IF NOT EXISTS `products` (\
	`id` int(10) NOT NULL auto_increment,\
	`name` varchar(255) NOT NULL,\
	`price` varchar(255) NOT NULL,\
	`createdAt` varchar(255) NOT NULL,\
	`description` varchar(255) NOT NULL,\
	`brand` varchar(255) NOT NULL,\
	PRIMARY KEY( `id` )\
);*


# 3° - GUI 💻
## Com a API e o DB no ar, você pode abrir a interface abrindo e executando em seu Visual Studio, ou executando diretamente o arquivo \Produtos\bin\Debug\Produtos.exe

# 3° Contribuição ✌️
### Contribuições são 100% bem-vindas, bastar fazer uma PR ou Issue