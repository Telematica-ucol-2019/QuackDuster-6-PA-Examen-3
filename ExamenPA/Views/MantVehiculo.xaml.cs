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
    public partial class MantVehiculo : ContentPage
    {
        public MantVehiculo(Vehiculo vehiculo)
        {
            InitializeComponent();
            BindingContext = new MantViewModel(vehiculo);
        }
    }
}