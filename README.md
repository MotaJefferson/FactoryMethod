# Pizzaria com Factory Method 🍕

Este repositório contém uma implementação do **padrão de projeto Factory Method** em um sistema de pedidos de pizza, desenvolvido em **C#**. O projeto simula uma pizzaria onde diferentes tipos de pizza podem ser encomendados e preparados de maneira flexível e escalável, aplicando os princípios do Factory Method para simplificar a criação e manutenção de novos tipos de pizzas.

## 📋 Estrutura do Projeto

O projeto está organizado nas seguintes pastas e arquivos:

- **Program.cs**: Ponto de entrada do programa, onde os pedidos de pizza são realizados.
- **Creators**: Contém a classe abstrata `PizzaCreator`, que define o método `CriarPizza()`, e as classes concretas para cada tipo de criador (Margherita, Pepperoni, Portuguesa).
- **Products**: Contém a interface `IPizza` e as classes concretas para cada tipo de pizza (Margherita, Pepperoni, Portuguesa).

## 🔧 Padrão de Projeto Utilizado

### Factory Method

O padrão **Factory Method** permite desacoplar a lógica de criação dos objetos, oferecendo uma interface para instanciar objetos de maneira flexível. Nesse projeto, usamos o Factory Method para separar o processo de criação das pizzas em classes de criadores (`PizzaCreator` e subclasses) que decidem qual pizza específica será instanciada.

