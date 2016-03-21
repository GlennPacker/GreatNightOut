using GNO.Models;
using System.Linq;

namespace GNO.Core
{
    public interface IPartyRepository
    {
        void Add(Party entity);
        void Update(Party entity);
        void Delete(Party entity);
        Party Get(int id);
        IQueryable<Party> List();
        void Save();
    }
}