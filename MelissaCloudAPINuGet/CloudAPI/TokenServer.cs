using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MelissaData.CloudAPI
{
  public class TokenServer : CloudAPIBase
  {
    private readonly Dictionary<string, string> parameterMappings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { nameof(IP), "IP" },
        { nameof(Package), "P" },
        { nameof(TimeSpan), "TS"}
    };

    protected override Dictionary<string, string> ParameterMappings => parameterMappings;

    // Private backing fields
    private string _ip;
    private string _package;
    private string _timespan;

    // Properties
    public string IP
    {
      get => _ip;
      set
      {
        _ip = value;
        parameters[parameterMappings[nameof(IP)]] = value;
      }
    }

    public string Package
    {
      get => _package;
      set
      {
        _package = value;
        parameters[parameterMappings[nameof(Package)]] = value;
      }
    }

    public string TimeSpan
    {
      get => _timespan;
      set
      {
        _timespan = value;
        parameters[parameterMappings[nameof(TimeSpan)]] = value;
      }
    }

    public TokenServer(string license = null) : base("https://tokenservice.melissadata.net", "/v3/JSON/Service.svc/RequestToken")
    {
      this.License = license ?? Environment.GetEnvironmentVariable("MD_LICENSE");
      this.parameters["format"] = "json";
    }

    // Setters
    public void SetIP(string ip)
    {
      this.parameters["IP"] = ip;
      this.IP = ip;
    }

    public void SetPackage(string package)
    {
      this.parameters["P"] = package;
      this.Package = package;
    }
    public void SetTimeSpan(string timespan)
    {
      this.parameters["TS"] = timespan;
      this.TimeSpan = timespan;
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
    public string GetIP()
    {
      return this.parameters.ContainsKey(parameterMappings[nameof(IP)]) ? this.parameters[parameterMappings[nameof(IP)]] : "";
    }

    public string GetPackage()
    {
      return this.parameters.ContainsKey(parameterMappings[nameof(Package)]) ? this.parameters[parameterMappings[nameof(Package)]] : "";
    }

    public string GetTimeSpan()
    {
      return this.parameters.ContainsKey(parameterMappings[nameof(TimeSpan)]) ? this.parameters[parameterMappings[nameof(TimeSpan)]] : "";
    }

    // Class Methods

    /// <summary>
    /// This synchronous function assembles the request URL and calls GetContents() to make the API request
    /// </summary>
    /// <param name="parameters"></param>
    /// <returns>the json response of the CloudAPI as a string</returns>
    protected override string ProcessRequest(Dictionary<string, string> parameters)
    {
      // Create a UriBuilder for constructing the URL
      var uriBuilder = new UriBuilder(this.BaseUrl)
      {
        Path = this.Endpoint
      };

      var query = System.Web.HttpUtility.ParseQueryString(string.Empty);
      query["L"] = this.License;

      // Add input parameters (including "L" for license)
      foreach (KeyValuePair<string, string> kvp in parameters)
      {
        query[kvp.Key] = kvp.Value;
      }

      // Build the string query
      uriBuilder.Query = query.ToString();

      // Make request
      string response = GetContents(uriBuilder.Uri.ToString());

      return response;
    }

    /// <summary>
    /// This asynchronous function assembles the request URL and calls GetContents() to make the API request
    /// </summary>
    /// <param name="parameters"></param>
    /// <returns>the json response if the CloudAPI as a string</returns>
    protected override async Task<string> ProcessRequestAsync(Dictionary<string, string> parameters)
    {
      // Create a UriBuilder for constructing the URL
      var uriBuilder = new UriBuilder(this.BaseUrl)
      {
        Path = this.Endpoint
      };

      var query = System.Web.HttpUtility.ParseQueryString(string.Empty);
      query["L"] = this.License;

      // Add input parameters (including "L" for license)
      foreach (KeyValuePair<string, string> kvp in parameters)
      {
        query[kvp.Key] = kvp.Value;
      }

      // Build the string query
      uriBuilder.Query = query.ToString();

      // Make request
      string response = await GetContentsAsync(uriBuilder.Uri.ToString());

      return response;
    }

    /// <summary>
    /// This synchronous function makes a getversion request and parses the response for the cloud api specific version
    /// </summary>
    /// <returns>returns the Cloud API version</returns>
    public string GetApiVersion()
    {
      string jsonResponse = SendVersionRequest();

      JObject responseObject = JObject.Parse(jsonResponse);

      string tokenServerVersion = (string)responseObject["tokenServerVersion"];

      return tokenServerVersion;
    }

    /// <summary>
    /// This asynchronous function makes a getversion request and parses the response for the Cloud API specific version
    /// </summary>
    /// <returns>returns the Cloud API version</returns>
    public async Task<string> GetApiVersionAsync()
    {
      string jsonResponse = await SendVersionRequestAsync();

      JObject responseObject = JObject.Parse(jsonResponse);

      string tokenServerVersion = (string)responseObject["tokenServerVersion"];

      return tokenServerVersion;
    }
  }
}
