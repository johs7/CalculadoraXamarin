using System;
using Xamarin.Forms;

namespace CalculadoraXamarinForms
{
    public partial class OperacionesBasicasPage : ContentPage
    {
        public OperacionesBasicasPage()
        {
            InitializeComponent();
        }

        private void OnSumarClicked(object sender, EventArgs e)
        {
            if (double.TryParse(EntryNumero1.Text, out double num1) && double.TryParse(EntryNumero2.Text, out double num2))
            {
                double resultado = num1 + num2;
                ResultadoLabel.Text = "Resultado: " + resultado;
            }
            else
            {
                ResultadoLabel.Text = "Por favor, ingrese números válidos en ambos campos.";
            }
        }

        private void OnRestarClicked(object sender, EventArgs e)
        {
            if (double.TryParse(EntryNumero1.Text, out double num1) && double.TryParse(EntryNumero2.Text, out double num2))
            {
                double resultado = num1 - num2;
                ResultadoLabel.Text = "Resultado: " + resultado;
            }
            else
            {
                ResultadoLabel.Text = "Por favor, ingrese números válidos en ambos campos.";
            }
        }

        private void OnMultiplicarClicked(object sender, EventArgs e)
        {
            if (double.TryParse(EntryNumero1.Text, out double num1) && double.TryParse(EntryNumero2.Text, out double num2))
            {
                double resultado = num1 * num2;
                ResultadoLabel.Text = "Resultado: " + resultado;
            }
            else
            {
                ResultadoLabel.Text = "Por favor, ingrese números válidos en ambos campos.";
            }
        }

        private void OnDividirClicked(object sender, EventArgs e)
        {
            if (double.TryParse(EntryNumero1.Text, out double num1) && double.TryParse(EntryNumero2.Text, out double num2))
            {
                if (num2 != 0)
                {
                    double resultado = num1 / num2;
                    ResultadoLabel.Text = "Resultado: " + resultado;
                }
                else
                {
                    ResultadoLabel.Text = "No se puede dividir por cero.";
                }
            }
            else
            {
                ResultadoLabel.Text = "Por favor, ingrese números válidos en ambos campos.";
            }
        }

        private void OnVolverClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }
    }
}
