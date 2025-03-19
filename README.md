# 📌 Projeto de Agenda em C# .NET Core com Windows Forms e MySQL

Este projeto foi uma das minhas primeiras experiências no mundo da programação, desenvolvido há **quatro anos**. Ele representa um marco no meu aprendizado inicial de **C# .NET Core**, **Windows Forms** e **bancos de dados MySQL**.

Atualmente, sou especialista em **Node.js** e **React**, mas mantenho um conhecimento básico de C# para atender a demandas quando necessário. Este projeto permanece disponível como referência histórica e pode ser útil para quem deseja aprender sobre aplicações desktop conectadas a um banco de dados.

## 📝 Descrição

A aplicação é uma **agenda de contatos** que permite cadastrar, listar, buscar, editar e excluir contatos. A interface gráfica foi construída utilizando **Windows Forms**, e o **MySQL** é responsável pelo armazenamento dos dados.

> ⚠ **Nota:** Este projeto foi desenvolvido quando eu ainda estava aprendendo. Ele pode não seguir as melhores práticas atuais, mas continua funcional e útil como estudo.

## ✨ Funcionalidades

- ✅ **Cadastro de Contatos** – Adicione novos contatos com nome, e-mail e telefone.
- ✅ **Listagem de Contatos** – Exibição de todos os contatos cadastrados.
- ✅ **Busca de Contatos** – Pesquisa de contatos por nome ou e-mail.
- ✅ **Edição de Contatos** – Modificação dos dados de um contato já cadastrado.
- ✅ **Exclusão de Contatos** – Remoção de contatos da agenda.

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** .NET Core
- **Interface Gráfica:** Windows Forms
- **Banco de Dados:** MySQL

## 📌 Pré-requisitos

Antes de executar o projeto, certifique-se de ter os seguintes requisitos instalados:

- .NET Core SDK
- MySQL Server
- Um cliente MySQL (ex.: MySQL Workbench) para gerenciar o banco de dados

## 🔧 Configuração do Banco de Dados

Siga os passos abaixo para configurar o banco de dados MySQL:

1. **Crie o banco de dados:**

   ```sql
   CREATE DATABASE db_agenda;
   ```

2. **Acesse o banco de dados:**

   ```sql
   USE db_agenda;
   ```

3. **Crie a tabela `Contato`:**

   ```sql
   CREATE TABLE Contato (
       id INT AUTO_INCREMENT PRIMARY KEY,
       nome VARCHAR(255) NOT NULL,
       email VARCHAR(255),
       telefone VARCHAR(20)
   );
   ```

## 🚀 Como Executar

1. Clone este repositório:
   
   ```bash
   git clone https://github.com/Maxtherox/API_Csharp_WF__MySQL.git
   ```

2. Abra o projeto no **Visual Studio** ou outro IDE compatível com .NET Core.

3. Configure a string de conexão no arquivo `Form1.cs`:
   
   ```csharp
   private string data_source = "datasource=localhost;username=root;password=root;database=db_agenda";
   ```
   
   > 🔹 Altere `username` e `password` conforme suas configurações do MySQL.

4. Execute a aplicação no Visual Studio.

## 🔍 Considerações Finais

Este projeto representa um **marco importante** na minha trajetória como desenvolvedor. Ele reflete meu aprendizado no início da carreira e minha evolução até me tornar especialista em **Node.js** e **React**.

Fique à vontade para explorar o código, sugerir melhorias ou utilizá-lo como referência para seus próprios estudos.

📩 Caso tenha dúvidas ou sugestões, entre em contato!

---
✒ **Desenvolvido originalmente há 4 anos, preservado como referência de aprendizado.**

