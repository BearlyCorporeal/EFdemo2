using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using EFvetAPI.Models;

namespace EFvetAPI.Controllers
{
    public class PetOwner0136Controller : ApiController
    {
        private DADEntities1 db = new DADEntities1();

        // GET: api/PetOwner0136
        public IQueryable<PetOwner0136> GetPetOwner0136()
        {
            return db.PetOwner0136;
        }

        // GET: api/PetOwner0136/5
        [ResponseType(typeof(PetOwner0136))]
        public IHttpActionResult GetPetOwner0136(int id)
        {
            PetOwner0136 petOwner0136 = db.PetOwner0136.Find(id);
            if (petOwner0136 == null)
            {
                return NotFound();
            }

            return Ok(petOwner0136);
        }

        // PUT: api/PetOwner0136/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPetOwner0136(int id, PetOwner0136 petOwner0136)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != petOwner0136.OwnerID)
            {
                return BadRequest();
            }

            db.Entry(petOwner0136).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PetOwner0136Exists(id))
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

        // POST: api/PetOwner0136
        [ResponseType(typeof(PetOwner0136))]
        public IHttpActionResult PostPetOwner0136(PetOwner0136 petOwner0136)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PetOwner0136.Add(petOwner0136);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (PetOwner0136Exists(petOwner0136.OwnerID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = petOwner0136.OwnerID }, petOwner0136);
        }

        // DELETE: api/PetOwner0136/5
        [ResponseType(typeof(PetOwner0136))]
        public IHttpActionResult DeletePetOwner0136(int id)
        {
            PetOwner0136 petOwner0136 = db.PetOwner0136.Find(id);
            if (petOwner0136 == null)
            {
                return NotFound();
            }

            db.PetOwner0136.Remove(petOwner0136);
            db.SaveChanges();

            return Ok(petOwner0136);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PetOwner0136Exists(int id)
        {
            return db.PetOwner0136.Count(e => e.OwnerID == id) > 0;
        }
    }
}