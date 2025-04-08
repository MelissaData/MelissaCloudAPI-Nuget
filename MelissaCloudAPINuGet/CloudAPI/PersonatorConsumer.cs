using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MelissaData.CloudAPI
{
  public class PersonatorConsumer : CloudAPIBase
  {
    public List<PersonatorConsumerRecordRequest> Records { get; set; }
    public PersonatorConsumerPostRequest PostBody { get; set; }

    private readonly Dictionary<string, string> parameterMappings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { nameof(Action), "act" },
        { nameof(AddressLine1), "a1" },
        { nameof(AddressLine2), "a2" },
        { nameof(BirthDay), "bday" },
        { nameof(BirthMonth), "bmo" },
        { nameof(BirthYear), "byr" },
        { nameof(City), "city" },
        { nameof(Company), "comp" },
        { nameof(Country), "ctry" },
        { nameof(Email), "email" },
        { nameof(FirstName), "first" },
        { nameof(FreeForm), "ff" },
        { nameof(FullName), "full" },
        { nameof(IP), "ip" },
        { nameof(LastLine), "lastline" },
        { nameof(LastName), "last" },
        { nameof(MAK), "mak" },
        { nameof(MIK), "MIK" },
        { nameof(Phone), "phone" },
        { nameof(Postal), "postal" },
        { nameof(SSN), "ss" },
        { nameof(State), "state" },
        { nameof(TransmissionReference), "t" },
        { nameof(Opt), "opt" },
        { nameof(Cols), "cols" }
    };

    // Private backing fields
    private string _action;
    private string _addressLine1;
    private string _addressLine2;
    private string _birthDay;
    private string _birthMonth;
    private string _birthYear;
    private string _city;
    private string _company;
    private string _country;
    private string _email;
    private string _firstName;
    private string _freeForm;
    private string _fullName;
    private string _ip;
    private string _lastLine;
    private string _lastName;
    private string _mak;
    private string _mik;
    private string _phone;
    private string _postal;
    private string _ssn;
    private string _state;
    private string _transmissionReference;
    private string _opt;
    private string _cols;

    // Properties
    public string Action
    {
      get => _action;
      set
      {
        _action = value;
        parameters[parameterMappings[nameof(Action)]] = value;
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

    public string BirthDay
    {
      get => _birthDay;
      set
      {
        _birthDay = value;
        parameters[parameterMappings[nameof(BirthDay)]] = value;
      }
    }

    public string BirthMonth
    {
      get => _birthMonth;
      set
      {
        _birthMonth = value;
        parameters[parameterMappings[nameof(BirthMonth)]] = value;
      }
    }

    public string BirthYear
    {
      get => _birthYear;
      set
      {
        _birthYear = value;
        parameters[parameterMappings[nameof(BirthYear)]] = value;
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

    public string Company
    {
      get => _company;
      set
      {
        _company = value;
        parameters[parameterMappings[nameof(Company)]] = value;
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

    public string Email
    {
      get => _email;
      set
      {
        _email = value;
        parameters[parameterMappings[nameof(Email)]] = value;
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

    public string FreeForm
    {
      get => _freeForm;
      set
      {
        _freeForm = value;
        parameters[parameterMappings[nameof(FreeForm)]] = value;
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

    public string IP
    {
      get => _ip;
      set
      {
        _ip = value;
        parameters[parameterMappings[nameof(IP)]] = value;
      }
    }

    public string LastLine
    {
      get => _lastLine;
      set
      {
        _lastLine = value;
        parameters[parameterMappings[nameof(LastLine)]] = value;
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

    public string MAK
    {
      get => _mak;
      set
      {
        _mak = value;
        parameters[parameterMappings[nameof(MAK)]] = value;
      }
    }

    public string MIK
    {
      get => _mik;
      set
      {
        _mik = value;
        parameters[parameterMappings[nameof(MIK)]] = value;
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

    public string Postal
    {
      get => _postal;
      set
      {
        _postal = value;
        parameters[parameterMappings[nameof(Postal)]] = value;
      }
    }

    public string SSN
    {
      get => _ssn;
      set
      {
        _ssn = value;
        parameters[parameterMappings[nameof(SSN)]] = value;
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

    public PersonatorConsumer(string license = null) : base("https://personator.melissadata.net", "/v3/WEB/ContactVerify/doContactVerify")
    {
      this.License = license ?? Environment.GetEnvironmentVariable("MD_LICENSE");
      this.parameters["format"] = "json";
      this.PostBody = new PersonatorConsumerPostRequest();
      this.Records = new List<PersonatorConsumerRecordRequest>();
    }

    // Setters
    public void SetAction(string action)
    {
      this.parameters["act"] = action;
      this.Action = action;
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

    public void SetBirthDay(string birthDay)
    {
      this.parameters["bday"] = birthDay;
      this.BirthDay = birthDay;
    }

    public void SetBirthMonth(string birthMonth)
    {
      this.parameters["bmo"] = birthMonth;
      this.BirthMonth = birthMonth;
    }

    public void SetBirthYear(string birthYear)
    {
      this.parameters["byr"] = birthYear;
      this.BirthYear = birthYear;
    }

    public void SetCity(string city)
    {
      this.parameters["city"] = city;
      this.City = city;
    }

    public void SetCompany(string company)
    {
      this.parameters["comp"] = company;
      this.Company = company;
    }

    public void SetCountry(string country)
    {
      this.parameters["ctry"] = country;
      this.Country = country;
    }

    public void SetEmail(string email)
    {
      this.parameters["email"] = email;
      this.Email = email;
    }

    public void SetFirstName(string firstName)
    {
      this.parameters["first"] = firstName;
      this.FirstName = firstName;
    }

    public void SetFreeForm(string ff)
    {
      this.parameters["ff"] = ff;
      this.FreeForm = ff;
    }

    public void SetFullName(string fullName)
    {
      this.parameters["full"] = fullName;
      this.FullName = fullName;
    }

    public void SetIP(string ip)
    {
      this.parameters["ip"] = ip;
      this.IP = ip;
    }

    public void SetLastLine(string lastLine)
    {
      this.parameters["lastline"] = lastLine;
      this.LastLine = lastLine;
    }

    public void SetLastName(string lastName)
    {
      this.parameters["last"] = lastName;
      this.LastName = lastName;
    }

    public void SetMAK(string mak)
    {
      this.parameters["mak"] = mak; 
      this.MAK = mak;
    }

    public void SetMIK(string mik)
    {
      this.parameters["MIK"] = mik;
      this.MIK = mik;
    }

    public void SetPhone(string phone)
    {
      this.parameters["phone"] = phone;
      this.Phone = phone;
    }

    public void SetPostal(string postal)
    {
      this.parameters["postal"] = postal;
      this.Postal = postal;
    }

    public void SetSSN(string ssn)
    {
      this.parameters["ss"] = ssn;
      this.SSN = ssn;
    }

    public void SetState(string state)
    {
      this.parameters["state"] = state;
      this.State = state;
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

    public void SetPostBody(PersonatorConsumerPostRequest postBody)
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
    public string GetAction()
    {
      return this.parameters.ContainsKey("act") ? this.parameters["act"] : "";
    }

    public string GetAddressLine1()
    {
      return this.parameters.ContainsKey("a1") ? this.parameters["a1"] : "";
    }

    public string GetAddressLine2()
    {
      return this.parameters.ContainsKey("a2") ? this.parameters["a2"] : "";
    }

    public string GetBirthDay()
    {
      return this.parameters.ContainsKey("bday") ? this.parameters["bday"] : "";
    }

    public string GetBirthMonth()
    {
      return this.parameters.ContainsKey("bmo") ? this.parameters["bmo"] : "";
    }

    public string GetBirthYear()
    {
      return this.parameters.ContainsKey("byr") ? this.parameters["byr"] : "";
    }

    public string GetCity()
    {
      return this.parameters.ContainsKey("city") ? this.parameters["city"] : "";
    }

    public string GetCompany()
    {
      return this.parameters.ContainsKey("comp") ? this.parameters["comp"] : "";
    }

    public string GetCountry()
    {
      return this.parameters.ContainsKey("ctry") ? this.parameters["ctry"] : "";
    }

    public string GetEmail()
    {
      return this.parameters.ContainsKey("email") ? this.parameters["email"] : "";
    }

    public string GetFirstName()
    {
      return this.parameters.ContainsKey("first") ? this.parameters["first"] : "";
    }

    public string GetFreeForm()
    {
      return this.parameters.ContainsKey("ff") ? this.parameters["ff"] : "";
    }

    public string GetFullName()
    {
      return this.parameters.ContainsKey("full") ? this.parameters["full"] : "";
    }

    public string GetIP()
    {
      return this.parameters.ContainsKey("ip") ? this.parameters["ip"] : "";
    }

    public string GetLastLine()
    {
      return this.parameters.ContainsKey("lastline") ? this.parameters["lastline"] : "";
    }

    public string GetLastName()
    {
      return this.parameters.ContainsKey("last") ? this.parameters["last"] : "";
    }

    public string GetMAK()
    {
      return this.parameters.ContainsKey("mak") ? this.parameters["mak"] : "";
    }

    public string GetMIK()
    {
      return this.parameters.ContainsKey("MIK") ? this.parameters["MIK"] : "";
    }

    public string GetPhone()
    {
      return this.parameters.ContainsKey("phone") ? this.parameters["phone"] : "";
    }

    public string GetPostal()
    {
      return this.parameters.ContainsKey("postal") ? this.parameters["postal"] : "";
    }

    public string GetSSN()
    {
      return this.parameters.ContainsKey("ss") ? this.parameters["ss"] : "";
    }

    public string GetState()
    {
      return this.parameters.ContainsKey("state") ? this.parameters["state"] : "";
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

    public PersonatorConsumerPostRequest GetPostBody()
    {
      return this.PostBody;
    }

    // Class Methods
    public void AddRecord(PersonatorConsumerRecordRequest record)
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
        var postRequest = new PersonatorConsumerPostRequest
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
        var postRequest = new PersonatorConsumerPostRequest
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
