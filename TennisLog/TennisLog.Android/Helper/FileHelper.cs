using System;
using System.Collections.Generic;
using System.IO;

using System.Text;
using TennisLog.Helpers;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(TennisLog.Droid.Helper.FileHelper))]

namespace TennisLog.Droid.Helper
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}
