using System.Net.Http.Headers; 

namespace Jack_Henry
{
    class Program
    { 
        static async Task Main()
        { 
            string BearerToken = "AAAAAAAAAAAAAAAAAAAAANsMiQEAAAAAyIQEwqXIdzNLrjjfvplr6hJqO8k%3Dow9QnT56yYrW5i20A3zeDEeueZ6qauCepCVDBiTMe5BkuA19mU"; 
            var url = "https://api.twitter.com/2/tweets/sample/stream/"; 

            HttpClient client = new HttpClient(); 
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {BearerToken}"); 
            using (HttpResponseMessage response = client.GetAsync(url).GetAwaiter().GetResult())
            {
                using (HttpContent content = response.Content)
                {
                    var json = content.ReadAsStringAsync().GetAwaiter().GetResult();
                    Console.WriteLine(json); 
                }
            } 
        }
    }
}
