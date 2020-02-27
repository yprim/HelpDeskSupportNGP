using Support.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Support.Controllers
{
    public class IssueClientController : ApiController
    {

        [HttpGet]
        [Route("api/IssueClient/")]
        public IHttpActionResult GetAll()
        {
            IList<IssueClientModel> issues = null;


            using (var context = new Entities())
            {
                issues = context.Issue_Client
                    .Select(issueItem => new IssueClientModel()
                    {
                        id = issueItem.id,
                        reportNumber = issueItem.report_number,
                        registerTimestamp = issueItem.register_timestamp,
                        address = issueItem.address,
                        contactPhone=issueItem.contact_phone,
                        contactEmail=issueItem.contact_email,
                        status = issueItem.status,
                        supportUserAsigned = issueItem.support_user_asigned,
                        idUser = issueItem.id_user,
                        description = issueItem.description,
                        service = issueItem.service,
                    }).ToList<IssueClientModel>();

            }
            //TODO: transform this snippet into a single return 
            if (issues.Count == 0)
            {
                return NotFound();
            }

            return Ok(issues);

        }



        [HttpPut]
        [Route("api/IssueClient/")]
        public IHttpActionResult Put(IssueClientModel issue)
        {
            using (var context = new Entities())
            {
                var existingIssue = context.Issue_Client.Where(report => report.report_number == issue.reportNumber).FirstOrDefault<Issue_Client>();
                if (existingIssue != null)
                {
                    existingIssue.status = issue.status;
                    existingIssue.support_user_asigned = issue.supportUserAsigned;
                    context.SaveChanges();
                }
                else
                {
                    return NotFound();
                }

            }
            return Ok();
        }
    }
}
