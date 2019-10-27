using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppUtecoTrans
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PgLogin : ContentPage
    {
        public PgLogin()
        {
            InitializeComponent();
        }

        private async void btnRegistar_Clicked(object sender, EventArgs e)
        {
           
            await Navigation.PushModalAsync(new PgRegistrar());
            
        }

        private async void btnAcceder_Clicked(object sender, EventArgs e)
        {
            
           
        }
    }
}