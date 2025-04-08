using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MelissaData.CloudAPI
{
  public class PersonatorIdentity : CloudAPIBase
  {
    public PersonatorIdentityRecordRequest PostBody { get; set; }

    private readonly Dictionary<string, string> parameterMappings = new(StringComparer.OrdinalIgnoreCase)
    {
        { nameof(Action), "act" },
        { nameof(NationalID), "nat" },
        { nameof(FirstName), "first" },
        { nameof(LastName), "last" },
        { nameof(FullName), "full" },
        { nameof(Company), "comp" },
        { nameof(Phone), "phone" },
        { nameof(Email), "email" },
        { nameof(DOB), "dob" },
        { nameof(AccountNumber), "accountNumber" },
        { nameof(AddressLine1), "a1" },
        { nameof(AddressLine2), "a2" },
        { nameof(AddressLine3), "a3" },
        { nameof(AddressLine4), "a4" },
        { nameof(AddressLine5), "a5" },
        { nameof(AddressLine6), "a6" },
        { nameof(AddressLine7), "a7" },
        { nameof(AddressLine8), "a8" },
        { nameof(Locality), "loc" },
        { nameof(AdministrativeArea), "admarea" },
        { nameof(Postal), "postal" },
        { nameof(Country), "ctry" },
        { nameof(CountryOrigin), "ctryOrg" },
        { nameof(TransmissionReference), "t" },
        { nameof(AddressOpt), "addrOpt" },
        { nameof(NameOpt), "nameOpt" },
        { nameof(EmailOpt), "emailOpt" },
        { nameof(PhoneOpt), "phoneOpt" },
        { nameof(Opt), "opt" },
        { nameof(Privacy), "privacy" }
    };

    // Private backing fields
    private string _action;
    private string _nationalId;
    private string _firstName;
    private string _lastName;
    private string _fullName;
    private string _company;
    private string _phone;
    private string _email;
    private string _dob;
    private string _accountNumber;
    private string _addressLine1;
    private string _addressLine2;
    private string _addressLine3;
    private string _addressLine4;
    private string _addressLine5;
    private string _addressLine6;
    private string _addressLine7;
    private string _addressLine8;
    private string _locality;
    private string _administrativeArea;
    private string _postal;
    private string _country;
    private string _countryOrigin;
    private string _transmissionReference;
    private string _addressOpt;
    private string _nameOpt;
    private string _emailOpt;
    private string _phoneOpt;
    private string _opt;
    private string _privacy;

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

    public string NationalID
    {
      get => _nationalId;
      set
      {
        _nationalId = value;
        parameters[parameterMappings[nameof(NationalID)]] = value;
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

    public string Email
    {
      get => _email;
      set
      {
        _email = value;
        parameters[parameterMappings[nameof(Email)]] = value;
      }
    }

    public string DOB
    {
      get => _dob;
      set
      {
        _dob = value;
        parameters[parameterMappings[nameof(DOB)]] = value;
      }
    }

    public string AccountNumber
    {
      get => _accountNumber;
      set
      {
        _accountNumber = value;
        parameters[parameterMappings[nameof(AccountNumber)]] = value;
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

    public string AddressOpt
    {
      get => _addressOpt;
      set
      {
        _addressOpt = value;
        parameters[parameterMappings[nameof(AddressOpt)]] = value;
      }
    }

    public string NameOpt
    {
      get => _nameOpt;
      set
      {
        _nameOpt = value;
        parameters[parameterMappings[nameof(NameOpt)]] = value;
      }
    }

    public string EmailOpt
    {
      get => _emailOpt;
      set
      {
        _emailOpt = value;
        parameters[parameterMappings[nameof(EmailOpt)]] = value;
      }
    }

    public string PhoneOpt
    {
      get => _phoneOpt;
      set
      {
        _phoneOpt = value;
        parameters[parameterMappings[nameof(PhoneOpt)]] = value;
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

    public string Privacy
    {
      get => _privacy;
      set
      {
        _privacy = value;
        parameters[parameterMappings[nameof(Privacy)]] = value;
      }
    }

    public PersonatorIdentity(string license = null) : base("https://globalpersonator.melissadata.net", "/v1/doContactVerify")
    {
      this.License = license ?? Environment.GetEnvironmentVariable("MD_LICENSE");
      this.parameters["format"] = "json";
      this.PostBody = new PersonatorIdentityRecordRequest();
    }

    // Setters
    public void SetAction(string action)
    {
      this.parameters["act"] = action;
      this.Action = action;
    }

    public void SetNationalID(string nationalId) 
    {
      this.parameters["nat"] = nationalId;
      this.NationalID = nationalId;
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

    public void SetEmail(string email)
    {
      this.parameters["email"] = email;
      this.Email = email;
    }

    public void SetDOB(string dob)
    {
      this.parameters["dob"] = dob;
      this.DOB = dob;
    }

    public void SetAccountNumber(string accountNumber)
    {
      this.parameters["accountNumber"] = accountNumber;
      this.AccountNumber = accountNumber;
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

    public void SetAddressOpt(string addressOpt)
    {
      this.parameters["addrOpt"] = addressOpt;
      this.AddressOpt = addressOpt;
    }

    public void SetNameOpt(string nameOpt)
    {
      this.parameters["nameOpt"] = nameOpt;
      this.NameOpt = nameOpt;
    }

    public void SetEmailOpt(string emailOpt)
    {
      this.parameters["emailOpt"] = emailOpt;
      this.EmailOpt = emailOpt;
    }

    public void SetPhoneOpt(string phoneOpt)
    {
      this.parameters["phoneOpt"] = phoneOpt;
      this.PhoneOpt = phoneOpt;
    }

    public void SetOpt(string opt)
    {
      this.parameters["opt"] = opt;
      this.Opt = opt;
    }

    public void SetPrivacy(string privacy)
    {
      this.parameters["privacy"] = privacy;
      this.Privacy = privacy;
    }

    public void SetPostBody(PersonatorIdentityRecordRequest postBody)
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

    public string GetNationalID()
    {
      return this.parameters.ContainsKey("nat") ? this.parameters["nat"] : "";
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

    public string GetCompany()
    {
      return this.parameters.ContainsKey("comp") ? this.parameters["comp"] : "";
    }

    public string GetPhone()
    {
      return this.parameters.ContainsKey("phone") ? this.parameters["phone"] : "";
    }

    public string GetEmail()
    {
      return this.parameters.ContainsKey("email") ? this.parameters["email"] : "";
    }

    public string GetDOB()
    {
      return this.parameters.ContainsKey("dob") ? this.parameters["dob"] : "";
    }

    public string GetAccountNumber()
    {
      return this.parameters.ContainsKey("accountNumber") ? this.parameters["accountNumber"] : "";
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

    public string GetAddressOpt()
    {
      return this.parameters.ContainsKey("addrOpt") ? this.parameters["addrOpt"] : "";
    }

    public string GetNameOpt()
    {
      return this.parameters.ContainsKey("nameOpt") ? this.parameters["nameOpt"] : "";
    }

    public string GetEmailOpt()
    {
      return this.parameters.ContainsKey("emailOpt") ? this.parameters["emailOpt"] : "";
    }

    public string GetPhoneOpt()
    {
      return this.parameters.ContainsKey("phoneOpt") ? this.parameters["phoneOpt"] : "";
    }

    public string GetOpt()
    {
      return this.parameters.ContainsKey("opt") ? this.parameters["opt"] : "";
    }

    public string GetPrivacy()
    {
      return this.parameters.ContainsKey("privacy") ? this.parameters["privacy"] : "";
    }

    public PersonatorIdentityRecordRequest GetPostBody()
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
    /// This synchronous function sends a post request to the Cloud API
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

      string businessCoderVersion = (string)responseObject["GlobalPersonatorVersion"];

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

      string businessCoderVersion = (string)responseObject["GlobalPersonatorVersion"];

      return businessCoderVersion;
    }
  }
}
