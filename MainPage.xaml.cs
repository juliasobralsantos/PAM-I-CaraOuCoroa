using CaraOuCoroa.Models;

namespace CaraOuCoroa
{
    public partial class MainPage : ContentPage
    {
        string escolha = "";
        string resultado = "";
        int escolhaResultado = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void CaraCoroaBtn_Clicked(object sender, EventArgs e)
        {
            //Pegar valor escolhido pelo picker
            escolha = CaraCoroaPicker.SelectedItem.ToString();

            //Sortear uma escolha (cara ou coroa)
            CaraCoroa caraCoroa = new(escolha);

            //Sortear um numero
            int rnd = caraCoroa.escolhaResultado();

            //Comparar o que o usuário escolheu com o número sorteado
            EscolhaResultado("Cara");

            //Exibe a mensagem de resultado do sorteio
            ExibirMensagem(rnd);

            //Troca a imagem de acordo com o número sorteado
            TrocarImagem(rnd);
        }

        private void EscolhaResultado(string escolhaDoUsuario)
        {
            if (escolha == escolhaDoUsuario)
            {
                escolhaResultado = (int)CoinType.CARA;
            }
            else
            {
                escolhaResultado = (int)CoinType.COROA;
            }
        }

        private void ExibirMensagem(int rnd)
        {
            if (escolhaResultado == rnd)
            {
                ResultLabel.Text = $"Eba! Deu {escolha}!";
            }
            else
            {
                ResultLabel.Text = $"Que pena! Não deu {escolha} :(";
            }
        }

        private void TrocarImagem(int rnd)
        {
            switch (rnd)
            {
                case (int)CoinType.CARA:
                    moeda.Source = "cara.png";
                    break;
                case (int)CoinType.COROA:
                    moeda.Source = "coroa.png";
                    break;
            }
        }
    }
}

