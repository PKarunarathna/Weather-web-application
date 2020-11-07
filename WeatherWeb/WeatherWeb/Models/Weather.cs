using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WeatherWeb.Models
{
    class Weather
    {
        public Object getWeatherForecast()
        {
            string appid = "0973222e61da15cc2474a5df3d890107";
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Kandy&APPID="+ appid;
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}