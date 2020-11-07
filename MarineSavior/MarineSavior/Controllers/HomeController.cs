using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MarineSavior.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //get data from AIShub API
            string JSonData = HttpGet("http://data.aishub.net/ws.php?username=USERNAME&format=1&output=json&compress=3&latmin=20.5&latmax=30.8&lonmin=-15&lonmax=18.6");

            //get data from 
            return View();
        }
        public string HttpGet(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            try
            {
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);

                    return reader.ReadToEnd();
                }
            }
            finally
            {
                response.Close();
            }
        }

    }
}