using Support.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Support.Controllers
{
    public class NotesController : ApiController
    {
        public IHttpActionResult GetAll()
        {
            IList<NotesModel> notes = null;


            using (var context = new Entities2())
            {
                notes = context.Notes_Support
                    .Select(notesItem => new NotesModel()
                    {
                        id = notesItem.id,
                        description = notesItem.description,
                        noteTimestamp = notesItem.note_timestamp,
                        idIssue = notesItem.id_issue

                    }).ToList<NotesModel>();

            }
            //TODO: transform this snippet into a single return 
            if (notes.Count == 0)
            {
                return NotFound();
            }

            return Ok(notes);

        }

        public IHttpActionResult PostNewNote(NotesModel notes)
        {
            using (var context = new Entities2())
            {
                context.Notes_Support.Add(new Notes_Support()
                {
                    id = notes.id,
                    description = notes.description,
                    note_timestamp = notes.noteTimestamp,
                    id_issue = notes.idIssue

                });

                context.SaveChanges();
            }
            return Ok();
        }

        public IHttpActionResult GetByIssue(int id)
        {
            NotesModel notes = null;

            using (var context = new Entities2())
            {
                notes = context.Notes_Support
                    .Where(notesItem => notesItem.id_issue == id)
                    .Select(notesItem => new NotesModel()
                    {
                        id = notesItem.id,
                        description = notesItem.description,
                        noteTimestamp = notesItem.note_timestamp,
                        idIssue = notesItem.id_issue

                    }).FirstOrDefault<NotesModel>();

                if (notes == null)
                {
                    return NotFound();
                }

                return Ok(notes);
            }
        }
    }
}
