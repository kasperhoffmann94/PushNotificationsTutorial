using System;
using UIKit;
using Foundation;
using Paperboy.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(PlatformLabel))]
namespace Paperboy.iOS
{
    public class PlatformLabel : IPlatformLabel
    {
        public PlatformLabel() { }

        public string GetLabel()
        {
            return "iOS";
        }

        //public string GetLabel(string additionalLabel, bool addVersion)
        //{
        //    string label = (addVersion) ? label = $"{additionalLabel} iOS {GetOsVersion()}" :
        //        $"{additionalLabel} iOS";

        //    return label;
        //}

        //private string GetOsVersion()
        //{
        //    return UIDevice.CurrentDevice.SystemVersion; 
        //}
    }
}