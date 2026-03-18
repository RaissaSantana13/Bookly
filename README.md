# 📚 Bookly - Sistema de Gestão de Leituras

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET Core](https://img.shields.io/badge/.NET%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=mysql&logoColor=white)
![Status](https://img.shields.io/badge/Status-Desenvolvimento-blue?style=for-the-badge)

O **Bookly** é uma aplicação robusta de gestão literária desenvolvida em C#, projetada para organizar bibliotecas pessoais e monitorizar o progresso de leitura de forma detalhada. O sistema utiliza uma arquitetura organizada e tecnologias modernas para garantir escalabilidade e manutenção eficiente.

---
<div align="center">
  <img src="https://github.com/user-attachments/assets/db14009b-bc5d-48ca-9550-f5e4e19fe0ff" alt="Interface do Bookly" width="85%">

  <br><br>

  <a href="https://player.cloudinary.com/embed/?cloud_name=dzkjdll3l&public_id=Bookly" target="_blank">
    <img src="https://img.shields.io/badge/ASSISTIR-DEMO%20VÍDEO-red?style=for-the-badge&logo=youtube" alt="Assistir Demonstração do Bookly">
  </a>
</div>

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


---

# 📚 Bookly - Reading Management System

**Bookly** is a robust literary management application developed in C#, designed to organize personal libraries and monitor reading progress in detail. The system utilizes an organized architecture and modern technologies to ensure scalability and efficient maintenance.

---

## Features and Highlights

* **Complete Collection Management:** Registration and maintenance of Authors, Books, Genres, and Users.
* **Reading Tracking:** System to record "Reading Processes" and individual sessions, allowing page-by-page progress tracking.
* **Dependency Injection (DI):** Use of `Microsoft.Extensions.DependencyInjection` to manage the lifecycle of repositories, services, and forms.
* **Automated Mapping:** Integration with **AutoMapper** to efficiently convert domain entities into ViewModels.
* **Relational Database:** Data persistence using **MySQL** with entity mapping via Entity Framework Core.
* **Data Seeding:** Automatic database population with predefined literary genres (Science Fiction, Romance, Fantasy, Horror, etc.).

---

## Technologies Used

* **Language:** C# (.NET).
* **ORM:** **Entity Framework Core** for data layer abstraction.
* **Database:** MySQL.
* **Object Mapping:** **AutoMapper**.
* **Interface:** Windows Forms (WinForms).
* **Design Patterns:** Repository Pattern and Service Layer.

---

## Project Structure

The project follows a clear separation of concerns:

* **Bookly.App:** Presentation layer containing forms (Login, Book Registration, Authors) and the Dependency Injection infrastructure configuration.
* **Bookly.Domain:** Definition of core entities (Author, Book, ReadingSession, User) and base interfaces.
* **Bookly.Repository:** Database access implementation, Entity Framework context (`BooklyContext`), and Fluent API mappings.
* **Bookly.Service:** Business logic layer and validators.

---

## System Configuration

1. **Database:** The system uses a MySQL connection string stored in the `Config/DbConfig.txt` file.
2. **Migrations:** The context is configured to ensure automatic database creation via `Database.EnsureCreated()`.
3. **Dependencies:** Ensure you restore the following NuGet packages:
    * `Microsoft.EntityFrameworkCore.MySQL`
    * `AutoMapper`
    * `Microsoft.Extensions.DependencyInjection`

---

## 👨‍💻 Author

Project developed with a focus on software engineering best practices and clean architecture.
