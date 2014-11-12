using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class ForecastController : ApiController
    {
        // GET api/values/5
        [HttpGet]
        public string Get([FromUri]float latitude, [FromUri]float longitude)
        {
            string apiUrl = "https://api.forecast.io/forecast/59cc4b448e36adeae3afe444c6337e0f/";
            WebRequest request = WebRequest.Create(apiUrl + latitude + "," + longitude);

            Stream result = request.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(result);
            string resultString = objReader.ReadToEnd();
            objReader.Close();
            result.Close();

            string json = JsonConvert.SerializeObject(resultString);
            return json;
        }

        [HttpGet]
        public string GetHistory([FromUri]float latitude, [FromUri]float longitude, [FromUri]uint time)
        {
            string apiUrl = "https://api.forecast.io/forecast/59cc4b448e36adeae3afe444c6337e0f/";
            WebRequest request = WebRequest.Create(apiUrl + latitude + "," + longitude + "," + time);

            Stream result = request.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(result);
            string resultString = objReader.ReadToEnd();
            objReader.Close();
            result.Close();

            string json = JsonConvert.SerializeObject(resultString);
            return json;
        }
    }
}
