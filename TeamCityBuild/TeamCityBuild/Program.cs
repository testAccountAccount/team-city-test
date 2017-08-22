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
            Directory.CreateDirectory("Artifacts");
            File.WriteAllText(Path.Combine("Artifacts", "Output.txt"), $"{DateTime.Now} test!");
        }
    }
}
