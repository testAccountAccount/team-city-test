using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectToBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { 1, 2, 3 }.ToImmutableArray();
            Console.WriteLine("Works!");
            Console.WriteLine(array);
            Console.ReadLine();
        }
    }
}
