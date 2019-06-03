using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArqDota2.Models
{
    public class User
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string SteamProfile { get; set; }
    }
}
