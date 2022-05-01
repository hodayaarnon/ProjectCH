using Common.modelsVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Services
{
   public interface IAskstojoinService
    {
        List<AskstojoinVM> GetList();
        //AskstojoinVM GetById(int id);
        void DeleteAsk(int id);
        void AddAsk(AskstojoinVM c);
        
    }
}
