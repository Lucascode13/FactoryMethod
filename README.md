#  Sistema de Cadastro de Alunos com Factory Method em C# (WPF)

##  Descrição

Este projeto consiste em uma aplicação desktop desenvolvida em C# utilizando WPF, com o objetivo de demonstrar na prática a aplicação do padrão de projeto Factory Method.

O sistema simula um cadastro de alunos, permitindo a criação de diferentes tipos de objetos (Aluno Regular e Aluno Bolsista) de forma desacoplada, organizada e escalável. A implementação segue a arquitetura MVVM, promovendo separação de responsabilidades e boas práticas de desenvolvimento.

O uso do padrão Factory Method elimina a necessidade de estruturas condicionais complexas, delegando a criação dos objetos para classes específicas (factories), tornando o código mais limpo, flexível e de fácil manutenção.

Este projeto foi desenvolvido como atividade acadêmica, visando consolidar o conhecimento sobre Design Patterns e sua aplicação em cenários reais de desenvolvimento de software.

---

##  Objetivo
Aplicar na prática o padrão **Factory Method**, demonstrando como ele pode reduzir o acoplamento e facilitar a manutenção e expansão de sistemas.

---

##  Padrão de Projeto Utilizado

### Factory Method
O Factory Method é um padrão criacional que define uma interface para criação de objetos, permitindo que subclasses decidam qual classe será instanciada.

✔ Evita uso excessivo de `if/else`  
✔ Reduz acoplamento  
✔ Facilita manutenção  

---

##  Tecnologias Utilizadas

- C#
- .NET 8
- WPF (Windows Presentation Foundation)
- MVVM (Model-View-ViewModel)
- Git e GitHub

---

## 🏗 Estrutura do Projeto

```
FactoryMethod/
│
├── Models/
├── ViewModels/
├── Views/
├── Commands/
```

##  Como Executar

1. Clone o repositório:
   
git clone https://github.com/Lucascode13/FactoryMethod.git

2. Abra o projeto no JetBrains Rider ou Visual Studio

3. Compile e execute a aplicação

4. Preencha os dados:
   - Nome
   - Idade
   - Tipo de aluno

5. Clique em **Cadastrar** para visualizar o aluno na lista

---

 Funcionamento

O sistema utiliza o padrão Factory Method para criar objetos do tipo `Aluno`.

Com base na escolha do usuário, uma fábrica específica é utilizada para instanciar o objeto correto.

Exemplo de uso:

```csharp
AlunoFactory factory;

if (TipoSelecionado == "Regular")
    factory = new AlunoRegularFactory();
else
    factory = new AlunoBolsistaFactory();

var aluno = factory.CriarAluno();
