using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace VistaPeliculas
{

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ListadoPeliculas : ContentPage
    {

        List<Pelicula> Peliculas;

        public ListadoPeliculas()
        {
            InitializeComponent();
        }

        Peliculas = new List<Pelicula>();
    }


    public class Peliculas
    {


        public string Imagen { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string LeerMas { get; set; }
    }

}
}
}
