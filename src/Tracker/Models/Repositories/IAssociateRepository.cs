using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tracker.Models
{
    public interface IAssociateRepository
    {
        IQueryable<Associate> Associates { get; }
        Associate Save(Associate Associate);
        Associate Edit(Associate Associate);
        void Remove(Associate Associate);
    }
}
