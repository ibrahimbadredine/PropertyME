using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMe.EF
{
    public class DataManager
    {
        public bool PropertyAdd(Property property)
        {
            using (Property365Entities ctx = new Property365Entities())
            {
                ctx.Properties.Add(property);
            }
            return true;
        }
        public List<Property> PropertyList()
        {
            using (Property365Entities ctx = new Property365Entities())
            {
                return ctx.Properties.ToList();
            }
        }
        public Property PropertyGet(long propertyID)
        {
            using (Property365Entities ctx = new Property365Entities())
            {
                return ctx.Properties.FirstOrDefault(p => p.ID == propertyID);
            }
        }

        public List<Agent> AgentList()
        {
            using (Property365Entities ctx = new Property365Entities())
            {
                return ctx.Agents.ToList();
            }
        }

        public bool AgentAdd(Agent agent)
        {
            using (Property365Entities ctx = new Property365Entities())
            {
                ctx.Agents.Add(agent);
            }
            return true;
        }
    }
}
