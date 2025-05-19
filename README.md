# 🚗 Desafio Fundamentos - Sistema de Estacionamento

Este projeto simula um sistema de estacionamento de veículos com funcionalidades básicas como cadastrar, listar e remover veículos, além do cálculo de valor a ser pago com base nas horas estacionadas.

## 📸 Demonstração

![Demonstração do sistema](https://github.com/amd-lima/trilha-net-fundamentos-desafio/blob/main/gif.gif)

---

## 📦 Funcionalidades

- ✅ Cadastrar veículos (valida placas duplicadas e vazias)
- ✅ Remover veículos (com cálculo de valor a pagar)
- ✅ Listar veículos estacionados
- ✅ Aplicação colorida via terminal para melhor usabilidade

---

## ✅ Validações

### ➕ Cadastro de veículos

- O sistema **não permite**:
  - Cadastrar placas já existentes
  - Cadastrar placas vazias ou com apenas espaços

- Mensagens informativas em cores:
  🔴 Vermelho para erros (placa inválida ou duplicada)
  🔵 Ciano para instruções
  ⚪ Branco para entradas normais
  🟡Títulos
  🔘Mensagens do sistema
  

### ➖ Remoção de veículos

- O sistema **verifica se a placa existe** antes de permitir a remoção.
- O usuário deve informar a quantidade de horas estacionado, e o sistema calcula o valor com base em:
  - **Preço inicial**
  - **Preço por hora**
- Também são validados:
  - ❌ Valores não numéricos

---

## 💰 Cálculo do valor
valorTotal = precoInicial + precoPorHora * horas;

---

# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.
