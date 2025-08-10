using System;
using System.Collections.Generic;
using System.Linq;


class Program
{

    public static void FiltrarPares (List<int> numeros)
    {
        var numerosPares = numeros.Where(numero => numero % 2 == 0);

        Console.WriteLine("Números pares:");
        foreach ( var numero in numerosPares )
        {
            Console.WriteLine(numero);
        }
    }

    static void Main()
    {
        List<int> numeros = new List<int> { 57, 23, 89, 12, 44, 76, 33, 68, 91, 5, 38, 84, 27, 49, 61, 70, 15, 93, 8, 55 };

        FiltrarPares(numeros);
    }
}

