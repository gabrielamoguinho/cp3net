# 🏥 Sistema de Gestão de Consultas Médicas

Este projeto é uma aplicação WebAPI desenvolvida com .NET 8.0 para gerenciar consultas médicas, integrando conceitos de orientação a objetos, arquitetura em camadas e integração com banco de dados Oracle via Entity Framework Core. A documentação é exposta via Swagger.

---

## 🎯 Objetivo do Projeto

- Gerenciar dados de **consultas médicas**, pacientes e médicos.
- Aplicar os conceitos aprendidos ao longo dos Checkpoints:
  - Classes abstratas, herança e polimorfismo
  - Níveis de acesso: `public`, `private` e `protected`
  - Estrutura em camadas com biblioteca de regras (`MedicalLib`) e WebAPI (`MedicalApi`)
  - Integração com Oracle utilizando Entity Framework Core
  - Endpoints RESTful
  - Documentação com Swagger

---

## 🗂️ Estrutura da Solução

GestaoConsultas/
├── MedicalLib/ # Biblioteca com entidades e regras de negócio
│ ├── Pessoa.cs
│ ├── Paciente.cs
│ ├── Medico.cs
│ └── Consulta.cs
│
├── MedicalApi/ # Projeto principal WebAPI
│ ├── Controllers/
│ │ └── ConsultaController.cs
│ ├── Program.cs
│ ├── appsettings.json
│ ├── launchSettings.json
│ └── MedicalApi.csproj
│
├── GestaoConsultas.sln # Arquivo da solução
└── .gitignore

yaml
Copiar
Editar

---

## 💻 Tecnologias Utilizadas

- C# com .NET 8
- ASP.NET Core Web API
- Entity Framework Core + Oracle
- Swagger/OpenAPI
- Visual Studio 2022 / VSCode

---

## 🌐 Endpoints Disponíveis

### 🔹 Consultas Médicas

| Método | Rota                   | Descrição                         | Status HTTP Esperado |
|--------|------------------------|-----------------------------------|----------------------|
| GET    | `/api/consulta`        | Lista todas as consultas          | 200 OK               |
| POST   | `/api/consulta`        | Cadastra uma nova consulta        | 201 Created          |
| PUT    | `/api/consulta/{id}`   | Atualiza os dados de uma consulta | 204 No Content       |
| DELETE | `/api/consulta/{id}`   | Remove uma consulta do sistema    | 204 No Content       |

---

## 🧠 Regras de Orientação a Objetos

- `Pessoa`: classe **abstrata**
- `Paciente` e `Medico`: classes **derivadas**
- Método `ObterIdentificacao()` implementado com **polimorfismo**
- Níveis de acesso aplicados: `public`, `protected`, `private`

---

## ⚙️ Como Executar Localmente

### 📦 Requisitos

- .NET SDK 8.0 ou superior
- Visual Studio 2022 (ou VS Code com extensão C#)
- Oracle instalado ou disponível em rede (opcional para testes locais)
- Git

### 📁 Clone o projeto

```bash
git clone https://github.com/seu-usuario/seu-repo.git
cd GestaoConsultas

🛠 Restaure e compile
```bash
dotnet build
▶️ Execute a API
```bash
dotnet run --project MedicalApi
```

🔍 Acessar o Swagger
Abra no navegador:

```bash
https://localhost:7002/index.html
```

👩‍💻 Desenvolvido por
Gabriela Moguinho Gonçalves
RM: 556143
