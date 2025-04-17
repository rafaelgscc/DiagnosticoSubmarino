// See https://aka.ms/new-console-template for more information
using DiagnosticoSubmarino.Interfaces;
using DiagnosticoSubmarino.Models;
using DiagnosticoSubmarino.Services;

class Program
{
    static void Main()
    {
        var relatorio = LeitorRelatorio.LerRelatorioJSON("relatorio.json");

        IDiagnosticoStrategy strategy = new CalculaGamaEpisilonStrategy();

        var analizar = new DiagnosticoRelatorioAnalyzer(strategy);

        DiagnosticoResultado resultado = analizar.Analyze(relatorio);

        Console.WriteLine($"Gama: {resultado.Gama}");
        Console.WriteLine($"Episilon: {resultado.Episilon}");
        Console.WriteLine($"Consumo de Energia: {resultado.ConsumoEnergia}");
    }
}
