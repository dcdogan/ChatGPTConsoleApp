using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace ChatGptConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Replace YOUR_API_KEY with your actual API key
            string apiKey = "<YOUR_API_KEY>";

            // Set the model and prompt for the request
            string model = "text-davinci-003";
            string prompt = "write me a poem about how much people love chatgpt";

            // Send the request to the OpenAI API
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
            HttpResponseMessage response = client.PostAsync($"https://api.openai.com/v1/completions",
                new StringContent($"{{\"model\": \"{model}\", \"prompt\": \"{prompt}\", \"max_tokens\": 512}}",
                System.Text.Encoding.UTF8, "application/json")).Result;

            // Read the response and extract the answer
            string json = response.Content.ReadAsStringAsync().Result;
            JObject result = JObject.Parse(json);
            string answer = result["choices"][0]["text"].ToString();

            // Print the answer
            Console.WriteLine(answer);
        }
    }
}

