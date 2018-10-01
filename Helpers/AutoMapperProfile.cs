using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PinPointWeb.Models;
using PinPointWeb.Repositories.Models;
using AutoMapper;

namespace PinPointWeb.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
