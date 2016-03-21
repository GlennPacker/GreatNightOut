using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using GNO.Core;

namespace GNO.Web.Controllers
{
    public class PartyController : ApiController
    {
        private readonly IPartyService _partyService;

        public PartyController(IPartyService partyService)
        {
            _partyService = partyService;
        }

        // GET api/party
        public HttpResponseMessage Get()
        {
            var result = _partyService.GetFutureParties();
            return result == null ? Request.CreateResponse(HttpStatusCode.BadRequest, "No Events Found") : Request.CreateResponse(HttpStatusCode.OK, result);
        }

        // GET api/party/5
        public HttpResponseMessage Get(int id)
        {
            var result = _partyService.GetParty(id);
            return result == null ? Request.CreateResponse(HttpStatusCode.BadRequest, "Event Not Found") : Request.CreateResponse(HttpStatusCode.OK, result);
        }

    }
}
