using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ENVIAR REQUEST Y DESEREALIZARLO A RESPONSE
            // GET LIST
            HttpClient client = new HttpClient();
            Uri baseUrl = new Uri("https://localhost:44386/api/");
            //var result = client.GetAsync(baseUrl+"manga").Result.Content.ReadAsStringAsync().Result;
            //var response = JsonConvert.DeserializeObject<ResponseList>(result);
            //Console.WriteLine(response.message);
            //foreach (var item in response.result)
            //{
            //    Console.WriteLine(item.Name);
            //}


            // POST NEW MANGA
            //var newManga = new Manga()
            //{
            //    Name = "Shingeki no Kyojin",
            //    Description = "Titanes"
            //};
            //var newMangaJson = JsonConvert.SerializeObject(newManga);
            //var payload = new StringContent(newMangaJson, Encoding.UTF8, "application/json");
            //var result = client.PostAsync(baseUrl+"manga", payload).Result.Content.ReadAsStringAsync().Result;
            //var response = JsonConvert.DeserializeObject<ResponseSingle>(result);
            //Console.WriteLine(response.result.Name);


            // GET BY ID
            //var result = client.GetAsync(baseUrl + "manga/1").Result.Content.ReadAsStringAsync().Result;
            //var response = JsonConvert.DeserializeObject<ResponseSingle>(result);
            //Console.WriteLine(response.result.Name);


            // DELETE BY ID
            //var request = new HttpRequestMessage(HttpMethod.Delete, baseUrl + "manga/1008")
            //{
            //    Content = new StringContent("", Encoding.UTF8, "application/json")
            //};
            //var result = client.SendAsync(request).Result.Content.ReadAsStringAsync().Result;
            ////Console.WriteLine(result.Result.Content.ReadAsStringAsync().Result);
            //var response = JsonConvert.DeserializeObject<ResponseDelete>(result);
            //Console.WriteLine(response.result);


            // PUT BY ID
            //var updateManga = new Manga()
            //{
            //    Id = 1004,
            //    Name = "Grand Blue",
            //    Description = "Drunk people"
            //};
            //var content = new StringContent(JsonConvert.SerializeObject(updateManga), Encoding.UTF8, "application/json");
            //var result = client.PutAsync(baseUrl + "manga", content).Result.Content.ReadAsStringAsync().Result;
            //var response = JsonConvert.DeserializeObject<ResponseSingle>(result);
            //Console.WriteLine(response.result);
        }
    }

    [Serializable]
    public class ResponseDelete
    {
        public bool isSuccess { get; set; }
        public object result { get; set; }
        public object message { get; set; }
        public object errorMessages { get; set; }
    }

    [Serializable]
    public class ResponseList
    {
        public bool isSuccess { get; set; }
        public List<Manga> result { get; set; }
        public object message { get; set; }
        public object errorMessages { get; set; }
    }

    [Serializable]
    public class ResponseSingle
    {
        public bool isSuccess { get; set; }
        public Manga result { get; set; }
        public object message { get; set; }
        public object errorMessages { get; set; }
    }

    public class Manga
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}