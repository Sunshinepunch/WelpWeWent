using System.Threading.Tasks;
using RestSharp;

namespace Welp.Models
{
  class ApiHelper
  {
        public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"reviews", Method.GET);
      var response = await client.ExecuteAsync(request);
      return response.Content;
    }
    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"reviews/{id}", Method.GET);
      var response = await client.ExecuteAsync(request);
      return response.Content;
    }

    public static async Task Post(string newReview)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"reviews", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newReview);
      var response = await client.ExecuteAsync(request);
    }

    public static async Task Put(int id, string newReview)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"reviews/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newReview);
      var response = await client.ExecuteAsync(request);
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"reviews/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteAsync(request);
    }

    public static async Task<string> GetAllDestinations()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"destinations", Method.GET);
      var response = await client.ExecuteAsync(request);
      return response.Content;
    }

    public static async Task<string> GetDestination(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"destinations/{id}", Method.GET);
      var response = await client.ExecuteAsync(request);
      return response.Content;
    }
    public static async Task PostDestination(string newDestination)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"destinations", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newDestination);
      var response = await client.ExecuteAsync(request);
    }
    public static async Task PutDestination(int id, string newDestination)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"destinations/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newDestination);
      var response = await client.ExecuteAsync(request);
    }
    public static async Task DeleteDestination(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"destinations/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteAsync(request);
    }
  }
}