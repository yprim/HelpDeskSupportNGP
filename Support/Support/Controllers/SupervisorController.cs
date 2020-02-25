using Support.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Support.Controllers
{
    public class SupervisorController : ApiController
    {
        //get all
        public IHttpActionResult GetAll()
        {
            IList<SupervisorModel> support = null;

            using (var context = new Entities())
            {
                support = context.Supervisor_Support
                    .Select(supportItem => new SupervisorModel()
                    {
                        id = supportItem.id,
                        name = supportItem.name,
                        firstSurname = supportItem.first_surname,
                        secondSurname = supportItem.second_surname,
                        email = supportItem.email,
                        password = supportItem.password
                    }).ToList<SupervisorModel>();
            }
            //TODO: transform this snippet into a single return 
            if (support.Count == 0)
            {
                return NotFound();
            }
            return Ok(support);

        }

        public IHttpActionResult GetByEmail(string email)
        {
            SupervisorModel support = null;

            using (var context = new Entities())
            {
                support = context.Supervisor_Support
                    .Where(supportItem => supportItem.email == email)
                    .Select(supportItem => new SupervisorModel()
                    {
                        id = supportItem.id,
                        name = supportItem.name,
                        firstSurname = supportItem.first_surname,
                        secondSurname = supportItem.second_surname,
                        email = supportItem.email,
                        password = supportItem.password

                    }).FirstOrDefault<SupervisorModel>();

                if (support == null)
                {
                    return NotFound();
                }

                return Ok(support);
            }
        }

        [HttpPost]
        public IHttpActionResult Post(SupervisorModel support)
        {
            using (var context = new Entities())
            {
                context.Supervisor_Support.Add(new Supervisor_Support()
                {
                    id = support.id,
                    name = support.name,
                    first_surname = support.firstSurname,
                    second_surname = support.secondSurname,
                    email = support.email,
                    password = support.password
                });
                context.SaveChanges();
            }
            return Ok();
        }
    }
}
