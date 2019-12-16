using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VistaPeliculas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class detallesPeliculasMaster : ContentPage
    {
        public ListView ListView;

        public detallesPeliculasMaster()
        {
            InitializeComponent();

            BindingContext = new detallesPeliculasMasterViewModel();
            ListView = MenuItemsListView;
        }

        class detallesPeliculasMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<detallesPeliculasMenuItem> MenuItems { get; set; }

            public detallesPeliculasMasterViewModel()
            {
                MenuItems = new ObservableCollection<detallesPeliculasMenuItem>(new[]
                {
                    new detallesPeliculasMenuItem { Id = 0, Title = "Page 1" },
                    new detallesPeliculasMenuItem { Id = 1, Title = "Page 2" },
                    new detallesPeliculasMenuItem { Id = 2, Title = "Page 3" },
                    new detallesPeliculasMenuItem { Id = 3, Title = "Page 4" },
                    new detallesPeliculasMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
