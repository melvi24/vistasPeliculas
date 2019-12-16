using System;
using System.Collections.Generic;
using VistaPeliculas.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VistaPeliculas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class PeliculasDetalles : ContentPage
    {
        public PeliculasDetalles(detalleViewModel Peliculas)
        {
            InitializeComponent();
            BindingContext = Peliculas;

        }
    }
}

