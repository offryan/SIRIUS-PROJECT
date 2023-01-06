using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sirius
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Teste1 : ContentPage
    {
        public Teste1()
        {
            InitializeComponent();
        }

        private void Verificar(object sender, EventArgs e)
        {
            //validacao
            if (txtNumero.Text == "")
            {
                DisplayAlert("Atenção!", "Digite um nº inteiro!!", "OK");
                return;
            }

            //declarando variaveis
            int n = Convert.ToInt32(txtNumero.Text);
            string resp = "O Número " + n + " é ";

            //checando valores digitados
            if (n == 0)
            {
                resp += "marco de escala!";
            }
            else if (n % 2 == 0)
            {
                resp += "par";
            }
            else
            {
                resp += "ímpar";
            }
            lblResult.Text = resp.ToString();
        }

        private void Reiniciar(object sender, EventArgs e)
        {
            txtNumero.Text = lblResult.Text = string.Empty;
            txtNumero.Focus();
        }
    }
}