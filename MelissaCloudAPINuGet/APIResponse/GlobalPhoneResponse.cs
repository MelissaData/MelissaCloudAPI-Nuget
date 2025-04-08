using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class GlobalPhoneResponse : ResponseBase
  {
    public string Version { get; set; }
    public string TransmissionReference { get; set; }
    public string TransmissionResults { get; set; }
    public string TotalRecords { get; set; }
    public List<GlobalPhoneRecord> Records { get; set; }

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

    public string GetTotalRecords()
    {
      return string.IsNullOrEmpty(this.TotalRecords) ? "" : this.TotalRecords;
    }
  }

  public class GlobalPhoneRecord : ResponseBase
  {
    public string RecordID { get; set; }
    public string Results { get; set; }
    public string PhoneNumber { get; set; }
    public string AdministrativeArea { get; set; }
    public string CountryAbbreviation { get; set; }
    public string CountryName { get; set; }
    public string Carrier { get; set; }
    public string CallerID { get; set; }
    public string DST { get; set; }
    public string InternationalPhoneNumber { get; set; }
    public string Language { get; set; }
    public string Latitude { get; set; }
    public string Locality { get; set; }
    public string Longitude { get; set; }
    public string PhoneInternationalPrefix { get; set; }
    public string PhoneCountryDialingCode { get; set; }
    public string PhoneNationPrefix { get; set; }
    public string PhoneNationalDestinationCode { get; set; }
    public string PhoneSubscriberNumber { get; set; }
    public string UTC { get; set; }
    public string PostalCode { get; set; }
    public string Suggestions { get; set; }
    public string TimeZoneCode { get; set; }
    public string TimeZoneName { get; set; }

    // Setters
    public void SetRecordID(string recordID)
    {
      this.RecordID = recordID;
    }

    public void SetResults(string results)
    {
      this.Results = results;
    }

    public void SetPhoneNumber(string phoneNumber)
    {
      this.PhoneNumber = phoneNumber;
    }

    public void SetAdministrativeArea(string administrativeArea)
    {
      this.AdministrativeArea = administrativeArea;
    }

    public void SetCountryAbbreviation(string countryAbbreviation)
    {
      this.CountryAbbreviation = countryAbbreviation;
    }

    public void SetCountryName(string countryName)
    {
      this.CountryName = countryName;
    }

    public void SetCarrier(string carrier)
    {
      this.Carrier = carrier;
    }

    public void SetCallerID(string callerID)
    {
      this.CallerID = callerID;
    }

    public void SetDST(string dst)
    {
      this.DST = dst;
    }

    public void SetInternationalPhoneNumber(string internationalPhoneNumber)
    {
      this.InternationalPhoneNumber = internationalPhoneNumber;
    }

    public void SetLanguage(string language)
    {
      this.Language = language;
    }

    public void SetLatitude(string latitude)
    {
      this.Latitude = latitude;
    }

    public void SetLocality(string locality)
    {
      this.Locality = locality;
    }

    public void SetLongitude(string longitude)
    {
      this.Longitude = longitude;
    }

    public void SetPhoneInternationalPrefix(string phoneInternationalPrefix)
    {
      this.PhoneInternationalPrefix = phoneInternationalPrefix;
    }

    public void SetPhoneCountryDialingCode(string phoneCountryDialingCode)
    {
      this.PhoneCountryDialingCode = phoneCountryDialingCode;
    }

    public void SetPhoneNationPrefix(string phoneNationPrefix)
    {
      this.PhoneNationPrefix = phoneNationPrefix;
    }

    public void SetPhoneNationalDestinationCode(string phoneNationalDestinationCode)
    {
      this.PhoneNationalDestinationCode = phoneNationalDestinationCode;
    }

    public void SetPhoneSubscriberNumber(string phoneSubscriberNumber)
    {
      this.PhoneSubscriberNumber = phoneSubscriberNumber;
    }

    public void SetUTC(string utc)
    {
      this.UTC = utc;
    }

    public void SetPostalCode(string postalCode)
    {
      this.PostalCode = postalCode;
    }

    public void SetSuggestions(string suggestions)
    {
      this.Suggestions = suggestions;
    }

    public void SetTimeZoneCode(string timeZoneCode)
    {
      this.TimeZoneCode = timeZoneCode;
    }

    public void SetTimeZoneName(string timeZoneName)
    {
      this.TimeZoneName = timeZoneName;
    }

    // Getters
    public string GetRecordID()
    {
      return string.IsNullOrEmpty(this.RecordID) ? "" : this.RecordID;
    }

    public string GetResults()
    {
      return string.IsNullOrEmpty(this.Results) ? "" : this.Results;
    }

    public string GetPhoneNumber()
    {
      return string.IsNullOrEmpty(this.PhoneNumber) ? "" : this.PhoneNumber;
    }

    public string GetAdministrativeArea()
    {
      return string.IsNullOrEmpty(this.AdministrativeArea) ? "" : this.AdministrativeArea;
    }

    public string GetCountryAbbreviation()
    {
      return string.IsNullOrEmpty(this.CountryAbbreviation) ? "" : this.CountryAbbreviation;
    }

    public string GetCountryName()
    {
      return string.IsNullOrEmpty(this.CountryName) ? "" : this.CountryName;
    }

    public string GetCarrier()
    {
      return string.IsNullOrEmpty(this.Carrier) ? "" : this.Carrier;
    }

    public string GetCallerID()
    {
      return string.IsNullOrEmpty(this.CallerID) ? "" : this.CallerID;
    }

    public string GetDST()
    {
      return string.IsNullOrEmpty(this.DST) ? "" : this.DST;
    }

    public string GetInternationalPhoneNumber()
    {
      return string.IsNullOrEmpty(this.InternationalPhoneNumber) ? "" : this.InternationalPhoneNumber;
    }

    public string GetLanguage()
    {
      return string.IsNullOrEmpty(this.Language) ? "" : this.Language;
    }

    public string GetLatitude()
    {
      return string.IsNullOrEmpty(this.Latitude) ? "" : this.Latitude;
    }

    public string GetLocality()
    {
      return string.IsNullOrEmpty(this.Locality) ? "" : this.Locality;
    }

    public string GetLongitude()
    {
      return string.IsNullOrEmpty(this.Longitude) ? "" : this.Longitude;
    }

    public string GetPhoneInternationalPrefix()
    {
      return string.IsNullOrEmpty(this.PhoneInternationalPrefix) ? "" : this.PhoneInternationalPrefix;
    }

    public string GetPhoneCountryDialingCode()
    {
      return string.IsNullOrEmpty(this.PhoneCountryDialingCode) ? "" : this.PhoneCountryDialingCode;
    }

    public string GetPhoneNationPrefix()
    {
      return string.IsNullOrEmpty(this.PhoneNationPrefix) ? "" : this.PhoneNationPrefix;
    }

    public string GetPhoneNationalDestinationCode()
    {
      return string.IsNullOrEmpty(this.PhoneNationalDestinationCode) ? "" : this.PhoneNationalDestinationCode;
    }

    public string GetPhoneSubscriberNumber()
    {
      return string.IsNullOrEmpty(this.PhoneSubscriberNumber) ? "" : this.PhoneSubscriberNumber;
    }

    public string GetUTC()
    {
      return string.IsNullOrEmpty(this.UTC) ? "" : this.UTC;
    }

    public string GetPostalCode()
    {
      return string.IsNullOrEmpty(this.PostalCode) ? "" : this.PostalCode;
    }

    public string GetSuggestions()
    {
      return string.IsNullOrEmpty(this.Suggestions) ? "" : this.Suggestions;
    }

    public string GetTimeZoneCode()
    {
      return string.IsNullOrEmpty(this.TimeZoneCode) ? "" : this.TimeZoneCode;
    }

    public string GetTimeZoneName()
    {
      return string.IsNullOrEmpty(this.TimeZoneName) ? "" : this.TimeZoneName;
    }
  }
}
