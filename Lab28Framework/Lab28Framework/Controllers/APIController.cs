using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Lab28Framework.Models;

namespace Lab28Framework.Controllers
{
    public class APIController : Controller
    {
        private const string _userAgent = "Mozilla / 5.0(Windows NT 6.1; Win64; x64; rv: 47.0) Gecko / 20100101 Firefox / 47.0";

        // GET: API
        public ActionResult Index()
        {
            var draw = new Draw();

            if (!TempData.ContainsKey("deckId"))
            {
                TempData.Add("deckId", "new");
            }

            HttpWebRequest request = WebRequest.CreateHttp($"https://deckofcardsapi.com/api/deck/{TempData["deckId"].ToString()}/draw/?count=5");

            request.UserAgent = _userAgent;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var serializer = new JsonSerializer();

                using (var data = new StreamReader(response.GetResponseStream()))
                using(var jsonReader = new JsonTextReader(data))
                {
                   draw = serializer.Deserialize<Draw>(jsonReader);
                }

                if (TempData["deckId"].ToString() == "new")
                {
                   TempData["deckId"] = draw.Deck_id;
                } 
                
            }

            TempData["deckId"] = TempData["deckId"];

            return View(draw);
        }

        public ActionResult Battle()
        {
            var draw = new Draw();

            if (!TempData.ContainsKey("deckId"))
            {
                TempData.Add("deckId", "new");
                TempData.Add("player1wins", 0);
                TempData.Add("ties", 0);
                TempData.Add("player2wins", 0);
            }

            HttpWebRequest request = WebRequest.CreateHttp($"https://deckofcardsapi.com/api/deck/{TempData["deckId"].ToString()}/draw/?count=2");

            request.UserAgent = _userAgent;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var serializer = new JsonSerializer();

                using (var data = new StreamReader(response.GetResponseStream()))
                using (var jsonReader = new JsonTextReader(data))
                {
                    draw = serializer.Deserialize<Draw>(jsonReader);
                }

                if (TempData["deckId"].ToString() == "new")
                {
                    TempData["deckId"] = draw.Deck_id;
                }

                if (draw.Success)
                {
                    switch (draw.Cards[0].CompareTo(draw.Cards[1]))
                    {
                        case 1:
                            TempData["player1wins"] = (int)TempData["player1wins"] + 1;
                            break;
                        case 0:
                            TempData["ties"] = (int)TempData["ties"] + 1;
                            break;
                        case -1:
                            TempData["player2wins"] = (int)TempData["player2wins"] + 1;
                            break;
                        default:
                            break;
                    }                   
                }              
            }

            TempData.Keep();

            return View(draw);
        }
    }
}