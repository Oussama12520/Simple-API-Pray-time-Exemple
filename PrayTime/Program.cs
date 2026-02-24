using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Security.Policy;
using Newtonsoft.Json.Linq;
using Spectre.Console;

namespace PrayTime
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                string url = $"https://api.aladhan.com/v1/timingsByAddress/" +
                     $"{DateTime.Now.Day.ToString().PadLeft(2, '0')}-" +
                     $"{DateTime.Now.Month.ToString().PadLeft(2, '0')}-" +
                     $"{DateTime.Now.Year}?address=Sfax,Tunisia";

                HttpClient client = new HttpClient();
                string response = await client.GetStringAsync(url);
                JObject jObject = JObject.Parse(response);
                //Console.WriteLine(jObject.ToString());
                JToken data = jObject["data"];

                string readableDate = data["date"]["readable"].ToString();

                // Access Hijri month
                string hijriMonth = data["date"]["hijri"]["month"]["en"].ToString();

                // Access timezone
                string timezone = data["meta"]["timezone"].ToString();


                string osama1 =
@"  
██╗   ██████╗ ███████╗ █████╗ ███╗   ███╗ █████╗  
 ██║  ██╔═══██╗██╔════╝██╔══██╗████╗ ████║██╔══██╗  
 ██║  ██║   ██║███████╗███████║██╔████╔██║███████║  
 ╚═╝  ██║   ██║╚════██║██╔══██║██║╚██╔╝██║██╔══██║  
 ██╗  ╚██████╔╝███████║██║  ██║██║ ╚═╝ ██║██║  ██║  
 ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝  
    ";

                // Corrected the usage of AnsiConsole.Markup to display the text properly  
                AnsiConsole.Write(
                    Align.Center(
                        new Markup($"[red]{osama1}[/]")
                    )
                );
                AnsiConsole.MarkupLine($"[link={url}]<<API URL>>[/]");
                Console.WriteLine($"Date: {readableDate}");
                Console.WriteLine($"Hijri Month: {hijriMonth}");
                Console.WriteLine($"Timezone: {timezone}\n");
                Console.WriteLine($"Fajr: {jObject["data"]["timings"]["Fajr"]}");
                Console.WriteLine($"Dhuhr: {jObject["data"]["timings"]["Dhuhr"]}");
                Console.WriteLine($"Asr: {jObject["data"]["timings"]["Asr"]}");
                Console.WriteLine($"Maghrib: {jObject["data"]["timings"]["Maghrib"]}");
                Console.WriteLine($"Isha: {jObject["data"]["timings"]["Isha"]}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
    }
}
