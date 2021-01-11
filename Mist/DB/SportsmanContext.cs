using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Mist.Models;

namespace Mist.DB
{
    public class SportsmanContext : DbContext
    {
        public DbSet<Sportsman> Sportsmans { get; set; }
    }
}