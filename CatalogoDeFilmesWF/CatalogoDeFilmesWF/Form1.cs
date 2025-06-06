using System.Net.Http.Json;

namespace CatalogoDeFilmesWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string filme = txtNomeDoFilme.Text;
            string API = "";
            string Link = $"https://api.themoviedb.org/3/search/movie?api_key={API}&query={Uri.EscapeDataString(filme)}";

            using var cliente = new HttpClient();

            var resposta = await cliente.GetFromJsonAsync<ResultadoFilme>(Link);
            
            if (resposta != null) {
                foreach (var filmes in resposta.ResultadosDoFilme)
                {
                    lblNomeFilme.Text = "Nome do filme: " + filmes.Title;
                    lblSinopse.Text = "Sin�pse do filme: " +
                    (filmes.Overview.Length > 75 ? filmes.Overview.Substring(0, 75) + "..." : filmes.Overview);
                    lblData.Text ="A data de lan�amento �: " + filmes.Release_Date;
                    lblNota.Text = "A sua nota �: " + filmes.Vote_Average;
                    lblAdulto.Text = "� um filme +18 ? " + filmes.Adult;
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }

        }
    }
}
