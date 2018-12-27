using System;
using System.Collections.Generic;
using System.Text;

namespace TennisLog.Helpers
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}
