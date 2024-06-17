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
    public partial class SharePage : ContentPage
    {
        public SharePage()
        {
            InitializeComponent();
        }

        private void OnCompartirClicked(object sender, EventArgs e)
        {
            var mensaje = EntryMensaje.Text;
            if (!string.IsNullOrEmpty(mensaje))
            {
                var compartir = new ShareTextRequest
                {
                    Text = mensaje,
                    Title = "Compartir Mensaje"
                };
                Share.RequestAsync(compartir);
            }
        }
    }
}