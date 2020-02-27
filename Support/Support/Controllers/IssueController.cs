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

        [HttpGet]
        [Route("api/Issue/")]
        public IHttpActionResult GetAll()
        {
            IList<IssueModel> issues = null;


            using (var context = new Entities())
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

        [HttpGet]
        [Route("api/Issue/{id}")]
        public IHttpActionResult GetBySupporter(int id)
        {
            IList<IssueModel> issues = null;


            using (var context = new Entities())
            {
                issues = context.Issue_Support
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
                    }).ToList<IssueModel>();

            }
            //TODO: transform this snippet into a single return 
            if (issues == null)
            {
                return NotFound();
            }

            return Ok(issues);

        }


        [HttpPost]
        [Route("api/Issue/")]
        public IHttpActionResult PostNewIssue(IssueModel issue)
        {
            using (var context = new Entities())
            {
                context.Issue_Support.Add(new Issue_Support()
                {
                   report_number=issue.reportNumber,
                    classification = issue.classification,
                    status = issue.status,
                    report_timestamp = issue.reportTimestamp,
                    resolution_comment = issue.resolutionComment,
                    id_supporter = issue.idSupporter,
                    description = issue.description,
                    service = issue.service,

                });

                context.SaveChanges();
            }
            return Ok();
        }

        [HttpPut]
        [Route("api/Issue/")]
        public IHttpActionResult Put(IssueModel issue)
        {
            using (var context = new Entities())
            {
                var existingIssue = context.Issue_Support.Where(id => id.id == issue.id).FirstOrDefault<Issue_Support>();
                if (existingIssue != null)
                {
                    existingIssue.status = issue.status;
                    existingIssue.id_supporter = issue.idSupporter;
                    existingIssue.resolution_comment = issue.resolutionComment;
                    existingIssue.classification = issue.classification;
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
