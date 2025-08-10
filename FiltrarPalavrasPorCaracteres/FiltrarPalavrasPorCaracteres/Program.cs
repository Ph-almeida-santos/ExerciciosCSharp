using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Método que retorna as palavras com mais de 3 caracteres e imprime elas
    public static void Caractere3mais(List<string> palavras)
    {
        var comMaisDeTres = palavras.Where(p => p.Length > 3).ToList();

        Console.WriteLine("Palavras com mais de 3 caracteres:");
        foreach (var palavra in comMaisDeTres)
        {
            Console.WriteLine($"- {palavra}");
        }
    }

    static void Main()
    {
        List<string> palavras = new List<string>
        {
            "banana", "maçã", "laranja", "abacaxi", "uva", "kiwi", "morango", "cereja", "pera", "melancia"
        };

        Caractere3mais(palavras);
    }
}
