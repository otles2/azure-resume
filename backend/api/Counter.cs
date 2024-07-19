using Newtonsoft.Json;
namespace Company.Function
{
    public class Counter
    {
        [JsonProperty(PropertyName ="id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName ="count")]
        public int Count { get; set; }
    }
}   
 
 The Counter class is a simple class that has a single property, Value, which is an integer. This class is used to store the value of the counter. 
 The Counter class is used in the following code snippet: