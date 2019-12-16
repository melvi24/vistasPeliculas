using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VistaPeliculas.Views
{
    public partial class peliculasFavoritas : ContentPage
    {
        public peliculasFavoritas()
        {
            InitializeComponent();
            ListBtn.Clicked += ListBtn_Clicked;
            
        }

        private void ListBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListadoPeliculass());
        }
    }
}
