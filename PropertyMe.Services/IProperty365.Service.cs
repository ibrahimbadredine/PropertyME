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
        List<Property> GetProperty();

        [WebInvoke(Method = "PUT",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "AddProperty/")]
        bool AddProperty(Property newProperty);

    }
}
