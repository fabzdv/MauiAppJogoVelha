namespace MauiAppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        int jogadas = 0;
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            jogadas++;  
            btn.IsEnabled = false;

            if(vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            if (btn10.Text == "X" &&
                btn11.Text == "X" &&
                btn12.Text == "X")
            {
                DisplayAlert("Parabens 🏆", "o X ganhou", "Zerar");
                limpar();
            }
              
            if(btn20.Text == "X" &&
               btn21.Text == "X" &&
               btn22.Text == "X")
            {
                DisplayAlert("Parabens 🏆", "o X ganhou", "Zerar");
                limpar();
            }

            if(btn30.Text == "X" &&
               btn31.Text == "X" &&
               btn32.Text == "X")
            {
                DisplayAlert("Parabens 🏆", "o X ganhou", "Zerar");
                limpar();
            }

            if(btn10.Text == "X" &&
               btn20.Text == "X" &&
               btn30.Text == "X")
            {
                DisplayAlert("Parabens 🏆", "o X ganhou", "Zerar");
                limpar();
            }

            if(btn11.Text == "X" &&
               btn21.Text == "X" &&
               btn31.Text == "X")
            {
                DisplayAlert("Parabens 🏆", "o X ganhou", "Zerar");
                limpar();
            }
            if(btn12.Text == "X" &&
               btn22.Text == "X" &&
               btn32.Text == "X")
            {
                DisplayAlert("Parabens 🏆", "o X ganhou", "Zerar");
                limpar();
            }

            if(btn10.Text == "X" &&
               btn21.Text == "X" &&
               btn32.Text == "X")
            {
                DisplayAlert("Parabens 🏆", "o X ganhou", "Zerar");
                limpar();
            }

            if(btn12.Text == "X" &&
               btn21.Text == "X" &&
               btn30.Text == "X")
            {
                DisplayAlert("Parabens 🏆", "o X ganhou", "Zerar");
                limpar();
            }

            if (btn10.Text == "O" &&
                btn11.Text == "O" &&
                btn12.Text == "O")
            {
                DisplayAlert("Parabens 🏆", "o O ganhou", "Zerar");
                limpar();
            }

            if (btn20.Text == "O" &&
               btn21.Text == "O" &&
               btn22.Text == "O")
            {
                DisplayAlert("Parabens 🏆", "o O ganhou", "Zerar");
                limpar();
            }

            if (btn30.Text == "O" &&
               btn31.Text == "O" &&
               btn32.Text == "O")
            {
                DisplayAlert("Parabens 🏆", "o O ganhou", "Zerar");
                limpar();
            }

            if (btn10.Text == "O" &&
               btn20.Text == "O" &&
               btn30.Text == "O")
            {
                DisplayAlert("Parabens 🏆", "o O ganhou", "Zerar");
                limpar();
            }

            if (btn11.Text == "O" &&
               btn21.Text == "O" &&
               btn31.Text == "O")
            {
                DisplayAlert("Parabens 🏆", "o O ganhou", "Zerar");
                limpar();
            }
            if (btn12.Text == "O" &&
               btn22.Text == "O" &&
               btn32.Text == "O")
            {
                DisplayAlert("Parabens 🏆", "o O ganhou", "Zerar");
                limpar();
            }

            if (btn10.Text == "O" &&
               btn21.Text == "O" &&
               btn32.Text == "O")
            {
                DisplayAlert("Parabens 🏆", "o O ganhou", "Zerar");
                limpar();
            }

            if (btn12.Text == "O" &&
               btn21.Text == "O" &&
               btn30.Text == "O")
            {
                DisplayAlert("Parabens 🏆", "o O ganhou", "Zerar");
                limpar();
            }

            if(jogadas == 9)
            {
                DisplayAlert("Empate", "Ninguém ganhou", "Zerar");
                limpar();
            }

            void limpar()
            {
                jogadas = 0;
                vez = "X";
                btn10.Text = "";
                btn11.Text = "";
                btn12.Text = "";

                btn20.Text = "";
                btn21.Text = "";
                btn22.Text = "";

                btn30.Text = "";
                btn31.Text = "";
                btn32.Text = "";

                btn10.IsEnabled = true;
                btn11.IsEnabled = true;
                btn12.IsEnabled = true;

                btn20.IsEnabled = true;
                btn21.IsEnabled = true;
                btn22.IsEnabled = true;

                btn30.IsEnabled = true;
                btn31.IsEnabled = true;
                btn32.IsEnabled = true; 
            }
        }
    }

}
