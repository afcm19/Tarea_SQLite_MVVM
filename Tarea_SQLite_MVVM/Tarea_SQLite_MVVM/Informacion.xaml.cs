using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_SQLite_MVVM.ModelViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea_SQLite_MVVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Informacion : ContentPage
    {
        public Informacion()
        {
            InitializeComponent();
            BindingContext = new ViewModelPersonas();
        }
    }
}