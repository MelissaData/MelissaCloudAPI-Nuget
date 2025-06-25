using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MelissaData.CloudAPI
{
  public class GlobalExpressEntry : CloudAPIBase
  {
    private readonly Dictionary<string, string> parameterMappings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { nameof(AddressLine1), "address1" },
        { nameof(City), "city" },
        { nameof(State), "state" },
        { nameof(Postal), "postalcode" },
        { nameof(FreeForm), "ff" },
        { nameof(Thoroughfare), "thoroughfare" },
        { nameof(Locality), "locality" },
        { nameof(AdministrativeArea), "administrativearea" },
        { nameof(Country), "country" },
        { nameof(MaxRecords), "maxrecords" },
        { nameof(Opt), "opt" },
        { nameof(Cols), "cols" },
        { nameof(NativeCharSet), "nativecharset" }
    };

    // Private backing fields
    private string _addressLine1;
    private string _city;
    private string _state;
    private string _postal;
    private string _freeForm;
    private string _thoroughfare;
    private string _locality;
    private string _administrativeArea;
    private string _country;
    private string _maxRecords;
    private string _opt;
    private string _cols;
    private string _nativeCharSet;

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

    public string FreeForm
    {
      get => _freeForm;
      set
      {
        _freeForm = value;
        parameters[parameterMappings[nameof(FreeForm)]] = value;
      }
    }

    public string Thoroughfare
    {
      get => _thoroughfare;
      set
      {
        _thoroughfare = value;
        parameters[parameterMappings[nameof(Thoroughfare)]] = value;
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

    public string Country
    {
      get => _country;
      set
      {
        _country = value;
        parameters[parameterMappings[nameof(Country)]] = value;
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

    public string NativeCharSet
    {
      get => _nativeCharSet;
      set
      {
        _nativeCharSet = value;
        parameters[parameterMappings[nameof(NativeCharSet)]] = value;
      }
    }

    public GlobalExpressEntry(string license = null) : base("https://expressentry.melissadata.net", "/web/GlobalExpressAddress")
    {
      this.License = license ?? Environment.GetEnvironmentVariable("MD_LICENSE");
      this.parameters["format"] = "json";
    }

    // Setters
    public void SetAddressLine1(string addressLine1)
    {
      this.parameters["address1"] = addressLine1;
      this.AddressLine1 = addressLine1;
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
      this.parameters["postalcode"] = postal;
      this.Postal = postal;
    }

    public void SetFreeForm(string freeForm)
    {
      this.parameters["ff"] = freeForm;
      this.FreeForm = freeForm;
    }

    public void SetThoroughfare(string thoroughfare)
    {
      this.parameters["thoroughfare"] = thoroughfare;
      this.Thoroughfare = thoroughfare;
    }

    public void SetLocality(string locality)
    {
      this.parameters["locality"] = locality;
      this.Locality = locality;
    }

    public void SetAdministrativeArea(string administrativeArea)
    {
      this.parameters["administrativearea"] = administrativeArea;
      this.AdministrativeArea = administrativeArea;
    }

    public void SetCountry(string country) 
    {
      this.parameters["country"] = country;
      this.Country = country;
    }

    public void SetMaxRecords(string maxRecords)
    {
      this.parameters["maxrecords"] = maxRecords;
      this.MaxRecords = maxRecords;
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

    public void SetNativeCharSet(string nativeCharSet)
    {
      this.parameters["nativecharset"] = nativeCharSet;
      this.NativeCharSet = nativeCharSet;
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
    public string GetAddressLine1() 
    {
      return this.parameters.ContainsKey("address1") ? this.parameters["address1"] : "";
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
      return this.parameters.ContainsKey("postalcode") ? this.parameters["postalcode"] : "";
    }
    
    public string GetFreeForm() 
    {
      return this.parameters.ContainsKey("ff") ? this.parameters["ff"] : "";
    }
    
    public string GetThoroughfare() 
    {
      return this.parameters.ContainsKey("thoroughfare") ? this.parameters["thoroughfare"] : "";
    } 
    
    public string GetLocality() 
    {
      return this.parameters.ContainsKey("locality") ? this.parameters["locality"] : "";
    }
    
    public string GetAdministrativeArea() 
    {
      return this.parameters.ContainsKey("administrativearea") ? this.parameters["administrativearea"] : "";
    }
    
    public string GetCountry() 
    {
      return this.parameters.ContainsKey("country") ? this.parameters["country"] : "";
    }
    
    public string GetMaxRecords() 
    {
      return this.parameters.ContainsKey("maxrecords") ? this.parameters["maxrecords"] : "";
    }
    
    public string GetOpt() 
    {
      return this.parameters.ContainsKey("opt") ? this.parameters["opt"] : "";
    }
    
    public string GetCols() 
    {
      return this.parameters.ContainsKey("cols") ? this.parameters["cols"] : "";
    }
    
    public string GetNativeCharSet() 
    {
      return this.parameters.ContainsKey("nativecharset") ? this.parameters["nativecharset"] : "";
    }

    /// <summary>
    /// This synchronous function sends the CloudAPI request using the /web/GlobalExpressAddress endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public T GetGlobalExpressAddress<T>()
    {
      this.SetEndpoint("/web/GlobalExpressAddress");

      return Get<T>();
    }

    /// <summary>
    /// This asynchronous function sends the CloudAPI request using the /web/GlobalExpressAddress endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public async Task<T> GetGlobalExpressAddressAsync<T>()
    {
      this.SetEndpoint("/web/GlobalExpressAddress");

      return await GetAsync<T>();
    }

    /// <summary>
    /// This synchronous function sends the CloudAPI request using the /web/GlobalExpressLocalityAdministrativeArea endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public T GetGlobalExpressLocalityAdministrativeArea<T>()
    {
      this.SetEndpoint("/web/GlobalExpressLocalityAdministrativeArea");

      return Get<T>();
    }

    /// <summary>
    /// This asynchronous function sends the CloudAPI request using the /web/GlobalExpressLocalityAdministrativeArea endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public async Task<T> GetGlobalExpressLocalityAdministrativeAreaAsync<T>()
    {
      this.SetEndpoint("/web/GlobalExpressLocalityAdministrativeArea");

      return await GetAsync<T>();
    }

    /// <summary>
    /// This synchronous function sends the CloudAPI request using the /web/GlobalExpressCountry endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public T GetGlobalExpressCountry<T>()
    {
      this.SetEndpoint("/web/GlobalExpressCountry");

      return Get<T>();
    }

    /// <summary>
    /// This asynchronous function sends the CloudAPI request using the /web/GlobalExpressCountry endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public async Task<T> GetGlobalExpressCountryAsync<T>()
    {
      this.SetEndpoint("/web/GlobalExpressCountry");

      return await GetAsync<T>();
    }

    /// <summary>
    /// This synchronous function sends the CloudAPI request using the /web/GlobalExpressFreeForm endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public T GetGlobalExpressFreeForm<T>()
    {
      this.SetEndpoint("/web/GlobalExpressFreeForm");

      return Get<T>();
    }

    /// <summary>
    /// This asynchronous function sends the CloudAPI request using the /web/GlobalExpressFreeForm endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public async Task<T> GetGlobalExpressFreeFormAsync<T>()
    {
      this.SetEndpoint("/web/GlobalExpressFreeForm");

      return await GetAsync<T>();
    }

    /// <summary>
    /// This synchronous function sends the CloudAPI request using the /web/GlobalExpressPostalCode endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public T GetGlobalExpressPostalCode<T>()
    {
      this.SetEndpoint("/web/GlobalExpressPostalCode");

      return Get<T>();
    }

    /// <summary>
    /// This asynchronous function sends the CloudAPI request using the /web/GlobalExpressPostalCode endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public async Task<T> GetGlobalExpressPostalCodeAsync<T>()
    {
      this.SetEndpoint("/web/GlobalExpressPostalCode");

      return await GetAsync<T>();
    }

    /// <summary>
    /// This synchronous function sends the CloudAPI request using the /web/GlobalExpressThoroughfare endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public T GetGlobalExpressThoroughfare<T>()
    {
      this.SetEndpoint("/web/GlobalExpressThoroughfare");

      return Get<T>();
    }

    /// <summary>
    /// This asynchronous function sends the CloudAPI request using the /web/GlobalExpressThoroughfare endpoint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>a string or deserialized response object</returns>
    public async Task<T> GetGlobalExpressThoroughfareAsync<T>()
    {
      this.SetEndpoint("/web/GlobalExpressThoroughfare");

      return await GetAsync<T>();
    }

    /// <summary>
    /// This synchronous function makes a getversion request and parses the response for the cloud api specific version
    /// </summary>
    /// <returns>returns the Cloud API version</returns>
    public string GetApiVersion()
    {
      string jsonResponse = SendVersionRequest();

      JObject responseObject = JObject.Parse(jsonResponse);

      string businessCoderVersion = (string)responseObject["BuildNumber"];

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

      string businessCoderVersion = (string)responseObject["BuildNumber"];

      return businessCoderVersion;
    }
  }
}
