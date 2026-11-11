<div align="center">

# 📖 Gestão de Livraria API

**API em ASP.NET Core para manter o catálogo de livros de uma livraria online.**

![C#](https://img.shields.io/badge/C%23-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)

</div>

## 💡 Sobre

API para cadastrar, consultar, editar e excluir livros do catálogo. Cada livro tem título, autor, gênero, preço e quantidade em estoque; a persistência usa Entity Framework Core com banco em memória, então não precisa configurar banco de dados. Projeto de estudo de C#/.NET.

## ✨ Funcionalidades

- Cadastrar livro
- Buscar livro pelo ID
- Atualizar livro
- Excluir livro
- Documentação via Swagger (ambiente de desenvolvimento)

## 🛠️ Tecnologias

- C# / ASP.NET Core Web API (.NET 8)
- Entity Framework Core (InMemory)
- Swashbuckle (Swagger)

## 📌 Endpoints

| Método | Rota | Descrição |
|--------|------|-----------|
| `POST` | `/api/livros` | Cadastra um livro (`titulo`, `autor`, `genero`, `preco`, `qntEmEstoque`) |
| `GET` | `/api/livros/{id}` | Busca um livro pelo ID |
| `PUT` | `/api/livros/{id}` | Atualiza um livro |
| `DELETE` | `/api/livros/{id}` | Remove um livro |

## 🚀 Como rodar

Requer .NET 8 SDK.

```bash
git clone https://github.com/KevinLopes23/Gestao-Livraria.git
cd Gestao-Livraria/LivrariaAPI
dotnet run
```

O Swagger fica em `http://localhost:5048/swagger`.

## 📄 Licença

Distribuído sob a licença MIT. Veja [LICENSE](LICENSE).

## 👤 Autor

Feito por [Kevin Lopes](https://github.com/KevinLopes23)
