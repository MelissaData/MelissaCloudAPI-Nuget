using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MelissaData.CloudAPI
{
  public class StreetRoute : CloudAPIBase
  {
    List<StreetRouteRecordRequest> Records { get; set; }
    public StreetRoutePostRequest PostBody { get; set; }

    private readonly Dictionary<string, string> parameterMappings = new(StringComparer.OrdinalIgnoreCase)
    {
        { nameof(Units), "units" },
        { nameof(StartLatitude), "StartLatitude" },
        { nameof(StartLongitude), "StartLongitude" },
        { nameof(EndLatitude), "EndLatitude" },
        { nameof(EndLongitude), "EndLongitude" },
        { nameof(TransmissionReference), "t" }
    };

    // Private backing fields
    private string _units;
    private string _startLatitude;
    private string _startLongitude;
    private string _endLatitude;
    private string _endLongitude;
    private string _transmissionReference;

    // Properties
    public string Units
    {
      get => _units;
      set
      {
        _units = value;
        parameters[parameterMappings[nameof(Units)]] = value;
      }
    }

    public string StartLatitude
    {
      get => _startLatitude;
      set
      {
        _startLatitude = value;
        parameters[parameterMappings[nameof(StartLatitude)]] = value;
      }
    }

    public string StartLongitude
    {
      get => _startLongitude;
      set
      {
        _startLongitude = value;
        parameters[parameterMappings[nameof(StartLongitude)]] = value;
      }
    }

    public string EndLatitude
    {
      get => _endLatitude;
      set
      {
        _endLatitude = value;
        parameters[parameterMappings[nameof(EndLatitude)]] = value;
      }
    }

    public string EndLongitude
    {
      get => _endLongitude;
      set
      {
        _endLongitude = value;
        parameters[parameterMappings[nameof(EndLongitude)]] = value;
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

    public StreetRoute(string license = null) : base("https://streetroute.melissadata.net", "/v1/WEB/StreetRoute/getDistance")
    {
      this.License = license ?? Environment.GetEnvironmentVariable("MD_LICENSE");
      this.parameters["format"] = "json";
      this.PostBody = new StreetRoutePostRequest();
      this.Records = new List<StreetRouteRecordRequest>();
    }

    // Setters
    public void SetUnits(string units)
    {
      this.parameters["units"] = units;
      this.Units = units;
    }

    public void SetStartLatitude(string startLatitude)
    {
      this.parameters["StartLatitude"] = startLatitude;
      this.StartLatitude = startLatitude;
    }

    public void SetStartLongitude(string startLongitude)
    {
      this.parameters["StartLongitude"] = startLongitude;
      this.StartLongitude = startLongitude;
    }

    public void SetEndLatitude(string endLatitude)
    {
      this.parameters["EndLatitude"] = endLatitude;
      this.EndLatitude = endLatitude;
    }

    public void SetEndLongitude(string endLongitude)
    {
      this.parameters["EndLongitude"] = endLongitude;
      this.EndLongitude = endLongitude;
    }

    public void SetTransmissionReference(string transmissionReference)
    {
      this.parameters["t"] = transmissionReference;
      this.TransmissionReference = transmissionReference;
    }

    public void SetPostBody(StreetRoutePostRequest postBody)
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
    public string GetUnits()
    {
      return this.parameters.ContainsKey("units") ? this.parameters["units"] : "";
    }

    public string GetStartLatitude()
    {
      return this.parameters.ContainsKey("StartLatitude") ? this.parameters["StartLatitude"] : "";
    }

    public string GetStartLongitude()
    {
      return this.parameters.ContainsKey("StartLongitude") ? this.parameters["StartLongitude"] : "";
    }

    public string GetEndLatitude()
    {
      return this.parameters.ContainsKey("EndLatitude") ? this.parameters["EndLatitude"] : "";
    }

    public string GetEndLongitude()
    {
      return this.parameters.ContainsKey("EndLongitude") ? this.parameters["EndLongitude"] : "";
    }

    public string GetTransmissionReference()
    {
      return this.parameters.ContainsKey("t") ? this.parameters["t"] : "";
    }

    public StreetRoutePostRequest GetPostBody()
    {
      return this.PostBody;
    }

    // Class Methods
    public void AddRecord(StreetRouteRecordRequest record)
    {
      this.Records.Add(record);
    }

    public void ClearRecords()
    {
      this.Records.Clear();
    }

    /// <summary>
    /// This synchronous function makes the batch request to the Cloud API
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized json response object</returns>
    public T Post<T>()
    {
      string response;

      if (Records != null && Records.Count > 0)
      {
        var postRequest = new StreetRoutePostRequest
        {
          CustomerID = this.GetLicense(),
          TransmissionReference = this.GetTransmissionReference(),
          Records = this.Records
        };

        response = base.SendPostRequest(postRequest);
      }
      else
      {
        response = base.SendPostRequest(this.PostBody);
      }

      return HandleResponse<T>(response);
    }

    /// <summary>
    /// This asynchronous function makes the batch request to the Cloud API
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserializes json response object</returns>
    public async Task<T> PostAsync<T>()
    {
      string response;

      if (Records != null && Records.Count > 0)
      {
        var postRequest = new StreetRoutePostRequest
        {
          CustomerID = this.GetLicense(),
          TransmissionReference = this.GetTransmissionReference(),
          Records = this.Records
        };

        response = await base.SendPostRequestAsync(postRequest);
      }
      else
      {
        response = await base.SendPostRequestAsync(this.PostBody);
      }

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

      string businessCoderVersion = (string)responseObject["Version"];

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

      string businessCoderVersion = (string)responseObject["Version"];

      return businessCoderVersion;
    }
  }
}
