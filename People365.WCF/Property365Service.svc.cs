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
        #region Property
        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/Property/")]
        List<PropertyModel> GetProperties()
        {
            var properties = new Property365Entities().MyProperties;

            List<PropertyModel> lstProperties = new List<PropertyModel>();
            foreach (var prop in properties)
            {
                PropertyModel propertyModel = new PropertyModel();

                propertyModel.ID = prop.ID;
                propertyModel.title = prop.Title;
                if (prop.PropertyPictures != null && prop.PropertyPictures.Count > 0)
                {
                    propertyModel.img = prop.PropertyPictures.FirstOrDefault().Picture.ImageName;
                    propertyModel.carousselPics = prop.PropertyPictures.Select(p => p.Picture.ImageName).ToArray();
                }
                propertyModel.description = prop.Description;
                propertyModel.type = prop.IsSale ? "For Sale" : "For Rent";
                propertyModel.price = prop.Price;
                propertyModel.address = prop.Location;
                propertyModel.bedrooms = prop.Bedroom;
                propertyModel.bathrooms = prop.Bathroom;
                propertyModel.area = prop.Area;
                propertyModel.position = new PositionModel() { lng = prop.Long, lat = prop.Lat };

                lstProperties.Add(propertyModel);
            }
            return lstProperties;
        }

        [WebInvoke(Method = "POST",
      RequestFormat = WebMessageFormat.Json,
      ResponseFormat = WebMessageFormat.Json,
      UriTemplate = "/Property")]
        bool AddProperty(PropertyModel newProperty)
        {
            MyProperty prop = new MyProperty();

            prop.Title = newProperty.title;
            prop.Price = newProperty.price;
            prop.Description = newProperty.description;
            prop.Long = newProperty.position.lng;


            //using (Property365Entities context = new Property365Entities())
            //{
            //    context.MyProperties.Add(newProperty);
            //    context.SaveChanges();
            //}
            return true;
        }
        #endregion

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
        [WebGet(
            BodyStyle = WebMessageBodyStyle.Bare,
            // RequestFormat = WebMessageFormat.Json,
            //ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/Pictures/{Id}")]
        Picture GetPicture(string ID)
        {
            long uID = long.Parse(ID);
            return new Property365Entities().Pictures.FirstOrDefault(p => p.ID == uID);
        }

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST",
            //RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
       UriTemplate = "/AddPicture")]
        bool AddPicture(System.IO.Stream newPicture)
        {
            using (Property365Entities context = new Property365Entities())
            {
                //context.Pictures.Add(newPicture);
                //context.SaveChanges();
            }
            return true;
        }


        //[OperationContract]
        //[WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
        //    Method = "PUT",
        //    //RequestFormat = WebMessageFormat.Json,
        //    //ResponseFormat = WebMessageFormat.Json,
        //   UriTemplate = "/Pictures/{Id}")]
        //bool UpdatePicture(System.IO.Stream contact, string ID)
        //{
        //    //new Property365Entities().Pictures.ToList();
        //    return true;
        //}

        #endregion

    }
}
