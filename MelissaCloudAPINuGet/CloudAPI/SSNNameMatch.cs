using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MelissaData.CloudAPI
{
  public class SSNNameMatch : CloudAPIBase
  {
    List<SSNNameMatchRecordRequest> Records { get; set; }
    public SSNNameMatchPostRequest PostBody { get; set; }

    private readonly Dictionary<string, string> parameterMappings = new(StringComparer.OrdinalIgnoreCase)
    {
        { nameof(SSN), "ssn" },
        { nameof(FirstName), "first" },
        { nameof(LastName), "last" },
        { nameof(FullName), "full" },
        { nameof(TransmissionReference), "t" }
    };

    // Private backing fields
    private string _ssn;
    private string _firstName;
    private string _lastName;
    private string _fullName;
    private string _transmissionReference;

    // Properties
    public string SSN
    {
      get => _ssn;
      set
      {
        _ssn = value;
        parameters[parameterMappings[nameof(SSN)]] = value;
      }
    }

    public string FirstName
    {
      get => _firstName;
      set
      {
        _firstName = value;
        parameters[parameterMappings[nameof(FirstName)]] = value;
      }
    }

    public string LastName
    {
      get => _lastName;
      set
      {
        _lastName = value;
        parameters[parameterMappings[nameof(LastName)]] = value;
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

    public string TransmissionReference
    {
      get => _transmissionReference;
      set
      {
        _transmissionReference = value;
        parameters[parameterMappings[nameof(TransmissionReference)]] = value;
      }
    }

    public SSNNameMatch(string license = null) : base("https://namessn.melissadata.net", "/v4/web/SSN/doLookup")
    {
      this.License = license ?? Environment.GetEnvironmentVariable("MD_LICENSE");
      this.parameters["format"] = "json";
      this.PostBody = new SSNNameMatchPostRequest();
      this.Records = new List<SSNNameMatchRecordRequest>();
    }

    // Setters
    public void SetSSN(string ssn)
    {
      this.parameters["ssn"] = ssn;
      this.SSN = ssn;
    }

    public void SetFirstName(string firstName)
    {
      this.parameters["first"] = firstName;
      this.FirstName = firstName;
    }

    public void SetLastName(string lastName) 
    {
      this.parameters["last"] = lastName;
      this.LastName = lastName;
    }

    public void SetFullName(string fullName) 
    {
      this.parameters["full"] = fullName;
      this.FullName = fullName;
    }

    public void SetTransmissionReference(string transmissionReference)
    {
      this.parameters["t"] = transmissionReference;
      this.TransmissionReference = transmissionReference;
    }

    public void SetPostBody(SSNNameMatchPostRequest postBody)
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
    public string GetSSN()
    {
      return this.parameters.ContainsKey("ssn") ? this.parameters["ssn"] : "";
    }

    public string GetFirstName()
    {
      return this.parameters.ContainsKey("first") ? this.parameters["first"] : "";
    }

    public string GetLastName()
    {
      return this.parameters.ContainsKey("last") ? this.parameters["last"] : "";
    }

    public string GetFullName()
    {
      return this.parameters.ContainsKey("full") ? this.parameters["full"] : "";
    }

    public string GetTransmissionReference()
    {
      return this.parameters.ContainsKey("t") ? this.parameters["t"] : "";
    }

    public SSNNameMatchPostRequest GetPostBody()
    {
      return this.PostBody;
    }

    // Class Methods
    public void AddRecord(SSNNameMatchRecordRequest record)
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
        var postRequest = new SSNNameMatchPostRequest
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
    /// <returns>a string or deserialized json response object</returns>
    public async Task<T> PostAsync<T>()
    {
      string response;

      if (Records != null && Records.Count > 0)
      {
        var postRequest = new SSNNameMatchPostRequest
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

      string businessCoderVersion = (string)responseObject["ssnWebServiceVersion"];

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

      string businessCoderVersion = (string)responseObject["ssnWebServiceVersion"];

      return businessCoderVersion;
    }
  }
}
