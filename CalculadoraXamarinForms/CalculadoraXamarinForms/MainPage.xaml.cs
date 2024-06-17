using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraXamarinForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnOperacionesBasicas(object sender, EventArgs e)
        {
            Application.Current.MainPage = new OperacionesBasicasPage();
        }

        private void Llamar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CallPage();
        }

        private void Navegar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigatePage();
        }

        private void Compartir(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SharePage();
        }

    }
}
