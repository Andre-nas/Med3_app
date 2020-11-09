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
    public partial class Cad1 : ContentPage
    {
        public Cad1()
        {
            InitializeComponent();
        }

        void ImageButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Cad2());
        }
    }
}