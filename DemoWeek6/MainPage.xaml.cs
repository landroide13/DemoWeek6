using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DemoWeek6.Services;

namespace DemoWeek6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        void Selected_item(System.Object sender, SelectionChangedEventArgs e)
        {
            Services.Product product = e.CurrentSelection.First() as Services.Product;

            Navigation.PushAsync(new ProductDetail(product));
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var products = await ProductService.GetProductsAsync();

            BindingContext = products;
        }
    }
}
