﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperboy.Helpers
{
    public static class StorageHelper
    {
        public static List<string> GetSpecialFolders()
        {
            return Xamarin.Forms.DependencyService.Get<IFileHelper>().GetSpecialFolders();
        }

        public static string GetLocalFilePath()
        {
            return Xamarin.Forms.DependencyService.Get<IFileHelper>().GetLocalFilePath("paperboy.db3");
        }

    }
}
