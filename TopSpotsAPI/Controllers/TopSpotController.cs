using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopSpotsAPI.Models;

namespace TopSpotsAPI.Controllers
{
    public class TopSpotController : ApiController
    {
        // GET: api/TopSpot
        public IEnumerable<TopSpot> Get()
        {
            var array = JsonConvert.DeserializeObject<IEnumerable<TopSpot>>(File.ReadAllText(@"C:/Dev/GitHub/TopSpotsAPI/TopSpotsAPI/TopSpotsAPI/topspots.json"));
            return array;
        }
    
        // GET: api/TopSpot/5
        public object Get(int id)
        {
            return "value";
        }

        // POST: api/TopSpot
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TopSpot/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TopSpot/5
        public void Delete(int id)
        {
        }
    }
}
