using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MelissaData.CloudAPI
{
  public class SmartMover : CloudAPIBase
  {
    List<SmartMoverRecordRequest> Records { get; set; }
    public SmartMoverPostRequest PostBody { get; set; }

    // Parameter mappings
    private readonly Dictionary<string, string> parameterMappings = new(StringComparer.OrdinalIgnoreCase)
    {
        { nameof(JobID), "jobid" },
        { nameof(PafID), "pafid" },
        { nameof(Action), "act" },
        { nameof(List), "list" },
        { nameof(Company), "comp" },
        { nameof(FullName), "full" },
        { nameof(FirstName), "first" },
        { nameof(MiddleName), "middle" },
        { nameof(NamePrefix), "namepre" },
        { nameof(NameSuffix), "namesfx" },
        { nameof(LastName), "last" },
        { nameof(Urbanization), "u" },
        { nameof(AddressLine1), "a1" },
        { nameof(AddressLine2), "a2" },
        { nameof(Suite), "ste" },
        { nameof(PrivateMailbox), "pmb" },
        { nameof(City), "city" },
        { nameof(State), "state" },
        { nameof(Postal), "postal" },
        { nameof(Plus4), "plus4" },
        { nameof(Country), "ctry" },
        { nameof(TransmissionReference), "t" },
        { nameof(Opt), "opt" },
        { nameof(Cols), "cols" }
    };

    // Private backing fields
    private string _jobID;
    private string _pafID;
    private string _action;
    private string _list;
    private string _company;
    private string _fullName;
    private string _firstName;
    private string _middleName;
    private string _namePrefix;
    private string _nameSuffix;
    private string _lastName;
    private string _urbanization;
    private string _addressLine1;
    private string _addressLine2;
    private string _suite;
    private string _privateMailbox;
    private string _city;
    private string _state;
    private string _postal;
    private string _plus4;
    private string _country;
    private string _transmissionReference;
    private string _opt;
    private string _cols;

    // Properties
    public string JobID
    {
      get => _jobID;
      set
      {
        _jobID = value;
        parameters[parameterMappings[nameof(JobID)]] = value;
      }
    }

    public string PafID
    {
      get => _pafID;
      set
      {
        _pafID = value;
        parameters[parameterMappings[nameof(PafID)]] = value;
      }
    }

    public string Action
    {
      get => _action;
      set
      {
        _action = value;
        parameters[parameterMappings[nameof(Action)]] = value;
      }
    }

    public string List
    {
      get => _list;
      set
      {
        _list = value;
        parameters[parameterMappings[nameof(List)]] = value;
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

    public string FullName
    {
      get => _fullName;
      set
      {
        _fullName = value;
        parameters[parameterMappings[nameof(FullName)]] = value;
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

    public string MiddleName
    {
      get => _middleName;
      set
      {
        _middleName = value;
        parameters[parameterMappings[nameof(MiddleName)]] = value;
      }
    }

    public string NamePrefix
    {
      get => _namePrefix;
      set
      {
        _namePrefix = value;
        parameters[parameterMappings[nameof(NamePrefix)]] = value;
      }
    }

    public string NameSuffix
    {
      get => _nameSuffix;
      set
      {
        _nameSuffix = value;
        parameters[parameterMappings[nameof(NameSuffix)]] = value;
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

    public string Urbanization
    {
      get => _urbanization;
      set
      {
        _urbanization = value;
        parameters[parameterMappings[nameof(Urbanization)]] = value;
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

    public string PrivateMailbox
    {
      get => _privateMailbox;
      set
      {
        _privateMailbox = value;
        parameters[parameterMappings[nameof(PrivateMailbox)]] = value;
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

    public string Plus4
    {
      get => _plus4;
      set
      {
        _plus4 = value;
        parameters[parameterMappings[nameof(Plus4)]] = value;
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

    public string Cols
    {
      get => _cols;
      set
      {
        _cols = value;
        parameters[parameterMappings[nameof(Cols)]] = value;
      }
    }

    public SmartMover(string license = null) : base("https://smartmover.melissadata.net", "/V3/WEB/SmartMover/doSmartMover")
    {
      this.License = license ?? Environment.GetEnvironmentVariable("MD_LICENSE");
      this.parameters["format"] = "json";
      this.PostBody = new SmartMoverPostRequest();
      this.Records = new List<SmartMoverRecordRequest>();
    }

    // Setters
    public void SetJobID(string jobID) 
    {
      this.parameters["jobid"] = jobID;
      this.JobID = jobID;
    }

    public void SetPafID(string pafID) 
    {
      this.parameters["pafid"] = pafID;
      this.PafID = pafID;
    }

    public void SetAction(string action) 
    {
      this.parameters["act"] = action;
      this.Action = action;
    }

    public void SetList(string list)
    {
      this.parameters["list"] = list;
      this.List = list;
    }

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

    public void SetFirstName(string firstName)
    {
      this.parameters["first"] = firstName;
      this.FirstName = firstName;
    }

    public void SetMiddleName(string middleName)
    {
      this.parameters["middle"] = middleName;
      this.MiddleName = middleName;
    }

    public void SetNamePrefix(string namePrefix) 
    {
      this.parameters["namepre"] = namePrefix;
      this.NamePrefix = namePrefix;
    }

    public void SetNameSuffix(string nameSuffix) 
    {
      this.parameters["namesfx"] = nameSuffix;
      this.NameSuffix = nameSuffix;
    }

    public void SetLastName(string lastName)
    {
      this.parameters["last"] = lastName;
      this.LastName = lastName;
    }

    public void SetUrbanization(string urbanization)
    {
      this.parameters["u"] = urbanization;
      this.Urbanization = urbanization;
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
      this.parameters["ste"] = suite;
      this.Suite = suite;
    }

    public void SetPrivateMailbox(string privateMailbox)
    {
      this.parameters["pmb"] = privateMailbox;
      this.PrivateMailbox = privateMailbox;
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

    public void SetPlus4(string plus4)
    {
      this.parameters["plus4"] = plus4;
      this.Plus4 = plus4;
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

    public void SetCols(string cols)
    {
      this.parameters["cols"] = cols;
      this.Cols = cols;
    }

    public void SetPostBody(SmartMoverPostRequest postBody)
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
    public string GetJobID()
    {
      return this.parameters.ContainsKey("jobid") ? this.parameters["jobid"] : "";
    }

    public string GetPafID()
    {
      return this.parameters.ContainsKey("pafid") ? this.parameters["pafid"] : "";
    }

    public string GetAction()
    {
      return this.parameters.ContainsKey("act") ? this.parameters["act"] : "";
    }

    public string GetList()
    {
      return this.parameters.ContainsKey("list") ? this.parameters["list"] : "";
    }

    public string GetCompany()
    {
      return this.parameters.ContainsKey("comp") ? this.parameters["comp"] : "";
    }

    public string GetFullName()
    {
      return this.parameters.ContainsKey("full") ? this.parameters["full"] : "";
    }

    public string GetFirstName()
    {
      return this.parameters.ContainsKey("first") ? this.parameters["first"] : "";
    }

    public string GetMiddleName()
    {
      return this.parameters.ContainsKey("middle") ? this.parameters["middle"] : "";
    }

    public string GetNamePrefix()
    {
      return this.parameters.ContainsKey("namepre") ? this.parameters["namepre"] : "";
    }

    public string GetNameSuffix()
    {
      return this.parameters.ContainsKey("namesfx") ? this.parameters["namesfx"] : "";
    }

    public string GetLastName()
    {
      return this.parameters.ContainsKey("last") ? this.parameters["last"] : "";
    }

    public string GetUrbanization()
    {
      return this.parameters.ContainsKey("u") ? this.parameters["u"] : "";
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
      return this.parameters.ContainsKey("ste") ? this.parameters["ste"] : "";
    }

    public string GetPrivateMailbox()
    {
      return this.parameters.ContainsKey("pmb") ? this.parameters["pmb"] : "";
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

    public string GetPlus4()
    {
      return this.parameters.ContainsKey("plus4") ? this.parameters["plus4"] : "";
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

    public string GetCols()
    {
      return this.parameters.ContainsKey("cols") ? this.parameters["cols"] : "";
    }

    public SmartMoverPostRequest GetPostBody()
    {
      return this.PostBody;
    }

    // Class Methods
    public void AddRecord(SmartMoverRecordRequest record)
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
        var postRequest = new SmartMoverPostRequest
        {
          CustomerID = this.GetLicense(),
          TransmissionReference = this.GetTransmissionReference(),
          JobID = this.GetJobID(),
          PAFId = this.GetPafID(),
          Actions = this.GetAction(),
          Options = this.GetOpt(),
          Columns = this.GetCols(),
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
    /// <returns>a string or deserialized json response object</returns>
    public async Task<T> PostAsync<T>()
    {
      string response;

      if (Records != null && Records.Count > 0)
      {
        var postRequest = new SmartMoverPostRequest
        {
          CustomerID = this.GetLicense(),
          TransmissionReference = this.GetTransmissionReference(),
          JobID = this.GetJobID(),
          PAFId = this.GetPafID(),
          Actions = this.GetAction(),
          Options = this.GetOpt(),
          Columns = this.GetCols(),
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
