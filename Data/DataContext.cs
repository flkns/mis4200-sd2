using mis4200_sd2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mis4200_sd2.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=DefaultConnection") { }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Label> Labels { get; set; }
    }
}