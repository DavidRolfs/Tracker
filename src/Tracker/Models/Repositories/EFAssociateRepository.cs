using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tracker.Models
{
    public class EFAssociateRepository : IAssociateRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public EFAssociateRepository(ApplicationDbContext connection = null)
        {
            if (connection == null)
            {
                this.db = new ApplicationDbContext();
            }
            else
            {
                this.db = connection;
            }
        }

        public IQueryable<Associate> Associates
        { get { return db.Associates; } }

        public Associate Save(Associate associate)
        {
            db.Associates.Add(associate);
            db.SaveChanges();
            return associate;
        }

        public Associate Edit(Associate associate)
        {
            db.Entry(associate).State = EntityState.Modified;
            db.SaveChanges();
            return associate;
        }

        public void Remove(Associate associate)
        {
            db.Associates.Remove(associate);
            db.SaveChanges();
        }
    }
}