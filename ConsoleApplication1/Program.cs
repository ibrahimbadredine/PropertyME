using People365.WCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {            
            ServiceHost sh = new ServiceHost(typeof(Property365Service),
                new Uri("http://localhost:62640/Property365Service"));

            sh.Open();

            Console.ReadLine();
        }
    }
}
