using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraXamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CallPage : ContentPage
    {
        public CallPage()
        {
            InitializeComponent();
        }

        private void OnLlamarClicked(object sender, EventArgs e)
        {
            string numero = EntryNumero.Text;
            if (!string.IsNullOrEmpty(numero))
            {
                PhoneDialer.Open(numero);
            }
        }
    }
}