using AutoMapper;
using Common.modelsVM;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Profiles
{
   public class RolesProfile : Profile 
    { 
        public RolesProfile()
        {
            CreateMap<Roles, RolesVM>()
            .ForMember(r => r.Roleid, op => op.MapFrom(r => r.Roleid))
            .ForMember(r => r.Rolename, op => op.MapFrom(r => r.Rolename))
            .ReverseMap();
        }
    }
}
