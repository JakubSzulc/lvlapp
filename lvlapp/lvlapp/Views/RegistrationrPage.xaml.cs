using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lvlapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationrPage : ContentPage
    {
        public RegistrationrPage()
        {
            InitializeComponent();
        }

        private void Button_Registration_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Gratulacje!", "Rejestracja przebiegła poprawnie!", "OK");
            Shell.Current.GoToAsync("//LoginPage");
        }
    }
}