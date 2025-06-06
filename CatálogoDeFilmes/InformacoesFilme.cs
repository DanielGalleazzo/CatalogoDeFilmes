using System.Text.Json.Serialization;

namespace CatálogoDeFilmes
{
    public class InformacoesFilme
    {
        public string Title { get; set; }
        public string Overview { get; set; }
        public string Release_Date { get; set; }
        public double Vote_Average { get; set; }
        public bool Adult { get; set; }
    }

    public class ResultadoFilme
    {
        [JsonPropertyName("results")]
        public List<InformacoesFilme> ResultadosDoFilme { get; set; }
    }
}