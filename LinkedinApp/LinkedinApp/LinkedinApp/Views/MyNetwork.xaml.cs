using LinkedinApp.Models;
using LinkedinApp.ViewModels;
using LinkedinApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LinkedinApp.Views
{
    public partial class MyNetworkPage : ContentPage
    {
        MyNetworkViewModel _viewModel;

        public MyNetworkPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new MyNetworkViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}