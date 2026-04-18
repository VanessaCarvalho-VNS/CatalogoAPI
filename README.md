# 🗂️ CatalogoAPI

API REST para gerenciamento de produtos e categorias desenvolvida com **Minimal API no .NET 8**, abordagem moderna que substitui os Controllers tradicionais por endpoints enxutos e organizados por domínio.

## 🚀 Funcionalidades

- ✅ CRUD completo de Produtos e Categorias
- ✅ Autenticação e autorização com JWT Bearer
- ✅ Login de usuários
- ✅ Endpoints organizados por domínio (Autenticação, Produtos, Categorias)
- ✅ Injeção de dependência via Service Extensions

## 🛠️ Tecnologias

- C# / .NET 8
- ASP.NET Core Minimal API
- Entity Framework Core (Code First)
- SQL Server
- JWT Bearer (autenticação)
- Swagger / OpenAPI

## 🏗️ Arquitetura

```
CatalogoAPI/
├── ApiEndpoints/               # Endpoints organizados por domínio
│   ├── AutenticacaoEndpoints.cs
│   ├── CategoriasEndpoints.cs
│   └── ProdutosEndpoints.cs
├── AppServicesExtensions/      # Extensões de configuração de serviços
│   ├── ApplicationBuilderExtension.cs
│   └── ServiceCollectionExtension.cs
├── Services/                   # Regras de negócio
├── Context/                    # DbContext (EF Core)
├── Models/                     # Entidades
└── Migrations/                 # Migrations EF Core
```

## ▶️ Como executar

### Pré-requisitos
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/sql-server)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/)

### Passos

1. Clone o repositório
```bash
git clone https://github.com/VanessaCarvalho-VNS/CatalogoAPI.git
cd CatalogoAPI
```

2. Configure a connection string no `appsettings.json`
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=CatalogoAPIDB;Trusted_Connection=True;"
}
```

3. Execute as migrations
```bash
dotnet ef database update
```

4. Rode o projeto
```bash
dotnet run
```

5. Acesse o Swagger
```
https://localhost:{porta}/swagger
```

## 🔐 Autenticação

1. Faça login em `POST /auth/login` e copie o token
2. Clique em **Authorize** no Swagger e cole o token no formato:
```
Bearer {seu_token}
```

## 📄 Endpoints principais

| Método | Rota | Descrição | Auth |
|--------|------|-----------|------|
| POST | /auth/login | Login | ❌ |
| GET | /produtos | Listar produtos | ✅ |
| GET | /produtos/{id} | Buscar produto | ✅ |
| POST | /produtos | Criar produto | ✅ |
| PUT | /produtos/{id} | Atualizar produto | ✅ |
| DELETE | /produtos/{id} | Deletar produto | ✅ |
| GET | /categorias | Listar categorias | ✅ |
| POST | /categorias | Criar categoria | ✅ |

## 💡 Diferencial

Este projeto utiliza **Minimal API**, abordagem introduzida no .NET 6 e aprimorada no .NET 8, que permite criar APIs com menos código e maior performance em comparação aos Controllers tradicionais. Os endpoints são organizados por domínio em arquivos separados, mantendo o código limpo e escalável.

## 👩‍💻 Autora

**Vanessa Erika de Carvalho**  
[![LinkedIn](https://img.shields.io/badge/LinkedIn-vanessacarvalho20-blue?logo=linkedin)](https://linkedin.com/in/vanessacarvalho20)
[![GitHub](https://img.shields.io/badge/GitHub-VanessaCarvalho--VNS-black?logo=github)](https://github.com/VanessaCarvalho-VNS)
