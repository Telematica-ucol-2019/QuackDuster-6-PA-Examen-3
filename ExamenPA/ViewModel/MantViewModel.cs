using ExamenPA.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ExamenPA.ViewModel
{
    public class MantViewModel : BaseViewModel
    {
        public Vehiculo vehiculo { get; set; }

        public ICommand cmdSaveMovie { get; set; }
        public MantViewModel(Vehiculo vehiculo)
        {
            Vehiculo = vehiculo;

            cmdSaveMovie = new Command<Vehiculo>((item) => cmdSaveMovieMethod(item));
        }

        private void cmdSaveMovieMethod(Vehiculo vehiculo)
        {
            //Console.WriteLine(movie.Producer.Name);
            App.VehiculoDB.InsertOrUpdate(vehiculo);
            //App.ProducerDB.InsertOrUpdate(movie.Producer);
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
