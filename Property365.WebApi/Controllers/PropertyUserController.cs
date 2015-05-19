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
    public class PropertyUserController : ApiController
    {
        private Property365Entities db = new Property365Entities();

        // GET api/PropertyUser
        public IQueryable<PropertyUser> GetPropertyUsers()
        {
            return db.PropertyUsers;
        }

        // GET api/PropertyUser/5
        [ResponseType(typeof(PropertyUser))]
        public async Task<IHttpActionResult> GetPropertyUser(long id)
        {
            PropertyUser propertyuser = await db.PropertyUsers.FindAsync(id);
            if (propertyuser == null)
            {
                return NotFound();
            }

            return Ok(propertyuser);
        }

        // PUT api/PropertyUser/5
        public async Task<IHttpActionResult> PutPropertyUser(long id, PropertyUser propertyuser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != propertyuser.ID)
            {
                return BadRequest();
            }

            db.Entry(propertyuser).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropertyUserExists(id))
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

        // POST api/PropertyUser
        [ResponseType(typeof(PropertyUser))]
        public async Task<IHttpActionResult> PostPropertyUser(PropertyUser propertyuser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PropertyUsers.Add(propertyuser);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = propertyuser.ID }, propertyuser);
        }

        // DELETE api/PropertyUser/5
        [ResponseType(typeof(PropertyUser))]
        public async Task<IHttpActionResult> DeletePropertyUser(long id)
        {
            PropertyUser propertyuser = await db.PropertyUsers.FindAsync(id);
            if (propertyuser == null)
            {
                return NotFound();
            }

            db.PropertyUsers.Remove(propertyuser);
            await db.SaveChangesAsync();

            return Ok(propertyuser);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PropertyUserExists(long id)
        {
            return db.PropertyUsers.Count(e => e.ID == id) > 0;
        }
    }
}