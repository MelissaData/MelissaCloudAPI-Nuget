using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class PersonatorConsumerResponse : ResponseBase
  {
    public string Version { get; set; }
    public string TransmissionReference { get; set; }
    public string TransmissionResults { get; set; }
    public string TotalRecords { get; set; }
    public List<PersonatorConsumerRecord> Records { get; set; }

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

  public class PersonatorConsumerRecord : ResponseBase
  {
    public string AddressDeliveryInstallation { get; set; }
    public string AddressExtras { get; set; }
    public string AddressHouseNumber { get; set; }
    public string AddressKey { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string AddressLockBox { get; set; }
    public string AddressPostDirection { get; set; }
    public string AddressPreDirection { get; set; }
    public string AddressPrivateMailboxName { get; set; }
    public string AddressPrivateMailboxRange { get; set; }
    public string AddressRouteService { get; set; }
    public string AddressStreetName { get; set; }
    public string AddressStreetSuffix { get; set; }
    public string AddressSuiteName { get; set; }
    public string AddressSuiteNumber { get; set; }
    public string AddressTypeCode { get; set; }
    public string AreaCode { get; set; }
    public string CBSACode { get; set; }
    public string CBSADivisionCode { get; set; }
    public string CBSADivisionLevel { get; set; }
    public string CBSADivisionTitle { get; set; }
    public string CBSALevel { get; set; }
    public string CBSATitle { get; set; }
    public string CarrierRoute { get; set; }
    public string CensusBlock { get; set; }
    public string CensusKey { get; set; }
    public string CensusTract { get; set; }
    public string ChildrenAgeRange { get; set; }
    public string City { get; set; }
    public string CityAbbreviation { get; set; }
    public string CompanyName { get; set; }
    public string CongressionalDistrict { get; set; }
    public string CountryCode { get; set; }
    public string CountryName { get; set; }
    public string CountyFIPS { get; set; }
    public string CountyName { get; set; }
    public string CountySubdivisionCode { get; set; }
    public string CountySubdivisionName { get; set; }
    public string CreditCardUser { get; set; }
    public string DateLastConfirmed { get; set; }
    public string DateOfBirth { get; set; }
    public string DateOfDeath { get; set; }
    public string DeliveryIndicator { get; set; }
    public string DeliveryPointCheckDigit { get; set; }
    public string DeliveryPointCode { get; set; }
    public string DemographicsGender { get; set; }
    public string DemographicsResults { get; set; }
    public string DistanceAddressToIP { get; set; }
    public string DomainName { get; set; }
    public string Education { get; set; }
    public string ElementarySchoolDistrictCode { get; set; }
    public string ElementarySchoolDistrictName { get; set; }
    public string EmailAddress { get; set; }
    public string EstimatedHomeValue { get; set; }
    public string EthnicCode { get; set; }
    public string EthnicGroup { get; set; }
    public string Gender { get; set; }
    public string Gender2 { get; set; }
    public string HouseholdIncome { get; set; }
    public string HouseholdSize { get; set; }
    public string IPAddress { get; set; }
    public string IPCity { get; set; }
    public string IPConnectionSpeed { get; set; }
    public string IPConnectionType { get; set; }
    public string IPContinent { get; set; }
    public string IPCountryAbbreviation { get; set; }
    public string IPCountryName { get; set; }
    public string IPDomainName { get; set; }
    public string IPISPName { get; set; }
    public string IPLatitude { get; set; }
    public string IPLongitude { get; set; }
    public string IPPostalCode { get; set; }
    public string IPProxyDescription { get; set; }
    public string IPProxyType { get; set; }
    public string IPRegion { get; set; }
    public string IPUTC { get; set; }
    public string Latitude { get; set; }
    public string LengthOfResidence { get; set; }
    public string Longitude { get; set; }
    public string MailboxName { get; set; }
    public string MaritalStatus { get; set; }
    public string MelissaAddressKey { get; set; }
    public string MelissaAddressKeyBase { get; set; }
    public string MelissaIdentityKey { get; set; }
    public string MoveDate { get; set; }
    public string NameFirst { get; set; }
    public string NameFirst2 { get; set; }
    public string NameFull { get; set; }
    public string NameLast { get; set; }
    public string NameLast2 { get; set; }
    public string NameMiddle { get; set; }
    public string NameMiddle2 { get; set; }
    public string NamePrefix { get; set; }
    public string NamePrefix2 { get; set; }
    public string NameSuffix { get; set; }
    public string NameSuffix2 { get; set; }
    public string NewAreaCode { get; set; }
    public string Occupation { get; set; }
    public string OwnRent { get; set; }
    public string PhoneCountryCode { get; set; }
    public string PhoneCountryName { get; set; }
    public string PhoneExtension { get; set; }
    public string PhoneNumber { get; set; }
    public string PhonePrefix { get; set; }
    public string PhoneSuffix { get; set; }
    public string PlaceCode { get; set; }
    public string PlaceName { get; set; }
    public string Plus4 { get; set; }
    public string PoliticalParty { get; set; }
    public string PostalCode { get; set; }
    public string PresenceOfChildren { get; set; }
    public string PresenceOfSenior { get; set; }
    public string PrivateMailBox { get; set; }
    public string RecordID { get; set; }
    public string Results { get; set; }
    public string Salutation { get; set; }
    public string SecondarySchoolDistrictCode { get; set; }
    public string SecondarySchoolDistrictName { get; set; }
    public string State { get; set; }
    public string StateDistrictLower { get; set; }
    public string StateDistrictUpper { get; set; }
    public string StateName { get; set; }
    public string Suite { get; set; }
    public string TopLevelDomain { get; set; }
    public string UTC { get; set; }
    public string UnifiedSchoolDistrictCode { get; set; }
    public string UnifiedSchoolDistrictName { get; set; }
    public string RecordExtras { get; set; }
    public string Reserved { get; set; }

    // Setters
    public void SetAddressDeliveryInstallation(string addressDeliveryInstallation)
    {
      this.AddressDeliveryInstallation = addressDeliveryInstallation;
    }

    public void SetAddressExtras(string addressExtras)
    {
      this.AddressExtras = addressExtras;
    }

    public void SetAddressHouseNumber(string addressHouseNumber)
    {
      this.AddressHouseNumber = addressHouseNumber;
    }

    public void SetAddressKey(string addressKey)
    {
      this.AddressKey = addressKey;
    }

    public void SetAddressLine1(string addressLine1)
    {
      this.AddressLine1 = addressLine1;
    }

    public void SetAddressLine2(string addressLine2)
    {
      this.AddressLine2 = addressLine2;
    }

    public void SetAddressLockBox(string addressLockBox)
    {
      this.AddressLockBox = addressLockBox;
    }

    public void SetAddressPostDirection(string addressPostDirection)
    {
      this.AddressPostDirection = addressPostDirection;
    }

    public void SetAddressPreDirection(string addressPreDirection)
    {
      this.AddressPreDirection = addressPreDirection;
    }

    public void SetAddressPrivateMailboxName(string addressPrivateMailboxName)
    {
      this.AddressPrivateMailboxName = addressPrivateMailboxName;
    }

    public void SetAddressPrivateMailboxRange(string addressPrivateMailboxRange)
    {
      this.AddressPrivateMailboxRange = addressPrivateMailboxRange;
    }

    public void SetAddressRouteService(string addressRouteService)
    {
      this.AddressRouteService = addressRouteService;
    }

    public void SetAddressStreetName(string addressStreetName)
    {
      this.AddressStreetName = addressStreetName;
    }

    public void SetAddressStreetSuffix(string addressStreetSuffix)
    {
      this.AddressStreetSuffix = addressStreetSuffix;
    }

    public void SetAddressSuiteName(string addressSuiteName)
    {
      this.AddressSuiteName = addressSuiteName;
    }

    public void SetAddressSuiteNumber(string addressSuiteNumber)
    {
      this.AddressSuiteNumber = addressSuiteNumber;
    }

    public void SetAddressTypeCode(string addressTypeCode)
    {
      this.AddressTypeCode = addressTypeCode;
    }

    public void SetAreaCode(string areaCode)
    {
      this.AreaCode = areaCode;
    }

    public void SetCBSACode(string cbsaCode)
    {
      this.CBSACode = cbsaCode;
    }

    public void SetCBSADivisionCode(string cbsaDivisionCode)
    {
      this.CBSADivisionCode = cbsaDivisionCode;
    }

    public void SetCBSADivisionLevel(string cbsaDivisionLevel)
    {
      this.CBSADivisionLevel = cbsaDivisionLevel;
    }

    public void SetCBSADivisionTitle(string cbsaDivisionTitle)
    {
      this.CBSADivisionTitle = cbsaDivisionTitle;
    }

    public void SetCBSALevel(string cbsaLevel)
    {
      this.CBSALevel = cbsaLevel;
    }

    public void SetCBSATitle(string cbsaTitle)
    {
      this.CBSATitle = cbsaTitle;
    }

    public void SetCarrierRoute(string carrierRoute)
    {
      this.CarrierRoute = carrierRoute;
    }

    public void SetCensusBlock(string censusBlock)
    {
      this.CensusBlock = censusBlock;
    }

    public void SetCensusKey(string censusKey)
    {
      this.CensusKey = censusKey;
    }

    public void SetCensusTract(string censusTract)
    {
      this.CensusTract = censusTract;
    }

    public void SetChildrenAgeRange(string childrenAgeRange)
    {
      this.ChildrenAgeRange = childrenAgeRange;
    }

    public void SetCity(string city)
    {
      this.City = city;
    }

    public void SetCityAbbreviation(string cityAbbreviation)
    {
      this.CityAbbreviation = cityAbbreviation;
    }

    public void SetCompanyName(string companyName)
    {
      this.CompanyName = companyName;
    }

    public void SetCongressionalDistrict(string congressionalDistrict)
    {
      this.CongressionalDistrict = congressionalDistrict;
    }

    public void SetCountryCode(string countryCode)
    {
      this.CountryCode = countryCode;
    }

    public void SetCountryName(string countryName)
    {
      this.CountryName = countryName;
    }

    public void SetCountyFIPS(string countyFIPS)
    {
      this.CountyFIPS = countyFIPS;
    }

    public void SetCountyName(string countyName)
    {
      this.CountyName = countyName;
    }

    public void SetCountySubdivisionCode(string countySubdivisionCode)
    {
      this.CountySubdivisionCode = countySubdivisionCode;
    }

    public void SetCountySubdivisionName(string countySubdivisionName)
    {
      this.CountySubdivisionName = countySubdivisionName;
    }

    public void SetCreditCardUser(string creditCardUser)
    {
      this.CreditCardUser = creditCardUser;
    }

    public void SetDateLastConfirmed(string dateLastConfirmed)
    {
      this.DateLastConfirmed = dateLastConfirmed;
    }

    public void SetDateOfBirth(string dateOfBirth)
    {
      this.DateOfBirth = dateOfBirth;
    }

    public void SetDateOfDeath(string dateOfDeath)
    {
      this.DateOfDeath = dateOfDeath;
    }

    public void SetDeliveryIndicator(string deliveryIndicator)
    {
      this.DeliveryIndicator = deliveryIndicator;
    }

    public void SetDeliveryPointCheckDigit(string deliveryPointCheckDigit)
    {
      this.DeliveryPointCheckDigit = deliveryPointCheckDigit;
    }

    public void SetDeliveryPointCode(string deliveryPointCode)
    {
      this.DeliveryPointCode = deliveryPointCode;
    }

    public void SetDemographicsGender(string demographicsGender)
    {
      this.DemographicsGender = demographicsGender;
    }

    public void SetDemographicsResults(string demographicsResults)
    {
      this.DemographicsResults = demographicsResults;
    }

    public void SetDistanceAddressToIP(string distanceAddressToIP)
    {
      this.DistanceAddressToIP = distanceAddressToIP;
    }

    public void SetDomainName(string domainName)
    {
      this.DomainName = domainName;
    }

    public void SetEducation(string education)
    {
      this.Education = education;
    }

    public void SetElementarySchoolDistrictCode(string elementarySchoolDistrictCode)
    {
      this.ElementarySchoolDistrictCode = elementarySchoolDistrictCode;
    }

    public void SetElementarySchoolDistrictName(string elementarySchoolDistrictName)
    {
      this.ElementarySchoolDistrictName = elementarySchoolDistrictName;
    }

    public void SetEmailAddress(string emailAddress)
    {
      this.EmailAddress = emailAddress;
    }

    public void SetEstimatedHomeValue(string estimatedHomeValue)
    {
      this.EstimatedHomeValue = estimatedHomeValue;
    }

    public void SetEthnicCode(string ethnicCode)
    {
      this.EthnicCode = ethnicCode;
    }

    public void SetEthnicGroup(string ethnicGroup)
    {
      this.EthnicGroup = ethnicGroup;
    }

    public void SetGender(string gender)
    {
      this.Gender = gender;
    }

    public void SetGender2(string gender2)
    {
      this.Gender2 = gender2;
    }

    public void SetHouseholdIncome(string householdIncome)
    {
      this.HouseholdIncome = householdIncome;
    }

    public void SetHouseholdSize(string householdSize)
    {
      this.HouseholdSize = householdSize;
    }

    public void SetIPAddress(string ipAddress)
    {
      this.IPAddress = ipAddress;
    }

    public void SetIPCity(string ipCity)
    {
      this.IPCity = ipCity;
    }

    public void SetIPConnectionSpeed(string ipConnectionSpeed)
    {
      this.IPConnectionSpeed = ipConnectionSpeed;
    }

    public void SetIPConnectionType(string ipConnectionType)
    {
      this.IPConnectionType = ipConnectionType;
    }

    public void SetIPContinent(string ipContinent)
    {
      this.IPContinent = ipContinent;
    }

    public void SetIPCountryAbbreviation(string ipCountryAbbreviation)
    {
      this.IPCountryAbbreviation = ipCountryAbbreviation;
    }

    public void SetIPCountryName(string ipCountryName)
    {
      this.IPCountryName = ipCountryName;
    }

    public void SetIPDomainName(string ipDomainName)
    {
      this.IPDomainName = ipDomainName;
    }

    public void SetIPISPName(string ipISPName)
    {
      this.IPISPName = ipISPName;
    }

    public void SetIPLatitude(string ipLatitude)
    {
      this.IPLatitude = ipLatitude;
    }

    public void SetIPLongitude(string ipLongitude)
    {
      this.IPLongitude = ipLongitude;
    }

    public void SetIPPostalCode(string ipPostalCode)
    {
      this.IPPostalCode = ipPostalCode;
    }

    public void SetIPProxyDescription(string ipProxyDescription)
    {
      this.IPProxyDescription = ipProxyDescription;
    }

    public void SetIPProxyType(string ipProxyType)
    {
      this.IPProxyType = ipProxyType;
    }

    public void SetIPRegion(string ipRegion)
    {
      this.IPRegion = ipRegion;
    }

    public void SetIPUTC(string ipUTC)
    {
      this.IPUTC = ipUTC;
    }

    public void SetLatitude(string latitude)
    {
      this.Latitude = latitude;
    }

    public void SetLengthOfResidence(string lengthOfResidence)
    {
      this.LengthOfResidence = lengthOfResidence;
    }

    public void SetLongitude(string longitude)
    {
      this.Longitude = longitude;
    }

    public void SetMailboxName(string mailboxName)
    {
      this.MailboxName = mailboxName;
    }

    public void SetMaritalStatus(string maritalStatus)
    {
      this.MaritalStatus = maritalStatus;
    }

    public void SetMelissaAddressKey(string melissaAddressKey)
    {
      this.MelissaAddressKey = melissaAddressKey;
    }

    public void SetMelissaAddressKeyBase(string melissaAddressKeyBase)
    {
      this.MelissaAddressKeyBase = melissaAddressKeyBase;
    }

    public void SetMelissaIdentityKey(string melissaIdentityKey)
    {
      this.MelissaIdentityKey = melissaIdentityKey;
    }

    public void SetMoveDate(string moveDate)
    {
      this.MoveDate = moveDate;
    }

    public void SetNameFirst(string nameFirst)
    {
      this.NameFirst = nameFirst;
    }

    public void SetNameFirst2(string nameFirst2)
    {
      this.NameFirst2 = nameFirst2;
    }

    public void SetNameFull(string nameFull)
    {
      this.NameFull = nameFull;
    }

    public void SetNameLast(string nameLast)
    {
      this.NameLast = nameLast;
    }

    public void SetNameLast2(string nameLast2)
    {
      this.NameLast2 = nameLast2;
    }

    public void SetNameMiddle(string nameMiddle)
    {
      this.NameMiddle = nameMiddle;
    }

    public void SetNameMiddle2(string nameMiddle2)
    {
      this.NameMiddle2 = nameMiddle2;
    }

    public void SetNamePrefix(string namePrefix)
    {
      this.NamePrefix = namePrefix;
    }

    public void SetNamePrefix2(string namePrefix2)
    {
      this.NamePrefix2 = namePrefix2;
    }

    public void SetNameSuffix(string nameSuffix)
    {
      this.NameSuffix = nameSuffix;
    }

    public void SetNameSuffix2(string nameSuffix2)
    {
      this.NameSuffix2 = nameSuffix2;
    }

    public void SetNewAreaCode(string newAreaCode)
    {
      this.NewAreaCode = newAreaCode;
    }

    public void SetOccupation(string occupation)
    {
      this.Occupation = occupation;
    }

    public void SetOwnRent(string ownRent)
    {
      this.OwnRent = ownRent;
    }

    public void SetPhoneCountryCode(string phoneCountryCode)
    {
      this.PhoneCountryCode = phoneCountryCode;
    }

    public void SetPhoneCountryName(string phoneCountryName)
    {
      this.PhoneCountryName = phoneCountryName;
    }

    public void SetPhoneExtension(string phoneExtension)
    {
      this.PhoneExtension = phoneExtension;
    }

    public void SetPhoneNumber(string phoneNumber)
    {
      this.PhoneNumber = phoneNumber;
    }

    public void SetPhonePrefix(string phonePrefix)
    {
      this.PhonePrefix = phonePrefix;
    }

    public void SetPhoneSuffix(string phoneSuffix)
    {
      this.PhoneSuffix = phoneSuffix;
    }

    public void SetPlaceCode(string placeCode)
    {
      this.PlaceCode = placeCode;
    }

    public void SetPlaceName(string placeName)
    {
      this.PlaceName = placeName;
    }

    public void SetPlus4(string plus4)
    {
      this.Plus4 = plus4;
    }

    public void SetPoliticalParty(string politicalParty)
    {
      this.PoliticalParty = politicalParty;
    }

    public void SetPostalCode(string postalCode)
    {
      this.PostalCode = postalCode;
    }

    public void SetPresenceOfChildren(string presenceOfChildren)
    {
      this.PresenceOfChildren = presenceOfChildren;
    }

    public void SetPresenceOfSenior(string presenceOfSenior)
    {
      this.PresenceOfSenior = presenceOfSenior;
    }

    public void SetPrivateMailBox(string privateMailBox)
    {
      this.PrivateMailBox = privateMailBox;
    }

    public void SetRecordID(string recordID)
    {
      this.RecordID = recordID;
    }

    public void SetResults(string results)
    {
      this.Results = results;
    }

    public void SetSalutation(string salutation)
    {
      this.Salutation = salutation;
    }

    public void SetSecondarySchoolDistrictCode(string secondarySchoolDistrictCode)
    {
      this.SecondarySchoolDistrictCode = secondarySchoolDistrictCode;
    }

    public void SetSecondarySchoolDistrictName(string secondarySchoolDistrictName)
    {
      this.SecondarySchoolDistrictName = secondarySchoolDistrictName;
    }

    public void SetState(string state)
    {
      this.State = state;
    }

    public void SetStateDistrictLower(string stateDistrictLower)
    {
      this.StateDistrictLower = stateDistrictLower;
    }

    public void SetStateDistrictUpper(string stateDistrictUpper)
    {
      this.StateDistrictUpper = stateDistrictUpper;
    }

    public void SetStateName(string stateName)
    {
      this.StateName = stateName;
    }

    public void SetSuite(string suite)
    {
      this.Suite = suite;
    }

    public void SetTopLevelDomain(string topLevelDomain)
    {
      this.TopLevelDomain = topLevelDomain;
    }

    public void SetUTC(string utc)
    {
      this.UTC = utc;
    }

    public void SetUnifiedSchoolDistrictCode(string unifiedSchoolDistrictCode)
    {
      this.UnifiedSchoolDistrictCode = unifiedSchoolDistrictCode;
    }

    public void SetUnifiedSchoolDistrictName(string unifiedSchoolDistrictName)
    {
      this.UnifiedSchoolDistrictName = unifiedSchoolDistrictName;
    }

    public void SetRecordExtras(string recordExtras)
    {
      this.RecordExtras = recordExtras;
    }

    public void SetReserved(string reserved)
    {
      this.Reserved = reserved;
    }

    // Getters
    public string GetAddressDeliveryInstallation()
    {
      return string.IsNullOrEmpty(this.AddressDeliveryInstallation) ? "" : this.AddressDeliveryInstallation;
    }

    public string GetAddressExtras()
    {
      return string.IsNullOrEmpty(this.AddressExtras) ? "" : this.AddressExtras;
    }

    public string GetAddressHouseNumber()
    {
      return string.IsNullOrEmpty(this.AddressHouseNumber) ? "" : this.AddressHouseNumber;
    }

    public string GetAddressKey()
    {
      return string.IsNullOrEmpty(this.AddressKey) ? "" : this.AddressKey;
    }

    public string GetAddressLine1()
    {
      return string.IsNullOrEmpty(this.AddressLine1) ? "" : this.AddressLine1;
    }

    public string GetAddressLine2()
    {
      return string.IsNullOrEmpty(this.AddressLine2) ? "" : this.AddressLine2;
    }

    public string GetAddressLockBox()
    {
      return string.IsNullOrEmpty(this.AddressLockBox) ? "" : this.AddressLockBox;
    }

    public string GetAddressPostDirection()
    {
      return string.IsNullOrEmpty(this.AddressPostDirection) ? "" : this.AddressPostDirection;
    }

    public string GetAddressPreDirection()
    {
      return string.IsNullOrEmpty(this.AddressPreDirection) ? "" : this.AddressPreDirection;
    }

    public string GetAddressPrivateMailboxName()
    {
      return string.IsNullOrEmpty(this.AddressPrivateMailboxName) ? "" : this.AddressPrivateMailboxName;
    }

    public string GetAddressPrivateMailboxRange()
    {
      return string.IsNullOrEmpty(this.AddressPrivateMailboxRange) ? "" : this.AddressPrivateMailboxRange;
    }

    public string GetAddressRouteService()
    {
      return string.IsNullOrEmpty(this.AddressRouteService) ? "" : this.AddressRouteService;
    }

    public string GetAddressStreetName()
    {
      return string.IsNullOrEmpty(this.AddressStreetName) ? "" : this.AddressStreetName;
    }

    public string GetAddressStreetSuffix()
    {
      return string.IsNullOrEmpty(this.AddressStreetSuffix) ? "" : this.AddressStreetSuffix;
    }

    public string GetAddressSuiteName()
    {
      return string.IsNullOrEmpty(this.AddressSuiteName) ? "" : this.AddressSuiteName;
    }

    public string GetAddressSuiteNumber()
    {
      return string.IsNullOrEmpty(this.AddressSuiteNumber) ? "" : this.AddressSuiteNumber;
    }

    public string GetAddressTypeCode()
    {
      return string.IsNullOrEmpty(this.AddressTypeCode) ? "" : this.AddressTypeCode;
    }

    public string GetAreaCode()
    {
      return string.IsNullOrEmpty(this.AreaCode) ? "" : this.AreaCode;
    }

    public string GetCBSACode()
    {
      return string.IsNullOrEmpty(this.CBSACode) ? "" : this.CBSACode;
    }

    public string GetCBSADivisionCode()
    {
      return string.IsNullOrEmpty(this.CBSADivisionCode) ? "" : this.CBSADivisionCode;
    }

    public string GetCBSADivisionLevel()
    {
      return string.IsNullOrEmpty(this.CBSADivisionLevel) ? "" : this.CBSADivisionLevel;
    }

    public string GetCBSADivisionTitle()
    {
      return string.IsNullOrEmpty(this.CBSADivisionTitle) ? "" : this.CBSADivisionTitle;
    }

    public string GetCBSALevel()
    {
      return string.IsNullOrEmpty(this.CBSALevel) ? "" : this.CBSALevel;
    }

    public string GetCBSATitle()
    {
      return string.IsNullOrEmpty(this.CBSATitle) ? "" : this.CBSATitle;
    }

    public string GetCarrierRoute()
    {
      return string.IsNullOrEmpty(this.CarrierRoute) ? "" : this.CarrierRoute;
    }

    public string GetCensusBlock()
    {
      return string.IsNullOrEmpty(this.CensusBlock) ? "" : this.CensusBlock;
    }

    public string GetCensusKey()
    {
      return string.IsNullOrEmpty(this.CensusKey) ? "" : this.CensusKey;
    }

    public string GetCensusTract()
    {
      return string.IsNullOrEmpty(this.CensusTract) ? "" : this.CensusTract;
    }

    public string GetChildrenAgeRange()
    {
      return string.IsNullOrEmpty(this.ChildrenAgeRange) ? "" : this.ChildrenAgeRange;
    }

    public string GetCity()
    {
      return string.IsNullOrEmpty(this.City) ? "" : this.City;
    }

    public string GetCityAbbreviation()
    {
      return string.IsNullOrEmpty(this.CityAbbreviation) ? "" : this.CityAbbreviation;
    }

    public string GetCompanyName()
    {
      return string.IsNullOrEmpty(this.CompanyName) ? "" : this.CompanyName;
    }

    public string GetCongressionalDistrict()
    {
      return string.IsNullOrEmpty(this.CongressionalDistrict) ? "" : this.CongressionalDistrict;
    }

    public string GetCountryCode()
    {
      return string.IsNullOrEmpty(this.CountryCode) ? "" : this.CountryCode;
    }

    public string GetCountryName()
    {
      return string.IsNullOrEmpty(this.CountryName) ? "" : this.CountryName;
    }

    public string GetCountyFIPS()
    {
      return string.IsNullOrEmpty(this.CountyFIPS) ? "" : this.CountyFIPS;
    }

    public string GetCountyName()
    {
      return string.IsNullOrEmpty(this.CountyName) ? "" : this.CountyName;
    }

    public string GetCountySubdivisionCode()
    {
      return string.IsNullOrEmpty(this.CountySubdivisionCode) ? "" : this.CountySubdivisionCode;
    }

    public string GetCountySubdivisionName()
    {
      return string.IsNullOrEmpty(this.CountySubdivisionName) ? "" : this.CountySubdivisionName;
    }

    public string GetCreditCardUser()
    {
      return string.IsNullOrEmpty(this.CreditCardUser) ? "" : this.CreditCardUser;
    }

    public string GetDateLastConfirmed()
    {
      return string.IsNullOrEmpty(this.DateLastConfirmed) ? "" : this.DateLastConfirmed;
    }

    public string GetDateOfBirth()
    {
      return string.IsNullOrEmpty(this.DateOfBirth) ? "" : this.DateOfBirth;
    }

    public string GetDateOfDeath()
    {
      return string.IsNullOrEmpty(this.DateOfDeath) ? "" : this.DateOfDeath;
    }

    public string GetDeliveryIndicator()
    {
      return string.IsNullOrEmpty(this.DeliveryIndicator) ? "" : this.DeliveryIndicator;
    }

    public string GetDeliveryPointCheckDigit()
    {
      return string.IsNullOrEmpty(this.DeliveryPointCheckDigit) ? "" : this.DeliveryPointCheckDigit;
    }

    public string GetDeliveryPointCode()
    {
      return string.IsNullOrEmpty(this.DeliveryPointCode) ? "" : this.DeliveryPointCode;
    }

    public string GetDemographicsGender()
    {
      return string.IsNullOrEmpty(this.DemographicsGender) ? "" : this.DemographicsGender;
    }

    public string GetDemographicsResults()
    {
      return string.IsNullOrEmpty(this.DemographicsResults) ? "" : this.DemographicsResults;
    }

    public string GetDistanceAddressToIP()
    {
      return string.IsNullOrEmpty(this.DistanceAddressToIP) ? "" : this.DistanceAddressToIP;
    }

    public string GetDomainName()
    {
      return string.IsNullOrEmpty(this.DomainName) ? "" : this.DomainName;
    }

    public string GetEducation()
    {
      return string.IsNullOrEmpty(this.Education) ? "" : this.Education;
    }

    public string GetElementarySchoolDistrictCode()
    {
      return string.IsNullOrEmpty(this.ElementarySchoolDistrictCode) ? "" : this.ElementarySchoolDistrictCode;
    }

    public string GetElementarySchoolDistrictName()
    {
      return string.IsNullOrEmpty(this.ElementarySchoolDistrictName) ? "" : this.ElementarySchoolDistrictName;
    }

    public string GetEmailAddress()
    {
      return string.IsNullOrEmpty(this.EmailAddress) ? "" : this.EmailAddress;
    }

    public string GetEstimatedHomeValue()
    {
      return string.IsNullOrEmpty(this.EstimatedHomeValue) ? "" : this.EstimatedHomeValue;
    }

    public string GetEthnicCode()
    {
      return string.IsNullOrEmpty(this.EthnicCode) ? "" : this.EthnicCode;
    }

    public string GetEthnicGroup()
    {
      return string.IsNullOrEmpty(this.EthnicGroup) ? "" : this.EthnicGroup;
    }

    public string GetGender()
    {
      return string.IsNullOrEmpty(this.Gender) ? "" : this.Gender;
    }

    public string GetGender2()
    {
      return string.IsNullOrEmpty(this.Gender2) ? "" : this.Gender2;
    }

    public string GetHouseholdIncome()
    {
      return string.IsNullOrEmpty(this.HouseholdIncome) ? "" : this.HouseholdIncome;
    }

    public string GetHouseholdSize()
    {
      return string.IsNullOrEmpty(this.HouseholdSize) ? "" : this.HouseholdSize;
    }

    public string GetIPAddress()
    {
      return string.IsNullOrEmpty(this.IPAddress) ? "" : this.IPAddress;
    }

    public string GetIPCity()
    {
      return string.IsNullOrEmpty(this.IPCity) ? "" : this.IPCity;
    }

    public string GetIPConnectionSpeed()
    {
      return string.IsNullOrEmpty(this.IPConnectionSpeed) ? "" : this.IPConnectionSpeed;
    }

    public string GetIPConnectionType()
    {
      return string.IsNullOrEmpty(this.IPConnectionType) ? "" : this.IPConnectionType;
    }

    public string GetIPContinent()
    {
      return string.IsNullOrEmpty(this.IPContinent) ? "" : this.IPContinent;
    }

    public string GetIPCountryAbbreviation()
    {
      return string.IsNullOrEmpty(this.IPCountryAbbreviation) ? "" : this.IPCountryAbbreviation;
    }

    public string GetIPCountryName()
    {
      return string.IsNullOrEmpty(this.IPCountryName) ? "" : this.IPCountryName;
    }

    public string GetIPDomainName()
    {
      return string.IsNullOrEmpty(this.IPDomainName) ? "" : this.IPDomainName;
    }

    public string GetIPISPName()
    {
      return string.IsNullOrEmpty(this.IPISPName) ? "" : this.IPISPName;
    }

    public string GetIPLatitude()
    {
      return string.IsNullOrEmpty(this.IPLatitude) ? "" : this.IPLatitude;
    }

    public string GetIPLongitude()
    {
      return string.IsNullOrEmpty(this.IPLongitude) ? "" : this.IPLongitude;
    }

    public string GetIPPostalCode()
    {
      return string.IsNullOrEmpty(this.IPPostalCode) ? "" : this.IPPostalCode;
    }

    public string GetIPProxyDescription()
    {
      return string.IsNullOrEmpty(this.IPProxyDescription) ? "" : this.IPProxyDescription;
    }

    public string GetIPProxyType()
    {
      return string.IsNullOrEmpty(this.IPProxyType) ? "" : this.IPProxyType;
    }

    public string GetIPRegion()
    {
      return string.IsNullOrEmpty(this.IPRegion) ? "" : this.IPRegion;
    }

    public string GetIPUTC()
    {
      return string.IsNullOrEmpty(this.IPUTC) ? "" : this.IPUTC;
    }

    public string GetLatitude()
    {
      return string.IsNullOrEmpty(this.Latitude) ? "" : this.Latitude;
    }

    public string GetLengthOfResidence()
    {
      return string.IsNullOrEmpty(this.LengthOfResidence) ? "" : this.LengthOfResidence;
    }

    public string GetLongitude()
    {
      return string.IsNullOrEmpty(this.Longitude) ? "" : this.Longitude;
    }

    public string GetMailboxName()
    {
      return string.IsNullOrEmpty(this.MailboxName) ? "" : this.MailboxName;
    }

    public string GetMaritalStatus()
    {
      return string.IsNullOrEmpty(this.MaritalStatus) ? "" : this.MaritalStatus;
    }

    public string GetMelissaAddressKey()
    {
      return string.IsNullOrEmpty(this.MelissaAddressKey) ? "" : this.MelissaAddressKey;
    }

    public string GetMelissaAddressKeyBase()
    {
      return string.IsNullOrEmpty(this.MelissaAddressKeyBase) ? "" : this.MelissaAddressKeyBase;
    }

    public string GetMelissaIdentityKey()
    {
      return string.IsNullOrEmpty(this.MelissaIdentityKey) ? "" : this.MelissaIdentityKey;
    }

    public string GetMoveDate()
    {
      return string.IsNullOrEmpty(this.MoveDate) ? "" : this.MoveDate;
    }

    public string GetNameFirst()
    {
      return string.IsNullOrEmpty(this.NameFirst) ? "" : this.NameFirst;
    }

    public string GetNameFirst2()
    {
      return string.IsNullOrEmpty(this.NameFirst2) ? "" : this.NameFirst2;
    }

    public string GetNameFull()
    {
      return string.IsNullOrEmpty(this.NameFull) ? "" : this.NameFull;
    }

    public string GetNameLast()
    {
      return string.IsNullOrEmpty(this.NameLast) ? "" : this.NameLast;
    }

    public string GetNameLast2()
    {
      return string.IsNullOrEmpty(this.NameLast2) ? "" : this.NameLast2;
    }

    public string GetNameMiddle()
    {
      return string.IsNullOrEmpty(this.NameMiddle) ? "" : this.NameMiddle;
    }

    public string GetNameMiddle2()
    {
      return string.IsNullOrEmpty(this.NameMiddle2) ? "" : this.NameMiddle2;
    }

    public string GetNamePrefix()
    {
      return string.IsNullOrEmpty(this.NamePrefix) ? "" : this.NamePrefix;
    }

    public string GetNamePrefix2()
    {
      return string.IsNullOrEmpty(this.NamePrefix2) ? "" : this.NamePrefix2;
    }

    public string GetNameSuffix()
    {
      return string.IsNullOrEmpty(this.NameSuffix) ? "" : this.NameSuffix;
    }

    public string GetNameSuffix2()
    {
      return string.IsNullOrEmpty(this.NameSuffix2) ? "" : this.NameSuffix2;
    }

    public string GetNewAreaCode()
    {
      return string.IsNullOrEmpty(this.NewAreaCode) ? "" : this.NewAreaCode;
    }

    public string GetOccupation()
    {
      return string.IsNullOrEmpty(this.Occupation) ? "" : this.Occupation;
    }

    public string GetOwnRent()
    {
      return string.IsNullOrEmpty(this.OwnRent) ? "" : this.OwnRent;
    }

    public string GetPhoneCountryCode()
    {
      return string.IsNullOrEmpty(this.PhoneCountryCode) ? "" : this.PhoneCountryCode;
    }

    public string GetPhoneCountryName()
    {
      return string.IsNullOrEmpty(this.PhoneCountryName) ? "" : this.PhoneCountryName;
    }

    public string GetPhoneExtension()
    {
      return string.IsNullOrEmpty(this.PhoneExtension) ? "" : this.PhoneExtension;
    }

    public string GetPhoneNumber()
    {
      return string.IsNullOrEmpty(this.PhoneNumber) ? "" : this.PhoneNumber;
    }

    public string GetPhonePrefix()
    {
      return string.IsNullOrEmpty(this.PhonePrefix) ? "" : this.PhonePrefix;
    }

    public string GetPhoneSuffix()
    {
      return string.IsNullOrEmpty(this.PhoneSuffix) ? "" : this.PhoneSuffix;
    }

    public string GetPlaceCode()
    {
      return string.IsNullOrEmpty(this.PlaceCode) ? "" : this.PlaceCode;
    }

    public string GetPlaceName()
    {
      return string.IsNullOrEmpty(this.PlaceName) ? "" : this.PlaceName;
    }

    public string GetPlus4()
    {
      return string.IsNullOrEmpty(this.Plus4) ? "" : this.Plus4;
    }

    public string GetPoliticalParty()
    {
      return string.IsNullOrEmpty(this.PoliticalParty) ? "" : this.PoliticalParty;
    }

    public string GetPostalCode()
    {
      return string.IsNullOrEmpty(this.PostalCode) ? "" : this.PostalCode;
    }

    public string GetPresenceOfChildren()
    {
      return string.IsNullOrEmpty(this.PresenceOfChildren) ? "" : this.PresenceOfChildren;
    }

    public string GetPresenceOfSenior()
    {
      return string.IsNullOrEmpty(this.PresenceOfSenior) ? "" : this.PresenceOfSenior;
    }

    public string GetPrivateMailBox()
    {
      return string.IsNullOrEmpty(this.PrivateMailBox) ? "" : this.PrivateMailBox;
    }

    public string GetRecordID()
    {
      return string.IsNullOrEmpty(this.RecordID) ? "" : this.RecordID;
    }

    public string GetResults()
    {
      return string.IsNullOrEmpty(this.Results) ? "" : this.Results;
    }

    public string GetSalutation()
    {
      return string.IsNullOrEmpty(this.Salutation) ? "" : this.Salutation;
    }

    public string GetSecondarySchoolDistrictCode()
    {
      return string.IsNullOrEmpty(this.SecondarySchoolDistrictCode) ? "" : this.SecondarySchoolDistrictCode;
    }

    public string GetSecondarySchoolDistrictName()
    {
      return string.IsNullOrEmpty(this.SecondarySchoolDistrictName) ? "" : this.SecondarySchoolDistrictName;
    }

    public string GetState()
    {
      return string.IsNullOrEmpty(this.State) ? "" : this.State;
    }

    public string GetStateDistrictLower()
    {
      return string.IsNullOrEmpty(this.StateDistrictLower) ? "" : this.StateDistrictLower;
    }

    public string GetStateDistrictUpper()
    {
      return string.IsNullOrEmpty(this.StateDistrictUpper) ? "" : this.StateDistrictUpper;
    }

    public string GetStateName()
    {
      return string.IsNullOrEmpty(this.StateName) ? "" : this.StateName;
    }

    public string GetSuite()
    {
      return string.IsNullOrEmpty(this.Suite) ? "" : this.Suite;
    }

    public string GetTopLevelDomain()
    {
      return string.IsNullOrEmpty(this.TopLevelDomain) ? "" : this.TopLevelDomain;
    }

    public string GetUTC()
    {
      return string.IsNullOrEmpty(this.UTC) ? "" : this.UTC;
    }

    public string GetUnifiedSchoolDistrictCode()
    {
      return string.IsNullOrEmpty(this.UnifiedSchoolDistrictCode) ? "" : this.UnifiedSchoolDistrictCode;
    }

    public string GetUnifiedSchoolDistrictName()
    {
      return string.IsNullOrEmpty(this.UnifiedSchoolDistrictName) ? "" : this.UnifiedSchoolDistrictName;
    }

    public string GetRecordExtras()
    {
      return string.IsNullOrEmpty(this.RecordExtras) ? "" : this.RecordExtras;
    }

    public string GetReserved()
    {
      return string.IsNullOrEmpty(this.Reserved) ? "" : this.Reserved;
    }
  }
}
