using AutoMapper;
using Common.modelsVM;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Profiles
{
   public class AskstojoinProfile:Profile
    {
        public AskstojoinProfile()
        {
            CreateMap<Askstojoin, AskstojoinVM>()
                .ForMember(a => a.Askid, ops => ops.MapFrom(ask=>ask.Askid))
                .ForMember(a => a.Communityid, ops => ops.MapFrom(ask=>ask.Communityid))
                .ForMember(a => a.Joinasamanager, ops => ops.MapFrom(ask=>ask.Joinasamanager))
                .ForMember(a => a.Userid, ops => ops.MapFrom(ask=>ask.Userid))
                .ForMember(a => a.Communityname, ops => ops.MapFrom(ask=>ask.Community.Communityname))
                .ReverseMap();

        }
    }
}
