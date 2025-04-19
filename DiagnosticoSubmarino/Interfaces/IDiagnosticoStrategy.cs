using System;
using DiagnosticoSubmarino.Models;

//Principio Solid Aplicado: SOLID
//I: Interface Segregation — interface específica e enxuta.
//D: Dependency Inversion — a lógica de negócio dependerá dessa abstração.

namespace DiagnosticoSubmarino.Interfaces;

public interface IDiagnosticoStrategy
{
    DiagnosticoResultado CalculaTaxas(List<string> relatorio);
}
