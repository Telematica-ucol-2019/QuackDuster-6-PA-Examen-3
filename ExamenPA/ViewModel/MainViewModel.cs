using Bogus;
using ExamenPA.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExamenPA.ViewModel
{
    internal class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Vehiculo> Vehiculos { get; set; }
        public ICommand cmdAddVehiculo { get; set; }
        public ICommand cmdDetalleVehiculo { get; set; }

        private Vehiculo vehiculo;
        public Vehiculo vehiculo
        {
            get { return vehiculo; }
            set { vehiculo = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            Vehiculos = new ObservableCollection<Vehiculo>();
            cmdAddVehiculo = new Command(() => cmdAddVehiculoMetodo());
        }

        private void cmdAddVehiculoMetodo()
        {
            Vehiculo vehiculo = new Faker<Vehiculo>()
                .RuleFor(c => c.Modelo, f => f.Person.Avatar)
                .RuleFor(c => c.Año, f => f.Address.BuildingNumber());

            vehiculo.Marca = new Faker<Marca>()
                (c => c.Name, f => f.Person.Name);
        }

        public void GetAll()
        {
            if (Vehiculos != null)
            {
                Vehiculos.Clear();
                App.VehiculoDB.GetAll().ForEach(item => Vehiculos.Add(item));

            }
            else
            {
                Vehiculos = new ObservableCollection<Vehiculo>(App.VehiculoDB.GetAll());
            }
            OnPropertyChanged();
        }


        public void GetAllActors()
        {
            if (Actors != null)
            {
                Actors.Clear();
                App.ActorDB.GetAll().ForEach(item => Actors.Add(item));

            }
            else
            {
                Actors = new ObservableCollection<Actor>(App.ActorDB.GetAll());
            }
            OnPropertyChanged();
        }
    }
}
