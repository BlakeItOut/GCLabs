using BatAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BatAPI.Controllers
{
    public class SpeciesController : ApiController
    {
        BatFriendsDBEntities db = new BatFriendsDBEntities();

        public IQueryable<Species> GetSpecies(string commonName = "", string speciesName = "", string genus = "", string family = "", string funFact = "")
        {
            return db.Species
                .Where(s => s.Family == family || String.IsNullOrEmpty(family))
                .Where(s => s.Genus == genus || String.IsNullOrEmpty(genus))
                .Where(s => s.SpeciesName == speciesName || String.IsNullOrEmpty(speciesName))
                .Where(s => s.CommonName.Contains(commonName) || String.IsNullOrEmpty(commonName))
                .Where(s => s.FunFact.Contains(funFact) || String.IsNullOrEmpty(funFact));
        }
    }
}
