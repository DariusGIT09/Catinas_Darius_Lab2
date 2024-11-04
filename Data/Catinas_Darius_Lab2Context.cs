using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Catinas_Darius_Lab2.Models;

namespace Catinas_Darius_Lab2.Data
{
    public class Catinas_Darius_Lab2Context : DbContext
    {
        public Catinas_Darius_Lab2Context (DbContextOptions<Catinas_Darius_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Catinas_Darius_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Catinas_Darius_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Catinas_Darius_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
