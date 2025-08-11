using System;
using System.IO;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }

    public Pessoa(string nome, int idade, string email)
    {
        Nome = nome;
        Idade = idade;
        Email = email;
    }


    public void GerarArquivoSobrePessoas()
    {
        string pasta = "ArquivosGerados";
        Directory.CreateDirectory(pasta);

        string nomeDoArquivo = Path.Combine(pasta, $"Informacoes-Pessoais-de-{Nome}.txt");
        using (StreamWriter escritor = new StreamWriter(nomeDoArquivo))
        {
            escritor.WriteLine($"Informações Pessoais de {Nome}");
            escritor.WriteLine($"Nome: {Nome}");
            escritor.WriteLine($"Idade: {Idade}");
            escritor.WriteLine($"E-mail: {Email}");
        }
        Console.WriteLine($"Arquivo gerado com sucesso!");
    }

    static void Main()
    {
        Pessoa pessoa = new Pessoa("Pedro", 21, "phteste@email.com");
        pessoa.GerarArquivoSobrePessoas();
    }
}