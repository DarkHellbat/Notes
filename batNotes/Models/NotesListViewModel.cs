using batNotes.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace batNotes.Models
{
    public class NotesListViewModel
    {
        public List<Note> Notes { get; set; }
        public User current =
        public NotesListViewModel()
        {
            Notes = new List<Note>();
        }
    }
}