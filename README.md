# 🧮 Calculadora de Operações Básicas

Este projeto é uma calculadora simples desenvolvida em **C#** para realizar operações matemáticas básicas: **adição, subtração, multiplicação e divisão**.  
O programa roda no console e interage diretamente com o usuário, solicitando os números e a operação desejada.

---

## 🚀 Funcionalidades
- Solicita dois números ao usuário.
- Permite escolher a operação matemática: `+`, `-`, `*`, `/`.
- Valida entradas para garantir que apenas números sejam aceitos.
- Trata divisão por zero, exibindo mensagem de erro apropriada.
- Exibe o resultado da operação escolhida.

---

## 📂 Estrutura do Código
- **Função `ValidarInformacao`**: garante que o usuário insira apenas números válidos.
- **Função `ValidarOperacao`**: valida se o operador informado é um dos permitidos (`+`, `-`, `*`, `/`).
- **Switch Expression**: utilizada para escolher a operação e calcular o resultado.
- **Tratamento de erros**: divisão por zero e operações inválidas retornam mensagens de erro.

---

## 🖥️ Exemplo de Uso
```bash
Calculadora de operações básicas.

Digite o primeiro número:
> 10
Digite o segundo número:
> 5
Informe qual operação você deseja realizar (+, -, *, /):
> *

Resultado: 50
```

---

## 🔧 Como Executar
1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/nome-do-repo.git
   ```
2. Abra o projeto em sua IDE (Visual Studio, Rider ou VS Code).
3. Compile e execute o programa:
   ```bash
   dotnet run
   ```

---

## 📌 Tecnologias Utilizadas
- Linguagem: **C#**
- Plataforma: **.NET**

---

## 📜 Licença
Este projeto está sob a licença MIT.  
Sinta-se livre para usar, modificar e compartilhar.

---

Quer que eu também crie uma seção de **roadmap** com ideias de melhorias futuras (como suporte a operações avançadas, interface gráfica ou testes unitários), para deixar o README ainda mais profissional?
