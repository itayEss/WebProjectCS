using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectCS.Models;


namespace WebProjectCS.Models.Managment
{
    
    public class ApplicationDbContextcs : DbContext 
    {
        public DbSet<UserAcccount> userAccount { get; set; }
        public DbSet<ConvBlogItem> convBlogItem { get; set; }
        public DbSet<BlogItem> blogItem { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ApplicationDB;Trusted_Connection=True;");
            //DefaultConnection
            //optionsBuilder.UseSqlServer("DefaultConnection");
        }

        public DbSet<WebProjectCS.Models.ConvBlogItem> ConvBlogItem { get; set; }
    }
}
