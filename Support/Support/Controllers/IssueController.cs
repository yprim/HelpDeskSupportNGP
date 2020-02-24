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


            using (var context = new Entities2())
            {
                issues = context.Issue_Support
                    .Select(issueItem => new IssueModel()
                    {
                        id = issueItem.id,
                        reportNumber = issueItem.report_number,
                        classification = issueItem.classification,
                        status = issueItem.status,
                        reportTimestamp = issueItem.report_timestamp,
                        resolutionComment = issueItem.resolution_comment,
                        idSupporter = issueItem.id_supporter,
                        description = issueItem.description,
                        service= issueItem.service,
                    }).ToList<IssueModel>();

            }
            //TODO: transform this snippet into a single return 
            if (issues.Count == 0)
            {
                return NotFound();
            }

            return Ok(issues);

        }


        public IHttpActionResult GetBySupporter(int id)
        {
            IssueModel issue = null;


            using (var context = new Entities2())
            {
                issue = context.Issue_Support
                    .Where(issueItem =>issueItem.id_supporter== id)
                    .Select(issueItem => new IssueModel()
                    {
                        id = issueItem.id,
                        reportNumber = issueItem.report_number,
                        classification = issueItem.classification,
                        status = issueItem.status,
                        reportTimestamp = issueItem.report_timestamp,
                        resolutionComment = issueItem.resolution_comment,
                        idSupporter = issueItem.id_supporter,
                        description = issueItem.description,
                        service = issueItem.service,
                    }).FirstOrDefault<IssueModel>();

            }
            //TODO: transform this snippet into a single return 
            if (issue == null)
            {
                return NotFound();
            }

            return Ok(issue);

        }




        public IHttpActionResult Put(IssueModel issue)
        {
            using (var context = new Entities2())
            {
                var existingIssue = context.Issue_Support.Where(id => id.id == issue.id).FirstOrDefault<Issue_Support>();
                if (existingIssue != null)
                {
                    existingIssue.status = issue.status;
                    existingIssue.id_supporter = issue.idSupporter;
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
