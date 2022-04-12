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

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Order o = BindingContext as Order;
            await DisplayAlert("Order Placed",$"Order PLaced for {o.Quantity} of {o.ProductName}", "OK");
            await Navigation.PopAsync();
        }

        //private void DisplayAlert(string v1, string v2)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
