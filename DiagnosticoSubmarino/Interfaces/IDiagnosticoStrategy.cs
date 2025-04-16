using System;
using DiagnosticoSubmarino.Models;

namespace DiagnosticoSubmarino.Interfaces;

public interface IDiagnosticoStrategy
{
    DiagnosticoResultado CalculaTaxas(List<string> relatorio);
}
