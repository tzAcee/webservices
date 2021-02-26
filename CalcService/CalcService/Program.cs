using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CalcService
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(Calculator));
          //  host.
            host.Open();

            Console.WriteLine("Service started! Press Enter to terminate");
            Console.ReadLine();
        }
    }
}
