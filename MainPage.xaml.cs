namespace CaraOuCoroa
{
    public partial class MainPage : ContentPage
    {
        string escolha = "";
        string resultado = "";
        int escolhaResultado = 0;
        int caraoucoroa = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void CaraCoroaBtn_Clicked(object sender, EventArgs e)
        {
            escolha = CaraCoroaPicker.SelectedItem.ToString();
            int rnd = new Random().Next(0, 2);

            if (escolha == "Cara")
            {
                escolhaResultado = 0;
            }
            else
            {
                escolhaResultado = 1;
            }


            if(escolhaResultado == rnd)
            {
                ResultLabel.Text = $"Eba! Deu {escolha}!";
            }
            else
            {
                ResultLabel.Text = $"Que pena! Não deu {escolha} :(";
            }

            switch (rnd)
            {
                case 0:
                    moeda.Source = "cara.png";
                break; 
                case 1:
                    moeda.Source = "coroa.png";
                break;
            }
        }
    }

}
