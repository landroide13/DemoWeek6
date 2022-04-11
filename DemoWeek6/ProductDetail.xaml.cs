using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoWeek6
{
    public partial class ProductDetail : ContentPage
    {
        public ProductDetail()
        {
            InitializeComponent();
        }

        public ProductDetail(Services.Product product)
        {
            InitializeComponent();

            BindingContext = product;
        }

        void orderBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Services.Product p = BindingContext as Services.Product;
            Navigation.PushAsync(new OrderForm(new Services.Order { ProductName = p.Name, Quantity = 1 }));
        }
    }
}
