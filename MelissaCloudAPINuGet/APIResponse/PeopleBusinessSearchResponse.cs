using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class PeopleBusinessSearchResponse : ResponseBase
  {
    public string Version { get; set; }
    public string TransmissionReference { get; set; }
    public string ResultCode { get; set; }
    public string TotalRecords { get; set; }
    public List<PeopleBusinessSearchResult> Results { get; set; }

    // Setters
    public void SetVersion(string version)
    {
      this.Version = version;
    }

    public void SetTransmissionReference(string transmissionReference)
    {
      this.TransmissionReference = transmissionReference;
    }

    public void SetResultCode(string resultCode)
    {
      this.ResultCode = resultCode;
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

    public string GetResultCode()
    {
      return string.IsNullOrEmpty(this.ResultCode) ? "" : this.ResultCode;
    }

    public string GetTotalRecords()
    {
      return string.IsNullOrEmpty(this.TotalRecords) ? "" : this.TotalRecords;
    }
  }

  public class PeopleBusinessSearchResult : ResponseBase
  {
    public string MatchLevel { get; set; }
    public PeopleBusinessSearchAddress Address { get; set; }
    public PeopleBusinessSearchConsumer Consumer { get; set; }
    public PeopleBusinessSearchPhone Phone { get; set; }

    // Setters
    public void SetMatchLevel(string matchLevel)
    {
      this.MatchLevel = matchLevel;
    }

    // Getters
    public string GetMatchLevel()
    {
      return string.IsNullOrEmpty(this.MatchLevel) ? "" : this.MatchLevel;
    }
  }

  public class PeopleBusinessSearchAddress : ResponseBase
  {
    public string Address1 { get; set; }  
    public string DependentLocality { get; set; }
    public string Locality { get; set; }
    public string LocalityAlternates { get; set; }
    public string AdministrativeArea { get; set; }
    public string CountryCode { get; set; }
    public string CountryName { get; set; }
    public string Thoroughfare { get; set; }
    public string ThoroughfarePreDirection { get; set; }
    public string ThoroughfareName { get; set; }
    public string ThoroughfareTrailingType { get; set; }
    public string ThoroughfarePostDirection { get; set; }
    public string Premises { get; set; }
    public string PremiseType { get; set; }
    public string PremiseNumber { get; set; }
    public string SubPremises { get; set; }
    public string SubPremiseType { get; set; }
    public string SubPremiseNumber { get; set; }
    public string PostalCode { get; set; }
    public string PostalCodeSecondary { get; set; }
    public string MelissaAddressKey { get; set; }
    public string MelissaAddressKeyBase { get; set; }

    // Setters
    public void SetAddress1(string address1)
    {
      this.Address1 = address1;
    }

    public void SetDependentLocality(string dependentLocality)
    {
      this.DependentLocality = dependentLocality;
    }

    public void SetLocality(string locality)
    {
      this.Locality = locality;
    }

    public void SetLocalityAlternates(string localityAlternates)
    {
      this.LocalityAlternates = localityAlternates;
    }

    public void SetAdministrativeArea(string administrativeArea)
    {
      this.AdministrativeArea = administrativeArea;
    }

    public void SetCountryCode(string countryCode)
    {
      this.CountryCode = countryCode;
    }

    public void SetCountryName(string countryName)
    {
      this.CountryName = countryName;
    }

    public void SetThoroughfare(string thoroughfare)
    {
      this.Thoroughfare = thoroughfare;
    }

    public void SetThoroughfarePreDirection(string thoroughfarePreDirection)
    {
      this.ThoroughfarePreDirection = thoroughfarePreDirection;
    }

    public void SetThoroughfareName(string thoroughfareName)
    {
      this.ThoroughfareName = thoroughfareName;
    }

    public void SetThoroughfareTrailingType(string thoroughfareTrailingType)
    {
      this.ThoroughfareTrailingType = thoroughfareTrailingType;
    }

    public void SetThoroughfarePostDirection(string thoroughfarePostDirection)
    {
      this.ThoroughfarePostDirection = thoroughfarePostDirection;
    }

    public void SetPremises(string premises)
    {
      this.Premises = premises;
    }

    public void SetPremiseType(string premiseType)
    {
      this.PremiseType = premiseType;
    }

    public void SetPremiseNumber(string premiseNumber)
    {
      this.PremiseNumber = premiseNumber;
    }

    public void SetSubPremises(string subPremises)
    {
      this.SubPremises = subPremises;
    }

    public void SetSubPremiseType(string subPremiseType)
    {
      this.SubPremiseType = subPremiseType;
    }

    public void SetSubPremiseNumber(string subPremiseNumber)
    {
      this.SubPremiseNumber = subPremiseNumber;
    }

    public void SetPostalCode(string postalCode)
    {
      this.PostalCode = postalCode;
    }

    public void SetPostalCodeSecondary(string postalCodeSecondary)
    {
      this.PostalCodeSecondary = postalCodeSecondary;
    }

    public void SetMelissaAddressKey(string melissaAddressKey)
    {
      this.MelissaAddressKey = melissaAddressKey;
    }

    public void SetMelissaAddressKeyBase(string melissaAddressKeyBase)
    {
      this.MelissaAddressKeyBase = melissaAddressKeyBase;
    }

    // Getters
    public string GetAddress1()
    {
      return string.IsNullOrEmpty(this.Address1) ? "" : this.Address1;
    }

    public string GetDependentLocality()
    {
      return string.IsNullOrEmpty(this.DependentLocality) ? "" : this.DependentLocality;
    }

    public string GetLocality()
    {
      return string.IsNullOrEmpty(this.Locality) ? "" : this.Locality;
    }

    public string GetLocalityAlternates()
    {
      return string.IsNullOrEmpty(this.LocalityAlternates) ? "" : this.LocalityAlternates;
    }

    public string GetAdministrativeArea()
    {
      return string.IsNullOrEmpty(this.AdministrativeArea) ? "" : this.AdministrativeArea;
    }

    public string GetCountryCode()
    {
      return string.IsNullOrEmpty(this.CountryCode) ? "" : this.CountryCode;
    }

    public string GetCountryName()
    {
      return string.IsNullOrEmpty(this.CountryName) ? "" : this.CountryName;
    }

    public string GetThoroughfare()
    {
      return string.IsNullOrEmpty(this.Thoroughfare) ? "" : this.Thoroughfare;
    }

    public string GetThoroughfarePreDirection()
    {
      return string.IsNullOrEmpty(this.ThoroughfarePreDirection) ? "" : this.ThoroughfarePreDirection;
    }

    public string GetThoroughfareName()
    {
      return string.IsNullOrEmpty(this.ThoroughfareName) ? "" : this.ThoroughfareName;
    }

    public string GetThoroughfareTrailingType()
    {
      return string.IsNullOrEmpty(this.ThoroughfareTrailingType) ? "" : this.ThoroughfareTrailingType;
    }

    public string GetThoroughfarePostDirection()
    {
      return string.IsNullOrEmpty(this.ThoroughfarePostDirection) ? "" : this.ThoroughfarePostDirection;
    }

    public string GetPremises()
    {
      return string.IsNullOrEmpty(this.Premises) ? "" : this.Premises;
    }

    public string GetPremiseType()
    {
      return string.IsNullOrEmpty(this.PremiseType) ? "" : this.PremiseType;
    }

    public string GetPremiseNumber()
    {
      return string.IsNullOrEmpty(this.PremiseNumber) ? "" : this.PremiseNumber;
    }

    public string GetSubPremises()
    {
      return string.IsNullOrEmpty(this.SubPremises) ? "" : this.SubPremises;
    }

    public string GetSubPremiseType()
    {
      return string.IsNullOrEmpty(this.SubPremiseType) ? "" : this.SubPremiseType;
    }

    public string GetSubPremiseNumber()
    {
      return string.IsNullOrEmpty(this.SubPremiseNumber) ? "" : this.SubPremiseNumber;
    }

    public string GetPostalCode()
    {
      return string.IsNullOrEmpty(this.PostalCode) ? "" : this.PostalCode;
    }

    public string GetPostalCodeSecondary()
    {
      return string.IsNullOrEmpty(this.PostalCodeSecondary) ? "" : this.PostalCodeSecondary;
    }

    public string GetMelissaAddressKey()
    {
      return string.IsNullOrEmpty(this.MelissaAddressKey) ? "" : this.MelissaAddressKey;
    }

    public string GetMelissaAddressKeyBase()
    {
      return string.IsNullOrEmpty(this.MelissaAddressKeyBase) ? "" : this.MelissaAddressKeyBase;
    }
  }

  public class PeopleBusinessSearchConsumer : ResponseBase
  {
    public string FullName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string Suffix { get; set; }
    public string OtherFullNames { get; set; }
    public string MelissaIdentityKey { get; set; }

    // Setters
    public void SetFullName(string fullName)
    {
      this.FullName = fullName;
    }

    public void SetFirstName(string firstName)
    {
      this.FirstName = firstName;
    }

    public void SetMiddleName(string middleName)
    {
      this.MiddleName = middleName;
    }

    public void SetLastName(string lastName)
    {
      this.LastName = lastName;
    }

    public void SetSuffix(string suffix)
    {
      this.Suffix = suffix;
    }

    public void SetOtherFullNames(string otherFullNames)
    {
      this.OtherFullNames = otherFullNames;
    }

    public void SetMelissaIdentityKey(string melissaIdentityKey)
    {
      this.MelissaIdentityKey = melissaIdentityKey;
    }

    // Getters
    public string GetFullName()
    {
      return string.IsNullOrEmpty(this.FullName) ? "" : this.FullName;
    }

    public string GetFirstName()
    {
      return string.IsNullOrEmpty(this.FirstName) ? "" : this.FirstName;
    }

    public string GetMiddleName()
    {
      return string.IsNullOrEmpty(this.MiddleName) ? "" : this.MiddleName;
    }

    public string GetLastName()
    {
      return string.IsNullOrEmpty(this.LastName) ? "" : this.LastName;
    }

    public string GetSuffix()
    {
      return string.IsNullOrEmpty(this.Suffix) ? "" : this.Suffix;
    }

    public string GetOtherFullNames()
    {
      return string.IsNullOrEmpty(this.OtherFullNames) ? "" : this.OtherFullNames;
    }

    public string GetMelissaIdentityKey()
    {
      return string.IsNullOrEmpty(this.MelissaIdentityKey) ? "" : this.MelissaIdentityKey;
    }
  }

  public class PeopleBusinessSearchPhone : ResponseBase
  {
    public string Phone { get; set; }
    public string OtherPhones { get; set; }

    // Setters
    public void SetPhone(string phone)
    {
      this.Phone = phone;
    }

    public void SetOtherPhones(string otherPhones)
    {
      this.OtherPhones = otherPhones;
    }

    // Getters
    public string GetPhone()
    {
      return string.IsNullOrEmpty(this.Phone) ? "" : this.Phone;
    }

    public string GetOtherPhones()
    {
      return string.IsNullOrEmpty(this.OtherPhones) ? "" : this.OtherPhones;
    }
  }
}
