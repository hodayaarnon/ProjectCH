using AutoMapper;
using Common;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Services
{
    public class CommunitiesService : ICommunitiesService
    {
       
        IMapper mapper;
        ICommunitiesRepository repo;

        public CommunitiesService(ICommunitiesRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        public List<CommunitiesVM> getAllCommunities()
        {
            List<Communities> communities = repo.GetAll();
             return mapper.Map<List<CommunitiesVM>>(communities);

                    //List<CommunitiesVM> getAll = new List<CommunitiesVM>();
                    //getAll.Add(new CommunitiesVM() { commuintyId = 90, communityName = "kut574" });
                    //return getAll;
        }
        public List<CommunitiesVM> GetUserCommunities(int id)
        {
            List<Communities> communities = repo.GetUserCommunities(id);
             return mapper.Map<List<CommunitiesVM>>(communities);

        }
    }
}
