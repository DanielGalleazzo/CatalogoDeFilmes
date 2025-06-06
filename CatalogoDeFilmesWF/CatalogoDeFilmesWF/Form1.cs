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
            if (string.IsNullOrWhiteSpace(API))
            {
                MessageBox.Show("Insira uma chave API");
                return;
            }
            string Link = $"https://api.themoviedb.org/3/search/movie?api_key={API}&query={Uri.EscapeDataString(filme)}";
            using var cliente = new HttpClient();

            var resposta = await cliente.GetFromJsonAsync<ResultadoFilme>(Link);

                if (resposta != null)
                {
                    foreach (var filmes in resposta.ResultadosDoFilme)
                    {
                        lblNomeFilme.Text = filmes.Title;
                        lblSinopse.Text = (filmes.Overview.Length > 75 ? filmes.Overview.Substring(0, 75) + "..." : filmes.Overview);
                        lblData.Text = filmes.Release_Date;
                        lblNota.Text = "A sua nota é: " + filmes.Vote_Average;
                        lblAdulto.Text = "É um filme +18 ? " + filmes.Adult;

                        //
                        // string linkImagem = "https://api.themoviedb.org" + filmes.Poster_Path;
                        // label1.Text =  linkImagem;
                        // try
                        // {
                        // using var posterStream = await cliente.GetStreamAsync(linkImagem);
                        //pictureBox1.Image = System.Drawing.Image.FromStream(posterStream);
                        //}
                        //catch (Exception ex)
                        //{
                        //MessageBox.Show("Erro ao carregar imagem do pôster: " + ex.Message);
                        //}
                        //

                        // Os comentários acima são para caso você queira carregar o poster do filme
                        // porém, o formato que o The movie data base envia geralmente não funciona,
                        // então não recomendo usar essa parte do código

                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                }
            }

        }
    }

