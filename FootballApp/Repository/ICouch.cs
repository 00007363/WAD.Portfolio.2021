using FootballApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApp.Repository
{
    public interface ICouch
    {
        List<Couch> GetAll();
        Couch GetById(int Id);
        void Create(Couch couch);
        void Edit(Couch couch);
        void Remove(Couch couch);
        void Save();

    }
}
