using System;

namespace ExercicioLoop
{
    public class Kata
    {
        public static Func<char> MakeLooper(string str)
        {
            int contador = 0;
            return () =>
            {
                char letra = str[contador];
                contador = (contador + 1) % str.Length;
                return letra;
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var looper = Kata.MakeLooper("abc");

            Console.WriteLine(looper()); // a
            Console.WriteLine(looper()); // b
            Console.WriteLine(looper()); // c
            Console.WriteLine(looper()); // a
            Console.WriteLine(looper()); // b

            Console.ReadLine(); // mantém o console aberto
        }
    }
}
