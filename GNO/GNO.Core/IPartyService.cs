using System.Collections.Generic;
using GNO.Models;

namespace GNO.Core
{
    public interface IPartyService
    {
        List<Party> GetFutureParties();
        Party GetParty(int id);
    }
}