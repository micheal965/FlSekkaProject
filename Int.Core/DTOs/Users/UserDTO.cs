using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int.Core.DTOs.Users
{
    public class UserDTO
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string token { get; set; }
        public string phoneNumber { get; set; }
    }
}
