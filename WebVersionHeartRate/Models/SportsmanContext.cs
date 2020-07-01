using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebVersionHeartRate.Models
{
    public class SportsmanContext : DbContext
    {
        public DbSet<Sportsman> Sportsmen { get; set; }
    }
}