using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MelissaData.CloudAPI
{
  public class ReverseGeoCoder : CloudAPIBase
  {
    ReverseGeoCoderRecordRequest PostBody { get; set; }

    private readonly Dictionary<string, string> parameterMappings = new(StringComparer.OrdinalIgnoreCase)
    {
        { nameof(Latitude), "lat" },
        { nameof(Longitude), "long" },
        { nameof(MaxRecords), "recs" },
        { nameof(MaxDistance), "dist" },
        { nameof(TransmissionReference), "t" },
        { nameof(Opt), "opt" }
    };

    // Private backing fields
    private string _latitude;
    private string _longitude;
    private string _maxRecords;
    private string _maxDistance;
    private string _transmissionReference;
    private string _opt;

    // Properties
    public string Latitude
    {
      get => _latitude;
      set
      {
        _latitude = value;
        parameters[parameterMappings[nameof(Latitude)]] = value;
      }
    }

    public string Longitude
    {
      get => _longitude;
      set
      {
        _longitude = value;
        parameters[parameterMappings[nameof(Longitude)]] = value;
      }
    }

    public string MaxRecords
    {
      get => _maxRecords;
      set
      {
        _maxRecords = value;
        parameters[parameterMappings[nameof(MaxRecords)]] = value;
      }
    }

    public string MaxDistance
    {
      get => _maxDistance;
      set
      {
        _maxDistance = value;
        parameters[parameterMappings[nameof(MaxDistance)]] = value;
      }
    }

    public string TransmissionReference
    {
      get => _transmissionReference;
      set
      {
        _transmissionReference = value;
        parameters[parameterMappings[nameof(TransmissionReference)]] = value;
      }
    }

    public string Opt
    {
      get => _opt;
      set
      {
        _opt = value;
        parameters[parameterMappings[nameof(Opt)]] = value;
      }
    }

    public ReverseGeoCoder(string license = null) : base("https://reversegeo.melissadata.net", "/v3/web/ReverseGeoCode/doLookup")
    {
      this.License = license ?? Environment.GetEnvironmentVariable("MD_LICENSE");
      this.parameters["format"] = "json";
      this.PostBody = new ReverseGeoCoderRecordRequest();
    }

    // Setters
    public void SetLatitude(string latitude)
    {
      this.parameters["lat"] = latitude;
      this.Latitude = latitude;
    }

    public void SetLongitude(string longitude)
    {
      this.parameters["long"] = longitude;
      this.Longitude = longitude;
    }

    public void SetMaxRecords(string records)
    {
      this.parameters["recs"] = records;
      this.MaxRecords = records;
    }

    public void SetMaxDistance(string distance)
    {
      this.parameters["dist"] = distance;
      this.MaxDistance = distance;
    }

    public void SetTransmissionReference(string transmissionReference)
    {
      this.parameters["t"] = transmissionReference;
      this.TransmissionReference = transmissionReference;
    }

    public void SetOpt(string opt)
    {
      this.parameters["opt"] = opt;
      this.Opt = opt;
    }

    public void SetPostBody(ReverseGeoCoderRecordRequest postBody)
    {
      this.PostBody = postBody;
    }

    public override void SetValue(string parameter, string value)
    {
      parameter = parameter?.Trim();

      if (parameterMappings.TryGetValue(parameter, out string parameterKey))
      {
        string propertyName = parameterMappings.FirstOrDefault(x => x.Value.Equals(parameterKey, StringComparison.OrdinalIgnoreCase)).Key;

        var propertyInfo = this.GetType().GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
        if (propertyInfo != null && propertyInfo.CanWrite)
        {
          propertyInfo.SetValue(this, value);
        }
      }
      else
      {
        // If not in derived class, go to base class implementation
        base.SetValue(parameter, value);
      }
    }

    // Getters
    public string GetLatitude()
    {
      return this.parameters.ContainsKey("lat") ? this.parameters["lat"] : "";
    }

    public string GetLongitude()
    {
      return this.parameters.ContainsKey("long") ? this.parameters["long"] : "";
    }

    public string GetMaxRecords()
    {
      return this.parameters.ContainsKey("recs") ? this.parameters["recs"] : "";
    }

    public string GetMaxDistance()
    {
      return this.parameters.ContainsKey("dist") ? this.parameters["dist"] : "";
    }

    public string GetTransmissionReference()
    {
      return this.parameters.ContainsKey("t") ? this.parameters["t"] : "";
    }

    public string GetOpt()
    {
      return this.parameters.ContainsKey("opt") ? this.parameters["opt"] : "";
    }

    public ReverseGeoCoderRecordRequest GetPostBody()
    {
      return this.PostBody;
    }

    /// <summary>
    /// This synchronous function sends the CloudAPI request using the /v3/web/ReverseGeoCode/doLookup endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public T GetDoLookup<T>()
    {
      this.SetEndpoint("/v3/web/ReverseGeoCode/doLookup");

      return Get<T>();
    }

    /// <summary>
    /// This asynchronous function sends the CloudAPI request using the /v3/web/ReverseGeoCode/doLookup endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public async Task<T> GetDoLookupAsync<T>()
    {
      this.SetEndpoint("/v3/web/ReverseGeoCode/doLookup");

      return await GetAsync<T>();
    }

    /// <summary>
    /// This synchronous function sends a post request to the Cloud API using the /v3/web/ReverseGeoCode/doLookup endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public T PostDoLookup<T>()
    {
      this.SetEndpoint("/v3/web/ReverseGeoCode/doLookup");

      string response = SendPostRequest(this.PostBody);

      return HandleResponse<T>(response);
    }

    /// <summary>
    /// This asynchronous function sends a post request to the Cloud API using the /v3/web/ReverseGeoCode/doLookup endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public async Task<T> PostDoLookupAsync<T>()
    {
      this.SetEndpoint("/v3/web/ReverseGeoCode/doLookup");

      string response = await SendPostRequestAsync(this.PostBody);

      return HandleResponse<T>(response);
    }

    /// <summary>
    /// This synchronous function sends the CloudAPI request using the /V3/WEB/ReverseGeoCode/doLookupPostalCodes endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public T GetDoLookupPostalCodes<T>()
    {
      this.SetEndpoint("/V3/WEB/ReverseGeoCode/doLookupPostalCodes");

      return Get<T>();
    }

    /// <summary>
    /// This asynchronous function sends the CloudAPI request using the /V3/WEB/ReverseGeoCode/doLookupPostalCodes endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public async Task<T> GetDoLookupPostalCodesAsync<T>()
    {
      this.SetEndpoint("/V3/WEB/ReverseGeoCode/doLookupPostalCodes");

      return await GetAsync<T>();
    }

    /// <summary>
    /// This synchronous function sends a post request to the Cloud API using the /V3/WEB/ReverseGeoCode/doLookupPostalCodes endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public T PostDoLookupPostalCodes<T>()
    {
      this.SetEndpoint("/V3/WEB/ReverseGeoCode/doLookupPostalCodes");

      string response = SendPostRequest(this.PostBody);

      return HandleResponse<T>(response);
    }

    /// <summary>
    /// This asynchronous function sends a post request to the Cloud API using the /V3/WEB/ReverseGeoCode/doLookupPostalCodes endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public async Task<T> PostDoLookupPostalCodesAsync<T>()
    {
      this.SetEndpoint("/V3/WEB/ReverseGeoCode/doLookupPostalCodes");

      string response = await SendPostRequestAsync(this.PostBody);

      return HandleResponse<T>(response);
    }  

    /// <summary>
    /// This synchronous function makes a getversion request and parses the response for the cloud api specific version
    /// </summary>
    /// <returns>returns the Cloud API version</returns>
    public string GetApiVersion()
    {
      string jsonResponse = SendVersionRequest();

      JObject responseObject = JObject.Parse(jsonResponse);

      string businessCoderVersion = (string)responseObject["reverseGeoCodeVersion"];

      return businessCoderVersion;
    }

    /// <summary>
    /// This asynchronous function makes a getversion request and parses the response for the Cloud API specific version
    /// </summary>
    /// <returns>returns the Cloud API version</returns>
    public async Task<string> GetApiVersionAsync()
    {
      string jsonResponse = await SendVersionRequestAsync();

      JObject responseObject = JObject.Parse(jsonResponse);

      string businessCoderVersion = (string)responseObject["reverseGeoCodeVersion"];

      return businessCoderVersion;
    }
  }
}
