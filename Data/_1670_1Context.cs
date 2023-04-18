using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _1670_1.Models;

namespace _1670_1.Data
{
    public class _1670_1Context : DbContext
    {
        public _1670_1Context (DbContextOptions<_1670_1Context> options)
            : base(options)
        {
        }

        public DbSet<_1670_1.Models.Book> Book { get; set; } = default!;

        public DbSet<_1670_1.Models.Category> Category { get; set; } = default!;
    }
}
