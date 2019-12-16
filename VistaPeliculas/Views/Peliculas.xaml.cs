using System;
using System.Collections.Generic;
using VistaPeliculas.ClasesPeliculas;
using VistaPeliculas.ViewModel;
using Xamarin.Forms;

namespace VistaPeliculas.Views
{
    public partial class Peliculas : ContentPage
    {
        public Peliculas()
        {
            InitializeComponent();

            BindingContext = new peliculasViewModel();
        }

        private async void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ClasePeliculas item = e.SelectedItem as ClasePeliculas;
            if (item == null)
                return;
            await Navigation.PushModalAsync(new PeliculasDetalles(new detalleViewModel(item)));

        }
    }
}


