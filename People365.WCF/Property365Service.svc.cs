using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace People365.WCF
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Property365Service
    {
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        [OperationContract]
        public void DoWork()
        {
            // Add your operation implementation here
            return;
        }

        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetUsers")]
        List<User> GetUsers()
        {
            return new Property365Entities().Users.ToList();
        }

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/GetUser/{userId}")]
        User GetUser(string userID)
        {
            return new Property365Entities().Users.FirstOrDefault(p => p.ID == long.Parse(userID));
        }

        [WebInvoke(Method = "POST",
       RequestFormat = WebMessageFormat.Json,
       ResponseFormat = WebMessageFormat.Json,
       UriTemplate = "/AddUser")]
        bool AddUser(User newUser)
        {
            new Property365Entities().Users.Add(newUser);
            return true;
        }


        [OperationContract]
        [WebInvoke(Method = "PUT",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/UpdateUser")]
        bool UpdateUser(User contact)
        {
            //new Property365Entities().Users.ToList();
            return true;
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/DeleteUser/{userId}")]
        bool DeleteUser(string userID)
        {
            //return new Property365Entities().Users.ToList();
            return true;
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
