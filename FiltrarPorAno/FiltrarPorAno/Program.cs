using System;
using System.Collections.Generic;
using System.Linq;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }

    // Método que retorna livros publicados a partir de 2000
    public static void FiltrarAno(List<Livro> livros)
    {
        var livrosFiltrados = livros.Where(l => l.AnoPublicacao > 2000).OrderBy(l => l.Titulo);

        Console.WriteLine("Livros publicados após 2000:");
        foreach (var livro in livrosFiltrados)
        {
            Console.WriteLine($"- Titulo: {livro.Titulo} | Autor: {livro.Autor}");
        }
    }
}

class Program
{
    static void Main()
    {
        var livros = new List<Livro>
        {
            new Livro { Titulo = "A Guerra dos Tronos", Autor = "George R. R. Martin", AnoPublicacao = 1996 },
            new Livro { Titulo = "O Senhor dos Anéis", Autor = "J. R. R. Tolkien", AnoPublicacao = 1954 },
            new Livro { Titulo = "Harry Potter e a Pedra Filosofal", Autor = "J. K. Rowling", AnoPublicacao = 1997 },
            new Livro { Titulo = "O Código Da Vinci", Autor = "Dan Brown", AnoPublicacao = 2003 },
            new Livro { Titulo = "A Menina que Roubava Livros", Autor = "Markus Zusak", AnoPublicacao = 2005 },
            new Livro { Titulo = "O Hobbit", Autor = "J. R. R. Tolkien", AnoPublicacao = 1937 },
            new Livro { Titulo = "Cem Anos de Solidão", Autor = "Gabriel García Márquez", AnoPublicacao = 1967 },
            new Livro { Titulo = "1984", Autor = "George Orwell", AnoPublicacao = 1949 },
            new Livro { Titulo = "O Pequeno Príncipe", Autor = "Antoine de Saint-Exupéry", AnoPublicacao = 1943 },
            new Livro { Titulo = "A Culpa é das Estrelas", Autor = "John Green", AnoPublicacao = 2012 }
        };

        Livro.FiltrarAno(livros);
    }
}
