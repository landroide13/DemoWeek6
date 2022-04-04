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
    }
}
