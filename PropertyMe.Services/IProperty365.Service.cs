using PropertyMe.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PropertyMe.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProperty365" in both code and config file together.
    [ServiceContract]
    public interface IProperty365Service
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "GetPropertyList/")]
        List<Property> GetPropertyList();

        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "GetProperty/{id}")]
        Property GetProperty(string ID);

        [WebInvoke(Method = "PUT",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "AddProperty/")]
        bool AddProperty(Property newProperty);


        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "GetAgentList/")]
        List<Agent> GetAgentList();

        [WebInvoke(Method = "PUT",
       RequestFormat = WebMessageFormat.Json,
       ResponseFormat = WebMessageFormat.Json,
       UriTemplate = "AddAgent/")]
        bool AddAgent(Agent newAgent);
    }
}
