using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface ICommunitiesRepository:IRepository<Communities>
    {
        List<Communities> GetUserCommunities(int id);
    }
}
