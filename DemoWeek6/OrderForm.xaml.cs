using System;
using System.Collections.Generic;
using DemoWeek6.Services;
using Xamarin.Forms;

namespace DemoWeek6
{
    public partial class OrderForm : TabbedPage
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(Order target)
        {
            InitializeComponent();
            BindingContext = target;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Order o = BindingContext as Order;
            DisplayAlert("Order Placed", $"Order PLaced for {o.Quantity} of {o.ProductName}");
        }
    }
}
