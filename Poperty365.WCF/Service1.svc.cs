using PropertyMe.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Poperty365.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetMessage(string inputMessage)
        {
            return "Calling Get for you " + inputMessage;
        }

        public List<Agent> GetAgentList()
        {
            //return new List<Agent>();
            var agents = new PropertyMe.EF.DataManager().AgentList();
            return agents;
            //return new List<Agent>() { new Agent() { ID = 1, UserID = 1 } };
        }

        public bool AddAgent(Agent newAgent)
        {
            return new PropertyMe.EF.DataManager().AgentAdd(newAgent);
        }

        public Agent GetAgent(string agentID)
        {
            return new PropertyMe.EF.DataManager().AgentSingle(agentID);
        }

        public bool UpdateAgent(Agent updateAgent)
        {
            return new DataManager().AgentUpdate(updateAgent);
        }

        public bool DeleteAgent(string agentID)
        {
            return new DataManager().AgentDelete(agentID);
        }
    }
}
