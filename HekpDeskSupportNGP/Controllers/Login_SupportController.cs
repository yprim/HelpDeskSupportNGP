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
using HekpDeskSupportNGP;
using HekpDeskSupportNGP.Models;

namespace HekpDeskSupportNGP.Controllers
{
    public class Login_SupportController : ApiController
    {
        private HelpDeskNGPEntities db = new HelpDeskNGPEntities();

        //    // GET: api/Login_Support
        //    public IQueryable<Login_Support> GetLogin_Support()
        //    {
        //        return db.Login_Support;
        //    }

        //    // GET: api/Login_Support/5
        //    [ResponseType(typeof(Login_Support))]
        //    public IHttpActionResult GetLogin_Support(int id)
        //    {
        //        Login_Support login_Support = db.Login_Support.Find(id);
        //        if (login_Support == null)
        //        {
        //            return NotFound();
        //        }

        //        return Ok(login_Support);
        //    }

        //    // PUT: api/Login_Support/5
        //    [ResponseType(typeof(void))]
        //    public IHttpActionResult PutLogin_Support(int id, Login_Support login_Support)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return BadRequest(ModelState);
        //        }

        //        if (id != login_Support.id)
        //        {
        //            return BadRequest();
        //        }

        //        db.Entry(login_Support).State = EntityState.Modified;

        //        try
        //        {
        //            db.SaveChanges();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!Login_SupportExists(id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return StatusCode(HttpStatusCode.NoContent);
        //    }

        //    // POST: api/Login_Support
        //    [ResponseType(typeof(Login_Support))]
        //    public IHttpActionResult PostLogin_Support(Login_Support login_Support)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return BadRequest(ModelState);
        //        }

        //        db.Login_Support.Add(login_Support);

        //        try
        //        {
        //            db.SaveChanges();
        //        }
        //        catch (DbUpdateException)
        //        {
        //            if (Login_SupportExists(login_Support.id))
        //            {
        //                return Conflict();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return CreatedAtRoute("DefaultApi", new { id = login_Support.id }, login_Support);
        //    }

        //    // DELETE: api/Login_Support/5
        //    [ResponseType(typeof(Login_Support))]
        //    public IHttpActionResult DeleteLogin_Support(int id)
        //    {
        //        Login_Support login_Support = db.Login_Support.Find(id);
        //        if (login_Support == null)
        //        {
        //            return NotFound();
        //        }

        //        db.Login_Support.Remove(login_Support);
        //        db.SaveChanges();

        //        return Ok(login_Support);
        //    }

        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing)
        //        {
        //            db.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }

        //    private bool Login_SupportExists(int id)
        //    {
        //        return db.Login_Support.Count(e => e.id == id) > 0;
        //    }


        public IHttpActionResult GetAll()
        {
            IList<Login_Support_Model> loginSuport = null;


            using (var context = new HelpDeskNGPEntities())
            {
                loginSuport = context.Login_Support
                    .Select(loginItem => new Login_Support_Model()
                    {
                        id = loginItem.id,
                        email = loginItem.email,
                        password = loginItem.password,
                        is_supervisor= loginItem.is_supervisor
                        

                    }).ToList<Login_Support_Model>();

            }
            //TODO: transform this snippet into a single return 
            if (loginSuport.Count == 0)
            {
                return NotFound();
            }

            return Ok(loginSuport);

        }
    }
}