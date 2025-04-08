using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class GlobalIPResponse : ResponseBase
  {
    public string Version { get; set; }
    public string TransmissionReference { get; set; }
    public string TransmissionResults { get; set; }
    public List<GlobalIPRecord> Records { get; set; }

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
  }

  public class GlobalIPRecord : ResponseBase
  {
    public string City { get; set; }
    public string ConnectionSpeed { get; set; }
    public string ConnectionType { get; set; }
    public string Continent { get; set; }
    public string CountryAbbreviation { get; set; }
    public string CountryName { get; set; }
    public string DomainAddress1 { get; set; }
    public string DomainAdministrativeArea { get; set; }
    public string DomainAgeEstimated { get; set; }
    public string DomainAvailability { get; set; }
    public string DomainCountry { get; set; }
    public string DomainCountryCode { get; set; }
    public string DomainCreatedDate { get; set; }
    public string DomainEmail { get; set; }
    public string DomainExpirationDate { get; set; }
    public string DomainLocality { get; set; }
    public string DomainName { get; set; }
    public string DomainOrganization { get; set; }
    public string DomainPostalCode { get; set; }
    public string DomainPrivateProxy { get; set; }
    public string DomainUpdatedDate { get; set; }
    public string DST { get; set; }
    public string IPAddress { get; set; }
    public string ISPName { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string PostalCode { get; set; }
    public string ProxyDescription { get; set; }
    public string ProxyType { get; set; }
    public string RecordID { get; set; }
    public string Region { get; set; }
    public string Result { get; set; }
    public string TimeZoneCode { get; set; }
    public string TimeZoneName { get; set; }
    public string UTC { get; set; }

    // Setters
    public void SetCity(string city)
    {
      this.City = city;
    }

    public void SetConnectionSpeed(string connectionSpeed)
    {
      this.ConnectionSpeed = connectionSpeed;
    }

    public void SetConnectionType(string connectionType)
    {
      this.ConnectionType = connectionType;
    }

    public void SetContinent(string continent)
    {
      this.Continent = continent;
    }

    public void SetCountryAbbreviation(string countryAbbreviation)
    {
      this.CountryAbbreviation = countryAbbreviation;
    }

    public void SetCountryName(string countryName)
    {
      this.CountryName = countryName;
    }

    public void SetDomainAddress1(string domainAddress1)
    {
      this.DomainAddress1 = domainAddress1;
    }

    public void SetDomainAdministrativeArea(string domainAdministrativeArea)
    {
      this.DomainAdministrativeArea = domainAdministrativeArea;
    }

    public void SetDomainAgeEstimated(string domainAgeEstimated)
    {
      this.DomainAgeEstimated = domainAgeEstimated;
    }

    public void SetDomainAvailability(string domainAvailability)
    {
      this.DomainAvailability = domainAvailability;
    }

    public void SetDomainCountry(string domainCountry)
    {
      this.DomainCountry = domainCountry;
    }

    public void SetDomainCountryCode(string domainCountryCode)
    {
      this.DomainCountryCode = domainCountryCode;
    }

    public void SetDomainCreatedDate(string domainCreatedDate)
    {
      this.DomainCreatedDate = domainCreatedDate;
    }

    public void SetDomainEmail(string domainEmail)
    {
      this.DomainEmail = domainEmail;
    }

    public void SetDomainExpirationDate(string domainExpirationDate)
    {
      this.DomainExpirationDate = domainExpirationDate;
    }

    public void SetDomainLocality(string domainLocality)
    {
      this.DomainLocality = domainLocality;
    }

    public void SetDomainName(string domainName)
    {
      this.DomainName = domainName;
    }

    public void SetDomainOrganization(string domainOrganization)
    {
      this.DomainOrganization = domainOrganization;
    }

    public void SetDomainPostalCode(string domainPostalCode)
    {
      this.DomainPostalCode = domainPostalCode;
    }

    public void SetDomainPrivateProxy(string domainPrivateProxy)
    {
      this.DomainPrivateProxy = domainPrivateProxy;
    }

    public void SetDomainUpdatedDate(string domainUpdatedDate)
    {
      this.DomainUpdatedDate = domainUpdatedDate;
    }

    public void SetDST(string dst)
    {
      this.DST = dst;
    }

    public void SetIPAddress(string ipAddress)
    {
      this.IPAddress = ipAddress;
    }

    public void SetISPName(string ispName)
    {
      this.ISPName = ispName;
    }

    public void SetLatitude(string latitude)
    {
      this.Latitude = latitude;
    }

    public void SetLongitude(string longitude)
    {
      this.Longitude = longitude;
    }

    public void SetPostalCode(string postalCode)
    {
      this.PostalCode = postalCode;
    }

    public void SetProxyDescription(string proxyDescription)
    {
      this.ProxyDescription = proxyDescription;
    }

    public void SetProxyType(string proxyType)
    {
      this.ProxyType = proxyType;
    }

    public void SetRecordID(string recordID)
    {
      this.RecordID = recordID;
    }

    public void SetRegion(string region)
    {
      this.Region = region;
    }

    public void SetResult(string result)
    {
      this.Result = result;
    }

    public void SetTimeZoneCode(string timeZoneCode)
    {
      this.TimeZoneCode = timeZoneCode;
    }

    public void SetTimeZoneName(string timeZoneName)
    {
      this.TimeZoneName = timeZoneName;
    }

    public void SetUTC(string utc)
    {
      this.UTC = utc;
    }

    // Getters
    public string GetCity()
    {
      return string.IsNullOrEmpty(this.City) ? "" : this.City;
    }

    public string GetConnectionSpeed()
    {
      return string.IsNullOrEmpty(this.ConnectionSpeed) ? "" : this.ConnectionSpeed;
    }

    public string GetConnectionType()
    {
      return string.IsNullOrEmpty(this.ConnectionType) ? "" : this.ConnectionType;
    }

    public string GetContinent()
    {
      return string.IsNullOrEmpty(this.Continent) ? "" : this.Continent;
    }

    public string GetCountryAbbreviation()
    {
      return string.IsNullOrEmpty(this.CountryAbbreviation) ? "" : this.CountryAbbreviation;
    }

    public string GetCountryName()
    {
      return string.IsNullOrEmpty(this.CountryName) ? "" : this.CountryName;
    }

    public string GetDomainAddress1()
    {
      return string.IsNullOrEmpty(this.DomainAddress1) ? "" : this.DomainAddress1;
    }

    public string GetDomainAdministrativeArea()
    {
      return string.IsNullOrEmpty(this.DomainAdministrativeArea) ? "" : this.DomainAdministrativeArea;
    }

    public string GetDomainAgeEstimated()
    {
      return string.IsNullOrEmpty(this.DomainAgeEstimated) ? "" : this.DomainAgeEstimated;
    }

    public string GetDomainAvailability()
    {
      return string.IsNullOrEmpty(this.DomainAvailability) ? "" : this.DomainAvailability;
    }

    public string GetDomainCountry()
    {
      return string.IsNullOrEmpty(this.DomainCountry) ? "" : this.DomainCountry;
    }

    public string GetDomainCountryCode()
    {
      return string.IsNullOrEmpty(this.DomainCountryCode) ? "" : this.DomainCountryCode;
    }

    public string GetDomainCreatedDate()
    {
      return string.IsNullOrEmpty(this.DomainCreatedDate) ? "" : this.DomainCreatedDate;
    }

    public string GetDomainEmail()
    {
      return string.IsNullOrEmpty(this.DomainEmail) ? "" : this.DomainEmail;
    }

    public string GetDomainExpirationDate()
    {
      return string.IsNullOrEmpty(this.DomainExpirationDate) ? "" : this.DomainExpirationDate;
    }

    public string GetDomainLocality()
    {
      return string.IsNullOrEmpty(this.DomainLocality) ? "" : this.DomainLocality;
    }

    public string GetDomainName()
    {
      return string.IsNullOrEmpty(this.DomainName) ? "" : this.DomainName;
    }

    public string GetDomainOrganization()
    {
      return string.IsNullOrEmpty(this.DomainOrganization) ? "" : this.DomainOrganization;
    }

    public string GetDomainPostalCode()
    {
      return string.IsNullOrEmpty(this.DomainPostalCode) ? "" : this.DomainPostalCode;
    }

    public string GetDomainPrivateProxy()
    {
      return string.IsNullOrEmpty(this.DomainPrivateProxy) ? "" : this.DomainPrivateProxy;
    }

    public string GetDomainUpdatedDate()
    {
      return string.IsNullOrEmpty(this.DomainUpdatedDate) ? "" : this.DomainUpdatedDate;
    }

    public string GetDST()
    {
      return string.IsNullOrEmpty(this.DST) ? "" : this.DST;
    }

    public string GetIPAddress()
    {
      return string.IsNullOrEmpty(this.IPAddress) ? "" : this.IPAddress;
    }

    public string GetISPName()
    {
      return string.IsNullOrEmpty(this.ISPName) ? "" : this.ISPName;
    }

    public string GetLatitude()
    {
      return string.IsNullOrEmpty(this.Latitude) ? "" : this.Latitude;
    }

    public string GetLongitude()
    {
      return string.IsNullOrEmpty(this.Longitude) ? "" : this.Longitude;
    }

    public string GetPostalCode()
    {
      return string.IsNullOrEmpty(this.PostalCode) ? "" : this.PostalCode;
    }

    public string GetProxyDescription()
    {
      return string.IsNullOrEmpty(this.ProxyDescription) ? "" : this.ProxyDescription;
    }

    public string GetProxyType()
    {
      return string.IsNullOrEmpty(this.ProxyType) ? "" : this.ProxyType;
    }

    public string GetRecordID()
    {
      return string.IsNullOrEmpty(this.RecordID) ? "" : this.RecordID;
    }

    public string GetRegion()
    {
      return string.IsNullOrEmpty(this.Region) ? "" : this.Region;
    }

    public string GetResult()
    {
      return string.IsNullOrEmpty(this.Result) ? "" : this.Result;
    }

    public string GetTimeZoneCode()
    {
      return string.IsNullOrEmpty(this.TimeZoneCode) ? "" : this.TimeZoneCode;
    }

    public string GetTimeZoneName()
    {
      return string.IsNullOrEmpty(this.TimeZoneName) ? "" : this.TimeZoneName;
    }

    public string GetUTC()
    {
      return string.IsNullOrEmpty(this.UTC) ? "" : this.UTC;
    }
  }
}
