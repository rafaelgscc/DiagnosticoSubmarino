# ⚓ Diagnóstico do Submarino

Projeto desenvolvido como desafio técnico por **Rafael Gomes da Silva**, com o objetivo de calcular o consumo de energia de um submarino a partir de um relatório binário.

---

## 📋 Descrição do Problema

O submarino tem feito alguns ruídos estranhos, então você pede que ele produza um relatório de
diagnóstico, apenas por precaução.

O relatório de diagnóstico (seu dado de entrada) consiste em uma lista de números binários que,
quando decodificados corretamente, podem informar muitas informações úteis sobre as condições
do submarino. O primeiro parâmetro a ser verificado é o consumo deenergia.

Você precisa usar os números binários no relatório de diagnóstico para gerar dois novos números
binários (chamados de taxa gama e taxa épsilon). O consumo de energia pode então ser encontrado
multiplicando a taxa gama pela taxa épsilon.

O sistema lê um arquivo JSON contendo uma lista de números binários e realiza os seguintes cálculos:

- **Taxa Gama**: construída a partir dos bits mais comuns em cada posição.
- **Taxa Épsilon**: construída a partir dos bits menos comuns em cada posição.
- **Consumo de Energia**: resultado da multiplicação entre a taxa gama e a taxa épsilon.

Entrada do problema:

```json
[
  "00100",
  "11110",
  "10110",
  "10111",
  "10101",
  "01111",
  "00111",
  "11100",
  "10000",
  "11001",
  "00010",
  "01010"
]
```

Resultado esperado:

- Taxa Gama: `10110` (22)
- Taxa Épsilon: `01001` (9)
- Consumo de Energia: `198`

---

## 📦 Estrutura do Projeto

```
DiagnosticoSubmarino/
│
├── Models/
│   └── DiagnosticoResultado.cs
│
├── Interfaces/
│   └── IDiagnosticoStrategy.cs
│
├── Services/
│   ├── CalculaGamaEpisilonStrategy.cs
│   └── LeitorRelatorio.cs
│
├── Program.cs
├── relatorio.json
└── DiagnosticoSubmarino.csproj
DiagnosticoSubmarinoTests/
└── DiagnosticoSubmarino.Tests.cs
```

---

## 💡 Padrões de Projeto Utilizados

- **Strategy Pattern**: Permite encapsular diferentes algoritmos de diagnóstico. A estratégia atual implementada é `CalculaGamaEpisilonStrategy`.
- **Single Responsibility Principle (SOLID)**: Cada classe tem uma responsabilidade única (ex: leitura do arquivo, cálculo de diagnóstico).
- **Inversão de Dependência**: A lógica de cálculo depende de uma abstração (`IDiagnosticoStrategy`), não de uma implementação concreta.

---

## 🧪 Testes Unitários

Os testes são implementados com **xUnit** no projeto `DiagnosticoSubmarino.Tests`.

```bash
dotnet test
```

### Exemplo de Teste:

```csharp
[Fact]
public void CalculaTaxasEsperado()
{
    var relatorio = new List<string> { ... };
    var estrategia = new CalculaGamaEpisilonStrategy();
    var resultado = estrategia.CalculaTaxas(relatorio);

    Assert.Equal(22, resultado.Gama);
    Assert.Equal(9, resultado.Episilon);
    Assert.Equal(198, resultado.ConsumoEnergia);
}
```

---

## 🧰 Tecnologias Utilizadas

- [.NET 9.0](https://dotnet.microsoft.com)
- C#
- xUnit (testes)
- JSON para entrada de dados

---

## 🚀 Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/rafaelgscc/DiagnosticoSubmarino.git
   cd DiagnosticoSubmarino
   ```

2. Compile o projeto:
   ```bash
   dotnet build
   ```

3. Execute:
   ```bash
   dotnet run
   ```

4. Teste:
   ```bash
   dotnet test
   ```

---

## 👤 Autor

**Rafael Gomes da Silva**  
- GitHub: [@rafaelgscc](https://github.com/rafaelgscc)
- LinkedIn:[Rafael Gomes da Silva](https://www.linkedin.com/in/rafael-gomes-da-silva-775b80123/)

---

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
