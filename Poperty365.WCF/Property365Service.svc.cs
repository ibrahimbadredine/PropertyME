using PropertyMe.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace Poperty365.WCF
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Property365Service
    {
        DataManager dm = new DataManager();
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetAgentList")]
        List<Agent> GetAgentList()
        {
            //return new List<Agent>();
            return new List<Agent>() { new Agent() { ID = 1, UserID = 1 } };
        }

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetAgent/{agentId}")]
        Agent GetAgent(string agentID)
        {
            return dm.AgentSingle(agentID);
        }

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
       UriTemplate = "/AddAgent")]
        bool AddAgent(Agent newAgent) { return dm.AgentAdd(newAgent); }


        [OperationContract]
        [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/UpdateAgent")]
        bool UpdateAgent(Agent agent) { return dm.AgentUpdate(agent); }

        [OperationContract]
        [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/DeleteAgent/{agentId}")]
        bool DeleteAgent(string agentID) { return dm.AgentDelete(agentID); }
    }
}
