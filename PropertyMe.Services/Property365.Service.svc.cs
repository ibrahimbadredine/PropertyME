using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PropertyMe.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Property365" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Property365.svc or Property365.svc.cs at the Solution Explorer and start debugging.
    public class Property365Service : IProperty365Service
    {
        public List<EF.Property> GetPropertyList()
        {
            return new PropertyMe.EF.DataManager().PropertyList();
        }

        public bool AddProperty(EF.Property property)
        {
            return new PropertyMe.EF.DataManager().PropertyAdd(property);
        }

        public EF.Property GetProperty(string ID)
        {
            return new PropertyMe.EF.DataManager().PropertyGet(long.Parse(ID));
        }


        public List<EF.Agent> GetAgentList()
        {
            return new PropertyMe.EF.DataManager().AgentList();
        }

        public bool AddAgent(EF.Agent newAgent)
        {
            return new PropertyMe.EF.DataManager().AgentAdd(newAgent);
        }
    }
}
