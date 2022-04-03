using AutoMapper;
using Common.modelsVM;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Profiles
{
   public class UsersProfile:Profile
    {
        public UsersProfile()
        {
            CreateMap<Users, UsersVM>()
                .ForMember(u => u.Userid, ops => ops.MapFrom(u => u.Userid))
                .ForMember(u => u.Useridentity, ops => ops.MapFrom(u => u.Useridentity))
                .ForMember(u => u.Adress, ops => ops.MapFrom(u => u.Adress))
                .ForMember(u => u.Adresslat, ops => ops.MapFrom(u => u.Adresslat))
                .ForMember(u => u.Adresslng, ops => ops.MapFrom(u => u.Adresslng))
                .ForMember(u => u.Userpassword, ops => ops.MapFrom(u => u.Userpassword))
                .ForMember(u => u.Userlastname, ops => ops.MapFrom(u => u.Userlastname))
                .ForMember(u => u.Userfirstname, ops => ops.MapFrom(u => u.Userfirstname))
                .ForMember(u => u.City, ops => ops.MapFrom(u => u.City))
                .ForMember(u => u.Email, ops => ops.MapFrom(u => u.Email))
                .ForMember(u => u.Street, ops => ops.MapFrom(u => u.Street))
                .ForMember(u => u.Housenumber, ops => ops.MapFrom(u => u.Housenumber))
                .ForMember(u => u.Postalcode, ops => ops.MapFrom(u => u.Postalcode))
                .ReverseMap();
        }


        
    }
}
