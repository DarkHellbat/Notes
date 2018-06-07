using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batNotes.Models.Mappings
{
    public class FileMap : ClassMap<File>
    {
        public FileMap()
        {
            Id(f => f.FileId).GeneratedBy.Identity();
            Map(f => f.Path).Length(100);
            Map(f => f.Size);
            Map(f => f.Type);

        }
    }
}
