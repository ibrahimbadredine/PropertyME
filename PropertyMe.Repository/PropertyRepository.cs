using PropertyMe.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMe.Repository
{

    public interface IPropertyRepository
    {
        bool AddProperty(Property property);
    }
    public class PropertyRepository : IPropertyRepository
    {
        public bool AddProperty(Property property)
        {

            try
            {
                if (property != null)
                    using (var ctx = new Property365Entities())
                    {

                    }

            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }
    }
}
