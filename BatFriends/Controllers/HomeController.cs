using BatFriends.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BatFriends.Controllers
{
    public class HomeController : Controller
    {
        private const string _userAgent = "Mozilla / 5.0(Windows NT 6.1; Win64; x64; rv: 47.0) Gecko / 20100101 Firefox / 47.0";
        public ActionResult Index(SpeciesDTO speciesDTO)
        {
            var species = new List<SpeciesDTO>();

            HttpWebRequest request = WebRequest.CreateHttp($"http://localhost:54141/api/species?commonName={speciesDTO.CommonName}&speciesName={speciesDTO.SpeciesName}&genus={speciesDTO.Genus}&family={speciesDTO.Family}&funFact={speciesDTO.FunFact}");

            request.UserAgent = _userAgent;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var serializer = new JsonSerializer();

                using (var data = new StreamReader(response.GetResponseStream()))
                using (var jsonReader = new JsonTextReader(data))
                {
                    species = serializer.Deserialize<List<SpeciesDTO>>(jsonReader);
                }

            }
            return View(species);
        }

        public ActionResult Search()
        {
            var species = new List<SpeciesDTO>();

            HttpWebRequest request = WebRequest.CreateHttp($"http://localhost:54141/api/species");

            request.UserAgent = _userAgent;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var serializer = new JsonSerializer();

                using (var data = new StreamReader(response.GetResponseStream()))
                using (var jsonReader = new JsonTextReader(data))
                {
                    species = serializer.Deserialize<List<SpeciesDTO>>(jsonReader);
                }

            }

            ViewBag.Family = new SelectList(species.Select(s => s.Family).Distinct().Concat(new[] { "" }).OrderBy(m => m));
            ViewBag.Genus = new SelectList(species.Select(s => s.Genus).Distinct().Concat(new[] { "" }).OrderBy(m => m));            
            ViewBag.SpeciesName = new SelectList(species.Select(s => s.SpeciesName).Distinct().Concat(new[] { "" }).OrderBy(m => m));

            return View();
        }

        [HttpPost]
        public ActionResult Search(SpeciesDTO speciesDTO)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", speciesDTO);
            }

            return View(speciesDTO);
        }

    }
}