# BuscaCNPJ MVC - Sistema de Consulta e Armazenamento de CNPJ

## 📝 Descrição

O **BuscaCNPJ MVC** é um sistema web desenvolvido em ASP.NET MVC que permite consultar informações de empresas através do CNPJ utilizando a API pública [ReceitaWS](https://receitaws.com.br/), além de armazenar esses dados em um banco de dados para consultas futuras.

## ✨ Funcionalidades

- 🔍 Consulta detalhada de CNPJ através da API ReceitaWS
- 💾 Armazenamento dos dados consultados em banco de dados MySQL
- 📋 Listagem de todos os CNPJs já consultados e armazenados
- 🔄 Integração eficiente com API externa usando Refit
- 🚀 Interface simples e intuitiva

## 🛠️ Tecnologias Utilizadas

- **Backend**:
  - .NET Core
  - C#
  - ASP.NET MVC
  - Entity Framework Core (ORM)
  
- **Frontend**:
  - Bootstrap (para estilização)
  - JavaScript (JQuery)
  
- **Integração**:
  - Refit (para consumo da API ReceitaWS)
  
- **Banco de Dados**:
  - MySQL

## 🚀 Como Executar o Projeto

### Pré-requisitos

- .NET 6 SDK ou superior
- MySQL Server instalado
- IDE de sua preferência (Visual Studio, VS Code, Rider, etc.)

### Configuração

1. Clone o repositório:
   ```bash
   git clone https://github.com/pedrodrey/BuscaCnpjMvc.git
   ```

2. Configure a conexão com o banco de dados no arquivo `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "server=localhost;database=BuscaCnpjDB;user=seu_usuario;password=sua_senha"
   }
   ```

3. Execute as migrações do Entity Framework:
   ```bash
   dotnet ef database update
   ```

4. Execute o projeto:
   ```bash
   dotnet run
   ```

5. Acesse no navegador:
   ```
   https://localhost:5001
   ```

## 📌 Endpoints Principais

- `/` - Página inicial
- `/CnpjResponses` - Listagem de CNPJs cadastrados
- `/CnpjResponses/ObterCnpj` - Tela de busca por CNPJ
- `/CnpjResponses/SalvarCnpj` - Endpoint para salvar CNPJ (POST)

## 🤝 Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

## 📄 Licença

Este projeto está licenciado sob a licença MIT - veja o arquivo [LICENSE](LICENSE) para detalhes.

## ✉️ Contato

Pedro Drey - [GitHub](https://github.com/pedrodrey)  
Projeto no GitHub: [https://github.com/pedrodrey/BuscaCnpjMvc](https://github.com/pedrodrey/BuscaCnpjMvc)

---

👨🏻‍💻Desenvolvido por **Pedro Drey**
