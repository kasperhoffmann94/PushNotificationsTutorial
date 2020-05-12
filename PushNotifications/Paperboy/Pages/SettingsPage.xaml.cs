using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Paperboy.Pages
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            InitializeSettings();

            base.OnAppearing();
        }

        private void InitializeSettings()
        {
            this.BindingContext = App.ViewModel;

            articleCountSlider.Value = 10;
            categoryPicker.SelectedIndex = 1;

            var label = Helpers.GeneralHelper.GetLabel();
            var extendedLabel = Helpers.GeneralHelper.GetLabel("Running Paperboy on", true);

            var orientation = Helpers.GeneralHelper.GetOrientation();

            App.ViewModel.PlatformLabel = label;
            App.ViewModel.ExtendedPlatformLabel = extendedLabel;
            App.ViewModel.CurrentOrientation = orientation;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.Resources["ListTextColor"] = Color.Blue;
        }

        private void TestThis(INavigation navigation)
        {
            throw new NotImplementedException();
        }
    }
}
