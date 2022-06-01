using ExamenPA.Models;
using ExamenPA.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenPA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleVehiculo : ContentPage
    {
        public DetalleVehiculo(Vehiculo vehiculo, MainViewModel vm)
        {
            InitializeComponent();
            //Console.WriteLine(movie.Actors[0].Name);
            vm.Vehiculo = new Vehiculo();
            vm.Vehiculo = vehiculo;
            //Console.WriteLine(vehiculo.Actors);

            //vm.GetAllActors(movie);
            this.BindingContext = vm;
            //BindingContext = new DetailMovieViewModel(movie);


        }
    }
}