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
using Mist.DB;
using Mist.Models;

namespace Mist.Controllers
{
    public class SportsmanRESTController : ApiController
    {
        private SportsmanContext db = new SportsmanContext();

        // GET: api/Sportsmen
        public IQueryable<Sportsman> GetSportsmans()
        {
            return db.Sportsmans;
        }

        // GET: api/Sportsmen/5
        [ResponseType(typeof(Sportsman))]
        public IHttpActionResult GetSportsman(int id)
        {
            Sportsman sportsman = db.Sportsmans.Find(id);
            if (sportsman == null)
            {
                return NotFound();
            }

            return Ok(sportsman);
        }

        // PUT: api/Sportsmen/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSportsman(int id, Sportsman sportsman)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sportsman.ID)
            {
                return BadRequest();
            }

            db.Entry(sportsman).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SportsmanExists(id))
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

        // POST: api/Sportsmen
        [ResponseType(typeof(Sportsman))]
        public IHttpActionResult PostSportsman(Sportsman sportsman)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sportsmans.Add(sportsman);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sportsman.ID }, sportsman);
        }

        // DELETE: api/Sportsmen/5
        [ResponseType(typeof(Sportsman))]
        public IHttpActionResult DeleteSportsman(int id)
        {
            Sportsman sportsman = db.Sportsmans.Find(id);
            if (sportsman == null)
            {
                return NotFound();
            }

            db.Sportsmans.Remove(sportsman);
            db.SaveChanges();

            return Ok(sportsman);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SportsmanExists(int id)
        {
            return db.Sportsmans.Count(e => e.ID == id) > 0;
        }
    }
}