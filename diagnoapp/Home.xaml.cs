using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace diagnoapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        void cadastro(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Cad1());
        }

        void logado(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new logado());
        }

    }
}