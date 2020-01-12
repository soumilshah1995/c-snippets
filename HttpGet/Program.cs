
//   Soumil Nitin Shah 
//   Wesbsite : http://soumilshah.herokuapp.com/
// Step 1: Install Dependencies 
// Install-Package Newtonsoft.Json -Version 12.0.3


using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace HttpGet
{

    class Requests{

        public string Url{get;set;}

        static readonly HttpClient client = new HttpClient();

        public Requests(string url)         // Constructor 
        {
            
            this.Url = url;
        }

        public async Task <dynamic> getJson()
        {   
            /*
                Makes a HTTP GET request and returns JSON 
            */
        
                var result = await client.GetStringAsync(this.Url);
                dynamic json = JsonConvert.DeserializeObject(result);
                return json;

        }

    }

    class Program
    {
        public static async Task  Main(string[] args)
        {
                var request = new Requests("https://data-asg.goldprice.org/dbXRates/USD");
                dynamic response = await request.getJson();
                Console.WriteLine(response);
        }
    }
}
