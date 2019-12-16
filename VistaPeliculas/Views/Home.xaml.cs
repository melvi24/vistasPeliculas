using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VistaPeliculas.Views
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            navBtn.Clicked += NavBtn_Clicked;
            ListaPeliculasBtn.Clicked += ListaPeliculasBtn_Clicked;
            peliculasMVVCBtn.Clicked += PeliculasMVVCBtn_Clicked;
        }

        private void PeliculasMVVCBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PeliculasMVVC());
        }

        private void ListaPeliculasBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new peliculasFavoritas());
        }

        private void NavBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }
    }
}
