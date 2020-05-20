using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PushNotifications
{
    public partial class App : Application
    {
        public App(bool shallNavigate)
        {
            InitializeComponent();
            if (shallNavigate)
            {
                MainPage = new NavigationPage(new DashboardPage());
            }
            else
            {
                MainPage = new NavigationPage(new MainPage());
            }

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
