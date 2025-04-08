using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MelissaData.CloudAPI
{
  public class Property : CloudAPIBase
  {
    public List<PropertyRecordRequest> Records { get; set; }
    public PropertyPostRequest PostBody { get; set; }

    private readonly Dictionary<string, string> parameterMappings = new(StringComparer.OrdinalIgnoreCase)
    {
        { nameof(AddressKey), "addresskey" },
        { nameof(AddressLine1), "a1" },
        { nameof(AddressLine2), "a2" },
        { nameof(APN), "apn" },
        { nameof(City), "city" },
        { nameof(Country), "ctry" },
        { nameof(FIPS), "fips" },
        { nameof(FreeForm), "ff" },
        { nameof(MAK), "mak" },
        { nameof(State), "state" },
        { nameof(Postal), "postal" },
        { nameof(TransmissionReference), "t" },
        { nameof(Cols), "cols" },
        { nameof(Opt), "opt" },
        { nameof(OwnerMAK), "mak" },
        { nameof(TotalRecords), "totalRecords" }
    };

    // Private backing fields
    private string _addressKey;
    private string _addressLine1;
    private string _addressLine2;
    private string _apn;
    private string _city;
    private string _country;
    private string _fips;
    private string _freeForm;
    private string _mak;
    private string _state;
    private string _postal;
    private string _transmissionReference;
    private string _cols;
    private string _opt;
    private string _ownerMAK;
    private string _totalRecords;

    // Properties
    public string AddressKey
    {
      get => _addressKey;
      set
      {
        _addressKey = value;
        parameters[parameterMappings[nameof(AddressKey)]] = value;
      }
    }

    public string AddressLine1
    {
      get => _addressLine1;
      set
      {
        _addressLine1 = value;
        parameters[parameterMappings[nameof(AddressLine1)]] = value;
      }
    }

    public string AddressLine2
    {
      get => _addressLine2;
      set
      {
        _addressLine2 = value;
        parameters[parameterMappings[nameof(AddressLine2)]] = value;
      }
    }

    public string APN
    {
      get => _apn;
      set
      {
        _apn = value;
        parameters[parameterMappings[nameof(APN)]] = value;
      }
    }

    public string City
    {
      get => _city;
      set
      {
        _city = value;
        parameters[parameterMappings[nameof(City)]] = value;
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

    public string FIPS
    {
      get => _fips;
      set
      {
        _fips = value;
        parameters[parameterMappings[nameof(FIPS)]] = value;
      }
    }

    public string FreeForm
    {
      get => _freeForm;
      set
      {
        _freeForm = value;
        parameters[parameterMappings[nameof(FreeForm)]] = value;
      }
    }

    public string MAK
    {
      get => _mak;
      set
      {
        _mak = value;
        parameters[parameterMappings[nameof(MAK)]] = value;
      }
    }

    public string State
    {
      get => _state;
      set
      {
        _state = value;
        parameters[parameterMappings[nameof(State)]] = value;
      }
    }

    public string Postal
    {
      get => _postal;
      set
      {
        _postal = value;
        parameters[parameterMappings[nameof(Postal)]] = value;
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

    public string Cols
    {
      get => _cols;
      set
      {
        _cols = value;
        parameters[parameterMappings[nameof(Cols)]] = value;
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

    public string OwnerMAK
    {
      get => _ownerMAK;
      set
      {
        _ownerMAK = value;
        parameters[parameterMappings[nameof(OwnerMAK)]] = value;
      }
    }

    public string TotalRecords
    {
      get => _totalRecords;
      set
      {
        _totalRecords = value;
        parameters[parameterMappings[nameof(TotalRecords)]] = value;
      }
    }

    public Property(string license = null) : base("https://property.melissadata.net", "/v4/WEB/LookupProperty")
    {
      this.License = license ?? Environment.GetEnvironmentVariable("MD_LICENSE");
      this.parameters["format"] = "json";
      this.PostBody = new PropertyPostRequest();
      this.Records = new List<PropertyRecordRequest>();
    }

    // Setters
    public void SetAddressKey(string addressKey)
    {
      this.parameters["addresskey"] = addressKey;
      this.AddressKey = addressKey;
    }

    public void SetAddressLine1(string addressLine1)
    {
      this.parameters["a1"] = addressLine1;
      this.AddressLine1 = addressLine1;
    }

    public void SetAddressLine2(string addressLine2)
    {
      this.parameters["a2"] = addressLine2;
      this.AddressLine2 = addressLine2;
    }

    public void SetAPN(string apn)
    {
      this.parameters["apn"] = apn;
      this.APN = apn;
    }

    public void SetCity(string city)
    {
      this.parameters["city"] = city;
      this.City = city;
    }

    public void SetCountry(string country)
    {
      this.parameters["ctry"] = country;
      this.Country = country;
    }

    public void SetFIPS(string fips)
    {
      this.parameters["fips"] = fips;
      this.FIPS = fips;
    }

    public void SetFreeForm(string freeForm)
    {
      this.parameters["ff"] = freeForm;
      this.FreeForm = freeForm;
    }

    public void SetMAK(string mak) 
    {
      this.parameters["mak"] = mak;
      this.MAK = mak;
    }

    public void SetState(string state)
    {
      this.parameters["state"] = state;
      this.State = state;
    }

    public void SetPostal(string postal)
    {
      this.parameters["postal"] = postal;
      this.Postal = postal;
    }

    public void SetTransmissionReference(string transmissionReference)
    {
      this.parameters["t"] = transmissionReference;
      this.TransmissionReference = transmissionReference;
    }

    public void SetCols(string cols)
    {
      this.parameters["cols"] = cols;
      this.Cols = cols;
    }

    public void SetOpt(string opt)
    {
      this.parameters["opt"] = opt;
      this.Opt = opt;
    }

    public void SetOwnerMAK(string mak)
    {
      this.parameters["mak"] = mak;
      this.OwnerMAK = mak;
    }

    public void SetTotalRecords(string totalRecords)
    {
      this.parameters["totalRecords"] = totalRecords;
      this.TotalRecords = totalRecords;
    }

    public void SetPostBody(PropertyPostRequest postBody)
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
    public string GetAddressKey()
    {
      return this.parameters.ContainsKey("addresskey") ? this.parameters["addresskey"] : "";
    }

    public string GetAddressLine1()
    {
      return this.parameters.ContainsKey("a1") ? this.parameters["a1"] : "";
    }

    public string GetAddressLine2()
    {
      return this.parameters.ContainsKey("a2") ? this.parameters["a2"] : "";
    }

    public string GetAPN()
    {
      return this.parameters.ContainsKey("apn") ? this.parameters["apn"] : "";
    }

    public string GetCity()
    {
      return this.parameters.ContainsKey("city") ? this.parameters["city"] : "";
    }

    public string GetCountry()
    {
      return this.parameters.ContainsKey("ctry") ? this.parameters["ctry"] : "";
    }

    public string GetFIPS()
    {
      return this.parameters.ContainsKey("fips") ? this.parameters["fips"] : "";
    }

    public string GetFreeForm()
    {
      return this.parameters.ContainsKey("ff") ? this.parameters["ff"] : "";
    }

    public string GetMAK()
    {
      return this.parameters.ContainsKey("mak") ? this.parameters["mak"] : "";
    }

    public string GetState()
    {
      return this.parameters.ContainsKey("state") ? this.parameters["state"] : "";
    }

    public string GetPostal()
    {
      return this.parameters.ContainsKey("postal") ? this.parameters["postal"] : "";
    }

    public string GetTransmissionReference()
    {
      return this.parameters.ContainsKey("t") ? this.parameters["t"] : "";
    }

    public string GetCols()
    {
      return this.parameters.ContainsKey("cols") ? this.parameters["cols"] : "";
    }

    public string GetOpt()
    {
      return this.parameters.ContainsKey("opt") ? this.parameters["opt"] : "";
    }

    public string GetOwnerMAK()
    {
      return this.parameters.ContainsKey("mak") ? this.parameters["mak"] : "";
    }

    public string GetTotalRecords()
    {
      return this.parameters.ContainsKey("totalRecords") ? this.parameters["totalRecords"] : "";
    }

    public PropertyPostRequest GetPostBatchBody()
    {
      return this.PostBody;
    }

    // Class Methods
    public void AddRecord(PropertyRecordRequest record)
    {
      this.Records.Add(record);
    }

    public void ClearRecords()
    {
      this.Records.Clear();
    }

    /// <summary>
    /// This synchronous function sends the CloudAPI request using the /v4/WEB/LookupProperty endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public T GetLookupProperty<T>()
    {
      this.SetEndpoint("/v4/WEB/LookupProperty");

      return Get<T>();
    }

    /// <summary>
    /// This asynchronous function sends the CloudAPI request using the /v4/WEB/LookupProperty endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public async Task<T> GetLookupPropertyAsync<T>()
    {
      this.SetEndpoint("/v4/WEB/LookupProperty");

      return await GetAsync<T>();
    }

    /// <summary>
    /// This synchronous function sends a post request to the Cloud API using the /v4/WEB/LookupProperty endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public T PostLookupProperty<T>()
    {
      this.SetEndpoint("/v4/WEB/LookupProperty");

      string response;

      if (Records != null && Records.Count > 0)
      {
        var postRequest = new PropertyPostRequest
        {
          Columns = this.GetCols(),
          CustomerId = this.GetLicense(),
          TransmissionReference = this.GetTransmissionReference(),
          Options = this.GetOpt(),
          TotalRecords = this.GetTotalRecords(),
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
    /// This asynchronous function sends a post request to the Cloud API using the /v4/WEB/LookupProperty endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public async Task<T> PostLookupPropertyAsync<T>()
    {
      this.SetEndpoint("/v4/WEB/LookupProperty");

      string response;

      if (Records != null && Records.Count > 0)
      {
        var postRequest = new PropertyPostRequest
        {
          Columns = this.GetCols(),
          CustomerId = this.GetLicense(),
          TransmissionReference = this.GetTransmissionReference(),
          Options = this.GetOpt(),
          TotalRecords = this.GetTotalRecords(),
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
    /// This synchronous function sends the CloudAPI request using the /v4/WEB/LookupDeeds endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public T GetLookupDeeds<T>()
    {
      this.SetEndpoint("/v4/WEB/LookupDeeds");

      return Get<T>();
    }

    /// <summary>
    /// This asynchronous function sends the CloudAPI request using the /v4/WEB/LookupDeeds endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public async Task<T> GetLookupDeedsAsync<T>()
    {
      this.SetEndpoint("/v4/WEB/LookupDeeds");

      return await GetAsync<T>();
    }

    /// <summary>
    /// This synchronous function sends a post request to the Cloud API using the /v4/WEB/LookupDeeds endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public T PostLookupDeeds<T>()
    {
      this.SetEndpoint("/v4/WEB/LookupDeeds");

      string response = base.SendPostRequest(this.PostBody);

      return HandleResponse<T>(response);
    }

    /// <summary>
    /// This asynchronous function sends a post request to the Cloud API using the /v4/WEB/LookupDeeds endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public async Task<T> PostLookupDeedsAsync<T>()
    {
      this.SetEndpoint("/v4/WEB/LookupDeeds");

      string response = await SendPostRequestAsync(this.PostBody);

      return HandleResponse<T>(response);
    }

    /// <summary>
    /// This synchronous function sends the CloudAPI request using the /v4/WEB/LookupProperty endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public T GetLookupHomesByOwner<T>()
    {
      this.SetEndpoint("/v4/WEB/LookupHomesByOwner");

      return Get<T>();
    }

    /// <summary>
    /// This asynchronous function sends the CloudAPI request using the /v4/WEB/LookupProperty endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public async Task<T> GetLookupHomesByOwnerAsync<T>()
    {
      this.SetEndpoint("/v4/WEB/LookupHomesByOwner");

      return await GetAsync<T>();
    }

    /// <summary>
    /// This synchronous function sends a post request to the Cloud API using the /v4/WEB/LookupHomesByOwner endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public T PostLookupHomesByOwner<T>()
    {
      this.SetEndpoint("/v4/WEB/LookupHomesByOwner");

      string response = base.SendPostRequest(this.PostBody);

      return HandleResponse<T>(response);
    }

    /// <summary>
    /// This asynchronous function sends a post request to the Cloud API using the /v4/WEB/LookupHomesByOwner endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public async Task<T> PostLookupHomesByOwnerAsync<T>()
    {
      this.SetEndpoint("/v4/WEB/LookupHomesByOwner");

      string response = await base.SendPostRequestAsync(this.PostBody);

      return HandleResponse<T>(response);
    }

    /// <summary>
    /// This is a sychronous helper function that makes the post request 
    /// </summary>
    /// <param name="postBody"></param>
    /// <returns>a string of the Cloud API response</returns>
    private string SendPostRequest(PropertyRecordRequest postBody)
    {
      try
      {
        using (HttpClient client = new HttpClient())
        {
          client.BaseAddress = new Uri(this.BaseUrl);
          client.DefaultRequestHeaders.Accept.Clear();
          client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

          string jsonRecord = JsonConvert.SerializeObject(postBody);
          StringContent content = new StringContent(jsonRecord, Encoding.UTF8, "application/json");

          HttpResponseMessage response = client.PostAsync(this.Endpoint, content).Result;

          string responseContent = response.Content.ReadAsStringAsync().Result;
          var obj = JsonConvert.DeserializeObject(responseContent);
          var prettyResponse = JsonConvert.SerializeObject(obj, Formatting.Indented);

          return prettyResponse;
        }
      }
      catch (Exception ex)
      {
        return ex.ToString();
      }
    }

    /// <summary>
    /// This is an asychronous helper function that makes the post request 
    /// </summary>
    /// <param name="postBody"></param>
    /// <returns>a string of the Cloud API response</returns>
    private async Task<string> SendPostRequestAsync(PropertyRecordRequest postBody)
    {
      try
      {
        using (HttpClient client = new HttpClient())
        {
          client.BaseAddress = new Uri(this.BaseUrl);
          client.DefaultRequestHeaders.Accept.Clear();
          client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

          string jsonRecord = JsonConvert.SerializeObject(postBody);
          StringContent content = new StringContent(jsonRecord, Encoding.UTF8, "application/json");

          HttpResponseMessage response = await client.PostAsync(this.Endpoint, content);

          string responseContent = await response.Content.ReadAsStringAsync();
          var obj = JsonConvert.DeserializeObject(responseContent);
          var prettyResponse = JsonConvert.SerializeObject(obj, Formatting.Indented);

          return prettyResponse;
        }
      }
      catch (Exception ex)
      {
        return ex.ToString();
      }
    }

    /// <summary>
    /// This synchronous function makes a getversion request and parses the response for the cloud api specific version
    /// </summary>
    /// <returns>returns the Cloud API version</returns>
    public string GetApiVersion()
    {
      string jsonResponse = SendVersionRequest();

      JObject responseObject = JObject.Parse(jsonResponse);

      string businessCoderVersion = (string)responseObject["propertyVersion"];

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

      string businessCoderVersion = (string)responseObject["propertyVersion"];

      return businessCoderVersion;
    }
  }
}
