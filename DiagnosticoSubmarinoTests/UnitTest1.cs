using DiagnosticoSubmarino.Interfaces;
using DiagnosticoSubmarino.Models;
using DiagnosticoSubmarino.Services;

namespace DiagnosticoSubmarinoTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

        var relatorio = LeitorRelatorio.LerRelatorioJSON("relatorio.json");

        IDiagnosticoStrategy strategy = new CalculaGamaEpisilonStrategy();
        var analizar = new DiagnosticoRelatorioAnalyzer(strategy);
        DiagnosticoResultado resultado = analizar.Analyze(relatorio);

        //resultados esperados
        Assert.Equal(22, resultado.Gama);
        Assert.Equal(9, resultado.Episilon);
        Assert.Equal(198, resultado.ConsumoEnergia);
    }
}
