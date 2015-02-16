using PropertyMe.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Property365ServiceClient srv = new ServiceReference1.Property365ServiceClient();


            srv.Open();
            var agents = srv.GetAgentList();
            srv.Close();
            //var temp = new DataManager().AgentList();
            //Console.WriteLine("tesmp");
            Console.ReadLine();
        }
    }
}
