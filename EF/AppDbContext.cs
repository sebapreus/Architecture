using Architecture.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class AppDbContext : ApplicationDbContext
    {
        public DbSet<Note> Note { get; set; }
    }
}
