using AutoMapper;
using Common.modelsVM;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Services
{
    public class JoiningsService : IJoiningsService
    {

        IMapper mapper;
        IJoiningsRepository repo;

        public JoiningsService(IJoiningsRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        public void AddJoining(JoiningsVM c)
        {
            repo.Create(mapper.Map<Joinings>(c));
        } 
        public void AddJoinings(IEnumerable<JoiningsVM> c)
        {
            repo.Create(mapper.Map<IEnumerable<Joinings>>(c));
        }

        public JoiningsVM GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<JoiningsVM> GetList()
        {
            return mapper.Map<List<JoiningsVM>>(repo.GetAll());
        }
    }
}
