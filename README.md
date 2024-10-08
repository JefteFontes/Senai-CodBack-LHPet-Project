# Senai-CodBack-LHPet-Project

Este é um projeto desenvolvido no **SENAI** como parte do curso **CodBack**, focado em uma aplicação web para gestão de informações de um pet shop. O projeto é implementado utilizando a **arquitetura MVC** com **.NET 8.0**.

## Estrutura do Projeto

A estrutura do projeto segue a organização padrão de aplicações MVC em .NET, com as seguintes pastas e arquivos principais:

- Controllers/
- Models/
- Properties/
- Views/
- bin/Debug/net8.0/
- obj/
- wwwroot/
- LHPet.csproj
- Program.cs
- appsettings.Development.json
- appsettings.json

### Descrição dos Diretórios

- **Controllers/**: Contém os controladores responsáveis por lidar com as requisições HTTP e definir a lógica de negócios.
- **Models/**: Contém as classes de modelo, que representam a lógica e dados da aplicação.
- **Properties/**: Contém informações sobre o projeto, como configurações de build.
- **Views/**: Contém as páginas de interface do usuário (arquivos .cshtml) que são renderizadas no navegador.
- **bin/Debug/net8.0/**: Contém os arquivos compilados da aplicação.
- **wwwroot/**: Contém arquivos estáticos como imagens, CSS, JavaScript, etc.
- **appsettings.Development.json**: Arquivo de configuração para o ambiente de desenvolvimento.
- **appsettings.json**: Arquivo de configuração geral para a aplicação.

## Configuração e Instalação

Siga os passos abaixo para rodar o projeto localmente:

### Pré-requisitos

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)

### Passos

1. Clone este repositório:
   ```bash
   git clone https://github.com/usuario/Senai-CodBack-LHPet-Project.git
   ```
2. Navegue até o diretório do projeto:

   ```bash
   cd Senai-CodBack-LHPet-Project
   ```
3. Restaure as dependências:

   ```bash
   dotnet restore
   ```
4. Inicie a aplicação:

   ```bash
   dotnet run
   ```
5. Acesse a aplicação no navegador utilizando o endereço:

   ```bash
   [dotnet run](http://localhost:5000)
   ```
## Tecnologias Utilizadas

- **.NET 8.0**: Framework para desenvolvimento da aplicação.
- **MVC (Model-View-Controller)**: Arquitetura utilizada para separar a lógica de negócios, interface de usuário e controle de fluxo.

## Configurações Adicionais

Arquivos de configuração estão presentes no projeto, incluindo `appsettings.Development.json` e `appsettings.json`. Estes arquivos são responsáveis por definir strings de conexão, configurações de ambiente, etc.

## Contribuindo

1. Faça um fork do projeto.
2. Crie sua feature branch:
   ```bash
   git checkout -b minha-feature
   ```
3. Faça o commit das suas alterações:

   ```bash
   git commit -m 'Adicionando uma nova feature'
   ```
4. Faça um push para a branch:
   ```bash
   git push origin minha-feature
   ```
5. Abra um Pull Request.
