using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RemovePageReproduction.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MiddlePage : ContentPage
    {
        public MiddlePage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("lastpage");
        }
    }
}