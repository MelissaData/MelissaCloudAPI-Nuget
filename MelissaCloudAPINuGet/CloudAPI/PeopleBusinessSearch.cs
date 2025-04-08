using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MelissaData.CloudAPI
{
  public class PeopleBusinessSearch : CloudAPIBase
  {
    PeopleBusinessSearchRecordRequest PostBody {  get; set; }

    private readonly Dictionary<string, string> parameterMappings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { nameof(AddressLine1), "a1" },
        { nameof(AdministrativeArea), "adminarea" },
        { nameof(Country), "ctry" },
        { nameof(Locality), "loc" },
        { nameof(Phone), "phone" },
        { nameof(Postal), "postal" },
        { nameof(PostDirection), "postdir" },
        { nameof(PreDirection), "predir" },
        { nameof(PremisesNumber), "premnum" },
        { nameof(SubPremisesNumber), "subpremnum" },
        { nameof(ThoroughfareName), "tname" },
        { nameof(TrailingType), "trailingtype" },
        { nameof(AnyName), "anyname" },
        { nameof(Company), "comp" },
        { nameof(FirstName), "first" },
        { nameof(FullName), "full" },
        { nameof(LastName), "last" },
        { nameof(SubUser), "subuser" },
        { nameof(TransmissionReference), "t" },
        { nameof(MatchLevel), "matchlevel" },
        { nameof(MaxRecords), "maxrecords" }
    };

    // Private backing fields
    private string _addressLine1;
    private string _administrativeArea;
    private string _country;
    private string _locality;
    private string _phone;
    private string _postal;
    private string _postDirection;
    private string _preDirection;
    private string _premisesNumber;
    private string _subPremisesNumber;
    private string _thoroughfareName;
    private string _trailingType;
    private string _anyName;
    private string _company;
    private string _firstName;
    private string _fullName;
    private string _lastName;
    private string _subUser;
    private string _transmissionReference;
    private string _matchLevel;
    private string _maxRecords;

    // Properties
    public string AddressLine1
    {
      get => _addressLine1;
      set
      {
        _addressLine1 = value;
        parameters[parameterMappings[nameof(AddressLine1)]] = value;
      }
    }

    public string AdministrativeArea
    {
      get => _administrativeArea;
      set
      {
        _administrativeArea = value;
        parameters[parameterMappings[nameof(AdministrativeArea)]] = value;
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

    public string Locality
    {
      get => _locality;
      set
      {
        _locality = value;
        parameters[parameterMappings[nameof(Locality)]] = value;
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

    public string PostDirection
    {
      get => _postDirection;
      set
      {
        _postDirection = value;
        parameters[parameterMappings[nameof(PostDirection)]] = value;
      }
    }

    public string PreDirection
    {
      get => _preDirection;
      set
      {
        _preDirection = value;
        parameters[parameterMappings[nameof(PreDirection)]] = value;
      }
    }

    public string PremisesNumber
    {
      get => _premisesNumber;
      set
      {
        _premisesNumber = value;
        parameters[parameterMappings[nameof(PremisesNumber)]] = value;
      }
    }

    public string SubPremisesNumber
    {
      get => _subPremisesNumber;
      set
      {
        _subPremisesNumber = value;
        parameters[parameterMappings[nameof(SubPremisesNumber)]] = value;
      }
    }

    public string ThoroughfareName
    {
      get => _thoroughfareName;
      set
      {
        _thoroughfareName = value;
        parameters[parameterMappings[nameof(ThoroughfareName)]] = value;
      }
    }

    public string TrailingType
    {
      get => _trailingType;
      set
      {
        _trailingType = value;
        parameters[parameterMappings[nameof(TrailingType)]] = value;
      }
    }

    public string AnyName
    {
      get => _anyName;
      set
      {
        _anyName = value;
        parameters[parameterMappings[nameof(AnyName)]] = value;
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

    public string FirstName
    {
      get => _firstName;
      set
      {
        _firstName = value;
        parameters[parameterMappings[nameof(FirstName)]] = value;
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

    public string LastName
    {
      get => _lastName;
      set
      {
        _lastName = value;
        parameters[parameterMappings[nameof(LastName)]] = value;
      }
    }

    public string SubUser
    {
      get => _subUser;
      set
      {
        _subUser = value;
        parameters[parameterMappings[nameof(SubUser)]] = value;
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

    public string MatchLevel
    {
      get => _matchLevel;
      set
      {
        _matchLevel = value;
        parameters[parameterMappings[nameof(MatchLevel)]] = value;
      }
    }

    public string MaxRecords
    {
      get => _maxRecords;
      set
      {
        _maxRecords = value;
        parameters[parameterMappings[nameof(MaxRecords)]] = value;
      }
    }

    public PeopleBusinessSearch(string license = null) : base("https://search.melissadata.net", "/v5/web/contactsearch/docontactSearch")
    {
      this.License = license ?? Environment.GetEnvironmentVariable("MD_LICENSE");
      this.parameters["format"] = "json";
      this.PostBody = new PeopleBusinessSearchRecordRequest();
    }
    
    // Setter
    public void SetAddressLine1(string addressLine1)
    {
      this.parameters["a1"] = addressLine1;
      this.AddressLine1 = addressLine1;
    }

    public void SetAdministrativeArea(string administrativeArea)
    {
      this.parameters["adminarea"] = administrativeArea;
      this.AdministrativeArea = administrativeArea;
    }

    public void SetCountry(string country)
    {
      this.parameters["ctry"] = country;
      this.Country = country;
    }

    public void SetLocality(string locality) 
    {
      this.parameters["loc"] = locality;
      this.Locality = locality;
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

    public void SetPostDirection(string postDirection)
    {
      this.parameters["postdir"] = postDirection;
      this.PostDirection = postDirection;
    }

    public void SetPreDirection(string preDirection)
    {
      this.parameters["predir"] = preDirection;
      this.PreDirection = preDirection;
    }

    public void SetPremisesNumber(string premisesNumber)
    {
      this.parameters["premnum"] = premisesNumber;
      this.PremisesNumber = premisesNumber;
    }

    public void SetSubPremisesNumber(string subPremisesNumber)
    {
      this.parameters["subpremnum"] = subPremisesNumber;
      this.SubPremisesNumber= subPremisesNumber;
    }

    public void SetThoroughfareName(string thoroughfareName)
    {
      this.parameters["tname"] = thoroughfareName;
      this.ThoroughfareName = thoroughfareName;
    }

    public void SetTrailingType(string trailingType)
    {
      this.parameters["trailingtype"] = trailingType;
      this.TrailingType = trailingType;
    }

    public void SetAnyName(string anyName)
    {
      this.parameters["anyname"] = anyName;
      this.AnyName = anyName;
    }

    public void SetCompany(string company)
    {
      this.parameters["comp"] = company;
      this.Company = company;
    }

    public void SetFirstName(string firstName)
    {
      this.parameters["first"] = firstName;
      this.FirstName = firstName;
    }

    public void SetFullName(string fullName)
    {
      this.parameters["full"] = fullName;
      this.FullName = fullName;
    }

    public void SetLastName(string lastName)
    {
      this.parameters["last"] = lastName;
      this.LastName = lastName;
    }

    public void SetSubUser(string subUser)
    {
      this.parameters["subuser"] = subUser;
      this.SubUser = subUser;
    }

    public void SetTransmissionReference(string transmissionReference)
    {
      this.parameters["t"] = transmissionReference;
      this.TransmissionReference = transmissionReference;
    }

    public void SetMatchLevel(string matchLevel)
    {
      this.parameters["matchlevel"] = matchLevel;
      this.MatchLevel = matchLevel;
    }

    public void SetMaxRecords(string maxRecords)
    {
      this.parameters["maxrecords"] = maxRecords;
      this.MaxRecords = maxRecords;
    }

    public void SetPostBody(PeopleBusinessSearchRecordRequest postBody)
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

    // Getter
    public string GetAddressLine1() 
    {
      return this.parameters.ContainsKey("a1") ? this.parameters["a1"] : "";
    } 
    
    public string GetAdministrativeArea() 
    {
      return this.parameters.ContainsKey("adminarea") ? this.parameters["adminarea"] : "";
    }
    
    public string GetCountry() 
    {
      return this.parameters.ContainsKey("ctry") ? this.parameters["ctry"] : "";
    }
    
    public string GetLocality() 
    {
      return this.parameters.ContainsKey("loc") ? this.parameters["loc"] : "";
    }
    
    public string GetPhone() 
    {
      return this.parameters.ContainsKey("phone") ? this.parameters["phone"] : "";
    }  
    
    public string GetPostal() 
    {
      return this.parameters.ContainsKey("postal") ? this.parameters["postal"] : "";
    }
    
    public string GetPostDirection() 
    {
      return this.parameters.ContainsKey("postdir") ? this.parameters["postdir"] : "";
    }
    
    public string GetPreDirection() 
    {
      return this.parameters.ContainsKey("predir") ? this.parameters["predir"] : "";
    }
    
    public string GetPremisesNumber() 
    {
      return this.parameters.ContainsKey("premnum") ? this.parameters["premnum"] : "";
    }
    
    public string GetSubPremisesNumber() 
    {
      return this.parameters.ContainsKey("subpremnum") ? this.parameters["subpremnum"] : "";
    }
    
    public string GetThoroughfareName() 
    {
      return this.parameters.ContainsKey("tname") ? this.parameters["tname"] : "";
    }
    
    public string GetTrailingType() 
    {
      return this.parameters.ContainsKey("trailingtype") ? this.parameters["trailingtype"] : "";
    }
    
    public string GetAnyName() 
    {
      return this.parameters.ContainsKey("anyname") ? this.parameters["anyname"] : "";
    }
    
    public string GetCompany() 
    {
      return this.parameters.ContainsKey("comp") ? this.parameters["comp"] : "";
    }
    
    public string GetFirstName() 
    {
      return this.parameters.ContainsKey("first") ? this.parameters["first"] : "";
    }
    
    public string GetFullName() 
    {
      return this.parameters.ContainsKey("full") ? this.parameters["full"] : "";
    } 
    
    public string GetLastName() 
    {
      return this.parameters.ContainsKey("last") ? this.parameters["last"] : "";
    }
    
    public string GetSubUser() 
    {
      return this.parameters.ContainsKey("subuser") ? this.parameters["subuser"] : "";
    }
    
    public string GetTransmissionReference() 
    {
      return this.parameters.ContainsKey("t") ? this.parameters["t"] : "";
    }
    
    public string getMatchLevel() 
    {
      return this.parameters.ContainsKey("matchlevel") ? this.parameters["matchlevel"] : "";
    }
    
    public string GetMaxRecords() 
    {
      return this.parameters.ContainsKey("maxrecords") ? this.parameters["maxrecords"] : "";
    }

    public PeopleBusinessSearchRecordRequest GetPostBody()
    {
      return this.PostBody;
    }

    /// <summary>
    /// This synchronous function sends a post request to the Cloud API
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public T Post<T>()
    {
      string response = SendPostRequest(this.PostBody);

      return HandleResponse<T>(response);
    }

    /// <summary>
    /// This asynchronous function sends a post request to the Cloud API
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public async Task<T> PostAsync<T>()
    {
      string response = await SendPostRequestAsync(this.PostBody);

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

      string businessCoderVersion = (string)responseObject["mdPersonBusinessSearch"];

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

      string businessCoderVersion = (string)responseObject["mdPersonBusinessSearch"];

      return businessCoderVersion;
    }
  }
}
