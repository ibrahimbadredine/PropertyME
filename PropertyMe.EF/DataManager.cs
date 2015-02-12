using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMe.EF
{
    public class DataManager
    {
        public bool AddProperty(Property property)
        {
            try
            {
                using (Property365Entities ctx = new Property365Entities())
                {
                    ctx.Properties.Add(property);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
