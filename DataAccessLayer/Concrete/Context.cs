﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-LCK25ST;database=CoreBlogDb; integrated security=true; TrustServerCertificate=True");
        }
        public DbSet<About>Abouts { get; set; }
        public DbSet<Blog>Blogs { get; set; }
        public DbSet<Category>Categories { get;set; }
        public DbSet<Comment>Comments{ get; set; }
        public DbSet<Contact>Contacts { get; set; }
        public DbSet<Writer>Writers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }

    }
}
