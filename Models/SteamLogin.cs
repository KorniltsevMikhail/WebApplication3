using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class SteamLogin
    {
        public int ID { get; set; }
        public string SteamID { get; set; }
        public string UserName { get; set; } 
        public string SteamTradeUrl { get; set; }
    }
}