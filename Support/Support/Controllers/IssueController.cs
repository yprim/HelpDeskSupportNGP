using Support.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Support.Controllers
{
    public class IssueController : ApiController
    {
        public IHttpActionResult GetAll()
        {
            IList<IssueModel> issues = null;


            using (var context = new Entities())
            {
                issues = context.Issue_Support
                    .Select(issueItem => new IssueModel()
                    {
                        id = issueItem.id,
                        report_number = issueItem.report_number,
                        classification = issueItem.classification,
                        status = issueItem.status,
                        report_timestamp = issueItem.report_timestamp,
                        resolution_comment = issueItem.resolution_comment,
                        id_supporter = issueItem.id_supporter,
                        description = issueItem.description,
                    }).ToList<IssueModel>();

            }
            //TODO: transform this snippet into a single return 
            if (issues.Count == 0)
            {
                return NotFound();
            }

            return Ok(issues);

        }

    }
}
