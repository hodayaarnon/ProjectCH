using System;
using Common;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public interface ICommunitiesService
    {
        List<CommunitiesVM> GetAllCommunities();
        List<CommunitiesVM> GetUserCommunities(int id);
        CommunitiesVM GetCommunityById(int id);
        
    }
}
