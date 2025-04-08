using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MelissaData.CloudAPI
{
  public class BusinessCoder : CloudAPIBase
  {
    public List<BusinessCoderRecordRequest> Records { get; set; } 
    public BusinessCoderPostRequest PostBody { get; set; }

    private readonly Dictionary<string, string> parameterMappings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { nameof(RecordID), "rec" },
        { nameof(Company), "comp" },
        { nameof(Phone), "phone" },
        { nameof(AddressLine1), "a1" },
        { nameof(AddressLine2), "a2" },
        { nameof(Suite), "suite" },
        { nameof(City), "city" },
        { nameof(State), "state" },
        { nameof(Postal), "postal" },
        { nameof(Country), "ctry" },
        { nameof(MAK), "mak" },
        { nameof(StockTicker), "stock" },
        { nameof(WebAddress), "web" },
        { nameof(MEK), "mek" },
        { nameof(FreeForm), "freeform" },
        { nameof(TransmissionReference), "t" },
        { nameof(Opt), "opt" },
        { nameof(Cols), "cols" }
    };

    // Private backing fields
    private string _recordID;
    private string _company;
    private string _phone;
    private string _addressLine1;
    private string _addressLine2;
    private string _suite;
    private string _city;
    private string _state;
    private string _postal;
    private string _country;
    private string _mak;
    private string _stockTicker;
    private string _webAddress;
    private string _mek;
    private string _freeForm;
    private string _transmissionReference;
    private string _opt;
    private string _cols;

    // Properties
    public string RecordID
    {
      get => _recordID;
      set
      {
        _recordID = value;
        parameters[parameterMappings[nameof(RecordID)]] = value;
      }
    }

    public string Company
    {
      get => _company;
      set
      {
        _company = value;
        parameters[parameterMappings[nameof(Company)]] = value;
      }
    }

    public string Phone
    {
      get => _phone;
      set
      {
        _phone = value;
        parameters[parameterMappings[nameof(Phone)]] = value;
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

    public string Suite
    {
      get => _suite;
      set
      {
        _suite = value;
        parameters[parameterMappings[nameof(Suite)]] = value;
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

    public string Country
    {
      get => _country;
      set
      {
        _country = value;
        parameters[parameterMappings[nameof(Country)]] = value;
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

    public string StockTicker
    {
      get => _stockTicker;
      set
      {
        _stockTicker = value;
        parameters[parameterMappings[nameof(StockTicker)]] = value;
      }
    }

    public string WebAddress
    {
      get => _webAddress;
      set
      {
        _webAddress = value;
        parameters[parameterMappings[nameof(WebAddress)]] = value;
      }
    }

    public string MEK
    {
      get => _mek;
      set
      {
        _mek = value;
        parameters[parameterMappings[nameof(MEK)]] = value;
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

    public string Cols
    {
      get => _cols;
      set
      {
        _cols = value;
        parameters[parameterMappings[nameof(Cols)]] = value;
      }
    }

    public BusinessCoder(string license = null) : base("https://businesscoder.melissadata.net", "/WEB/BusinessCoder/doBusinessCoderUS")
    {
      this.License = license ?? Environment.GetEnvironmentVariable("MD_LICENSE");
      this.parameters["format"] = "json";
      this.PostBody = new BusinessCoderPostRequest();
      this.Records = new List<BusinessCoderRecordRequest>();
    }

    // Setters
    public void SetRecordID(string recordId)
    {
      this.parameters["rec"] = recordId;
      this.RecordID = recordId;
    }

    public void SetCompany(string company)
    {
      this.parameters["comp"] = company;
      this.Company = company;
    }

    public void SetPhone(string phone) 
    {
      this.parameters["phone"] = phone;
      this.Phone = phone;
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
    public void SetSuite(string suite)
    {
      this.parameters["suite"] = suite;
      this.Suite = suite;
    }

    public void SetCity(string city)
    {
      this.parameters["city"] = city;
      this.City = city;
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

    public void SetCountry(string country)
    {
      this.parameters["ctry"] = country;
      this.Country = country;
    }

    public void SetMAK(string mak)
    {
      this.parameters["mak"] = mak;
      this.MAK = mak;
    }

    public void SetStockTicker(string ticker)
    {
      this.parameters["stock"] = ticker;
      this.StockTicker = ticker;
    }

    public void SetWebAddress(string url)
    {
      this.parameters["web"] = url;
      this.WebAddress = url;
    }

    public void SetMEK(string mek)
    {
      this.parameters["mek"] = mek;
      this.MEK = mek;
    }

    public void SetFreeForm(string ff)
    {
      this.parameters["freeform"] = ff;
      this.FreeForm = ff;
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

    public void SetCols(string cols)
    {
      this.parameters["cols"] = cols;
      this.Cols = cols;
    }

    public void SetPostBody(BusinessCoderPostRequest postBody)
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
    public string GetRecordID()
    {
      return this.parameters.ContainsKey("rec") ? this.parameters["rec"] : "";
    }

    public string GetCompany()
    {
      return this.parameters.ContainsKey("comp") ? this.parameters["comp"] : "";
    }

    public string GetPhone()
    {
      return this.parameters.ContainsKey("phone") ? this.parameters["phone"] : "";
    }

    public string GetAddressLine1()
    {
      return this.parameters.ContainsKey("a1") ? this.parameters["a1"] : "";
    }

    public string GetAddressLine2()
    {
      return this.parameters.ContainsKey("a2") ? this.parameters["a2"] : "";
    }

    public string GetSuite()
    {
      return this.parameters.ContainsKey("suite") ? this.parameters["suite"] : "";
    }

    public string GetCity() 
    {
      return this.parameters.ContainsKey("city") ? this.parameters["city"] : "";
    }

    public string GetState() 
    {
      return this.parameters.ContainsKey("state") ? this.parameters["state"] : "";
    }
    public string GetPostal() 
    {
      return this.parameters.ContainsKey("postal") ? this.parameters["postal"] : "";
    }
    public string GetCountry() 
    {
      return this.parameters.ContainsKey("ctry") ? this.parameters["ctry"] : "";
    }
    public string GetMAK() 
    {
      return this.parameters.ContainsKey("mak") ? this.parameters["mak"] : "";
    }
    public string GetStockTicker() 
    {
      return this.parameters.ContainsKey("stock") ? this.parameters["stock"] : "";
    }
    public string GetWebAddress() 
    {
      return this.parameters.ContainsKey("web") ? this.parameters["web"] : "";
    }
    public string GetMEK() 
    {
      return this.parameters.ContainsKey("mek") ? this.parameters["mek"] : "";
    }
    public string GetFreeForm() 
    {
      return this.parameters.ContainsKey("freeform") ? this.parameters["freeform"] : "";
    }
    public string GetTransmissionReference() 
    {
      return this.parameters.ContainsKey("t") ? this.parameters["t"] : "";
    }    
    public string GetOpt() 
    {
      return this.parameters.ContainsKey("opt") ? this.parameters["opt"] : "";
    }
    public string GetCols() 
    {
      return this.parameters.ContainsKey("cols") ? this.parameters["cols"] : "";
    }

    public BusinessCoderPostRequest GetPostBody()
    {
      return this.PostBody;
    }

    // Class Methods
    public void AddRecord(BusinessCoderRecordRequest record)
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
        var postRequest = new BusinessCoderPostRequest
        {
          Cols = this.GetCols(),
          Id = this.GetLicense(),
          T = this.GetTransmissionReference(),
          Opt = this.GetOpt(),
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
        var postRequest = new BusinessCoderPostRequest
        {
          Cols = this.GetCols(),
          Id = this.GetLicense(),
          T = this.GetTransmissionReference(),
          Opt = this.GetOpt(),
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

      string businessCoderVersion = (string)responseObject["businessCoderVersion"];

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

      string businessCoderVersion = (string)responseObject["businessCoderVersion"];

      return businessCoderVersion;
    }
  }
}
