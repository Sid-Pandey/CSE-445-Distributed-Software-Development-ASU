using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace WeatherService
{
   
    class Program
    {
        public static void Main(string[] args)
        {
            string zip = "85281,us";
            string api_key = "aef5f633af7b9c2c7ac0b580bcab3988";
            string mode = "xml";
            string weather_service_url = "http://api.openweathermap.org/data/2.5/forecast?zip=" + zip + "&APPID=" + api_key + "&mode=" + mode;
            Console.WriteLine(weather_service_url);

            var request = (HttpWebRequest)WebRequest.Create(weather_service_url);
            request.Method = "GET";
            var weather_response = string.Empty;
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        weather_response = sr.ReadToEnd();
                    }
                }
            }

            List<string> forecasts = new List<string>();

            Console.WriteLine(weather_response);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(weather_response);
            XmlNodeList xnList = doc.SelectNodes("/weatherdata/forecast/time"); //select all time nodes.

            foreach (XmlNode node in xnList)
            {
                Console.WriteLine("Here!");
                string from = node.Attributes[0].InnerText;
                string to = node.Attributes[1].InnerText;
                if(from.Contains("15:00:00") && to.Contains("18:00:00"))
                {
                    string forecast = "";
                    foreach(XmlNode child in node.ChildNodes)
                    {
                        if (child.Name == "symbol")
                        {
                            String sky = child.Attributes[0].InnerText;
                            String skies = "Skies : " + sky;
                            forecast += skies;
                            forecast += "\n";
                        }
                        else if (child.Name == "windDirection")
                        {
                            String direction = child.Attributes[0].InnerText;
                            String code = child.Attributes[1].InnerText;
                            String name = child.Attributes[2].InnerText;
                            String wind = "Wind : Degree : " + direction + "\t Direction code : " + code + "\t Direction : " + name;
                            forecast += wind;
                            forecast += "\n";
                        }
                        else if (child.Name == "windSpeed")
                        {
                            String speed = child.Attributes[0].InnerText;
                            String speeddesc = child.Attributes[1].InnerText;
                            String windspeed = "Wind Speed : " + speed + "\t Type : " + speeddesc;
                            forecast = forecast + windspeed + "\n";
                        }
                        else if (child.Name == "temperature")
                        {
                            String unit = child.Attributes[0].InnerText;
                            String temp = child.Attributes[1].InnerText;
                            String mintemp = child.Attributes[2].InnerText;
                            String maxtemp = child.Attributes[3].InnerText;
                            String temperature = "Temerature : Unit : " + unit + "\t Current : " + temp + "\t Min : " + mintemp + "\t Max : " + maxtemp;
                            forecast = forecast + temperature + "\n";
                        }
                        else if (child.Name == "humidity")
                        {
                            String value = child.Attributes[0].InnerText;
                            String humidity = "Humidity : " + value + "%";
                            forecast = forecast + humidity + "\n";
                        }
                    }
            //        Console.WriteLine(forecast);
                    forecasts.Add(forecast);
                }
            }

            foreach (string f in forecasts)
                Console.WriteLine(f);

            Console.ReadKey();
        }
    }
}
