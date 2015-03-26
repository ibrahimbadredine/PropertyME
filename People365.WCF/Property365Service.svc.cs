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
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/Users/")]
        List<PropertyUser> GetUsers()
        {
            try
            {
                return new Property365Entities().PropertyUsers.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/Users/{userId}")]
        PropertyUser GetUser(string userID)
        {
            return new Property365Entities().PropertyUsers.FirstOrDefault(p => p.ID == long.Parse(userID));
        }

        [WebInvoke(Method = "POST",
       RequestFormat = WebMessageFormat.Json,
       ResponseFormat = WebMessageFormat.Json,
       UriTemplate = "/Users")]
        bool AddUser(PropertyUser newUser)
        {
            using (Property365Entities context = new Property365Entities())
            {
                context.PropertyUsers.Add(newUser);
                context.SaveChanges();
            }
            return true;
        }


        [OperationContract]
        [WebInvoke(Method = "PUT",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/Users/{userId}")]
        bool UpdateUser(PropertyUser contact, string userID)
        {
            //new Property365Entities().Users.ToList();
            return true;
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/Users/{userId}")]
        bool DeleteUser(string userID)
        {
            //return new Property365Entities().Users.ToList();
            return true;
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
