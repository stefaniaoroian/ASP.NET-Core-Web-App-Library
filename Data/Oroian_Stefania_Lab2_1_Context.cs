using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Oroian_Stefania_Lab2_1_.Models;
using Oroian_Stefania_Lab2_1_.Models.ViewModels;

namespace Oroian_Stefania_Lab2_1_.Data
{
    public class Oroian_Stefania_Lab2_1_Context : DbContext
    {
        public Oroian_Stefania_Lab2_1_Context (DbContextOptions<Oroian_Stefania_Lab2_1_Context> options)
            : base(options)
        {
        }

        public DbSet<Oroian_Stefania_Lab2_1_.Models.Book> Book { get; set; } = default!;

        public DbSet<Oroian_Stefania_Lab2_1_.Models.Publisher> Publisher { get; set; }

        public DbSet<Oroian_Stefania_Lab2_1_.Models.Author> Author { get; set; }

        public DbSet<Oroian_Stefania_Lab2_1_.Models.Category> Category { get; set; }

        public DbSet<Oroian_Stefania_Lab2_1_.Models.Member> Member { get; set; }

        public DbSet<Oroian_Stefania_Lab2_1_.Models.ViewModels.Borrowing> Borrowing { get; set; }
    }
}
