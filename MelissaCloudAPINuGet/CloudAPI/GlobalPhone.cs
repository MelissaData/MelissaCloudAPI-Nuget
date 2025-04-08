using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MelissaData.CloudAPI
{
  public class GlobalPhone : CloudAPIBase
  {
    List<GlobalPhoneRecordRequest> Records { get; set; }
    GlobalPhonePostRequest PostBody { get; set; }

    private readonly Dictionary<string, string> parameterMappings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { nameof(Phone), "phone" },
        { nameof(Country), "ctry" },
        { nameof(CountryOrigin), "ctryOrg" },
        { nameof(TransmissionReference), "t" },
        { nameof(Opt), "opt" }
    };

    // Private backing fields
    private string _phone;
    private string _country;
    private string _countryOrigin;
    private string _transmissionReference;
    private string _opt;

    // Properties
    public string Phone
    {
      get => _phone;
      set
      {
        _phone = value;
        parameters[parameterMappings[nameof(Phone)]] = value;
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

    public string CountryOrigin
    {
      get => _countryOrigin;
      set
      {
        _countryOrigin = value;
        parameters[parameterMappings[nameof(CountryOrigin)]] = value;
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

    public GlobalPhone(string license = null) : base("https://globalphone.melissadata.net", "/v4/WEB/GlobalPhone/doGlobalPhone")
    {
      this.License = license ?? Environment.GetEnvironmentVariable("MD_LICENSE");
      this.parameters["format"] = "json";
      this.PostBody = new GlobalPhonePostRequest();
      this.Records = new List<GlobalPhoneRecordRequest>();
    }

    // Setters
    public void SetPhone(string phone)
    {
      this.parameters["phone"] = phone;
      this.Phone = phone;
    }

    public void SetCountry(string country) 
    {
      this.parameters["ctry"] = country;
      this.Country = country;
    }

    public void SetCountryOrigin(string countryOrigin)
    {
      this.parameters["ctryOrg"] = countryOrigin;
      this.CountryOrigin = countryOrigin;
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

    public void SetPostBody(GlobalPhonePostRequest postBody)
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
    public string GetPhone() 
    {
      return this.parameters.ContainsKey("phone") ? this.parameters["phone"] : "";
    }
    
    public string GetCountry() 
    {
      return this.parameters.ContainsKey("ctry") ? this.parameters["ctry"] : "";
    }  
    
    public string GetCountryOrigin() 
    {
      return this.parameters.ContainsKey("ctryOrg") ? this.parameters["ctryOrg"] : "";
    }
    
    public string GetTransmissionReference() 
    {
      return this.parameters.ContainsKey("t") ? this.parameters["t"] : "";
    }
    
    public string GetOpt() 
    {
      return this.parameters.ContainsKey("opt") ? this.parameters["opt"] : "";
    }

    public GlobalPhonePostRequest GetPostBody()
    {
      return this.PostBody;
    }

    // Class Methods
    public void AddRecord(GlobalPhoneRecordRequest record)
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
        var postRequest = new GlobalPhonePostRequest
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
    /// This asynchronous function makes the batch request to the Cloud API
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserializes json response object</returns>
    public async Task<T> PostAsync<T>()
    {
      string response;

      if (Records != null && Records.Count > 0)
      {
        var postRequest = new GlobalPhonePostRequest
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
