using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class BusinessCoderResponse : ResponseBase
  {
    public string Version { get; set; }
    public string TransmissionReference { get; set; }
    public string TransmissionResults { get; set; }
    public string TotalRecords { get; set; }
    public List<BusinessCoderRecord> Records { get; set; }

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

  public class BusinessCoderRecord : ResponseBase
  {
    public string RecordID { get; set; }
    public string CompanyName { get; set; }
    public string CurrentCompanyName { get; set; }
    public string AddressLine1 { get; set; }
    public string Suite { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string TotalContacts { get; set; }
    public string MelissaEnterpriseKey { get; set; }
    public string LocationType { get; set; }
    public string Phone { get; set; }
    public string EmployeesEstimate { get; set; }
    public string SalesEstimate { get; set; }
    public string StockTicker { get; set; }
    public string WebAddress { get; set; }
    public List<BusinessCoderContacts> Contacts { get; set; }
    public string CountryCode { get; set; }
    public string CountryName { get; set; }
    public string DeliveryIndicator { get; set; }
    public string MelissaAddressKey { get; set; }
    public string MelissaAddressKeyBase { get; set; }
    public string Plus4 { get; set; }
    public string EIN { get; set; }
    public string SICCode1 { get; set; }
    public string SICCode2 { get; set; }
    public string SICCode3 { get; set; }
    public string NAICSCode1 { get; set; }
    public string NAICSCode2 { get; set; }
    public string NAICSCode3 { get; set; }
    public string SICDescription1 { get; set; }
    public string SICDescription2 { get; set; }
    public string SICDescription3 { get; set; }
    public string NAICSDescription1 { get; set; }
    public string NAICSDescription2 { get; set; }
    public string NAICSDescription3 { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string CountyName { get; set; }
    public string CountyFIPS { get; set; }
    public string CensusTract { get; set; }
    public string CensusBlock { get; set; }
    public string PlaceCode { get; set; }
    public string PlaceName { get; set; }
    public string Results { get; set; }

    // Setters
    public void SetRecordID(string recordID)
    {
      this.RecordID = recordID;
    }

    public void SetCompanyName(string companyName)
    {
      this.CompanyName = companyName;
    }

    public void SetCurrentCompanyName(string currentCompanyName)
    {
      this.CurrentCompanyName = currentCompanyName;
    }

    public void SetAddressLine1(string addressLine1)
    {
      this.AddressLine1 = addressLine1;
    }

    public void SetSuite(string suite)
    {
      this.Suite = suite;
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

    public void SetTotalContacts(string totalContacts)
    {
      this.TotalContacts = totalContacts;
    }

    public void SetMelissaEnterpriseKey(string melissaEnterpriseKey)
    {
      this.MelissaEnterpriseKey = melissaEnterpriseKey;
    }

    public void SetLocationType(string locationType)
    {
      this.LocationType = locationType;
    }

    public void SetPhone(string phone)
    {
      this.Phone = phone;
    }

    public void SetEmployeesEstimate(string employeesEstimate)
    {
      this.EmployeesEstimate = employeesEstimate;
    }

    public void SetSalesEstimate(string salesEstimate)
    {
      this.SalesEstimate = salesEstimate;
    }

    public void SetStockTicker(string stockTicker)
    {
      this.StockTicker = stockTicker;
    }

    public void SetWebAddress(string webAddress)
    {
      this.WebAddress = webAddress;
    }

    public void SetCountryCode(string countryCode)
    {
      this.CountryCode = countryCode;
    }

    public void SetCountryName(string countryName)
    {
      this.CountryName = countryName;
    }

    public void SetDeliveryIndicator(string deliveryIndicator)
    {
      this.DeliveryIndicator = deliveryIndicator;
    }

    public void SetMelissaAddressKey(string melissaAddressKey)
    {
      this.MelissaAddressKey = melissaAddressKey;
    }

    public void SetMelissaAddressKeyBase(string melissaAddressKeyBase)
    {
      this.MelissaAddressKeyBase = melissaAddressKeyBase;
    }

    public void SetPlus4(string plus4)
    {
      this.Plus4 = plus4;
    }

    public void SetEIN(string ein)
    {
      this.EIN = ein;
    }

    public void SetSICCode1(string sicCode1)
    {
      this.SICCode1 = sicCode1;
    }

    public void SetSICCode2(string sicCode2)
    {
      this.SICCode2 = sicCode2;
    }

    public void SetSICCode3(string sicCode3)
    {
      this.SICCode3 = sicCode3;
    }

    public void SetNAICSCode1(string naicsCode1)
    {
      this.NAICSCode1 = naicsCode1;
    }

    public void SetNAICSCode2(string naicsCode2)
    {
      this.NAICSCode2 = naicsCode2;
    }

    public void SetNAICSCode3(string naicsCode3)
    {
      this.NAICSCode3 = naicsCode3;
    }

    public void SetSICDescription1(string sicDescription1)
    {
      this.SICDescription1 = sicDescription1;
    }

    public void SetSICDescription2(string sicDescription2)
    {
      this.SICDescription2 = sicDescription2;
    }

    public void SetSICDescription3(string sicDescription3)
    {
      this.SICDescription3 = sicDescription3;
    }

    public void SetNAICSDescription1(string naicsDescription1)
    {
      this.NAICSDescription1 = naicsDescription1;
    }

    public void SetNAICSDescription2(string naicsDescription2)
    {
      this.NAICSDescription2 = naicsDescription2;
    }

    public void SetNAICSDescription3(string naicsDescription3)
    {
      this.NAICSDescription3 = naicsDescription3;
    }

    public void SetLatitude(string latitude)
    {
      this.Latitude = latitude;
    }

    public void SetLongitude(string longitude)
    {
      this.Longitude = longitude;
    }

    public void SetCountyName(string countyName)
    {
      this.CountyName = countyName;
    }

    public void SetCountyFIPS(string countyFIPS)
    {
      this.CountyFIPS = countyFIPS;
    }

    public void SetCensusTract(string censusTract)
    {
      this.CensusTract = censusTract;
    }

    public void SetCensusBlock(string censusBlock)
    {
      this.CensusBlock = censusBlock;
    }

    public void SetPlaceCode(string placeCode)
    {
      this.PlaceCode = placeCode;
    }

    public void SetPlaceName(string placeName)
    {
      this.PlaceName = placeName;
    }

    public void SetResults(string results)
    {
      this.Results = results;
    }

    // Getters
    public string GetRecordID()
    {
      return string.IsNullOrEmpty(this.RecordID) ? "" : this.RecordID;
    }

    public string GetCompanyName()
    {
      return string.IsNullOrEmpty(this.CompanyName) ? "" : this.CompanyName;
    }

    public string GetCurrentCompanyName()
    {
      return string.IsNullOrEmpty(this.CurrentCompanyName) ? "" : this.CurrentCompanyName;
    }

    public string GetAddressLine1()
    {
      return string.IsNullOrEmpty(this.AddressLine1) ? "" : this.AddressLine1;
    }

    public string GetSuite()
    {
      return string.IsNullOrEmpty(this.Suite) ? "" : this.Suite;
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

    public string GetTotalContacts()
    {
      return string.IsNullOrEmpty(this.TotalContacts) ? "" : this.TotalContacts;
    }

    public string GetMelissaEnterpriseKey()
    {
      return string.IsNullOrEmpty(this.MelissaEnterpriseKey) ? "" : this.MelissaEnterpriseKey;
    }

    public string GetLocationType()
    {
      return string.IsNullOrEmpty(this.LocationType) ? "" : this.LocationType;
    }

    public string GetPhone()
    {
      return string.IsNullOrEmpty(this.Phone) ? "" : this.Phone;
    }

    public string GetEmployeesEstimate()
    {
      return string.IsNullOrEmpty(this.EmployeesEstimate) ? "" : this.EmployeesEstimate;
    }

    public string GetSalesEstimate()
    {
      return string.IsNullOrEmpty(this.SalesEstimate) ? "" : this.SalesEstimate;
    }

    public string GetStockTicker()
    {
      return string.IsNullOrEmpty(this.StockTicker) ? "" : this.StockTicker;
    }

    public string GetWebAddress()
    {
      return string.IsNullOrEmpty(this.WebAddress) ? "" : this.WebAddress;
    }

    public string GetCountryCode()
    {
      return string.IsNullOrEmpty(this.CountryCode) ? "" : this.CountryCode;
    }

    public string GetCountryName()
    {
      return string.IsNullOrEmpty(this.CountryName) ? "" : this.CountryName;
    }

    public string GetDeliveryIndicator()
    {
      return string.IsNullOrEmpty(this.DeliveryIndicator) ? "" : this.DeliveryIndicator;
    }

    public string GetMelissaAddressKey()
    {
      return string.IsNullOrEmpty(this.MelissaAddressKey) ? "" : this.MelissaAddressKey;
    }

    public string GetMelissaAddressKeyBase()
    {
      return string.IsNullOrEmpty(this.MelissaAddressKeyBase) ? "" : this.MelissaAddressKeyBase;
    }

    public string GetPlus4()
    {
      return string.IsNullOrEmpty(this.Plus4) ? "" : this.Plus4;
    }

    public string GetEIN()
    {
      return string.IsNullOrEmpty(this.EIN) ? "" : this.EIN;
    }

    public string GetSICCode1()
    {
      return string.IsNullOrEmpty(this.SICCode1) ? "" : this.SICCode1;
    }

    public string GetSICCode2()
    {
      return string.IsNullOrEmpty(this.SICCode2) ? "" : this.SICCode2;
    }

    public string GetSICCode3()
    {
      return string.IsNullOrEmpty(this.SICCode3) ? "" : this.SICCode3;
    }

    public string GetNAICSCode1()
    {
      return string.IsNullOrEmpty(this.NAICSCode1) ? "" : this.NAICSCode1;
    }

    public string GetNAICSCode2()
    {
      return string.IsNullOrEmpty(this.NAICSCode2) ? "" : this.NAICSCode2;
    }

    public string GetNAICSCode3()
    {
      return string.IsNullOrEmpty(this.NAICSCode3) ? "" : this.NAICSCode3;
    }

    public string GetSICDescription1()
    {
      return string.IsNullOrEmpty(this.SICDescription1) ? "" : this.SICDescription1;
    }

    public string GetSICDescription2()
    {
      return string.IsNullOrEmpty(this.SICDescription2) ? "" : this.SICDescription2;
    }

    public string GetSICDescription3()
    {
      return string.IsNullOrEmpty(this.SICDescription3) ? "" : this.SICDescription3;
    }

    public string GetNAICSDescription1()
    {
      return string.IsNullOrEmpty(this.NAICSDescription1) ? "" : this.NAICSDescription1;
    }

    public string GetNAICSDescription2()
    {
      return string.IsNullOrEmpty(this.NAICSDescription2) ? "" : this.NAICSDescription2;
    }

    public string GetNAICSDescription3()
    {
      return string.IsNullOrEmpty(this.NAICSDescription3) ? "" : this.NAICSDescription3;
    }

    public string GetLatitude()
    {
      return string.IsNullOrEmpty(this.Latitude) ? "" : this.Latitude;
    }

    public string GetLongitude()
    {
      return string.IsNullOrEmpty(this.Longitude) ? "" : this.Longitude;
    }

    public string GetCountyName()
    {
      return string.IsNullOrEmpty(this.CountyName) ? "" : this.CountyName;
    }

    public string GetCountyFIPS()
    {
      return string.IsNullOrEmpty(this.CountyFIPS) ? "" : this.CountyFIPS;
    }

    public string GetCensusTract()
    {
      return string.IsNullOrEmpty(this.CensusTract) ? "" : this.CensusTract;
    }

    public string GetCensusBlock()
    {
      return string.IsNullOrEmpty(this.CensusBlock) ? "" : this.CensusBlock;
    }

    public string GetPlaceCode()
    {
      return string.IsNullOrEmpty(this.PlaceCode) ? "" : this.PlaceCode;
    }

    public string GetPlaceName()
    {
      return string.IsNullOrEmpty(this.PlaceName) ? "" : this.PlaceName;
    }

    public string GetResults()
    {
      return string.IsNullOrEmpty(this.Results) ? "" : this.Results;
    }
  }

  public class BusinessCoderContacts : ResponseBase
  {
    public string NameFirst { get; set; }
    public string NameLast { get; set; }
    public string Gender { get; set; }
    public string Title { get; set; }
    public string ContactPhone { get; set; }
    public string Email { get; set; }

    // Setters
    public void SetNameFirst(string nameFirst)
    {
      this.NameFirst = nameFirst;
    }

    public void SetNameLast(string nameLast)
    {
      this.NameLast = nameLast;
    }

    public void SetGender(string gender)
    {
      this.Gender = gender;
    }

    public void SetTitle(string title)
    {
      this.Title = title;
    }

    public void SetContactPhone(string contactPhone)
    {
      this.ContactPhone = contactPhone;
    }

    public void SetEmail(string email)
    {
      this.Email = email;
    }

    // Getters
    public string GetNameFirst()
    {
      return string.IsNullOrEmpty(this.NameFirst) ? "" : this.NameFirst;
    }

    public string GetNameLast()
    {
      return string.IsNullOrEmpty(this.NameLast) ? "" : this.NameLast;
    }

    public string GetGender()
    {
      return string.IsNullOrEmpty(this.Gender) ? "" : this.Gender;
    }

    public string GetTitle()
    {
      return string.IsNullOrEmpty(this.Title) ? "" : this.Title;
    }

    public string GetContactPhone()
    {
      return string.IsNullOrEmpty(this.ContactPhone) ? "" : this.ContactPhone;
    }

    public string GetEmail()
    {
      return string.IsNullOrEmpty(this.Email) ? "" : this.Email;
    }
  }
}
