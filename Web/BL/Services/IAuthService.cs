using Common.modelsVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Services
{
   public interface IAuthService
    {

        List<AuthorizationsVM> GetAllAuthorizeds();
        List<AuthorizationsVM> GetCommunityAuthorizeds(int comid);
       // bool IsAuthInCommunity(int userid, int comid);
    }
}
