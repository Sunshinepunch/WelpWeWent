using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Welp.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string Comment { get; set; }
    public int Rating { get; set; }



    public static List<Review> GetReviews()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Review> reviewList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse.ToString());

      return reviewList;
    }

    public static Review GetDetails(int id)
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      Review review = JsonConvert.DeserializeObject<Review>(jsonResponse.ToString());

      return review;
    }
  }
}
