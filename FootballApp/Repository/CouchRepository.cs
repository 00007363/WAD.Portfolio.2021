
using FootballApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApp.Repository
{
    public class CouchRepository : ICouch
    {
        private FootballContext _context;

        public CouchRepository(FootballContext context)
        {
            _context = context;
        }
        public void Create(Couch couch)
        {
            _context.Couches.Add(couch);
        }

        public void Edit(Couch couch)
        {
            _context.Couches.Update(couch);
        }

        public List<Couch> GetAll()
        {
            return _context.Couches.ToList();
        }

        public Couch GetById(int Id)
        {
            return _context.Couches.Where(a => a.Id == Id).FirstOrDefault();
        }

        public void Remove(Couch couch)
        {
            _context.Couches.Remove(couch);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
