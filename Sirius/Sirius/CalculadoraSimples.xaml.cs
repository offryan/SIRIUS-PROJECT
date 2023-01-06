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
    public partial class CalculadoraSimples : ContentPage
    {
        public CalculadoraSimples()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            //criando variaveis
            double valorA = 0, valorB = 0, resultado = 0;
            Button bt = (Button)sender;
            valorA = Convert.ToDouble(txtValorA.Text);
            valorB = Convert.ToDouble(txtValorB.Text);
            

            //checando a operacao a ser executada
            switch (bt.Text)
            {
                case "+":
                    resultado = valorA + valorB;
                    break;
                case "-":
                    resultado = valorA - valorB;
                    break;
                case "*":
                    resultado = valorA * valorB;
                    break;
                case "/":
                    resultado = valorA / valorB;
                    break;
                case "c":
                    txtValorA.Text = txtValorB.Text = string.Empty;
                    txtValorA.Focus();
                    break;
            }
            lblResult.Text = resultado.ToString();
        }
    }
}