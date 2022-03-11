using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digisegal.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string UserName { get; set; }
        public string Nationalcode { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Status { get; set; } = "Active";
        public int RoleId { get; set; } = 3;
        public string Address { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public DateTime RemoveDate { get; set; }
    }
}