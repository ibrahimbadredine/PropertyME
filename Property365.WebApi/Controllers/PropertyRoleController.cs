using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using People365.WCF;

namespace Property365.WebApi.Controllers
{
    public class PropertyRoleController : ApiController
    {
        private Property365Entities db = new Property365Entities();

        // GET api/PropertyRole
        public IQueryable<PropertyRole> GetPropertyRoles()
        {
            return db.PropertyRoles;
        }

        // GET api/PropertyRole/5
        [ResponseType(typeof(PropertyRole))]
        public async Task<IHttpActionResult> GetPropertyRole(int id)
        {
            PropertyRole propertyrole = await db.PropertyRoles.FindAsync(id);
            if (propertyrole == null)
            {
                return NotFound();
            }

            return Ok(propertyrole);
        }

        // PUT api/PropertyRole/5
        public async Task<IHttpActionResult> PutPropertyRole(int id, PropertyRole propertyrole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != propertyrole.ID)
            {
                return BadRequest();
            }

            db.Entry(propertyrole).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropertyRoleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/PropertyRole
        [ResponseType(typeof(PropertyRole))]
        public async Task<IHttpActionResult> PostPropertyRole(PropertyRole propertyrole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PropertyRoles.Add(propertyrole);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = propertyrole.ID }, propertyrole);
        }

        // DELETE api/PropertyRole/5
        [ResponseType(typeof(PropertyRole))]
        public async Task<IHttpActionResult> DeletePropertyRole(int id)
        {
            PropertyRole propertyrole = await db.PropertyRoles.FindAsync(id);
            if (propertyrole == null)
            {
                return NotFound();
            }

            db.PropertyRoles.Remove(propertyrole);
            await db.SaveChangesAsync();

            return Ok(propertyrole);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PropertyRoleExists(int id)
        {
            return db.PropertyRoles.Count(e => e.ID == id) > 0;
        }
    }
}