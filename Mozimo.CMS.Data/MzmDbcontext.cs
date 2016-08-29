using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mozimo.CMS.Data.Domain.News;

namespace Mozimo.CMS.Data
{
    public class MzmDbcontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMyCat("server=localhost;database=testdb;uid=root;pwd=digdeep")
                .UseDataNode("localhost", "mozimo_cms_01", "root", "")
                .UseDataNode("localhost", "mozimo_cms_02", "root", "");
        }

        public DbSet<News> News { get; set; }
    }
}
