using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Razor_Blog.Model;

namespace Razor_Blog.Mapping
{
    public class Blogcontext:DbContext
    {
        public DbSet<Article> Articles { get; set;  }

        public  Blogcontext(DbContextOptions<Blogcontext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
