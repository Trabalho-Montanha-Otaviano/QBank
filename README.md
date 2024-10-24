Sistema Bancário

* Este projeto é uma aplicação simples de sistema bancário que permite gerenciar clientes, contas bancárias e transações. O sistema foi desenvolvido em C# com o objetivo de demonstrar o relacionamento entre diferentes entidades bancárias e operações associadas a cada cliente e conta.

Funcionalidades

* Clientes: Cada cliente possui um nome, e-mail e CPF. Os clientes podem ter várias contas bancárias.
* Contas Bancárias: Cada cliente pode ter uma ou mais contas bancárias associadas, com um número de conta e saldo.
* Transações: As contas bancárias permitem a realização de transações, como depósitos e saques, registrando a data e o valor de cada operação.

Estrutura do Projeto

Modelos

Cliente

* ClienteId: Identificador único do cliente.
* Nome: Nome do cliente (até 100 caracteres).
* Email: E-mail do cliente.
* CPF: Número do CPF do cliente (11 dígitos).
* Contas: Coleção de contas bancárias associadas ao cliente.

ContaBancaria

* ContaBancariaId: Identificador único da conta.
* NumeroConta: Número da conta bancária.
* Saldo: Saldo disponível na conta.
* Cliente: Cliente associado à conta.
* Transacoes: Coleção de transações realizadas pela conta.

Transacao

* TransacaoId: Identificador único da transação.
* Valor: Valor da transação.
* DataTransacao: Data em que a transação foi realizada.
* TipoTransacao: Tipo da transação (Deposito ou Saque).
* ContaBancaria: Conta bancária associada à transação.

Enum

* TipoTransacao: Define o tipo de operação de uma transação:
* Deposito
* Saque

Tecnologias Utilizadas

* HTML/CSS/JavaScript (para a interface web)
* .NET Core
* Entity Framework Core (C#)
* SQL Server

Integrantes:

* Daniel De Moura Renda  **RA: 124115549**
* Gabriel Sousa Bastos        **RA: 123115047**
* Gabriela Falcão Penna Campos Abreu  **RA: 12311964**
* Yago Marquezini Magalhães                     **RA: 12319847**
