using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core.Utilities
{
    public static class FileValidator
    {
        public static bool PathExist(string path)
        {
            return Directory.Exists(path);
        }
    }
}
