# 📚 Bookly - Sistema de Gestão de Leituras

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET Core](https://img.shields.io/badge/.NET%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=mysql&logoColor=white)
![Status](https://img.shields.io/badge/Status-Desenvolvimento-blue?style=for-the-badge)

O **Bookly** é uma aplicação robusta de gestão literária desenvolvida em C#, projetada para organizar bibliotecas pessoais e monitorizar o progresso de leitura de forma detalhada. O sistema utiliza uma arquitetura organizada e tecnologias modernas para garantir escalabilidade e manutenção eficiente.

---

## Funcionalidades e Destaques

* **Gestão Completa de Acervo:** Registo e manutenção de Autores, Livros, Géneros e Utilizadores.
* **Monitorização de Leitura:** Sistema para registar "Processos de Leitura" e sessões individuais, permitindo acompanhar o progresso página a página.
* **Injeção de Dependências (DI):** Utilização de `Microsoft.Extensions.DependencyInjection` para gerir o ciclo de vida de repositórios, serviços e formulários.
* **Mapeamento Automatizado:** Integração com **AutoMapper** para converter de forma eficiente entidades de domínio para ViewModels.
* **Base de Dados Relacional:** Persistência de dados utilizando **MySQL** com mapeamento de entidades via Entity Framework Core.
* **Seed de Dados:** População automática da base de dados com géneros literários predefinidos (Ficção Científica, Romance, Fantasia, Terror, etc.).

---

## Tecnologias Utilizadas

* **Linguagem:** C# (.NET).
* **ORM:** **Entity Framework Core** para abstração da camada de dados.
* **Base de Dados:** MySQL.
* **Mapeamento de Objetos:** **AutoMapper**.
* **Interface:** Windows Forms (WinForms).
* **Padrões de Desenho:** Repository Pattern e Service Layer.

---

## Estrutura do Projeto

O projeto segue uma divisão clara de responsabilidades:

* **Bookly.App:** Camada de apresentação contendo os formulários (Login, Registo de Livros, Autores) e a configuração da infraestrutura de Injeção de Dependências.
* **Bookly.Domain:** Definição das entidades centrais (Author, Book, ReadingSession, User) e interfaces base.
* **Bookly.Repository:** Implementação do acesso à base de dados, contexto do Entity Framework (`BooklyContext`) e mapeamentos fluentes (Fluent API).
* **Bookly.Service:** Camada de lógica de negócio e validadores.

---

## Configuração do Sistema

1.  **Base de Dados:** O sistema utiliza uma string de conexão MySQL armazenada no ficheiro `Config/DbConfig.txt`.
2.  **Migrações:** O contexto está configurado para garantir a criação da base de dados automaticamente via `Database.EnsureCreated()`.
3.  **Dependências:** Certifica-te de restaurar os pacotes NuGet:
    * `Microsoft.EntityFrameworkCore.MySQL`
    * `AutoMapper`
    * `Microsoft.Extensions.DependencyInjection`

---

## 👨‍💻 Autor

Projeto desenvolvido com foco em boas práticas de engenharia de software e arquitetura limpa em ambiente.
