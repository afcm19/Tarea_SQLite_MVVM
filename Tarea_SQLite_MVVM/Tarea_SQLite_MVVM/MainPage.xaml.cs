using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_SQLite_MVVM.ModelViewModel;
using Xamarin.Forms;

namespace Tarea_SQLite_MVVM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModelPersonas();
        }

        private async void lista_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new inicio());
        }
    }
}
