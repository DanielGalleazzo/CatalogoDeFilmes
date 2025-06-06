using System.Net.Http.Json;
using CatálogoDeFilmes;

public class BuscarFilmes
{
    public static async Task<List<InformacoesFilme>> ProcurarFilmeAsync(string nomeFilme)
    {
        var API = "";
        var Link = $"https://api.themoviedb.org/3/search/movie?api_key={API}&query={Uri.EscapeDataString(nomeFilme)}";

        using var cliente = new HttpClient();
        var resposta = await cliente.GetFromJsonAsync<ResultadoFilme>(Link);
        return resposta?.ResultadosDoFilme ?? new();
    }
}