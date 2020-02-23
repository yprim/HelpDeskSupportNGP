﻿using Support.Models;
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


            using (var context = new Entities1())
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
                    }).ToList<IssueModel>();

            }
            //TODO: transform this snippet into a single return 
            if (issues.Count == 0)
            {
                return NotFound();
            }

            return Ok(issues);

        }


        public IHttpActionResult GetById(int id)
        {
            IssueModel issue = null;


            using (var context = new Entities1())
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
                    }).FirstOrDefault<IssueModel>();

            }
            //TODO: transform this snippet into a single return 
            if (issue == null)
            {
                return NotFound();
            }

            return Ok(issue);

        }

    }
}
