using GeneratorSolowek.Contracts;
using System;
using System.Linq;
using System.ServiceModel;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c = new ChannelFactory<IFileGenerator>(""))
            {
                var s = c.CreateChannel();

                var x = s.GetDMajorFrets();
                Console.ReadKey();
            }
        }
    }
}
