using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WeatherApp.Models
{
    public class Weather
    {
        string cityname;
      public Object getWeatherForecast()
      {
      
      string url = "http://api.openweathermap.org/data/2.5/weather?q="+cityname+"&APPID=fad7de74a958f53fa6b85a3632c426af&units=imperial";
      var client = new WebClient();
      var content = client.DownloadString(url);
      var serializer = new JavaScriptSerializer();
      var jsonContent = serializer.Deserialize<Object>(content);
      return jsonContent;
      }

      public static string GetIPAddress()
      {
          string ipAddress = HttpContext.Current.Request.UserHostAddress;
          return ipAddress;
      }



    }
}