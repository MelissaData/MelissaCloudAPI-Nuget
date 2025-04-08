using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MelissaData.CloudAPI
{
  public class GlobalName : CloudAPIBase
  {
    public List<GlobalNameRecordRequest> Records { get; set; }
    public GlobalNamePostRequest PostBody { get; set; }

    private readonly Dictionary<string, string> parameterMappings = new(StringComparer.OrdinalIgnoreCase)
    {
        { nameof(Company), "comp" },
        { nameof(FullName), "full" },
        { nameof(Country), "ctry" },
        { nameof(TransmissionReference), "t" },
        { nameof(Opt), "opt" }
    };

    // Private backing fields
    private string _company;
    private string _fullName;
    private string _country;
    private string _transmissionReference;
    private string _opt;

    // Properties
    public string Company
    {
      get => _company;
      set
      {
        _company = value;
        parameters[parameterMappings[nameof(Company)]] = value;
      }
    }

    public string FullName
    {
      get => _fullName;
      set
      {
        _fullName = value;
        parameters[parameterMappings[nameof(FullName)]] = value;
      }
    }

    public string Country
    {
      get => _country;
      set
      {
        _country = value;
        parameters[parameterMappings[nameof(Country)]] = value;
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

    public GlobalName(string license = null) : base("https://globalname.melissadata.net", "/V3/WEB/GlobalName/doGlobalName")
    {
      this.License = license ?? Environment.GetEnvironmentVariable("MD_LICENSE");
      this.parameters["format"] = "json";
      this.PostBody = new GlobalNamePostRequest();
      this.Records = new List<GlobalNameRecordRequest>();
    }

    // Setters
    public void SetCompany(string company)
    {
      this.parameters["comp"] = company;
      this.Company = company;
      
    }

    public void SetFullName(string fullName)
    {
      this.parameters["full"] = fullName;
      this.FullName = fullName;
    }

    public void SetCountry(string country) 
    {
      this.parameters["ctry"] = country;
      this.Country = country;
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

    public void SetPostBody(GlobalNamePostRequest postBody)
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
    public string GetCompany() 
    {
      return this.parameters.ContainsKey("comp") ? this.parameters["comp"] : "";
    }

    public string GetFullName() 
    {
      return this.parameters.ContainsKey("full") ? this.parameters["full"] : "";
    }
    
    public string GetCountry() 
    {
      return this.parameters.ContainsKey("ctry") ? this.parameters["ctry"] : "";
    }
    
    public string GetTransmissionReference() 
    {
      return this.parameters.ContainsKey("t") ? this.parameters["t"] : "";
    }
    
    public string GetOpt() 
    {
      return this.parameters.ContainsKey("opt") ? this.parameters["opt"] : "";
    }

    public GlobalNamePostRequest GetPostBody()
    {
      return this.PostBody;
    }

    // Class Methods
    public void AddRecord(GlobalNameRecordRequest record)
    {
      this.Records.Add(record);
    }

    public void ClearRecords()
    {
      this.Records.Clear();
    }

    /// <summary>
    /// This synchronous function makes the batch request using the post body
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized json response object</returns>
    public T Post<T>()
    {
      string response;

      if (Records != null && Records.Count > 0)
      {
        var postRequest = new GlobalNamePostRequest
        {
          CustomerID = this.GetLicense(),
          TransmissionReference = this.GetTransmissionReference(),
          Options = this.GetOpt(),
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
    /// This asynchronous function makes the batch request using the post body
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserializes json response object</returns>
    public async Task<T> PostAsync<T>()
    {
      string response;

      if (Records != null && Records.Count > 0)
      {
        var postRequest = new GlobalNamePostRequest
        {
          CustomerID = this.GetLicense(),
          TransmissionReference = this.GetTransmissionReference(),
          Options = this.GetOpt(),
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
