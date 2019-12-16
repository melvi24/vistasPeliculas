using System;
using VistaPeliculas.ClasesPeliculas;

namespace VistaPeliculas.ViewModel
{
    public class detalleViewModel
    {
        public string ImagenPeliculas { get; set; }
        public string TituloPeliculas { get; set; }
        public string Sinopsis { get; set; }
        public string Director { get; set; }
        public detalleViewModel(ClasePeliculas peliculas)
        {
            TituloPeliculas = peliculas.TituloPeliculas;
            Sinopsis = peliculas.Sinopsis;
            Director = peliculas.Director;
            ImagenPeliculas = peliculas.ImagenPeliculas;
        }
    }
}



