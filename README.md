# Cadastro de Alunos - ASP.NET MVC

## Descrição

Projeto desenvolvido utilizando o padrão MVC (Model-View-Controller) para cadastro de alunos.

O sistema aplica os conceitos de:

- Model Binding
- Data Annotations
- Validação de dados
- Controllers
- Views

## Funcionalidades

- Cadastro de alunos
- Validação de campos obrigatórios
- Validação de e-mail
- Exibição de confirmação de cadastro

## Campos do formulário

- Nome
- E-mail
- RA
- Curso
- Data de Nascimento

## Estrutura do Projeto

### Model

Classe Aluno contendo os atributos do cadastro.

### Controller

AlunoController responsável por receber os dados do formulário através de Model Binding.

### Views

- Cadastrar.cshtml
- Confirmacao.cshtml

## Testes Realizados

### Testes Positivos

- Cadastro com todos os campos preenchidos corretamente.

### Testes Negativos

- Nome não informado.
- E-mail inválido.
- RA não informado.
- Curso não informado.
- Data de nascimento não informada.

## Tecnologias

- ASP.NET MVC
- C#
- Razor Views
- GitHub

## Autor

Guilherme Ribeiro Lins
Tecnólogo em Análise e Desenvolvimento de Sistemas - UNINOVE
