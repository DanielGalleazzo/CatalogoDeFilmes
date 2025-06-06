using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Digite o nome do filme");
        string NomeFilme = Console.ReadLine();

        var filmes = await BuscarFilmes.ProcurarFilmeAsync(NomeFilme);

        foreach (var filme in filmes)
        {
            Console.WriteLine("Nome do filme: " + filme.Title);
            Console.WriteLine("Sinópse do filme: " + filme.Overview);
            Console.WriteLine("A data de lançamento é: " + filme.Release_Date);
            Console.WriteLine("A sua nota é: " + filme.Vote_Average);
            Console.WriteLine("É um filme +18 ?" + filme.Adult);
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}