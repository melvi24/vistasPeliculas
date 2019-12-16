using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VistaPeliculas.Views
{
    public partial class ListadoPeliculass : ContentPage
    {

        List<Pelicula> Peliculas;

        public ListadoPeliculass()
        {
            InitializeComponent();
            Peliculas = new List<Pelicula>();

            Peliculas.Add(new Pelicula()
            {
                Imagen = "menteBrillante.jpg",
                Nombre = "Mente Brillante",
                Genero = "Triller",
                LeerMas = "LeerMas"

            });

            Peliculas.Add(new Pelicula()
            {
                Imagen = "efectoMariposa.jpg",
                Nombre = "Efecto Mariposa",
                Genero = "Triller",
                LeerMas = "LeerMas"

            });

            Peliculas.Add(new Pelicula()
            {
                Imagen = "isla.jpg",
                Nombre = "La isla siniestra",
                Genero = "Terror",
                LeerMas = "LeerMas"

            });

            Peliculas.Add(new Pelicula()
            {
                Imagen = "origen.jpg",
                Nombre = "El origen",
                Genero = "Triller",
                LeerMas = "LeerMas"

            });

            Peliculas.Add(new Pelicula()
            {
                Imagen = "aquaman.jpg",
                Nombre = "Aquaman",
                Genero = "Accion",
                LeerMas = "LeerMas"

            });

            Peliculas.Add(new Pelicula()
            {
                Imagen = "marea.jpg",
                Nombre = "Marea Negra",
                Genero = "Accion",
                LeerMas = "LeerMas"

            });

            Peliculas.Add(new Pelicula()
            {
                Imagen = "verdad.jpg",
                Nombre = "Toda la Verdad",
                Genero = "Triller",
                LeerMas = "LeerMas"

            });

            ListaPeliculas.ItemsSource = Peliculas;
        }
    }
}

public class Pelicula
{


    public string Imagen { get; set; }
    public string Nombre { get; set; }
    public string Genero { get; set; }
    public string LeerMas { get; set; }
}
