using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IRolesRepository: IRepository<Roles>
    {
        List<Roles> GetUserRolesInCommunity(int userid, int comid);
    }
}
