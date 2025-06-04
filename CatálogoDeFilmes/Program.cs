Console.WriteLine("Digite o nome do filme");
string NomeFilme = Console.ReadLine();

var filmes = await BuscarFilmes.ProcurarFilmeAsync(NomeFilme);

foreach(var filme in filmes)
{
    Console.WriteLine("Nome do filme: " + filme.Title);
    Console.WriteLine("Sinópse do filme: " + filme.Overview);
}
