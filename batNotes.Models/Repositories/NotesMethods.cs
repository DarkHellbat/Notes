using NHibernate;
using NHibernate.Criterion;
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
        public IList<Note> GetUsersNotes(User user)
        {
            var crit = session.CreateCriteria<Note>();

            crit.Add(Restrictions.Eq("Author.Id", user.Id));

            return crit.List<Note>();

        }
    }
}
