using ExamenPA.Repositories;
using ExamenPA.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenPA
{
    public partial class App : Application
    {
        #region Repository
        private static MarcaRepository _marcaDB;
        public static MarcaRepository MarcaDB
        {
            get
            {
                if (_marcaDB == null)
                {
                    _marcaDB = new MarcaRepository();
                }
                return _marcaDB;
            }
        }

        private static VehiculoRepository _vehiculoDB;
        public static VehiculoRepository VehiculoDB
        {
            get
            {
                if (_vehiculoDB == null)
                {
                    _vehiculoDB = new VehiculoRepository();
                }
                return _vehiculoDB;
            }
        }
        #endregion
        public App()
        {
            InitializeComponent();
            MarcaDB.Init();
            VehiculoDB.Init();

            MainPage = new NavigationPage(new Main());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
