using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MelissaData.CloudAPI
{
  public class GlobalAddressVerification : CloudAPIBase
  {
    public List<GlobalAddressVerificationRecordRequest> Records { get; set; }
    public GlobalAddressVerificationPostRequest PostBody { get; set; }

    private readonly Dictionary<string, string> parameterMappings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
      { nameof(Organization), "org" },
      { nameof(LastName), "last" },
      { nameof(AddressLine1), "a1" },
      { nameof(AddressLine2), "a2" },
      { nameof(AddressLine3), "a3" },
      { nameof(AddressLine4), "a4" },
      { nameof(AddressLine5), "a5" },
      { nameof(AddressLine6), "a6" },
      { nameof(AddressLine7), "a7" },
      { nameof(AddressLine8), "a8" },
      { nameof(DoubleDependentLocality), "ddeploc" },
      { nameof(DependentLocality), "deploc" },
      { nameof(Locality), "loc" },
      { nameof(AdministrativeArea), "admarea" },
      { nameof(Postal), "postal" },
      { nameof(SubNationalArea), "subnatarea" },
      { nameof(Country), "ctry" },
      { nameof(TransmissionReference), "t" },
      { nameof(Opt), "opt" }
    };

    // Private backing fields 
    private string _organization;
    private string _lastName;
    private string _addressLine1;
    private string _addressLine2;
    private string _addressLine3;
    private string _addressLine4;
    private string _addressLine5;
    private string _addressLine6;
    private string _addressLine7;
    private string _addressLine8;
    private string _doubleDependentLocality;
    private string _dependentLocality;
    private string _locality;
    private string _administrativeArea;
    private string _postal;
    private string _subNationalArea;
    private string _country;
    private string _opt;

    // Properties
    public string Organization
    {
      get => _organization;
      set
      {
        _organization = value;
        parameters[parameterMappings[nameof(Organization)]] = value;
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


    public string AddressLine2
    {
      get => _addressLine2;
      set
      {
        _addressLine2 = value;
        parameters[parameterMappings[nameof(AddressLine2)]] = value;
      }
    }

    public string AddressLine3
    {
      get => _addressLine3;
      set
      {
        _addressLine3 = value;
        parameters[parameterMappings[nameof(AddressLine3)]] = value;
      }
    }

    public string AddressLine4
    {
      get => _addressLine4;
      set
      {
        _addressLine4 = value;
        parameters[parameterMappings[nameof(AddressLine4)]] = value;
      }
    }

    public string AddressLine5
    {
      get => _addressLine5;
      set
      {
        _addressLine5 = value;
        parameters[parameterMappings[nameof(AddressLine5)]] = value;
      }
    }

    public string AddressLine6
    {
      get => _addressLine6;
      set
      {
        _addressLine6 = value;
        parameters[parameterMappings[nameof(AddressLine6)]] = value;
      }
    }

    public string AddressLine7
    {
      get => _addressLine7;
      set
      {
        _addressLine7 = value;
        parameters[parameterMappings[nameof(AddressLine7)]] = value;
      }
    }

    public string AddressLine8
    {
      get => _addressLine8;
      set
      {
        _addressLine8 = value;
        parameters[parameterMappings[nameof(AddressLine8)]] = value;
      }
    }


    public string DoubleDependentLocality
    {
      get => _doubleDependentLocality;
      set
      {
        _doubleDependentLocality = value;
        parameters[parameterMappings[nameof(DoubleDependentLocality)]] = value;
      }
    }

    public string DependentLocality
    {
      get => _dependentLocality;
      set
      {
        _dependentLocality = value;
        parameters[parameterMappings[nameof(DependentLocality)]] = value;
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

    public string AdministrativeArea
    {
      get => _administrativeArea;
      set
      {
        _administrativeArea = value;
        parameters[parameterMappings[nameof(AdministrativeArea)]] = value;
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

    public string SubNationalArea
    {
      get => _subNationalArea;
      set
      {
        _subNationalArea = value;
        parameters[parameterMappings[nameof(SubNationalArea)]] = value;
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

    private string _transmissionReference;
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


    public GlobalAddressVerification(string license = null) : base("https://address.melissadata.net", "/v3/WEB/GlobalAddress/doGlobalAddress")
    {
      this.License = license ?? Environment.GetEnvironmentVariable("MD_LICENSE");
      this.parameters["format"] = "json";
      this.PostBody = new GlobalAddressVerificationPostRequest();
      this.Records = new List<GlobalAddressVerificationRecordRequest>();
    }

    // Setters
    public void SetOrganization(string organization) { 
      this.parameters["org"] = organization;
      this.Organization = organization;
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

    public void SetAddressLine2(string addressLine2)
    {
      this.parameters["a2"] = addressLine2;
      this.AddressLine2 = addressLine2;
    }

    public void SetAddressLine3(string addressLine3)
    {
      this.parameters["a3"] = addressLine3;
      this.AddressLine3 = addressLine3;
    }

    public void SetAddressLine4(string addressLine4)
    {
      this.parameters["a4"] = addressLine4;
      this.AddressLine4 = addressLine4;
    }

    public void SetAddressLine5(string addressLine5)
    {
      this.parameters["a5"] = addressLine5;
      this.AddressLine5 = addressLine5;
    }

    public void SetAddressLine6(string addressLine6)
    {
      this.parameters["a6"] = addressLine6;
      this.AddressLine6 = addressLine6; 
    }

    public void SetAddressLine7(string addressLine7)
    {
      this.parameters["a7"] = addressLine7;
      this.AddressLine7 = addressLine7;
    }

    public void SetAddressLine8(string addressLine8)
    {
      this.parameters["a8"] = addressLine8;
      this.AddressLine8 = addressLine8;
    }

    public void SetDoubleDependentLocality(string doubleDependentLocality)
    {
      this.parameters["ddeploc"] = doubleDependentLocality;
      this.DoubleDependentLocality = doubleDependentLocality;
    }

    public void SetDependentLocality(string dependentLocality)
    {
      this.parameters["deploc"] = dependentLocality;
      this.DependentLocality = dependentLocality;
    }

    public void SetLocality(string locality)
    {
      this.parameters["loc"] = locality;
      this.Locality = locality;
    }

    public void SetAdministrativeArea(string administrativeArea)
    {
      this.parameters["admarea"] = administrativeArea;
      this.AdministrativeArea = administrativeArea; 
    }

    public void SetPostal(string postal)
    {
      this.parameters["postal"] = postal;
      this.Postal = postal;
    }

    public void SetSubNationalArea(string subNationalArea)
    {
      this.parameters["subnatarea"] = subNationalArea;
      this.SubNationalArea = subNationalArea;
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

    public void SetPostBody(GlobalAddressVerificationPostRequest postBody)
    {
      this.PostBody = postBody;
    }

    // Getters
    public string GetOrganization() 
    {
      return this.parameters.ContainsKey("org") ? this.parameters["org"] : "";
    }

    public string GetLastName() 
    {
      return this.parameters.ContainsKey("last") ? this.parameters["last"] : "";
    }

    public string GetAddressLine1() 
    {
      return this.parameters.ContainsKey("a1") ? this.parameters["a1"] : "";
    }

    public string GetAddressLine2() 
    {
      return this.parameters.ContainsKey("a2") ? this.parameters["a2"] : "";
    }

    public string GetAddressLine3() 
    {
      return this.parameters.ContainsKey("a3") ? this.parameters["a3"] : "";
    }

    public string GetAddressLine4() 
    {
      return this.parameters.ContainsKey("a4") ? this.parameters["a4"] : "";
    }

    public string GetAddressLine5() 
    {
      return this.parameters.ContainsKey("a5") ? this.parameters["a5"] : "";
    }
    
    public string GetAddressLine6() 
    {
      return this.parameters.ContainsKey("a6") ? this.parameters["a6"] : "";
    }
    
    public string GetAddressLine7() 
    {
      return this.parameters.ContainsKey("a7") ? this.parameters["a7"] : "";
    }

    public string GetAddressLine8() 
    {
      return this.parameters.ContainsKey("a8") ? this.parameters["a8"] : "";
    }
    
    public string GetDoubleDependentLocality() 
    {
      return this.parameters.ContainsKey("ddeploc") ? this.parameters["ddeploc"] : "";
    }
    
    public string GetDependentLocality() 
    {
      return this.parameters.ContainsKey("deploc") ? this.parameters["deploc"] : "";
    }
    
    public string GetLocality() 
    {
      return this.parameters.ContainsKey("loc") ? this.parameters["loc"] : "";
    }

    public string GetAdministrativeArea() 
    {
      return this.parameters.ContainsKey("admarea") ? this.parameters["admarea"] : "";
    }
    
    public string GetPostal() 
    {
      return this.parameters.ContainsKey("postal") ? this.parameters["postal"] : "";
    }
    
    public string GetSubNationalArea() 
    {
      return this.parameters.ContainsKey("subnatarea") ? this.parameters["subnatarea"] : "";
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

    public GlobalAddressVerificationPostRequest GetPostBody()
    {
      return this.PostBody;
    }

    // Class Methods
    public void AddRecord(GlobalAddressVerificationRecordRequest record)
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
        var postRequest = new GlobalAddressVerificationPostRequest
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
        var postRequest = new GlobalAddressVerificationPostRequest
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
