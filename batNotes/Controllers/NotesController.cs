using batNotes.Models;
using batNotes.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace batNotes.Controllers
{
    public class NotesController : BaseController
    {
        private NotesMethods notesMethods;

        public NotesController(NotesMethods notesMethods ,UserMethods userRepository) : base(userRepository)
        {
            this.notesMethods = notesMethods;
        }

        // GET: Notes
        public ActionResult ShowNotes()
        {
            var model = new NotesListViewModel
            {
                Notes = notesMethods.GetAll()
        };
            return View(model);
        }
        public ActionResult ViewNote(long id)
        {
            var note = notesMethods.Load(id);
            return View(new NoteViewModel
            {
                Name = note.Name,
                Text = note.Text,
                Changed = note.Changed,
                Created=note.Changed
            });
        }
    }
}