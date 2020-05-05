using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperboy.Common
{
    public class CoreConstants
    {
        public static string NewsSearchApiKey
        {
            get { return "[YOUR MSFT BG NEWS SEARCH API KEY]"; }
        }

        public static string ApplicationURL = @"http://[your azure mobile app name].azurewebsites.net";
        public static string GcmRemoteId = "[YOUR FIREBASE CLOUD MESSAGING REMOTE ID]";
    }
}
