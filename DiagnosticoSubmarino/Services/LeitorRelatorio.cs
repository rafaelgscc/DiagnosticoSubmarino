using System;
using System.Globalization;
using System.Text.Json;

namespace DiagnosticoSubmarino.Services;

public class LeitorRelatorio
{
    public static List<string> LerRelatorioJSON(string relativePath)
    {
        //verifica o path no projeto
        var fullPath = Path.Combine(AppContext.BaseDirectory, relativePath);
        if (!File.Exists(fullPath))
        {
            //mensagem de que não encontrou o arquivo
            Console.WriteLine($"Arquivo não encontrado: {fullPath}");
            throw new FileNotFoundException("Arquivo JSON não encontrado.", fullPath);
        }

        var json = File.ReadAllText(fullPath);
        var relatorio = JsonSerializer.Deserialize<List<string>>(json);
        //usado um operador de coalescência nula mais elegante que verificar se relatorio é NULL
        return relatorio ?? new List<string>();
    }

}
