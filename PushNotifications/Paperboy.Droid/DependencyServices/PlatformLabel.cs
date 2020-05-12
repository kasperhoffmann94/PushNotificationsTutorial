using System;
using Android.Hardware;
using Android.OS;
using Android.Views;
using Android.Content;
using Android.Runtime;
using Android.App;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(Paperboy.Droid.PlatformLabel))]
namespace Paperboy.Droid
{
    public class PlatformLabel : IPlatformLabel
    {
        public PlatformLabel() { }

        public static void Init()
        {
        }

        public string GetLabel()
        {             
            return "Android";
        }

        public string GetLabel(string additionalLabel)
        {
            return additionalLabel + " Android";
        }

        public string GetLabel(string additionalLabel, bool addVersion)
        {
            string label = (addVersion) ? label = $"{additionalLabel} Android {GetOsVersion()}" :
                $"{additionalLabel} Android";

            return label;
        }

        private string GetOsVersion()
        {
            return Android.OS.Build.VERSION.Release;
        }
    }
}

 