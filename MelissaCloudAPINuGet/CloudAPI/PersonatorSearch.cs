using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MelissaData.CloudAPI
{
  public class PersonatorSearch : CloudAPIBase
  {
    private readonly Dictionary<string, string> parameterMappings = new(StringComparer.OrdinalIgnoreCase)
    {
        { nameof(TransmissionReference), "t" },
        { nameof(Opt), "opt" },
        { nameof(Cols), "cols" },
        { nameof(FreeForm), "ff" },
        { nameof(FullName), "full" },
        { nameof(FirstName), "first" },
        { nameof(LastName), "last" },
        { nameof(AddressLine1), "a1" },
        { nameof(Action), "act" },
        { nameof(City), "city" },
        { nameof(State), "state" },
        { nameof(Postal), "postal" },
        { nameof(Phone), "phone" },
        { nameof(Email), "email" },
        { nameof(MAK), "mak" },
        { nameof(BirthDay), "bday" },
        { nameof(BirthMonth), "bmonth" },
        { nameof(BirthYear), "byear" }
    };

    // Private backing fields
    private string _transmissionReference;
    private string _opt;
    private string _cols;
    private string _freeForm;
    private string _fullName;
    private string _firstName;
    private string _lastName;
    private string _addressLine1;
    private string _action;
    private string _city;
    private string _state;
    private string _postal;
    private string _phone;
    private string _email;
    private string _mak;
    private string _birthDay;
    private string _birthMonth;
    private string _birthYear;

    // Properties
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

    public string AddressLine1
    {
      get => _addressLine1;
      set
      {
        _addressLine1 = value;
        parameters[parameterMappings[nameof(AddressLine1)]] = value;
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

    public string Phone
    {
      get => _phone;
      set
      {
        _phone = value;
        parameters[parameterMappings[nameof(Phone)]] = value;
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

    public string MAK
    {
      get => _mak;
      set
      {
        _mak = value;
        parameters[parameterMappings[nameof(MAK)]] = value;
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


    public PersonatorSearch(string license = null) : base("http://personatorsearch.melissadata.net", "/WEB/doPersonatorSearch")
    {
      this.License = license ?? Environment.GetEnvironmentVariable("MD_LICENSE");
      this.parameters["format"] = "json";
    }

    // Setters
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

    public void SetAddressLine1(string addressLine1)
    {
      this.parameters["a1"] = addressLine1;
      this.AddressLine1 = addressLine1;
    }

    public void SetAction(string action)
    {
      this.parameters["act"] = action;
      this.Action = action;
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

    public void SetPhone(string phone)
    {
      this.parameters["phone"] = phone;
      this.Phone = phone;
    }

    public void SetEmail(string email)
    {
      this.parameters["email"] = email;
      this.Email = email;
    }

    public void SetMAK(string mak)
    {
      this.parameters["mak"] = mak;
      this.MAK = mak;
    }

    public void SetBirthDay(string birthDay)
    {
      this.parameters["bday"] = birthDay;
      this.BirthDay = birthDay;
    }

    public void SetBirthMonth(string birthMonth)
    {
      this.parameters["bmonth"] = birthMonth;
      this.BirthMonth = birthMonth;
    }

    public void SetBirthYear(string birthYear)
    {
      this.parameters["byear"] = birthYear;
      this.BirthYear = birthYear;
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

    public string GetFreeForm()
    {
      return this.parameters.ContainsKey("ff") ? this.parameters["ff"] : "";
    }

    public string GetFullName()
    {
      return this.parameters.ContainsKey("full") ? this.parameters["full"] : "";
    }

    public string GetFirstName()
    {
      return this.parameters.ContainsKey("first") ? this.parameters["first"] : "";
    }

    public string GetLastName()
    {
      return this.parameters.ContainsKey("last") ? this.parameters["last"] : "";
    }

    public string GetAddressLine1()
    {
      return this.parameters.ContainsKey("a1") ? this.parameters["a1"] : "";
    }

    public string GetAction()
    {
      return this.parameters.ContainsKey("act") ? this.parameters["act"] : "";
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

    public string GetPhone()
    {
      return this.parameters.ContainsKey("phone") ? this.parameters["phone"] : "";
    }

    public string GetEmail()
    {
      return this.parameters.ContainsKey("email") ? this.parameters["email"] : "";
    }

    public string GetMAK()
    {
      return this.parameters.ContainsKey("mak") ? this.parameters["mak"] : "";
    }

    public string GetBirthDay()
    {
      return this.parameters.ContainsKey("bday") ? this.parameters["bday"] : "";
    }

    public string GetBirthMonth()
    {
      return this.parameters.ContainsKey("bmonth") ? this.parameters["bmonth"] : "";
    }

    public string GetBirthYear()
    {
      return this.parameters.ContainsKey("byear") ? this.parameters["byear"] : "";
    }

    /// <summary>
    /// This synchronous function makes a getversion request and parses the response for the cloud api specific version
    /// </summary>
    /// <returns>returns the Cloud API version</returns>
    public string GetApiVersion()
    {
      string jsonResponse = SendVersionRequest();

      JObject responseObject = JObject.Parse(jsonResponse);

      string businessCoderVersion = (string)responseObject["personatorSearchVersion"];

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

      string businessCoderVersion = (string)responseObject["personatorSearchVersion"];

      return businessCoderVersion;
    }
  }
}
