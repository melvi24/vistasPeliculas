using System.Collections.ObjectModel;
using System.ComponentModel;


namespace VistaPeliculas.ViewModel
{
    public class peliculasViewModel : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<ClasesPeliculas.ClasePeliculas> lista { get; set; }


        public peliculasViewModel()
        {

            lista = new ObservableCollection<ClasesPeliculas.ClasePeliculas>();

            lista.Add(new ClasesPeliculas.ClasePeliculas()
            {
                ImagenPeliculas = "menteBrillante.jpg",
                TituloPeliculas = "Una mente brillante",
                Sinopsis = "La historia del genial matemático John Forbes Nash Jr., " +
                "quien, a pesar de sufrir esquizofrenia, logró desarrollar su carrera " +
                "y obtener el Premio Nobel..",
                Director = "Ron Howard",
            });
            lista.Add(new ClasesPeliculas.ClasePeliculas()
            {
                ImagenPeliculas = "efectoMariposa.jpg",
                TituloPeliculas = "El efecto mariposa",
                Sinopsis = "Un joven estudiante de psicología viaja en el tiempo para transformar " +
                "el pasado y alterar el futuro de sus amigos..",
                Director = "Eric Bress, J. Mackye Gruber",
            });
            lista.Add(new ClasesPeliculas.ClasePeliculas()
            {
                ImagenPeliculas = "isla.jpg",
                TituloPeliculas = "La isla siniestra",
                Sinopsis = "Un alguacil de los años cincuenta persigue a una asesina que escapó de " +
                "un sanatorio en una isla remota, y hay pistas de hechos macabros cometidos en su interior..",
                Director = "Martin Scorsese",
            });
            lista.Add(new ClasesPeliculas.ClasePeliculas()
            {
                ImagenPeliculas = "origen.jpg",
                TituloPeliculas = "El origen",
                Sinopsis = "Dom Cobb es un ladrón con una extraña habilidad para entrar a los sueños de " +
                "la gente y robarles los secretos de sus subconscientes. Su habilidad lo ha vuelto muy popular " +
                "en el mundo del espionaje corporativo, pero ha tenido un gran costo en la gente que ama. " +
                "Cobb obtiene la oportunidad de redimirse cuando recibe una tarea imposible: plantar " +
                "una idea en la mente de una persona. Si tiene éxito, " +
                "será el crimen perfecto, pero un enemigo se anticipa a sus movimientos.",
                Director = "Christopher Nolan",
            });

            lista.Add(new ClasesPeliculas.ClasePeliculas()
            {
                ImagenPeliculas = "aquaman.jpg",
                TituloPeliculas = "Aquaman",
                Sinopsis = "quaman debe recuperar el legendario Tridente de Atlan para salvar a la " +
                "ciudad subacuática de Atlantis, y al mundo de la superficie, de su hermano hambriento de poder.",
                Director = "James Wan",
            });

            lista.Add(new ClasesPeliculas.ClasePeliculas()
            {
                ImagenPeliculas = "marea.jpg",
                TituloPeliculas = "Horizonte profundo",
                Sinopsis = "La historia del accidente ocurrido en un oleoducto del golfo de México en " +
                "abril de 2010, el cual causó 11 víctimas mortales y produjo una " +
                "de las catástrofes medioambientales más perjudiciales provocadas por el hombre.",
                Director = "Peter Berg",
            });

            lista.Add(new ClasesPeliculas.ClasePeliculas()
            {
                ImagenPeliculas = "verdad.jpg",
                TituloPeliculas = "El abogado del mal",
                Sinopsis = "UEl abogado Richard Ramsey defiende a un adolescente acusado de " +
                "haber asesinado a su millonario padre. Para descubrir qué ocurrió realmente " +
                "entre el padre y su hijo contará con la ayuda de Janelle, una joven letrada.",
                Director = "Nicholas Kazan",
            });
        }

    }
}



