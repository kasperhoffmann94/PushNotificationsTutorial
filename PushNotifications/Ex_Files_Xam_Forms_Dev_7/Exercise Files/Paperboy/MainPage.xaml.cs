using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Paperboy
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            if (App.ViewModel == null)
            {
                App.ViewModel = new ViewModels.MainViewModel();

                App.ViewModel.RefreshNewsAsync();
            }

            App.MainNavigation = Navigation;
 
            base.OnAppearing();
        }
        
    }
}
