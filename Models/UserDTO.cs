using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PinPointWeb.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
