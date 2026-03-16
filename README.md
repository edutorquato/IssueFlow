# 🚀 IssueFlow

**IssueFlow** é um sistema moderno de gerenciamento de issues desenvolvido para demonstrar boas práticas de desenvolvimento **Full Stack** utilizando **.NET**, **Vue.js**, **Docker** e **SQL Server**.

O projeto simula a arquitetura de um sistema SaaS real, com autenticação JWT, API REST segura, banco de dados containerizado e frontend desacoplado.

---

# 📸 Preview

![IssueFlow Preview](https://via.placeholder.com/1200x600.png?text=IssueFlow+Dashboard)

---

# 🧰 Tech Stack

## Backend
- ASP.NET Core 8
- Entity Framework Core
- JWT Authentication
- SQL Server
- Swagger

## Frontend
- Vue 3
- Vue Router
- Vite

## DevOps
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


O backend segue uma estrutura modular simples baseada em **Controllers + Entity Framework**, permitindo evolução futura para arquiteturas mais complexas como **Clean Architecture** ou **DDD**.

---

# 🔐 Autenticação

A autenticação é baseada em **JWT (JSON Web Token)**.

Fluxo:

1️⃣ Usuário realiza login  
2️⃣ API valida as credenciais  
3️⃣ Token JWT é gerado  
4️⃣ O frontend envia o token nas requisições protegidas

Header esperado:

Authorization: Bearer {token}


---

# 🐳 Rodando o Projeto com Docker

### 1️⃣ Clonar o repositório

```bash
git clone https://github.com/seu-usuario/issueflow.git

cd issueflow

docker compose up --build

issueflow-api
issueflow-sql

http://localhost:5176/swagger

Configuração padrão:

Server: localhost
Port: 1433
User: sa
Password: YourStrong!Pass123
Database: IssueFlowDb

