using Common.modelsVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Services
{
   public interface IJoiningsService
    {
        List<JoiningsVM> GetList();
        JoiningsVM GetById(int id);
        void AddJoining(JoiningsVM c);
    }
}
