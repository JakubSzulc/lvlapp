using lvlapp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace lvlapp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}