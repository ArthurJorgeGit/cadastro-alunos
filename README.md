# 📚 Sistema de Cadastro de Alunos

Sistema de gerenciamento de alunos desenvolvido em C# com interface via terminal, aplicando os conceitos de Programação Orientada a Objetos e coleções.

## 🛠️ Tecnologias utilizadas

- C# / .NET 9
- Coleções (List<T>)
- Git e GitHub

## ⚙️ Funcionalidades

- Cadastrar aluno (nome, e-mail e curso)
- Listar todos os alunos cadastrados
- Buscar aluno por nome
- Remover aluno por ID

## ▶️ Como rodar o projeto

**Pré-requisitos:** ter o [.NET 9 SDK](https://dotnet.microsoft.com/download) instalado.
```bash
# Clone o repositório
git clone https://github.com/ArthurJorgeGit/cadastro-alunos.git

# Entre na pasta do projeto
cd cadastro-alunos

# Execute o projeto
dotnet run
```

## 📁 Estrutura do projeto
```
CadastroAlunos/
├── Models/
│   └── Aluno.cs          # Classe modelo com propriedades e ExibirInfo()
├── Services/
│   └── AlunoService.cs   # Regras de negócio e operações CRUD
└── Program.cs            # Menu de interação com o usuário
```

## 👨‍💻 Autor

Arthur Jorge Soares Silveira  
[LinkedIn](https://www.linkedin.com/in/arthur-jorge/) • [GitHub](https://github.com/ArthurJorgeGit)

