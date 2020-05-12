using System;
using UIKit;
using Foundation;
 
[assembly: Xamarin.Forms.Dependency(typeof(Paperboy.iOS.PlatformLabel))]
namespace Paperboy.iOS
{
    public class PlatformLabel : IPlatformLabel
    {
        public PlatformLabel() { }

        public string GetLabel()
        {
            return "iOS";
        }

        public string GetLabel(string additionalLabel)
        {
            return $"{additionalLabel} iOS";
        }

        public string GetLabel(string additionalLabel, bool addVersion)
        {
            string label = (addVersion) ? label = $"{additionalLabel} iOS {GetOsVersion()}" :
                $"{additionalLabel} iOS";

            return label;
        }

        private string GetOsVersion()
        {
            return UIDevice.CurrentDevice.SystemVersion;
        }
    }
} 