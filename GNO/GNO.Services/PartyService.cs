using GNO.Core;
using System.Collections.Generic;
using GNO.Models;
using System.Linq;

namespace GNO.Services
{
    public class PartyService : IPartyService
    {
        private readonly IPartyRepository _partyRepository;

        public PartyService(IPartyRepository partyRepository)
        {
            _partyRepository = partyRepository;
        }

        public List<Party> GetFutureParties()
        {
            var now = System.DateTime.Now.AddHours(-4); // so that we can see the event until its ended
            var data = _partyRepository.List().Where(r => r.EventDate > now).ToList();
            return data;
        }

        public Party GetParty(int id)
        {
            var data = _partyRepository.Get(id);
            return data;
        }
    }
}
