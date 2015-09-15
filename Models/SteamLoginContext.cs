using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;


namespace WebApplication3.Models
{
    public class SteamLoginContext : DbContext
    {
        public DbSet<SteamLogin> Login { get; set; }
    }
}