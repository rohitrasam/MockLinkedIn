using LinkedinApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LinkedinApp.Views
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