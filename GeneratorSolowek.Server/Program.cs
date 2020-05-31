using System;
using System.ServiceModel;

namespace GeneratorSolowek.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(FileGenerator));
            host.Open();
            Console.WriteLine("Serwer uruchomiony");
            Console.ReadKey();
        }
    }
}
