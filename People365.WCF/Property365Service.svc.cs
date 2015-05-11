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
        #region User

        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/Users/")]
        List<PropertyUser> GetUsers()
        {
            try
            {
                var users = new Property365Entities().PropertyUsers.Include("PropertyRole").Include("Picture").ToList();
                return users;
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
            long uID = long.Parse(userID);
            return new Property365Entities().PropertyUsers.Include("PropertyRole").Include("Picture").FirstOrDefault(p => p.ID == uID);
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
        bool UpdateUser(PropertyUser user, string userID)
        {
            using (Property365Entities db = new Property365Entities())
            {
                db.PropertyUsers.Attach(user);
                var entry = db.Entry(user);
                entry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return true;
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/Users/{userId}")]
        bool DeleteUser(string userID)
        {
            long uID = long.Parse(userID);
            PropertyUser userToDelete = new PropertyUser() { ID = uID };

            using (Property365Entities db = new Property365Entities())
            {
                db.PropertyUsers.Attach(userToDelete);
                db.PropertyUsers.Remove(userToDelete);
                db.SaveChanges();
            }
            return true;
        }

        #endregion

        #region Picture
        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/Pictures/")]
        List<Picture> GetPictures()
        {
            try
            {
                return new Property365Entities().Pictures.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/Pictures/{Id}")]
        Picture GetPicture(string ID)
        {
            long uID = long.Parse(ID);
            return new Property365Entities().Pictures.FirstOrDefault(p => p.ID == uID);
        }

        [WebInvoke(Method = "POST",
       RequestFormat = WebMessageFormat.Json,
       ResponseFormat = WebMessageFormat.Json,
       UriTemplate = "/Pictures")]
        bool AddPicture(object newPicture)
        {
            using (Property365Entities context = new Property365Entities())
            {
                //context.Pictures.Add(newPicture);
                //context.SaveChanges();
            }
            return true;
        }


        [OperationContract]
        [WebInvoke(Method = "PUT",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/Pictures/{Id}")]
        bool UpdatePicture(object contact, string ID)
        {
            //new Property365Entities().Pictures.ToList();
            return true;
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/Pictures/{Id}")]
        bool DeletePicture(string ID)
        {
            //return new Property365Entities().Pictures.ToList();
            return true;
        }
        #endregion

    }
}
