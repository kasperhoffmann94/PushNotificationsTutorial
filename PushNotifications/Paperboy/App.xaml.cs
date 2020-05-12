 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Paperboy
{
    public partial class App : Application
    {
        //static FavoritesDatabase database;
        //public static FavoritesDatabase Database
        //{
        //    get
        //    {

        //        if (database == null)
        //        {
        //            database = new FavoritesDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("Favorites.db3"));
        //        }

        //        return database;
        //    }

        //}

        public static ViewModels.MainViewModel ViewModel { get; set; }
        public static INavigation MainNavigation { get; set; }
        public App()
        {
            InitializeComponent();
            
            MainPage = new NavigationPage(new Paperboy.MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
