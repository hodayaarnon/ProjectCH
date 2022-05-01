using AutoMapper;
using Common.modelsVM;
using DAL;
using DAL.Classes;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Services
{
    public class AskstojoinService : IAskstojoinService
    {
        IMapper mapper;
        IAskstojoinRepositpry repo;

        public AskstojoinService(IAskstojoinRepositpry repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public void AddAsk(AskstojoinVM c)
        {
            repo.Create(mapper.Map<Askstojoin>(c));
        }

        public void DeleteAsk(int id)
        {
            throw new NotImplementedException();
        }

        public AskstojoinVM GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AskstojoinVM> GetList()
        {
            return mapper.Map<List<AskstojoinVM>>(repo.GetAll());
        }
    }
}
