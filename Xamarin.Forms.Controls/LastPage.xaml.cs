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
    public partial class LastPage : ContentPage
    {
        public LastPage()
        {
            InitializeComponent();
            var existingPages = Shell.Current.Navigation.NavigationStack.ToList();
            foreach (var page in existingPages)
            {
                if (page != null)
                {
                    Shell.Current.Navigation.RemovePage(page);
                }
            }
        }
    }
}