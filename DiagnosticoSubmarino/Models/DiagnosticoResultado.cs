using System;

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

    public int ConsumoEnergia => Gama * Episilon;
}
