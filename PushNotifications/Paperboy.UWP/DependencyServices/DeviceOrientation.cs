using Xamarin.Forms;
using Paperboy.UWP;
using Windows.UI.ViewManagement;

[assembly: Dependency(typeof(DeviceOrientation))]
namespace Paperboy.UWP
{
    public class DeviceOrientation : IDeviceOrientation
    {
        public DeviceOrientation() { }

        public DeviceOrientations GetOrientation()
        {
            var orientation = ApplicationView.GetForCurrentView().Orientation;
            if (orientation == ApplicationViewOrientation.Landscape)
                return DeviceOrientations.Landscape;
            else
                return DeviceOrientations.Portrait;
        }
    }
}