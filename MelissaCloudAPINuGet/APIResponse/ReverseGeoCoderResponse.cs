using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class ReverseGeoCoderResponse : ResponseBase
  {
    public string Version { get; set; }
    public string TransmissionReference { get; set; }
    public string TransmissionResults { get; set; }
    public string Results { get; set; }
    public string TotalRecords { get; set; }
    public List<ReverseGeoCoderRecord> Records { get; set; }

    // Setters
    public void SetVersion(string version)
    {
      this.Version = version;
    }

    public void SetTransmissionReference(string transmissionReference)
    {
      this.TransmissionReference = transmissionReference;
    }

    public void SetTransmissionResults(string transmissionResults)
    {
      this.TransmissionResults = transmissionResults;
    }

    public void SetResults(string results)
    {
      this.Results = results;
    }

    public void SetTotalRecords(string totalRecords)
    {
      this.TotalRecords = totalRecords;
    }

    // Getters
    public string GetVersion()
    {
      return string.IsNullOrEmpty(this.Version) ? "" : this.Version;
    }

    public string GetTransmissionReference()
    {
      return string.IsNullOrEmpty(this.TransmissionReference) ? "" : this.TransmissionReference;
    }

    public string GetTransmissionResults()
    {
      return string.IsNullOrEmpty(this.TransmissionResults) ? "" : this.TransmissionResults;
    }

    public string GetResults()
    {
      return string.IsNullOrEmpty(this.Results) ? "" : this.Results;
    }

    public string GetTotalRecords()
    {
      return string.IsNullOrEmpty(this.TotalRecords) ? "" : this.TotalRecords;
    }
  }

  public class ReverseGeoCoderRecord : ResponseBase
  {
    // For doLookup endpoint
    public string AddressLine1 { get; set; }
    public string SuiteName { get; set; }
    public string SuiteCount { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string AddressKey { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string Distance { get; set; }
    public string MelissaAddressKey { get; set; }
    public string MelissaAddressKeyBase { get; set; }

    // For doLookupPostalCodes endpoint
    public string CarrierRoute { get; set; }
    public string Laitude { get; set; }

    // For doLookupFromList
    public string RecordID { get; set; }

    // Setters
    public void SetAddressLine1(string addressLine1)
    {
      this.AddressLine1 = addressLine1;
    }

    public void SetSuiteName(string suiteName)
    {
      this.SuiteName = suiteName;
    }

    public void SetSuiteCount(string suiteCount)
    {
      this.SuiteCount = suiteCount;
    }

    public void SetCity(string city)
    {
      this.City = city;
    }

    public void SetState(string state)
    {
      this.State = state;
    }

    public void SetPostalCode(string postalCode)
    {
      this.PostalCode = postalCode;
    }

    public void SetAddressKey(string addressKey)
    {
      this.AddressKey = addressKey;
    }

    public void SetLatitude(string latitude)
    {
      this.Latitude = latitude;
    }

    public void SetLongitude(string longitude)
    {
      this.Longitude = longitude;
    }

    public void SetDistance(string distance)
    {
      this.Distance = distance;
    }

    public void SetMelissaAddressKey(string melissaAddressKey)
    {
      this.MelissaAddressKey = melissaAddressKey;
    }

    public void SetMelissaAddressKeyBase(string melissaAddressKeyBase)
    {
      this.MelissaAddressKeyBase = melissaAddressKeyBase;
    }

    public void SetCarrierRoute(string carrierRoute)
    {
      this.CarrierRoute = carrierRoute;
    }

    public void SetLaitude(string laitude)
    {
      this.Laitude = laitude;
    }

    public void SetRecordID(string recordID)
    {
      this.RecordID = recordID;
    }

    // Getters
    public string GetAddressLine1()
    {
      return string.IsNullOrEmpty(this.AddressLine1) ? "" : this.AddressLine1;
    }

    public string GetSuiteName()
    {
      return string.IsNullOrEmpty(this.SuiteName) ? "" : this.SuiteName;
    }

    public string GetSuiteCount()
    {
      return string.IsNullOrEmpty(this.SuiteCount) ? "" : this.SuiteCount;
    }

    public string GetCity()
    {
      return string.IsNullOrEmpty(this.City) ? "" : this.City;
    }

    public string GetState()
    {
      return string.IsNullOrEmpty(this.State) ? "" : this.State;
    }

    public string GetPostalCode()
    {
      return string.IsNullOrEmpty(this.PostalCode) ? "" : this.PostalCode;
    }

    public string GetAddressKey()
    {
      return string.IsNullOrEmpty(this.AddressKey) ? "" : this.AddressKey;
    }

    public string GetLatitude()
    {
      return string.IsNullOrEmpty(this.Latitude) ? "" : this.Latitude;
    }

    public string GetLongitude()
    {
      return string.IsNullOrEmpty(this.Longitude) ? "" : this.Longitude;
    }

    public string GetDistance()
    {
      return string.IsNullOrEmpty(this.Distance) ? "" : this.Distance;
    }

    public string GetMelissaAddressKey()
    {
      return string.IsNullOrEmpty(this.MelissaAddressKey) ? "" : this.MelissaAddressKey;
    }

    public string GetMelissaAddressKeyBase()
    {
      return string.IsNullOrEmpty(this.MelissaAddressKeyBase) ? "" : this.MelissaAddressKeyBase;
    }

    public string GetCarrierRoute()
    {
      return string.IsNullOrEmpty(this.CarrierRoute) ? "" : this.CarrierRoute;
    }

    public string GetLaitude()
    {
      return string.IsNullOrEmpty(this.Laitude) ? "" : this.Laitude;
    }

    public string GetRecordID()
    {
      return string.IsNullOrEmpty(this.RecordID) ? "" : this.RecordID;
    }
  }
}
