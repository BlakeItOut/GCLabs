using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Capstone6.Models;

namespace Capstone6.Models
{
    public class Capstone6Context : DbContext
    {
        public Capstone6Context (DbContextOptions<Capstone6Context> options)
            : base(options)
        {
        }

        public DbSet<Capstone6.Models.Todo> Todo { get; set; }

        public DbSet<Capstone6.Models.User> User { get; set; }
    }
}
