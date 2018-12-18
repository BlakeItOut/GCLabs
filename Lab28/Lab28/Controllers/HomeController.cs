using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab28.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Lab28.Controllers
{
    public class HomeController : Controller
    {
        private const string _userAgent = "Mozilla / 5.0(Windows NT 6.1; Win64; x64; rv: 47.0) Gecko / 20100101 Firefox / 47.0";
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Play()
        {
            //var deckId = TempData["deckId"] != null ? TempData["deckId"].ToString() : "new";

            //HttpWebRequest request = WebRequest.CreateHttp($"https://deckofcardsapi.com/api/deck/new/draw/?count=5");

            //request.UserAgent = _userAgent;

            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //if (response.StatusCode == HttpStatusCode.OK)
            //{
            //    StreamReader data = new StreamReader(response.GetResponseStream());

            //    JObject dataObject = JObject.Parse(data.ReadToEnd());

            //    //TempData["deckId"] = dataObject["deck_id"];

            //    ViewBag.Cards = dataObject["cards"];

            //    ViewBag.Card = dataObject["cards"][0];
            //}

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
