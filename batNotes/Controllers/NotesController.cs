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
                Notes = notesMethods.GetUsersNotes(CurrentUser)
        };
            return View(model);
        }
        public ActionResult ViewNote(long id)
        {
            var note = notesMethods.Load(id);
            return View(new NoteViewModel
            {NoteId = note.NoteId,
                Name = note.Name,
                Text = note.Text,
                Changed = note.Changed,
                Created=note.Changed
            });
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EditNoteModel model)
        {
             Note newNote = new Note
                {
                    Name = model.Name,
                    Text = model.Text,
                    Created = DateTime.Now,
                    Changed = DateTime.Now,
                    Author = CurrentUser
                };

                notesMethods.Save(newNote);

                return RedirectToAction("ShowNotes", "Notes");
        }
 
        public ActionResult Edit(long id)
        {
            var note = notesMethods.Load(id);
            var model = new EditNoteModel
            { NoteId = note.NoteId,
                Name = note.Name,
                Text = note.Text,
                Changed = note.Changed,
                Created = note.Created
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(EditNoteModel model)
        {
            var note = notesMethods.Load(model.NoteId);
            note.Name = model.Name;
            note.Text = model.Text;
            note.Changed = DateTime.Now;
            notesMethods.Save(note);
            return RedirectToAction("ShowNotes", "Notes");
        }
    }
}