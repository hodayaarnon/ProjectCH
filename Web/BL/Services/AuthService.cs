using AutoMapper;
using Common.modelsVM;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.Services
{
    public class AuthService : IAuthService
    {
        IAuthRepository repo;
        IMapper mapper;
        public AuthService(IAuthRepository repo, IMapper mapper)
        {
            this.mapper = mapper;
            this.repo = repo;
        }
        public List<AuthorizationsVM> GetAllAuthorizeds()
        {
            return mapper.Map<List<AuthorizationsVM>>(repo.GetAll());
        }

        public List<AuthorizationsVM> GetCommunityAuthorizeds(int comid)
        {
            List<Authorizations> list1 = (from a in repo.GetAll() where (a.Communityid==comid) select a).ToList();
            return mapper.Map<List<AuthorizationsVM>>(list1);

        }

        //public bool IsAuthInCommunity(int userid, int comid)
        //{
        //    //List<Authorizations> list1 = (from a in repo.GetAll() where (a.Communityid == comid && a.) select a).ToList();
        //    //return mapper.Map<List<AuthorizationsVM>>(list1);
        //   // List<Authorizations> list1 = (from a in repo.GetAll() where (a.Communityid == comid && a.use) select a).ToList();
        //}
    }
}
