using lvlapp.ViewModels;
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

    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (NameString.Text == "admin" && PassString.Text == "admin")
                await Shell.Current.GoToAsync("//Main");
            else
                await DisplayAlert("Ups...", message: "Imię lub hasło jest niepoprawne!", cancel: "Ok");


        }

        private async void Register_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Login/Registration");
        }

    }
}