using Microsoft.EntityFrameworkCore;
using PictureManager.BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace PictureManager.DAL
{
   public class PictureManagerDBContext : DbContext
    {
        public PictureManagerDBContext(DbContextOptions<PictureManagerDBContext> options) : base(options)
        {

        }

        public DbSet<Picture> Pictures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PictureDbConfiguration());
        }
    }
}
