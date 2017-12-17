using System;
using System.Reflection;

namespace csharpres
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var resource in Assembly.GetExecutingAssembly().GetManifestResourceNames())
            {
                Console.WriteLine(resource);
            }
        }
    }
}
