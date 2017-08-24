using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComdZip
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <=0)
            {
                ZipArchiveDirectory();
            }
        }

        private static void ZipArchiveDirectory()
        {
            var currDir = System.Environment.CurrentDirectory;
            Directory.EnumerateDirectories(currDir, "*.*", SearchOption.TopDirectoryOnly).ToList().ForEach(dir => {
                var zipName = Path.ChangeExtension(dir, ".zip");
                ZipFile.CreateFromDirectory(dir, zipName, CompressionLevel.Optimal, false);
                Console.WriteLine(zipName + " ...Complete!");
            });
        }
    }
}
