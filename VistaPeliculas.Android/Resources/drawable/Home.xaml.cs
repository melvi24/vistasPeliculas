using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VistaPeliculas.Views
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
               navBtn.Clicked += NavBtn_Clicked;
        }

        private void NavBtn_Clicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new About());
        }

        
    }
}
