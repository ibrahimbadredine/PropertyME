using Poperty365.WCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Property365.Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceHost sh = new ServiceHost(typeof(MSDNMagazineServiceType));
            //string baseUri = "http://localhost/MagazineService";
            //ServiceEndpoint se = sh.AddServiceEndpoint(typeof(IMSDNMagazineService),
            //new WebHttpBinding(), baseUri);
            //se.Behaviors.Add(new WebHttpBehavior());
            //sh.Open();

            string baseUri = "http://localhost:8000";
            WebServiceHost sh = new WebServiceHost(typeof(Service1), new Uri(baseUri));

            ServiceEndpoint ep = sh.AddServiceEndpoint(typeof(IService1), new WebHttpBinding(), "");

            ServiceDebugBehavior sdb = sh.Description.Behaviors.Find<ServiceDebugBehavior>();
            sdb.HttpHelpPageEnabled = false;

            sh.Open();
            Console.WriteLine("Service is up and running");
            Console.WriteLine("Press enter to quit ");
            Console.ReadLine();
            sh.Close();
        }
    }
}
