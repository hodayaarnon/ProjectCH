using Common.modelsVM;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Services
{
   public interface IRolesService
   {
        List<RolesVM> GetUserRolesInCommunity(int userid, int comid);
        bool isCommunityManager(int userid, int comid);
        //bool isAuthorizedToPublish(int userid, int comid);
    }
}
