using InterfazRes.Servicio;
using InterfazRes.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InterfazRes
{
    public partial class App : Application
    {
        private static PersonaServicio personaservicio;
        public static PersonaServicio Personaservicio
        {
            get
            {
                if (personaservicio == null)
                {
                    personaservicio = new PersonaServicio();
                }
                return personaservicio;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Principal());
        
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
