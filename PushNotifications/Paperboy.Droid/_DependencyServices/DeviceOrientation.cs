using System;
using Android.Hardware;
using Android.OS;
using Android.Views;
using Android.Content;
using Android.Runtime;
using Android.App;
using Xamarin.Forms;
using Paperboy.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceOrientation))]
namespace Paperboy.Droid
{

    public class DeviceOrientation : IDeviceOrientation
    {
        public DeviceOrientation() { }

        public static void Init()
        {
        }

        public DeviceOrientations GetOrientation()
        {
            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            var rotation = windowManager.DefaultDisplay.Rotation;
            bool isLandscape = rotation == SurfaceOrientation.Rotation90 || rotation == SurfaceOrientation.Rotation270;
            return isLandscape ? DeviceOrientations.Landscape : DeviceOrientations.Portrait;
        }
    }
}

