using System.Text.Json.Serialization;

namespace ASP.NET_Learn.models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3 
    }
}