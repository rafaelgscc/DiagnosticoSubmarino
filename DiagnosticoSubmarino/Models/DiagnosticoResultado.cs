using System;

//Principio SOLID aplicado: S: Single Responsibility — 
//essa classe tem uma única responsabilidade: armazenar e expor os dados do diagnóstico.

namespace DiagnosticoSubmarino.Models;

public class DiagnosticoResultado
{
    public int Gama {get;}
    public int Episilon {get;}

    //constuctor
    public DiagnosticoResultado(int gama, int episilon)
    {
        Gama = gama;
        Episilon = episilon;
    }

    /*Foi utilizado uma Expressao lambda de uma forma mais elegante que
    public int ConsumoEnergia
    {
        get
        {
            return Gama*Epision;
        }
    }*/

    public int ConsumoEnergia => Gama * Episilon;
}
