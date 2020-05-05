﻿ 
using Paperboy.UWP;
using System.IO;
using Windows.Storage;
using System.Collections.Generic;
using Xamarin.Forms;
using System;

[assembly: Dependency(typeof(FileHelper))]
namespace Paperboy.UWP
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
        }

        public List<string> GetSpecialFolders()
        {
            return new List<string>();
        }
    }
}