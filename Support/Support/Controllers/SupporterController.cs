
using Support.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Support.Controllers
{
    public class SupporterController : ApiController
    {

        public IHttpActionResult GetAll()
        {
            IList<SupporterModel> supporter = null;

            using (var context = new Entities())
            {
                supporter = context.Supporter_Support
                    .Select(supporterItem => new SupporterModel()
                    {
                        id = supporterItem.id,
                        name = supporterItem.name,
                        firstSurname = supporterItem.first_surname,
                        secondSurname = supporterItem.second_surname,
                        email = supporterItem.email,
                        idSupervisor = supporterItem.id_supervisor,
                        password = supporterItem.password,
                        television = supporterItem.television,
                        mobilePhone = supporterItem.mobile_phone,
                        telephone = supporterItem.telephone,
                        internet = supporterItem.internet

                    }).ToList<SupporterModel>();

            }
            //TODO: transform this snippet into a single return 
            if (supporter.Count == 0)
            {
                return NotFound();
            }

            return Ok(supporter);
        }

        public IHttpActionResult GetByEmail(string email)
        {
            SupporterModel support = null;

            using (var context = new Entities())
            {
                support = context.Supporter_Support
                    .Where(supporterItem => supporterItem.email == email)
                    .Select(supporterItem => new SupporterModel()
                    {
                        id = supporterItem.id,
                        name = supporterItem.name,
                        firstSurname = supporterItem.first_surname,
                        secondSurname = supporterItem.second_surname,
                        email = supporterItem.email,
                        idSupervisor = supporterItem.id_supervisor,
                        password = supporterItem.password,
                        television = supporterItem.television,
                        mobilePhone = supporterItem.mobile_phone,
                        telephone = supporterItem.telephone,
                        internet = supporterItem.internet

                    }).FirstOrDefault<SupporterModel>();

                if (support == null)
                {
                    return NotFound();
                }

                return Ok(support);
            }
        }

        [HttpPost]
        public IHttpActionResult Post(SupporterModel supporter)
        {
            using (var context = new Entities())
            {
                context.Supporter_Support.Add(new Supporter_Support()
                {
                    id = supporter.id,
                    name = supporter.name,
                    first_surname = supporter.firstSurname,
                    second_surname = supporter.secondSurname,
                    email = supporter.email,
                    id_supervisor = supporter.idSupervisor,
                    password = supporter.password,
                    television = supporter.television,
                    mobile_phone = supporter.mobilePhone,
                    telephone = supporter.telephone,
                    internet = supporter.internet
                });
                context.SaveChanges();
            }
            return Ok();
        }
    }
}
