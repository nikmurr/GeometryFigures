using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    public static class FileHelper
    {
        public static string GetMat(string fileName)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Materials", fileName);
        }
    }
}
