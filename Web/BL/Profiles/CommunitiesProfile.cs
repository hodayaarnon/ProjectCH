using AutoMapper;
using Common;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Profiles
{
   public class CommunitiesProfile: Profile
    {
        public CommunitiesProfile()
        {
            CreateMap<Communities, CommunitiesVM>()
                .ForMember(c=>c.communityId, ops=>ops.MapFrom(c=>c.Communityid))
                .ForMember(c=>c.communityName, ops=>ops.MapFrom(c=>c.Communityname))
                .ForMember(c=>c.Descriptions, ops=>ops.MapFrom(c=>c.Descriptions))
                .ForMember(c=>c.City, ops=>ops.MapFrom(c=>c.City))
                .ForMember(c=>c.Primemanager, ops=>ops.MapFrom(c=>c.Primemanager))
                .ReverseMap();

        }
    }
}
