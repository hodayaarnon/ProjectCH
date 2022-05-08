using AutoMapper;
using Common.modelsVM;
using DAL.Classes;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Services
{

    public class UsersService : IUsersService
    {
        IMapper mapper;
        IUsersRepository repo;

        public UsersService(IUsersRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        public void AddUser(UsersVM c)
        {
            repo.Create(mapper.Map<Users>(c));
        }

        public void AddUsers(IEnumerable<UsersVM> c)
        {
            repo.Create(mapper.Map<IEnumerable<Users>>(c));
        }

        public void DeleteUser(int id)
        {
            repo.Delete(id);
        }

        public UsersVM GetById(int id)
        {
            return mapper.Map<UsersVM>(repo.GetById(id));
        }

        public List<UsersVM> GetList()
        {
            List<Users> communities = repo.GetAll();
            return mapper.Map<List<UsersVM>>(communities);
        }

        public UsersVM GetUserByEmail(string Email)
        {
            return mapper.Map<UsersVM>(repo.GetUserByEmail(Email));
        }

        public UsersVM GetUserByEmailAndPassword(string Email, string password)
        {
            return mapper.Map<UsersVM>(repo.GetUserByEmailAndPassword(Email, password));
        }
    }
}
