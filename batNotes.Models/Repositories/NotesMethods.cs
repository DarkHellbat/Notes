using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batNotes.Models.Repositories
{
    [Repository]
   public class NotesMethods : Repository<Note>
    {
        public NotesMethods(ISession session):
            base(session)
        {
            this.session = session;
        }
        public List<Note> GetAll()
        {
            return session.CreateCriteria<Note>().List<Note>().ToList();
        }
        public List<Note> GetUsersNotes()
        {
            session.CreateCriteria<Note>().CreateCriteria();

        }
    }
}
