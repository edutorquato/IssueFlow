# 🚀 IssueFlow

**IssueFlow** é um sistema de gerenciamento de issues desenvolvido para demonstrar uma arquitetura moderna **Full Stack**, utilizando **.NET**, **Vue.js**, **Docker** e **SQL Server**.

O projeto simula um cenário real de aplicação SaaS, com:

- API REST segura
- Autenticação via JWT
- Frontend desacoplado
- Banco de dados containerizado
- Estrutura preparada para crescimento

---

# 📸 Preview

![IssueFlow Preview](https://via.placeholder.com/1200x600.png?text=IssueFlow+Dashboard)

---

# 🧰 Tech Stack

## 🔹 Backend
- ASP.NET Core 8
- Entity Framework Core
- JWT Authentication
- SQL Server
- Swagger

## 🔹 Frontend
- Vue 3
- Vue Router
- Vite

## 🔹 DevOps
- Docker
- Docker Compose

---

# 🏗️ Arquitetura do Projeto


IssueFlow
│
├── IssueFlowApi
│ ├── Controllers
│ ├── Data
│ ├── Models
│ ├── Migrations
│ ├── Program.cs
│ └── Dockerfile
│
├── IssueFlowWeb
│ ├── src
│ │ ├── views
│ │ ├── router
│ │ ├── layouts
│ │ └── components
│
└── docker-compose.yml


O backend segue uma estrutura modular baseada em **Controllers + Entity Framework**, com possibilidade de evolução para **Clean Architecture** ou **DDD**.

---

# 🔐 Autenticação

A autenticação é feita via **JWT (JSON Web Token)**.

### Fluxo:

1. Usuário realiza login  
2. API valida credenciais  
3. Token JWT é gerado  
4. Frontend envia o token nas requisições protegidas  

### Header esperado:


Authorization: Bearer {token}


---

# 🐳 Como rodar o projeto

## 🔧 Pré-requisitos

- Docker instalado
- Docker Compose

---

## ▶️ Subindo o ambiente

Clone o repositório:

```bash
git clone https://github.com/seu-usuario/issueflow.git
cd issueflow

Suba os containers:

docker compose up --build
🚀 Serviços disponíveis

Após subir o projeto:

🔹 API (.NET)
http://localhost:5176/swagger
🔹 Banco de dados (SQL Server)
Host: localhost
Port: 1433
User: sa
Password: YourStrong!Pass123
Database: IssueFlowDb
🧪 Principais funcionalidades

✔ Autenticação JWT

✔ API protegida

✔ Integração Vue + .NET

✔ Banco SQL Server via Docker

✔ Documentação com Swagger

📌 Próximos passos (Roadmap)

 CRUD completo de Issues

 Gestão de usuários

 Sistema de permissões (roles)

 Dashboard com métricas

 Deploy em cloud

👨‍💻 Autor

Eduardo

Desenvolvedor com foco em backend, arquitetura e aplicações escaláveis.

⭐ Objetivo

Este projeto foi criado com foco em:

Demonstrar boas práticas em .NET

Trabalhar com frontend desacoplado

Utilizar Docker no fluxo de desenvolvimento

Simular um ambiente real de aplicação SaaS

📄 Licença

MIT


---

# 🔥 O que melhoramos (isso é o que recrutador percebe)

- Organização visual (muito importante)
- Separação clara de responsabilidades
- Seção “Como rodar” bem objetiva
- Linguagem mais profissional (menos “tutorial”, mais “produto”)
- Estrutura fácil de escanear (quem avalia não lê tudo)

---

# 🚀 Se quiser deixar ainda mais forte

Posso te ajudar a dar o próximo nível:

- adicionar **badges (Docker, .NET, Vue)**
- criar um **GIF real do sistema funcionando**
- montar um **diagrama de arquitetura estilo senior**
- ajustar o README para inglês (isso aumenta MUITO alcance)

Só me fala 👍
