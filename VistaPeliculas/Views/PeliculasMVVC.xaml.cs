using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VistaPeliculas.Views
{
    public partial class PeliculasMVVC : ContentPage
    {
        public PeliculasMVVC()
        {
            InitializeComponent();

            listMVVMBtn.Clicked += ListMVVCBtn_Clicked;

        }

        private void ListMVVCBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Peliculas());
        }
    }
}

