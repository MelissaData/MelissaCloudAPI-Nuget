using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class PersonatorIdentityResponse : ResponseBase
  {
    public string Version { get; set; }
    public string TransmissionReference { get; set; }
    public string TransactionID { get; set; }
    public string Results { get; set; }
    public PersonatorIdentityName Name { get; set; }
    public PersonatorIdentityAddress Address { get; set; }
    public PersonatorIdentityEmail Email { get; set; }
    public PersonatorIdentityPhone Phone { get; set; }
    public PersonatorIdentityIdentity Identity { get; set; }

    // Setters
    public void SetVersion(string version)
    {
      this.Version = version;
    }

    public void SetTransmissionReference(string transmissionReference)
    {
      this.TransmissionReference = transmissionReference;
    }

    public void SetTransactionID(string transactionID)
    {
      this.TransactionID = transactionID;
    }

    public void SetResults(string results)
    {
      this.Results = results;
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

    public string GetTransactionID()
    {
      return string.IsNullOrEmpty(this.TransactionID) ? "" : this.TransactionID;
    }

    public string GetResults()
    {
      return string.IsNullOrEmpty(this.Results) ? "" : this.Results;
    }
  }

  public class PersonatorIdentityName : ResponseBase
  {
    public string Results { get; set; }
    public string Company { get; set; }
    public string NamePrefix { get; set; }
    public string NameFirst { get; set; }
    public string NameMiddle { get; set; } 
    public string NameLast { get; set; }
    public string NameSuffix { get; set; }
    public string Gender { get; set; }
    public string NamePrefix2 { get; set; }
    public string NameFirst2 { get; set; }
    public string NameMiddle2 { get; set; } 
    public string NameLast2 { get; set; }
    public string NameSuffix2 { get; set; }
    public string Gender2 { get; set; }

    // Setters
    public void SetResults(string results)
    {
      this.Results = results;
    }

    public void SetCompany(string company)
    {
      this.Company = company;
    }

    public void SetNamePrefix(string namePrefix)
    {
      this.NamePrefix = namePrefix;
    }

    public void SetNameFirst(string nameFirst)
    {
      this.NameFirst = nameFirst;
    }

    public void SetNameMiddle(string nameMiddle)
    {
      this.NameMiddle = nameMiddle;
    }

    public void SetNameLast(string nameLast)
    {
      this.NameLast = nameLast;
    }

    public void SetNameSuffix(string nameSuffix)
    {
      this.NameSuffix = nameSuffix;
    }

    public void SetGender(string gender)
    {
      this.Gender = gender;
    }

    public void SetNamePrefix2(string namePrefix2)
    {
      this.NamePrefix2 = namePrefix2;
    }

    public void SetNameFirst2(string nameFirst2)
    {
      this.NameFirst2 = nameFirst2;
    }

    public void SetNameMiddle2(string nameMiddle2)
    {
      this.NameMiddle2 = nameMiddle2;
    }

    public void SetNameLast2(string nameLast2)
    {
      this.NameLast2 = nameLast2;
    }

    public void SetNameSuffix2(string nameSuffix2)
    {
      this.NameSuffix2 = nameSuffix2;
    }

    public void SetGender2(string gender2)
    {
      this.Gender2 = gender2;
    }

    // Getters
    public string GetResults()
    {
      return string.IsNullOrEmpty(this.Results) ? "" : this.Results;
    }

    public string GetCompany()
    {
      return string.IsNullOrEmpty(this.Company) ? "" : this.Company;
    }

    public string GetNamePrefix()
    {
      return string.IsNullOrEmpty(this.NamePrefix) ? "" : this.NamePrefix;
    }

    public string GetNameFirst()
    {
      return string.IsNullOrEmpty(this.NameFirst) ? "" : this.NameFirst;
    }

    public string GetNameMiddle()
    {
      return string.IsNullOrEmpty(this.NameMiddle) ? "" : this.NameMiddle;
    }

    public string GetNameLast()
    {
      return string.IsNullOrEmpty(this.NameLast) ? "" : this.NameLast;
    }

    public string GetNameSuffix()
    {
      return string.IsNullOrEmpty(this.NameSuffix) ? "" : this.NameSuffix;
    }

    public string GetGender()
    {
      return string.IsNullOrEmpty(this.Gender) ? "" : this.Gender;
    }

    public string GetNamePrefix2()
    {
      return string.IsNullOrEmpty(this.NamePrefix2) ? "" : this.NamePrefix2;
    }

    public string GetNameFirst2()
    {
      return string.IsNullOrEmpty(this.NameFirst2) ? "" : this.NameFirst2;
    }

    public string GetNameMiddle2()
    {
      return string.IsNullOrEmpty(this.NameMiddle2) ? "" : this.NameMiddle2;
    }

    public string GetNameLast2()
    {
      return string.IsNullOrEmpty(this.NameLast2) ? "" : this.NameLast2;
    }

    public string GetNameSuffix2()
    {
      return string.IsNullOrEmpty(this.NameSuffix2) ? "" : this.NameSuffix2;
    }

    public string GetGender2()
    {
      return string.IsNullOrEmpty(this.Gender2) ? "" : this.Gender2;
    }
  }

  public class PersonatorIdentityAddress : ResponseBase
  {
    public string Results { get; set; }
    public string FormattedAddress { get; set; }
    public string Organization { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string AddressLine3 { get; set; }
    public string AddressLine4 { get; set; }
    public string AddressLine5 { get; set; }
    public string AddressLine6 { get; set; }
    public string AddressLine7 { get; set; }
    public string AddressLine8 { get; set; }
    public string SubPremises { get; set; }
    public string DoubleDependentLocality { get; set; }
    public string DependentLocality { get; set; }
    public string Locality { get; set; }
    public string SubAdministrativeArea { get; set; }
    public string AdministrativeArea { get; set; }
    public string PostalCode { get; set; }
    public string AddressType { get; set; }
    public string AddressKey { get; set; }
    public string SubNationalArea { get; set; }
    public string CountryName { get; set; }
    public string CountryCode { get; set; }
    public string CountryISO3 { get; set; }
    public string CountryNumber { get; set; }
    public string CountrySubdivisionCode { get; set; }
    public string Thoroughfare { get; set; }
    public string ThoroughfarePreDirection { get; set; }
    public string ThoroughfareLeadingType { get; set; }
    public string ThoroughfareName { get; set; }
    public string ThoroughfareTrailingType { get; set; }
    public string ThoroughfarePostDirection { get; set; }
    public string DependentThoroughfare { get; set; }
    public string DependentThoroughfarePreDirection { get; set; }
    public string DependentThoroughfareLeadingType { get; set; }
    public string DependentThoroughfareName { get; set; }
    public string DependentThoroughfareTrailingType { get; set; }
    public string DependentThoroughfarePostDirection { get; set; }
    public string Building { get; set; }
    public string PremisesType { get; set; }
    public string PremisesNumber { get; set; }
    public string SubPremisesType { get; set; }
    public string SubPremisesNumber { get; set; }
    public string PostBox { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }

    // Setters
    public void SetResults(string results)
    {
      this.Results = results;
    }

    public void SetFormattedAddress(string formattedAddress)
    {
      this.FormattedAddress = formattedAddress;
    }

    public void SetOrganization(string organization)
    {
      this.Organization = organization;
    }

    public void SetAddressLine1(string addressLine1)
    {
      this.AddressLine1 = addressLine1;
    }

    public void SetAddressLine2(string addressLine2)
    {
      this.AddressLine2 = addressLine2;
    }

    public void SetAddressLine3(string addressLine3)
    {
      this.AddressLine3 = addressLine3;
    }

    public void SetAddressLine4(string addressLine4)
    {
      this.AddressLine4 = addressLine4;
    }

    public void SetAddressLine5(string addressLine5)
    {
      this.AddressLine5 = addressLine5;
    }

    public void SetAddressLine6(string addressLine6)
    {
      this.AddressLine6 = addressLine6;
    }

    public void SetAddressLine7(string addressLine7)
    {
      this.AddressLine7 = addressLine7;
    }

    public void SetAddressLine8(string addressLine8)
    {
      this.AddressLine8 = addressLine8;
    }

    public void SetSubPremises(string subPremises)
    {
      this.SubPremises = subPremises;
    }

    public void SetDoubleDependentLocality(string doubleDependentLocality)
    {
      this.DoubleDependentLocality = doubleDependentLocality;
    }

    public void SetDependentLocality(string dependentLocality)
    {
      this.DependentLocality = dependentLocality;
    }

    public void SetLocality(string locality)
    {
      this.Locality = locality;
    }

    public void SetSubAdministrativeArea(string subAdministrativeArea)
    {
      this.SubAdministrativeArea = subAdministrativeArea;
    }

    public void SetAdministrativeArea(string administrativeArea)
    {
      this.AdministrativeArea = administrativeArea;
    }

    public void SetPostalCode(string postalCode)
    {
      this.PostalCode = postalCode;
    }

    public void SetAddressType(string addressType)
    {
      this.AddressType = addressType;
    }

    public void SetAddressKey(string addressKey)
    {
      this.AddressKey = addressKey;
    }

    public void SetSubNationalArea(string subNationalArea)
    {
      this.SubNationalArea = subNationalArea;
    }

    public void SetCountryName(string countryName)
    {
      this.CountryName = countryName;
    }

    public void SetCountryCode(string countryCode)
    {
      this.CountryCode = countryCode;
    }

    public void SetCountryISO3(string countryISO3)
    {
      this.CountryISO3 = countryISO3;
    }

    public void SetCountryNumber(string countryNumber)
    {
      this.CountryNumber = countryNumber;
    }

    public void SetCountrySubdivisionCode(string countrySubdivisionCode)
    {
      this.CountrySubdivisionCode = countrySubdivisionCode;
    }

    public void SetThoroughfare(string thoroughfare)
    {
      this.Thoroughfare = thoroughfare;
    }

    public void SetThoroughfarePreDirection(string thoroughfarePreDirection)
    {
      this.ThoroughfarePreDirection = thoroughfarePreDirection;
    }

    public void SetThoroughfareLeadingType(string thoroughfareLeadingType)
    {
      this.ThoroughfareLeadingType = thoroughfareLeadingType;
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

    public void SetDependentThoroughfare(string dependentThoroughfare)
    {
      this.DependentThoroughfare = dependentThoroughfare;
    }

    public void SetDependentThoroughfarePreDirection(string dependentThoroughfarePreDirection)
    {
      this.DependentThoroughfarePreDirection = dependentThoroughfarePreDirection;
    }

    public void SetDependentThoroughfareLeadingType(string dependentThoroughfareLeadingType)
    {
      this.DependentThoroughfareLeadingType = dependentThoroughfareLeadingType;
    }

    public void SetDependentThoroughfareName(string dependentThoroughfareName)
    {
      this.DependentThoroughfareName = dependentThoroughfareName;
    }

    public void SetDependentThoroughfareTrailingType(string dependentThoroughfareTrailingType)
    {
      this.DependentThoroughfareTrailingType = dependentThoroughfareTrailingType;
    }

    public void SetDependentThoroughfarePostDirection(string dependentThoroughfarePostDirection)
    {
      this.DependentThoroughfarePostDirection = dependentThoroughfarePostDirection;
    }

    public void SetBuilding(string building)
    {
      this.Building = building;
    }

    public void SetPremisesType(string premisesType)
    {
      this.PremisesType = premisesType;
    }

    public void SetPremisesNumber(string premisesNumber)
    {
      this.PremisesNumber = premisesNumber;
    }

    public void SetSubPremisesType(string subPremisesType)
    {
      this.SubPremisesType = subPremisesType;
    }

    public void SetSubPremisesNumber(string subPremisesNumber)
    {
      this.SubPremisesNumber = subPremisesNumber;
    }

    public void SetPostBox(string postBox)
    {
      this.PostBox = postBox;
    }

    public void SetLatitude(string latitude)
    {
      this.Latitude = latitude;
    }

    public void SetLongitude(string longitude)
    {
      this.Longitude = longitude;
    }

    // Getters
    public string GetResults()
    {
      return string.IsNullOrEmpty(this.Results) ? "" : this.Results;
    }

    public string GetFormattedAddress()
    {
      return string.IsNullOrEmpty(this.FormattedAddress) ? "" : this.FormattedAddress;
    }

    public string GetOrganization()
    {
      return string.IsNullOrEmpty(this.Organization) ? "" : this.Organization;
    }

    public string GetAddressLine1()
    {
      return string.IsNullOrEmpty(this.AddressLine1) ? "" : this.AddressLine1;
    }

    public string GetAddressLine2()
    {
      return string.IsNullOrEmpty(this.AddressLine2) ? "" : this.AddressLine2;
    }

    public string GetAddressLine3()
    {
      return string.IsNullOrEmpty(this.AddressLine3) ? "" : this.AddressLine3;
    }

    public string GetAddressLine4()
    {
      return string.IsNullOrEmpty(this.AddressLine4) ? "" : this.AddressLine4;
    }

    public string GetAddressLine5()
    {
      return string.IsNullOrEmpty(this.AddressLine5) ? "" : this.AddressLine5;
    }

    public string GetAddressLine6()
    {
      return string.IsNullOrEmpty(this.AddressLine6) ? "" : this.AddressLine6;
    }

    public string GetAddressLine7()
    {
      return string.IsNullOrEmpty(this.AddressLine7) ? "" : this.AddressLine7;
    }

    public string GetAddressLine8()
    {
      return string.IsNullOrEmpty(this.AddressLine8) ? "" : this.AddressLine8;
    }

    public string GetSubPremises()
    {
      return string.IsNullOrEmpty(this.SubPremises) ? "" : this.SubPremises;
    }

    public string GetDoubleDependentLocality()
    {
      return string.IsNullOrEmpty(this.DoubleDependentLocality) ? "" : this.DoubleDependentLocality;
    }

    public string GetDependentLocality()
    {
      return string.IsNullOrEmpty(this.DependentLocality) ? "" : this.DependentLocality;
    }

    public string GetLocality()
    {
      return string.IsNullOrEmpty(this.Locality) ? "" : this.Locality;
    }

    public string GetSubAdministrativeArea()
    {
      return string.IsNullOrEmpty(this.SubAdministrativeArea) ? "" : this.SubAdministrativeArea;
    }

    public string GetAdministrativeArea()
    {
      return string.IsNullOrEmpty(this.AdministrativeArea) ? "" : this.AdministrativeArea;
    }

    public string GetPostalCode()
    {
      return string.IsNullOrEmpty(this.PostalCode) ? "" : this.PostalCode;
    }

    public string GetAddressType()
    {
      return string.IsNullOrEmpty(this.AddressType) ? "" : this.AddressType;
    }

    public string GetAddressKey()
    {
      return string.IsNullOrEmpty(this.AddressKey) ? "" : this.AddressKey;
    }

    public string GetSubNationalArea()
    {
      return string.IsNullOrEmpty(this.SubNationalArea) ? "" : this.SubNationalArea;
    }

    public string GetCountryName()
    {
      return string.IsNullOrEmpty(this.CountryName) ? "" : this.CountryName;
    }

    public string GetCountryCode()
    {
      return string.IsNullOrEmpty(this.CountryCode) ? "" : this.CountryCode;
    }

    public string GetCountryISO3()
    {
      return string.IsNullOrEmpty(this.CountryISO3) ? "" : this.CountryISO3;
    }

    public string GetCountryNumber()
    {
      return string.IsNullOrEmpty(this.CountryNumber) ? "" : this.CountryNumber;
    }

    public string GetCountrySubdivisionCode()
    {
      return string.IsNullOrEmpty(this.CountrySubdivisionCode) ? "" : this.CountrySubdivisionCode;
    }

    public string GetThoroughfare()
    {
      return string.IsNullOrEmpty(this.Thoroughfare) ? "" : this.Thoroughfare;
    }

    public string GetThoroughfarePreDirection()
    {
      return string.IsNullOrEmpty(this.ThoroughfarePreDirection) ? "" : this.ThoroughfarePreDirection;
    }

    public string GetThoroughfareLeadingType()
    {
      return string.IsNullOrEmpty(this.ThoroughfareLeadingType) ? "" : this.ThoroughfareLeadingType;
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

    public string GetDependentThoroughfare()
    {
      return string.IsNullOrEmpty(this.DependentThoroughfare) ? "" : this.DependentThoroughfare;
    }

    public string GetDependentThoroughfarePreDirection()
    {
      return string.IsNullOrEmpty(this.DependentThoroughfarePreDirection) ? "" : this.DependentThoroughfarePreDirection;
    }

    public string GetDependentThoroughfareLeadingType()
    {
      return string.IsNullOrEmpty(this.DependentThoroughfareLeadingType) ? "" : this.DependentThoroughfareLeadingType;
    }

    public string GetDependentThoroughfareName()
    {
      return string.IsNullOrEmpty(this.DependentThoroughfareName) ? "" : this.DependentThoroughfareName;
    }

    public string GetDependentThoroughfareTrailingType()
    {
      return string.IsNullOrEmpty(this.DependentThoroughfareTrailingType) ? "" : this.DependentThoroughfareTrailingType;
    }

    public string GetDependentThoroughfarePostDirection()
    {
      return string.IsNullOrEmpty(this.DependentThoroughfarePostDirection) ? "" : this.DependentThoroughfarePostDirection;
    }

    public string GetBuilding()
    {
      return string.IsNullOrEmpty(this.Building) ? "" : this.Building;
    }

    public string GetPremisesType()
    {
      return string.IsNullOrEmpty(this.PremisesType) ? "" : this.PremisesType;
    }

    public string GetPremisesNumber()
    {
      return string.IsNullOrEmpty(this.PremisesNumber) ? "" : this.PremisesNumber;
    }

    public string GetSubPremisesType()
    {
      return string.IsNullOrEmpty(this.SubPremisesType) ? "" : this.SubPremisesType;
    }

    public string GetSubPremisesNumber()
    {
      return string.IsNullOrEmpty(this.SubPremisesNumber) ? "" : this.SubPremisesNumber;
    }

    public string GetPostBox()
    {
      return string.IsNullOrEmpty(this.PostBox) ? "" : this.PostBox;
    }

    public string GetLatitude()
    {
      return string.IsNullOrEmpty(this.Latitude) ? "" : this.Latitude;
    }

    public string GetLongitude()
    {
      return string.IsNullOrEmpty(this.Longitude) ? "" : this.Longitude;
    }
  }

  public class PersonatorIdentityEmail : ResponseBase
  {
    public string DeliverabilityConfidenceScore { get; set; }
    public string Results { get; set; }
    public string EmailAddress { get; set; }
    public string MailboxName { get; set; }
    public string DomainName { get; set; }
    public string TopLevelDomain { get; set; }
    public string TopLevelDomainName { get; set; }
    public string DateChecked { get; set; }
    public string EmailAgeEstimated { get; set; }
    public string DomainAgeEstimated { get; set; }
    public string DomainExpirationDate { get; set; }
    public string DomainCreatedDate { get; set; }
    public string DomainUpdatedDate { get; set; }
    public string DomainEmail { get; set; }
    public string DomainOrganization { get; set; }
    public string DomainAddress1 { get; set; }
    public string DomainLocality { get; set; }
    public string DomainAdministrativeArea { get; set; }
    public string DomainPostalCode { get; set; }
    public string DomainCountry { get; set; }
    public string DomainAvailability { get; set; }
    public string DomainCountryCode { get; set; }
    public string DomainPrivateProxy { get; set; }
    public string PrivacyFlag { get; set; }
    public string MXServer { get; set; }
    public string BreachCount { get; set; }

    // Setters
    public void SetDeliverabilityConfidenceScore(string deliverabilityConfidenceScore)
    {
      this.DeliverabilityConfidenceScore = deliverabilityConfidenceScore;
    }

    public void SetResults(string results)
    {
      this.Results = results;
    }

    public void SetEmailAddress(string emailAddress)
    {
      this.EmailAddress = emailAddress;
    }

    public void SetMailboxName(string mailboxName)
    {
      this.MailboxName = mailboxName;
    }

    public void SetDomainName(string domainName)
    {
      this.DomainName = domainName;
    }

    public void SetTopLevelDomain(string topLevelDomain)
    {
      this.TopLevelDomain = topLevelDomain;
    }

    public void SetTopLevelDomainName(string topLevelDomainName)
    {
      this.TopLevelDomainName = topLevelDomainName;
    }

    public void SetDateChecked(string dateChecked)
    {
      this.DateChecked = dateChecked;
    }

    public void SetEmailAgeEstimated(string emailAgeEstimated)
    {
      this.EmailAgeEstimated = emailAgeEstimated;
    }

    public void SetDomainAgeEstimated(string domainAgeEstimated)
    {
      this.DomainAgeEstimated = domainAgeEstimated;
    }

    public void SetDomainExpirationDate(string domainExpirationDate)
    {
      this.DomainExpirationDate = domainExpirationDate;
    }

    public void SetDomainCreatedDate(string domainCreatedDate)
    {
      this.DomainCreatedDate = domainCreatedDate;
    }

    public void SetDomainUpdatedDate(string domainUpdatedDate)
    {
      this.DomainUpdatedDate = domainUpdatedDate;
    }

    public void SetDomainEmail(string domainEmail)
    {
      this.DomainEmail = domainEmail;
    }

    public void SetDomainOrganization(string domainOrganization)
    {
      this.DomainOrganization = domainOrganization;
    }

    public void SetDomainAddress1(string domainAddress1)
    {
      this.DomainAddress1 = domainAddress1;
    }

    public void SetDomainLocality(string domainLocality)
    {
      this.DomainLocality = domainLocality;
    }

    public void SetDomainAdministrativeArea(string domainAdministrativeArea)
    {
      this.DomainAdministrativeArea = domainAdministrativeArea;
    }

    public void SetDomainPostalCode(string domainPostalCode)
    {
      this.DomainPostalCode = domainPostalCode;
    }

    public void SetDomainCountry(string domainCountry)
    {
      this.DomainCountry = domainCountry;
    }

    public void SetDomainAvailability(string domainAvailability)
    {
      this.DomainAvailability = domainAvailability;
    }

    public void SetDomainCountryCode(string domainCountryCode)
    {
      this.DomainCountryCode = domainCountryCode;
    }

    public void SetDomainPrivateProxy(string domainPrivateProxy)
    {
      this.DomainPrivateProxy = domainPrivateProxy;
    }

    public void SetPrivacyFlag(string privacyFlag)
    {
      this.PrivacyFlag = privacyFlag;
    }

    public void SetMXServer(string mxServer)
    {
      this.MXServer = mxServer;
    }

    public void SetBreachCount(string breachCount)
    {
      this.BreachCount = breachCount;
    }

    // Getters
    public string GetDeliverabilityConfidenceScore()
    {
      return string.IsNullOrEmpty(this.DeliverabilityConfidenceScore) ? "" : this.DeliverabilityConfidenceScore;
    }

    public string GetResults()
    {
      return string.IsNullOrEmpty(this.Results) ? "" : this.Results;
    }

    public string GetEmailAddress()
    {
      return string.IsNullOrEmpty(this.EmailAddress) ? "" : this.EmailAddress;
    }

    public string GetMailboxName()
    {
      return string.IsNullOrEmpty(this.MailboxName) ? "" : this.MailboxName;
    }

    public string GetDomainName()
    {
      return string.IsNullOrEmpty(this.DomainName) ? "" : this.DomainName;
    }

    public string GetTopLevelDomain()
    {
      return string.IsNullOrEmpty(this.TopLevelDomain) ? "" : this.TopLevelDomain;
    }

    public string GetTopLevelDomainName()
    {
      return string.IsNullOrEmpty(this.TopLevelDomainName) ? "" : this.TopLevelDomainName;
    }

    public string GetDateChecked()
    {
      return string.IsNullOrEmpty(this.DateChecked) ? "" : this.DateChecked;
    }

    public string GetEmailAgeEstimated()
    {
      return string.IsNullOrEmpty(this.EmailAgeEstimated) ? "" : this.EmailAgeEstimated;
    }

    public string GetDomainAgeEstimated()
    {
      return string.IsNullOrEmpty(this.DomainAgeEstimated) ? "" : this.DomainAgeEstimated;
    }

    public string GetDomainExpirationDate()
    {
      return string.IsNullOrEmpty(this.DomainExpirationDate) ? "" : this.DomainExpirationDate;
    }

    public string GetDomainCreatedDate()
    {
      return string.IsNullOrEmpty(this.DomainCreatedDate) ? "" : this.DomainCreatedDate;
    }

    public string GetDomainUpdatedDate()
    {
      return string.IsNullOrEmpty(this.DomainUpdatedDate) ? "" : this.DomainUpdatedDate;
    }

    public string GetDomainEmail()
    {
      return string.IsNullOrEmpty(this.DomainEmail) ? "" : this.DomainEmail;
    }

    public string GetDomainOrganization()
    {
      return string.IsNullOrEmpty(this.DomainOrganization) ? "" : this.DomainOrganization;
    }

    public string GetDomainAddress1()
    {
      return string.IsNullOrEmpty(this.DomainAddress1) ? "" : this.DomainAddress1;
    }

    public string GetDomainLocality()
    {
      return string.IsNullOrEmpty(this.DomainLocality) ? "" : this.DomainLocality;
    }

    public string GetDomainAdministrativeArea()
    {
      return string.IsNullOrEmpty(this.DomainAdministrativeArea) ? "" : this.DomainAdministrativeArea;
    }

    public string GetDomainPostalCode()
    {
      return string.IsNullOrEmpty(this.DomainPostalCode) ? "" : this.DomainPostalCode;
    }

    public string GetDomainCountry()
    {
      return string.IsNullOrEmpty(this.DomainCountry) ? "" : this.DomainCountry;
    }

    public string GetDomainAvailability()
    {
      return string.IsNullOrEmpty(this.DomainAvailability) ? "" : this.DomainAvailability;
    }

    public string GetDomainCountryCode()
    {
      return string.IsNullOrEmpty(this.DomainCountryCode) ? "" : this.DomainCountryCode;
    }

    public string GetDomainPrivateProxy()
    {
      return string.IsNullOrEmpty(this.DomainPrivateProxy) ? "" : this.DomainPrivateProxy;
    }

    public string GetPrivacyFlag()
    {
      return string.IsNullOrEmpty(this.PrivacyFlag) ? "" : this.PrivacyFlag;
    }

    public string GetMXServer()
    {
      return string.IsNullOrEmpty(this.MXServer) ? "" : this.MXServer;
    }

    public string GetBreachCount()
    {
      return string.IsNullOrEmpty(this.BreachCount) ? "" : this.BreachCount;
    }
  }

  public class PersonatorIdentityPhone : ResponseBase
  {
    public string Results { get; set; }
    public string PhoneNumber { get; set; }
    public string AdministrativeArea { get; set; }
    public string CountryAbbreviation { get; set; }
    public string CountryName { get; set; }
    public string Carrier { get; set; }
    public string CallerID { get; set; }
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
    public string DST { get; set; }
    public string TimeZoneCode { get; set; }
    public string TimeZoneName { get; set; }

    // Setters
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

    public void SetDST(string dst)
    {
      this.DST = dst;
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

    public string GetDST()
    {
      return string.IsNullOrEmpty(this.DST) ? "" : this.DST;
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

  public class PersonatorIdentityIdentity : ResponseBase
  {
    public string Results { get; set; }
    public string Confidence { get; set; }
    public List<string> Datasources { get; set; }
    public IdentityWatchlists Watchlists { get; set; }
    public string WatchlistPersons { get; set; }
    public string NationalID { get; set; }
    public string DateOfBirth { get; set; }
    public IdentityAccountNumber AccountNumber { get; set; }
    public IdentityBusinessInformation BusinessInformation { get; set; }

    // Setters
    public void SetResults(string results)
    {
      this.Results = results;
    }

    public void SetConfidence(string confidence)
    {
      this.Confidence = confidence;
    }

    public void SetWatchlistPersons(string watchlistPersons)
    {
      this.WatchlistPersons = watchlistPersons;
    }

    public void SetNationalID(string nationalID)
    {
      this.NationalID = nationalID;
    }

    public void SetDateOfBirth(string dateOfBirth)
    {
      this.DateOfBirth = dateOfBirth;
    }

    // Getters
    public string GetResults()
    {
      return string.IsNullOrEmpty(this.Results) ? "" : this.Results;
    }

    public string GetConfidence()
    {
      return string.IsNullOrEmpty(this.Confidence) ? "" : this.Confidence;
    }

    public string GetWatchlistPersons()
    {
      return string.IsNullOrEmpty(this.WatchlistPersons) ? "" : this.WatchlistPersons;
    }

    public string GetNationalID()
    {
      return string.IsNullOrEmpty(this.NationalID) ? "" : this.NationalID;
    }

    public string GetDateOfBirth()
    {
      return string.IsNullOrEmpty(this.DateOfBirth) ? "" : this.DateOfBirth;
    }
  }

  public class IdentityWatchlists : ResponseBase
  {
    public string Hit { get; set; }
    public List<string> Sources { get; set; }
    public List<string> Articles { get; set; }
    public string ReportLink { get; set; }

    // Setters
    public void SetHit(string hit)
    {
      this.Hit = hit;
    }

    public void SetReportLink(string reportLink)
    {
      this.ReportLink = reportLink;
    }

    // Getters
    public string GetHit()
    {
      return string.IsNullOrEmpty(this.Hit) ? "" : this.Hit;
    }

    public string GetReportLink()
    {
      return string.IsNullOrEmpty(this.ReportLink) ? "" : this.ReportLink;
    }
  }

  public class IdentityAccountNumber : ResponseBase
  {
    public string Validated { get; set; }

    // Setters
    public void SetValidated(string validated)
    {
      this.Validated = validated;
    }

    // Getters
    public string GetValidated()
    {
      return string.IsNullOrEmpty(this.Validated) ? "" : this.Validated;
    }
  }

  public class IdentityBusinessInformation : ResponseBase
  {
    public string Name { get; set; }
    public string ID { get; set; }
    public string Status { get; set; }
    public string Type { get; set; }
    public string RegistrationDate { get; set; }

    // Setters
    public void SetName(string name)
    {
      this.Name = name;
    }

    public void SetID(string id)
    {
      this.ID = id;
    }

    public void SetStatus(string status)
    {
      this.Status = status;
    }

    public void SetType(string type)
    {
      this.Type = type;
    }

    public void SetRegistrationDate(string registrationDate)
    {
      this.RegistrationDate = registrationDate;
    }

    // Getters
    public string GetName()
    {
      return string.IsNullOrEmpty(this.Name) ? "" : this.Name;
    }

    public string GetID()
    {
      return string.IsNullOrEmpty(this.ID) ? "" : this.ID;
    }

    public string GetStatus()
    {
      return string.IsNullOrEmpty(this.Status) ? "" : this.Status;
    }

    public string GetType()
    {
      return string.IsNullOrEmpty(this.Type) ? "" : this.Type;
    }

    public string GetRegistrationDate()
    {
      return string.IsNullOrEmpty(this.RegistrationDate) ? "" : this.RegistrationDate;
    }
  }
}
