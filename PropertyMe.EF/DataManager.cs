using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMe.EF
{
    public class DataManager
    {
        public bool PropertyAdd(MyProperty property)
        {
            using (Property365Entities ctx = new Property365Entities())
            {
                ctx.MyProperties.Add(property);
            }
            return true;
        }
        public List<MyProperty> PropertyList()
        {
            using (Property365Entities ctx = new Property365Entities())
            {
                return ctx.MyProperties.ToList();
            }
        }
        public MyProperty PropertyGet(long propertyID)
        {
            using (Property365Entities ctx = new Property365Entities())
            {
                return ctx.MyProperties.FirstOrDefault(p => p.ID == propertyID);
            }
        }

        public List<Agent> AgentList()
        {
            //temp();
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
        public bool AgentUpdate(Agent agent)
        {
            using (Property365Entities ctx = new Property365Entities())
            {
                ctx.Agents.Attach(agent);
                var entry = ctx.Entry(agent);
                entry.State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
            return true;
        }
        public bool AgentDelete(string agentId)
        {
            using (Property365Entities ctx = new Property365Entities())
            {
                Agent agentToDelete = new Agent() { ID = int.Parse(agentId) };
                ctx.Agents.Attach(agentToDelete);
                ctx.Agents.Remove(agentToDelete);
                ctx.SaveChanges();
            }
            return true;
        }
        public Agent AgentSingle(string agentID)
        {
            using (Property365Entities ctx = new Property365Entities())
            {
                return ctx.Agents.FirstOrDefault(p => p.ID == int.Parse(agentID));
            }
        }
    }
}
