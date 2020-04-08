using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorreiosPOC.Models
{
    public class Context: DbContext
    {

        public Context(DbContextOptions<Context> option) : base(option)
        {
            Database.EnsureCreated();
        }

        public DbSet<Endereco> Endereco { get; set; }
    }
}
