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
   public class RolesService: IRolesService
    {
        IRolesRepository repo;
        IMapper mapper;
         public RolesService(IRolesRepository repo, IMapper mapper)
        {
            this.mapper = mapper;
            this.repo = repo;
        }
        public List<RolesVM> GetUserRolesInCommunity(int userid, int comid)
        {
           return mapper.Map<List<RolesVM>>(repo.GetUserRolesInCommunity(userid, comid));
        }

        public bool isCommunityManager(int userid, int comid)
        {
            return repo.GetUserRolesInCommunity(userid, comid).Where(r => r.Roleid == 1).Count() > 0;
            //if(repo.GetUserRolesInCommunity(userid, comid).)
            
                //foreach (var role in repo.GetUserRolesInCommunity(userid, comid).Where()
                //{
                //    if (role.Roleid == 1)
                //        return true;
                //} return false;
        }

        //public bool isAuthorizedToPublish(int userid, int comid)
        //{
        //    List<Roles> userRoles = repo.GetById(userid);
        //    return 
        //}
    }
}
