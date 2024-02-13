using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CryptoScanner.DAL.Models;

// CoinRoot myDeserializedClass = JsonConvert.DeserializeObject<CoinRoot>(myJsonResponse);
public class CoinRoot
{
    [Newtonsoft.Json.JsonIgnore] // this property will be ignored during serialization and deserialization 
    [System.Text.Json.Serialization.JsonIgnore] // this property will be ignored during serialization and deserialization
    [Key]
    public int Id { get; set; }

    [JsonProperty("id")]
    public string IdInAPI { get; set; }

    [JsonProperty("symbol")]
    public string Symbol { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("web_slug")]
    public string WebSlug { get; set; }

    [JsonProperty("hashing_algorithm")]
    public string HashingAlgorithm { get; set; }

    [JsonProperty("country_origin")]
    public string CountryOrigin { get; set; }

    [JsonProperty("market_cap_rank")]
    public int? MarketCapRank { get; set; }

    [JsonProperty("last_updated")]
    public DateTime? LastUpdated { get; set; }
}




