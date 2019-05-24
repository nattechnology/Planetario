using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Planetario
{
   
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Sala_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(),true);
        }

        private async void Eventos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Event(),true);
        }

        private async void Conocenos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cono(),true);
        }
    }
}
