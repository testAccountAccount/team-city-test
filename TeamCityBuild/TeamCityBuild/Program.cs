using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCityBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            var artifactsDirectory = "Artifacts";
            if (Directory.Exists(artifactsDirectory))
            {
                Directory.Delete(artifactsDirectory, true);
            }

            Directory.CreateDirectory(artifactsDirectory);
            
            File.WriteAllText(Path.Combine(artifactsDirectory, "Output.txt"), $"{DateTime.Now} test!");
        }
    }
}
