// See https://aka.ms/new-console-template for more information
using DiagnosticoSubmarino.Interfaces;
using DiagnosticoSubmarino.Models;
using DiagnosticoSubmarino.Services;

class Program
{
    static void Main()
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

        Console.WriteLine($"Gama: {resultado.Gama}");
        Console.WriteLine($"Episilon: {resultado.Episilon}");
        Console.WriteLine($"Consumo de Energia: {resultado.ConsumoEnergia}");
    }
}
