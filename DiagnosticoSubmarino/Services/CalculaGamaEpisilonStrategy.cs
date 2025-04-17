using System;
using DiagnosticoSubmarino.Interfaces;
using DiagnosticoSubmarino.Models;

namespace DiagnosticoSubmarino.Services;

public class CalculaGamaEpisilonStrategy : IDiagnosticoStrategy
{
    public DiagnosticoResultado CalculaTaxas(List<string> relatorio)
    {
        int tamanhoBit = relatorio[0].Length;
        int[] count = new int[tamanhoBit];

        //contando cada bit em cada posicao
        foreach(var binario in relatorio)
        {
            for(int i = 0; i<tamanhoBit; i++)
            {
                if(binario[i]==1)
                    count[i]++;
            }
        }

        string gamaString = "", episilonString = "";
        int metade = relatorio.Count / 2;

        //juncao da string com os valores de Gama e de Epision

        for(int i = 0; i < tamanhoBit; i++)
        {
            //fazendo a verificacao das colunas
            if(count[i]>metade)
            {
                gamaString += "1";
                episilonString += "0";
            }
            else
            {
                 gamaString += "1";
                episilonString += "0";
            }
        }

        //converter valores para decimal

        int gama = Convert.ToInt32(gamaString, 2);
        int episilon = Convert.ToInt32(episilonString, 2);

        return new DiagnosticoResultado(gama, episilon);
    }
}
