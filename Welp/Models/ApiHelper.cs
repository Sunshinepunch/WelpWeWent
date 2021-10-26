using System.Threading.Tasks;
using RestSharp;

namespace Welp.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"animals", Method.GET);
    }
  }
}