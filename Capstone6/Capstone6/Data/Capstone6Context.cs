using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Capstone6.Models
{
    public class Capstone6Context : DbContext
    {
        public Capstone6Context (DbContextOptions<Capstone6Context> options)
            : base(options)
        {
        }

        public DbSet<Capstone6.Models.Todo> Todo { get; set; }
    }
}
