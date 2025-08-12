using System;
using System.IO;
using System.Text.Json;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        string fileName = "pessoa.json";

        if (File.Exists(fileName))
        {
            try
            {
                string jsonString = File.ReadAllText(fileName);
                Pessoa pessoa = JsonSerializer.Deserialize<Pessoa>(jsonString);

                if (pessoa != null)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}");
                    Console.WriteLine($"Idade: {pessoa.Idade}");
                    Console.WriteLine($"E-mail: {pessoa.Email}");
                }
                else
                {
                    Console.WriteLine("Erro ao desserializar o conteúdo do arquivo.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler ou desserializar o arquivo: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine($"O arquivo {fileName} não existe.");
        }
    }
}
