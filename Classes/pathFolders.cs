using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace eFirmaApplication.Classes
{
    public static class pathFolders
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPTStr)]
            string path,
            [MarshalAs(UnmanagedType.LPTStr)]
            StringBuilder shortPath,
            int shortPathLength
        );

        public static string shortPathFolder(string path)
        {
            StringBuilder tmp = new StringBuilder(255);
            GetShortPathName(path, tmp, tmp.Capacity);
            return tmp.ToString();
        }

        public static string tmpFolderPath
        {
            get
            {
                return System.IO.Path.GetTempPath();
            }
        }
        public static string shortTmpPath
        {
            get
            {
                StringBuilder tmp = new StringBuilder(255);
                GetShortPathName(tmpFolderPath, tmp, tmp.Capacity);
                return tmp.ToString();
            }
        }

        public static string executingFolderPath
        {
            get
            {
                return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            }
        }
        public static string shortExecutingFolderPath
        {
            get
            {
                StringBuilder tmp = new StringBuilder(255);
                GetShortPathName(executingFolderPath, tmp, tmp.Capacity);
                return tmp.ToString();
            }
        }

    }
}
