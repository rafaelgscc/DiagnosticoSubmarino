using DiagnosticoSubmarino.Interfaces;
using DiagnosticoSubmarino.Models;
using DiagnosticoSubmarino.Services;

namespace DiagnosticoSubmarinoTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var relatorio = new List<string>
        {
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
        };

        IDiagnosticoStrategy strategy = new CalculaGamaEpisilonStrategy();

        var analizar = new DiagnosticoRelatorioAnalyzer(strategy);

        DiagnosticoResultado resultado = analizar.Analyze(relatorio);

        Assert.Equal(22, resultado.Gama);
        Assert.Equal(9, resultado.Episilon);
        Assert.Equal(198, resultado.ConsumoEnergia);
    }
}
