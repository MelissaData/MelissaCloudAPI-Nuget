using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class ExpressEntryResponse : ResponseBase
  {
    public string Version { get; set; }
    public string ResultCode { get; set; }
    public string ErrorString { get; set; }
    public List<ExpressEntryRecord> Results { get; set; }

    // Setters
    public void SetVersion(string version)
    {
      this.Version = version;
    }

    public void SetResultCode(string resultCode)
    {
      this.ResultCode = resultCode;
    }

    public void SetErrorString(string errorString)
    {
      this.ErrorString = errorString;
    }

    // Getters
    public string GetVersion()
    {
      return string.IsNullOrEmpty(this.Version) ? "" : this.Version;
    }

    public string GetResultCode()
    {
      return string.IsNullOrEmpty(this.ResultCode) ? "" : this.ResultCode;
    }

    public string GetErrorString()
    {
      return string.IsNullOrEmpty(this.ErrorString) ? "" : this.ErrorString;
    }
  }

  public class ExpressEntryRecord : ResponseBase
  {
    public ExpressEntryAddress Address { get; set; }
  }

  public class ExpressEntryAddress : ResponseBase
  {
    public string AddressLine1 { get; set; }
    public string City { get; set; }
    public string CityAccepted { get; set; }
    public string CityNotAccepted { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string CountrySubdivisionCode { get; set; }
    public string AddressKey { get; set; }
    public string SuiteName { get; set; }
    public string SuiteCount { get; set; }
    public List<string> SuiteList { get; set; }
    public List<string> PlusFour { get; set; }
    public string MAK { get; set; }
    public string BaseMAK { get; set; }

    // Setters
    public void SetAddressLine1(string addressLine1)
    {
      this.AddressLine1 = addressLine1;
    }

    public void SetCity(string city)
    {
      this.City = city;
    }

    public void SetCityAccepted(string cityAccepted)
    {
      this.CityAccepted = cityAccepted;
    }

    public void SetCityNotAccepted(string cityNotAccepted)
    {
      this.CityNotAccepted = cityNotAccepted;
    }

    public void SetState(string state)
    {
      this.State = state;
    }

    public void SetPostalCode(string postalCode)
    {
      this.PostalCode = postalCode;
    }

    public void SetCountrySubdivisionCode(string countrySubdivisionCode)
    {
      this.CountrySubdivisionCode = countrySubdivisionCode;
    }

    public void SetAddressKey(string addressKey)
    {
      this.AddressKey = addressKey;
    }

    public void SetSuiteName(string suiteName)
    {
      this.SuiteName = suiteName;
    }

    public void SetSuiteCount(string suiteCount)
    {
      this.SuiteCount = suiteCount;
    }

    public void SetMAK(string mak)
    {
      this.MAK = mak;
    }

    public void SetBaseMAK(string baseMak)
    {
      this.BaseMAK = baseMak;
    }

    // Getters
    public string GetAddressLine1()
    {
      return string.IsNullOrEmpty(this.AddressLine1) ? "" : this.AddressLine1;
    }

    public string GetCity()
    {
      return string.IsNullOrEmpty(this.City) ? "" : this.City;
    }

    public string GetCityAccepted()
    {
      return string.IsNullOrEmpty(this.CityAccepted) ? "" : this.CityAccepted;
    }

    public string GetCityNotAccepted()
    {
      return string.IsNullOrEmpty(this.CityNotAccepted) ? "" : this.CityNotAccepted;
    }

    public string GetState()
    {
      return string.IsNullOrEmpty(this.State) ? "" : this.State;
    }

    public string GetPostalCode()
    {
      return string.IsNullOrEmpty(this.PostalCode) ? "" : this.PostalCode;
    }

    public string GetCountrySubdivisionCode()
    {
      return string.IsNullOrEmpty(this.CountrySubdivisionCode) ? "" : this.CountrySubdivisionCode;
    }

    public string GetAddressKey()
    {
      return string.IsNullOrEmpty(this.AddressKey) ? "" : this.AddressKey;
    }

    public string GetSuiteName()
    {
      return string.IsNullOrEmpty(this.SuiteName) ? "" : this.SuiteName;
    }

    public string GetSuiteCount()
    {
      return string.IsNullOrEmpty(this.SuiteCount) ? "" : this.SuiteCount;
    }

    public string GetMAK()
    {
      return string.IsNullOrEmpty(this.MAK) ? "" : this.MAK;
    }

    public string GetBaseMAK()
    {
      return string.IsNullOrEmpty(this.BaseMAK) ? "" : this.BaseMAK;
    }
  }
}
