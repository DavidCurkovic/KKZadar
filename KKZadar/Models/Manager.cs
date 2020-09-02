using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KKZadar.Models
{
    public class Manager
    {
        public int ManagerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }

        public ICollection<Player> Team { get; set; }
    }
}
