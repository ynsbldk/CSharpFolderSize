using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileProps
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dinfo = new DirectoryInfo(@"D:\Media\English");
            Console.WriteLine(dinfo.GetTotalSize());
            Console.ReadLine();
            

        }

    }
    ///// Extensions
    public static class DirectoryExtensions
    {
        public static long GetTotalSize(this DirectoryInfo Directory)
        {
            long result = 0;
            try
            {
                foreach (var file in Directory.GetFiles())
                    result += file.Length;
                foreach (var dir in Directory.GetDirectories())
                    result += GetTotalSize(dir);
            }
            catch (Exception e)
            {

            }
            return result;
        }
    }
}
