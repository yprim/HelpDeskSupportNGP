using Support.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Support.Controllers
{
    public class CommentsController : ApiController
    {

        [HttpGet]
        [Route("api/Comments/")]
        public IHttpActionResult GetAll()
        {
            IList<CommentModel> comments = null;


            using (var context = new Entities())
            {
                comments = context.Comment_Client
                    .Select(comentItem => new CommentModel()
                    {
                        id = comentItem.id,
                        description=comentItem.description,
                        noteTimestamp = comentItem.note_timestamp,
                        idIssue = comentItem.id_issue,
                        reportNumber = comentItem.report_number,

                    }).ToList<CommentModel>();

            }
            //TODO: transform this snippet into a single return 
            if (comments.Count == 0)
            {
                return NotFound();
            }

            return Ok(comments);

        }

        [HttpGet]
        [Route("api/Comments/")]
        public IHttpActionResult GetByReportNumber(String reportNumber)
        {
             IList<CommentModel> comments = null;


            using (var context = new Entities())
            {
                comments = context.Comment_Client
                    .Where(comentItem => comentItem.report_number == reportNumber)
                    .Select(comentItem => new CommentModel()
                    {
                        id = comentItem.id,
                        description = comentItem.description,
                        noteTimestamp = comentItem.note_timestamp,
                        idIssue = comentItem.id_issue,
                        reportNumber = comentItem.report_number,
                    }).ToList<CommentModel>();

            }
            //TODO: transform this snippet into a single return 
            if (comments == null)
            {
                return NotFound();
            }

            return Ok(comments);

        }

        [HttpPost]
        [Route("api/Comments/")]
        public IHttpActionResult Post(CommentModel comment)
        {
            using (var context = new Entities())
            {
                context.Comment_Client.Add(new Comment_Client()
                {
                    id = comment.id,
                    description = comment.description,
                    note_timestamp = comment.noteTimestamp,
                    id_issue = comment.idIssue,
                    report_number = comment.reportNumber,
                });
                context.SaveChanges();
            }
            return Ok();
        }
    }
}
