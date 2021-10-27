using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Welp.Models
{
  public class Destination
  {

    public int DestinationId {get;set;}
    
    [Required]
    public string Name {get;set;}

    public virtual ICollection<Review> Reviews { get; set; }

    public static List<Destination> GetDestinations()
    {
      var apiCallTask = ApiHelper.GetAllDestinations();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Destination> reviewList = JsonConvert.DeserializeObject<List<Destination>>(jsonResponse.ToString());

      return reviewList;
    }
    public static Destination GetDestination(int id)
    {
      var apiCallTask = ApiHelper.GetDestination(id);
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      Destination destination = JsonConvert.DeserializeObject<Destination>(jsonResponse.ToString());

      return destination;
    }
    public static void Post(Destination destination)
    {
      string jsonReview = JsonConvert.SerializeObject(destination);
      var apiCallTask = ApiHelper.PostDestination(jsonReview);
    }
    public static void Put(Destination destination)
    {
      string jsonReview = JsonConvert.SerializeObject(destination);
      var apiCallTask = ApiHelper.PutDestination(destination.DestinationId, jsonReview);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.DeleteDestination(id);
    }

  }
}