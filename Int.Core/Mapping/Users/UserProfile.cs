using AutoMapper;
using Int.Core.DTOs.Users;
using Int.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int.Core.Mapping.Users
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>(); // تحويل Userr إلى UserDTO
        }
    }
}
