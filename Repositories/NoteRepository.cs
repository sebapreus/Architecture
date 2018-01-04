using EF;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class NoteRepository : BaseRepository<Note>
    {
        public NoteRepository(AppDbContext context)
            : base(context)
        {
        }
    }
}
