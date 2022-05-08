using AutoMapper;
using Common.modelsVM;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Profiles
{
  public  class JoiningsProfile:Profile
    {
        public JoiningsProfile()
        {
            CreateMap<Joinings, JoiningsVM>()
                .ForMember(j => j.Userid, ops => ops.MapFrom(j => j.Userid))
                .ForMember(j => j.Roleid, ops => ops.MapFrom(j => j.Roleid))
                .ForMember(j => j.Isavalid, ops => ops.MapFrom(j => j.Isavalid))
                .ForMember(j => j.Joiningid, ops => ops.MapFrom(j => j.Joiningid))
                .ForMember(j => j.Joinnigdate, ops => ops.MapFrom(j => j.Joinnigdate))
                .ForMember(j => j.Communityid, ops => ops.MapFrom(j => j.Communityid))
                .ReverseMap();
        }
    }
}
