using System;
using DiagnosticoSubmarino.Interfaces;
using DiagnosticoSubmarino.Models;

namespace DiagnosticoSubmarino.Services;

public class DiagnosticoRelatorioAnalyzer
{
    //Injecao da estrategia de diagnostico (Inversao de dependencia)
    private readonly IDiagnosticoStrategy _strategy;

    public DiagnosticoRelatorioAnalyzer(IDiagnosticoStrategy strategy)
    {
        _strategy = strategy;
    }

    public DiagnosticoResultado Analyze(List<string> relatorio)
    {
        return _strategy.CalculaTaxas(relatorio);
    }
}
