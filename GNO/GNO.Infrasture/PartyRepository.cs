using GNO.Core;
using GNO.Models;

namespace GNO.Infrasturcture
{
    public class PartyRepository: BaseRepository<Party>, IPartyRepository
    {
        public PartyRepository(GreatNightOutContext db) : base(db)
        {       
        }
    }
}
