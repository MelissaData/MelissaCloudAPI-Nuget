using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class SmartMoverResponse : ResponseBase
  {
    public string Version { get; set; }
    public string TransmissionReference { get; set; }
    public string TransmissionResults { get; set; }
    public string TotalRecords { get; set; }
    public string CASSReportLink { get; set; }
    public string NCOAReportLink { get; set; }
    public List<SmartMoverRecord> Records { get; set; }

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

    public void SetCASSReportLink(string cassReportLink)
    {
      this.CASSReportLink = cassReportLink;
    }

    public void SetNCOAReportLink(string ncoaReportLink)
    {
      this.NCOAReportLink = ncoaReportLink;
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

    public string GetCASSReportLink()
    {
      return string.IsNullOrEmpty(this.CASSReportLink) ? "" : this.CASSReportLink;
    }

    public string GetNCOAReportLink()
    {
      return string.IsNullOrEmpty(this.NCOAReportLink) ? "" : this.NCOAReportLink;
    }
  }

  public class SmartMoverRecord : ResponseBase
  {
    public string AddressExtras { get; set; }
    public string AddressKey { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string AddressTypeCode { get; set; }
    public string BaseMelissaAddressKey { get; set; }
    public string CarrierRoute { get; set; }
    public string City { get; set; }
    public string CityAbbreviation { get; set; }
    public string CompanyName { get; set; }
    public string CountryCode { get; set; }
    public string CountryName { get; set; }
    public string DeliveryIndicator { get; set; }
    public string DeliveryPointCheckDigit { get; set; }
    public string DeliveryPointCode { get; set; }
    public string MelissaAddressKey { get; set; }
    public string MoveEffectiveDate { get; set; }
    public string MoveTypeCode { get; set; }
    public string PostalCode { get; set; }
    public string RecordID { get; set; }
    public string Results { get; set; }
    public string State { get; set; }
    public string StateName { get; set; }
    public string Urbanization { get; set; }
    public string NameFirst { set; get; }
    public string NameFull { get; set; }
    public string NameLast { get; set; }
    public string NameMiddle { get; set; }
    public string NamePrefix { get; set; }
    public string NameSuffix { get; set; }
    public string OriginalAddressLine1 { get; set; }
    public string OriginalAddressLine2 { get; set; }
    public string OriginalCity { get; set; }
    public string OriginalCityAbbreviation { get; set; }
    public string OriginalCountryCode { get; set; }
    public string OriginalPlus4 { get; set; }
    public string OriginalPostalCode { get; set; }
    public string OriginalPrivateMailbox { get; set; }
    public string OriginalResults { get; set; }
    public string OriginalState { get; set; }
    public string OriginalStateName { get; set; }
    public string OriginalSuite { get; set; }
    public string OriginalUrbanization { get; set; }
    public string AddressDeliveryInstallation { get; set; }
    public string AddressHouseNumber { get; set; }
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
    public string StandardizedAddressLine1 { get; set; }
    public string StandardizedAddressLine2 { get; set; }
    public string StandardizedBaseMelissaAddressKey { get; set; }
    public string StandardizedCarrierRoute { get; set; }
    public string StandardizedCity { get; set; }
    public string StandardizedCityAbbreviation { get; set; }
    public string StandardizedCountryCode { get; set; }
    public string StandardizedDeliveryIndicator { get; set; }
    public string StandardizedDeliveryPointCheckDigit { get; set; }
    public string StandardizedDeliveryPointCode { get; set; }
    public string StandardizedMelissaAddressKey { get; set; }
    public string StandardizedPlus4 { get; set; }
    public string StandardizedPostalCode { get; set; }
    public string StandardizedPrivateMailbox { get; set; }
    public string StandardizedResults { get; set; }
    public string StandardizedState { get; set; }
    public string StandardizedStateName { get; set; }
    public string StandardizedSuite { get; set; }
    public string StandardizedUrbanization { get; set; }
    public string DPVFootNotes { get; set; }
    public string MoveReturnCode { get; set; }
    public string Plus4 { get; set; }
    public string PrivateMailbox { get; set; }
    public string Suite { get; set; }

    // Setters
    public void SetAddressExtras(string addressExtras)
    {
      this.AddressExtras = addressExtras;
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

    public void SetAddressTypeCode(string addressTypeCode)
    {
      this.AddressTypeCode = addressTypeCode;
    }

    public void SetBaseMelissaAddressKey(string baseMelissaAddressKey)
    {
      this.BaseMelissaAddressKey = baseMelissaAddressKey;
    }

    public void SetCarrierRoute(string carrierRoute)
    {
      this.CarrierRoute = carrierRoute;
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

    public void SetDeliveryPointCheckDigit(string deliveryPointCheckDigit)
    {
      this.DeliveryPointCheckDigit = deliveryPointCheckDigit;
    }

    public void SetDeliveryPointCode(string deliveryPointCode)
    {
      this.DeliveryPointCode = deliveryPointCode;
    }

    public void SetMelissaAddressKey(string melissaAddressKey)
    {
      this.MelissaAddressKey = melissaAddressKey;
    }

    public void SetMoveEffectiveDate(string moveEffectiveDate)
    {
      this.MoveEffectiveDate = moveEffectiveDate;
    }

    public void SetMoveTypeCode(string moveTypeCode)
    {
      this.MoveTypeCode = moveTypeCode;
    }

    public void SetPostalCode(string postalCode)
    {
      this.PostalCode = postalCode;
    }

    public void SetRecordID(string recordID)
    {
      this.RecordID = recordID;
    }

    public void SetResults(string results)
    {
      this.Results = results;
    }

    public void SetState(string state)
    {
      this.State = state;
    }

    public void SetStateName(string stateName)
    {
      this.StateName = stateName;
    }

    public void SetUrbanization(string urbanization)
    {
      this.Urbanization = urbanization;
    }

    public void SetNameFirst(string nameFirst)
    {
      this.NameFirst = nameFirst;
    }

    public void SetNameFull(string nameFull)
    {
      this.NameFull = nameFull;
    }

    public void SetNameLast(string nameLast)
    {
      this.NameLast = nameLast;
    }

    public void SetNameMiddle(string nameMiddle)
    {
      this.NameMiddle = nameMiddle;
    }

    public void SetNamePrefix(string namePrefix)
    {
      this.NamePrefix = namePrefix;
    }

    public void SetNameSuffix(string nameSuffix)
    {
      this.NameSuffix = nameSuffix;
    }

    public void SetOriginalAddressLine1(string originalAddressLine1)
    {
      this.OriginalAddressLine1 = originalAddressLine1;
    }

    public void SetOriginalAddressLine2(string originalAddressLine2)
    {
      this.OriginalAddressLine2 = originalAddressLine2;
    }

    public void SetOriginalCity(string originalCity)
    {
      this.OriginalCity = originalCity;
    }

    public void SetOriginalCityAbbreviation(string originalCityAbbreviation)
    {
      this.OriginalCityAbbreviation = originalCityAbbreviation;
    }

    public void SetOriginalCountryCode(string originalCountryCode)
    {
      this.OriginalCountryCode = originalCountryCode;
    }

    public void SetOriginalPlus4(string originalPlus4)
    {
      this.OriginalPlus4 = originalPlus4;
    }

    public void SetOriginalPostalCode(string originalPostalCode)
    {
      this.OriginalPostalCode = originalPostalCode;
    }

    public void SetOriginalPrivateMailbox(string originalPrivateMailbox)
    {
      this.OriginalPrivateMailbox = originalPrivateMailbox;
    }

    public void SetOriginalResults(string originalResults)
    {
      this.OriginalResults = originalResults;
    }

    public void SetOriginalState(string originalState)
    {
      this.OriginalState = originalState;
    }

    public void SetOriginalStateName(string originalStateName)
    {
      this.OriginalStateName = originalStateName;
    }

    public void SetOriginalSuite(string originalSuite)
    {
      this.OriginalSuite = originalSuite;
    }

    public void SetOriginalUrbanization(string originalUrbanization)
    {
      this.OriginalUrbanization = originalUrbanization;
    }

    public void SetAddressDeliveryInstallation(string addressDeliveryInstallation)
    {
      this.AddressDeliveryInstallation = addressDeliveryInstallation;
    }

    public void SetAddressHouseNumber(string addressHouseNumber)
    {
      this.AddressHouseNumber = addressHouseNumber;
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

    public void SetStandardizedAddressLine1(string standardizedAddressLine1)
    {
      this.StandardizedAddressLine1 = standardizedAddressLine1;
    }

    public void SetStandardizedAddressLine2(string standardizedAddressLine2)
    {
      this.StandardizedAddressLine2 = standardizedAddressLine2;
    }

    public void SetStandardizedBaseMelissaAddressKey(string standardizedBaseMelissaAddressKey)
    {
      this.StandardizedBaseMelissaAddressKey = standardizedBaseMelissaAddressKey;
    }

    public void SetStandardizedCarrierRoute(string standardizedCarrierRoute)
    {
      this.StandardizedCarrierRoute = standardizedCarrierRoute;
    }

    public void SetStandardizedCity(string standardizedCity)
    {
      this.StandardizedCity = standardizedCity;
    }

    public void SetStandardizedCityAbbreviation(string standardizedCityAbbreviation)
    {
      this.StandardizedCityAbbreviation = standardizedCityAbbreviation;
    }

    public void SetStandardizedCountryCode(string standardizedCountryCode)
    {
      this.StandardizedCountryCode = standardizedCountryCode;
    }

    public void SetStandardizedDeliveryIndicator(string standardizedDeliveryIndicator)
    {
      this.StandardizedDeliveryIndicator = standardizedDeliveryIndicator;
    }

    public void SetStandardizedDeliveryPointCheckDigit(string standardizedDeliveryPointCheckDigit)
    {
      this.StandardizedDeliveryPointCheckDigit = standardizedDeliveryPointCheckDigit;
    }

    public void SetStandardizedDeliveryPointCode(string standardizedDeliveryPointCode)
    {
      this.StandardizedDeliveryPointCode = standardizedDeliveryPointCode;
    }

    public void SetStandardizedMelissaAddressKey(string standardizedMelissaAddressKey)
    {
      this.StandardizedMelissaAddressKey = standardizedMelissaAddressKey;
    }

    public void SetStandardizedPlus4(string standardizedPlus4)
    {
      this.StandardizedPlus4 = standardizedPlus4;
    }

    public void SetStandardizedPostalCode(string standardizedPostalCode)
    {
      this.StandardizedPostalCode = standardizedPostalCode;
    }

    public void SetStandardizedPrivateMailbox(string standardizedPrivateMailbox)
    {
      this.StandardizedPrivateMailbox = standardizedPrivateMailbox;
    }

    public void SetStandardizedResults(string standardizedResults)
    {
      this.StandardizedResults = standardizedResults;
    }

    public void SetStandardizedState(string standardizedState)
    {
      this.StandardizedState = standardizedState;
    }

    public void SetStandardizedStateName(string standardizedStateName)
    {
      this.StandardizedStateName = standardizedStateName;
    }

    public void SetStandardizedSuite(string standardizedSuite)
    {
      this.StandardizedSuite = standardizedSuite;
    }

    public void SetStandardizedUrbanization(string standardizedUrbanization)
    {
      this.StandardizedUrbanization = standardizedUrbanization;
    }

    public void SetDPVFootNotes(string dpvFootNotes)
    {
      this.DPVFootNotes = dpvFootNotes;
    }

    public void SetMoveReturnCode(string moveReturnCode)
    {
      this.MoveReturnCode = moveReturnCode;
    }

    public void SetPlus4(string plus4)
    {
      this.Plus4 = plus4;
    }

    public void SetPrivateMailbox(string privateMailbox)
    {
      this.PrivateMailbox = privateMailbox;
    }

    public void SetSuite(string suite)
    {
      this.Suite = suite;
    }

    // Getters
    public string GetAddressExtras()
    {
      return string.IsNullOrEmpty(this.AddressExtras) ? "" : this.AddressExtras;
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

    public string GetAddressTypeCode()
    {
      return string.IsNullOrEmpty(this.AddressTypeCode) ? "" : this.AddressTypeCode;
    }

    public string GetBaseMelissaAddressKey()
    {
      return string.IsNullOrEmpty(this.BaseMelissaAddressKey) ? "" : this.BaseMelissaAddressKey;
    }

    public string GetCarrierRoute()
    {
      return string.IsNullOrEmpty(this.CarrierRoute) ? "" : this.CarrierRoute;
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

    public string GetDeliveryPointCheckDigit()
    {
      return string.IsNullOrEmpty(this.DeliveryPointCheckDigit) ? "" : this.DeliveryPointCheckDigit;
    }

    public string GetDeliveryPointCode()
    {
      return string.IsNullOrEmpty(this.DeliveryPointCode) ? "" : this.DeliveryPointCode;
    }

    public string GetMelissaAddressKey()
    {
      return string.IsNullOrEmpty(this.MelissaAddressKey) ? "" : this.MelissaAddressKey;
    }

    public string GetMoveEffectiveDate()
    {
      return string.IsNullOrEmpty(this.MoveEffectiveDate) ? "" : this.MoveEffectiveDate;
    }

    public string GetMoveTypeCode()
    {
      return string.IsNullOrEmpty(this.MoveTypeCode) ? "" : this.MoveTypeCode;
    }

    public string GetPostalCode()
    {
      return string.IsNullOrEmpty(this.PostalCode) ? "" : this.PostalCode;
    }

    public string GetRecordID()
    {
      return string.IsNullOrEmpty(this.RecordID) ? "" : this.RecordID;
    }

    public string GetResults()
    {
      return string.IsNullOrEmpty(this.Results) ? "" : this.Results;
    }

    public string GetState()
    {
      return string.IsNullOrEmpty(this.State) ? "" : this.State;
    }

    public string GetStateName()
    {
      return string.IsNullOrEmpty(this.StateName) ? "" : this.StateName;
    }

    public string GetUrbanization()
    {
      return string.IsNullOrEmpty(this.Urbanization) ? "" : this.Urbanization;
    }

    public string GetNameFirst()
    {
      return string.IsNullOrEmpty(this.NameFirst) ? "" : this.NameFirst;
    }

    public string GetNameFull()
    {
      return string.IsNullOrEmpty(this.NameFull) ? "" : this.NameFull;
    }

    public string GetNameLast()
    {
      return string.IsNullOrEmpty(this.NameLast) ? "" : this.NameLast;
    }

    public string GetNameMiddle()
    {
      return string.IsNullOrEmpty(this.NameMiddle) ? "" : this.NameMiddle;
    }

    public string GetNamePrefix()
    {
      return string.IsNullOrEmpty(this.NamePrefix) ? "" : this.NamePrefix;
    }

    public string GetNameSuffix()
    {
      return string.IsNullOrEmpty(this.NameSuffix) ? "" : this.NameSuffix;
    }

    public string GetOriginalAddressLine1()
    {
      return string.IsNullOrEmpty(this.OriginalAddressLine1) ? "" : this.OriginalAddressLine1;
    }

    public string GetOriginalAddressLine2()
    {
      return string.IsNullOrEmpty(this.OriginalAddressLine2) ? "" : this.OriginalAddressLine2;
    }

    public string GetOriginalCity()
    {
      return string.IsNullOrEmpty(this.OriginalCity) ? "" : this.OriginalCity;
    }

    public string GetOriginalCityAbbreviation()
    {
      return string.IsNullOrEmpty(this.OriginalCityAbbreviation) ? "" : this.OriginalCityAbbreviation;
    }

    public string GetOriginalCountryCode()
    {
      return string.IsNullOrEmpty(this.OriginalCountryCode) ? "" : this.OriginalCountryCode;
    }

    public string GetOriginalPlus4()
    {
      return string.IsNullOrEmpty(this.OriginalPlus4) ? "" : this.OriginalPlus4;
    }

    public string GetOriginalPostalCode()
    {
      return string.IsNullOrEmpty(this.OriginalPostalCode) ? "" : this.OriginalPostalCode;
    }

    public string GetOriginalPrivateMailbox()
    {
      return string.IsNullOrEmpty(this.OriginalPrivateMailbox) ? "" : this.OriginalPrivateMailbox;
    }

    public string GetOriginalResults()
    {
      return string.IsNullOrEmpty(this.OriginalResults) ? "" : this.OriginalResults;
    }

    public string GetOriginalState()
    {
      return string.IsNullOrEmpty(this.OriginalState) ? "" : this.OriginalState;
    }

    public string GetOriginalStateName()
    {
      return string.IsNullOrEmpty(this.OriginalStateName) ? "" : this.OriginalStateName;
    }

    public string GetOriginalSuite()
    {
      return string.IsNullOrEmpty(this.OriginalSuite) ? "" : this.OriginalSuite;
    }

    public string GetOriginalUrbanization()
    {
      return string.IsNullOrEmpty(this.OriginalUrbanization) ? "" : this.OriginalUrbanization;
    }

    public string GetAddressDeliveryInstallation()
    {
      return string.IsNullOrEmpty(this.AddressDeliveryInstallation) ? "" : this.AddressDeliveryInstallation;
    }

    public string GetAddressHouseNumber()
    {
      return string.IsNullOrEmpty(this.AddressHouseNumber) ? "" : this.AddressHouseNumber;
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

    public string GetStandardizedAddressLine1()
    {
      return string.IsNullOrEmpty(this.StandardizedAddressLine1) ? "" : this.StandardizedAddressLine1;
    }

    public string GetStandardizedAddressLine2()
    {
      return string.IsNullOrEmpty(this.StandardizedAddressLine2) ? "" : this.StandardizedAddressLine2;
    }

    public string GetStandardizedBaseMelissaAddressKey()
    {
      return string.IsNullOrEmpty(this.StandardizedBaseMelissaAddressKey) ? "" : this.StandardizedBaseMelissaAddressKey;
    }

    public string GetStandardizedCarrierRoute()
    {
      return string.IsNullOrEmpty(this.StandardizedCarrierRoute) ? "" : this.StandardizedCarrierRoute;
    }

    public string GetStandardizedCity()
    {
      return string.IsNullOrEmpty(this.StandardizedCity) ? "" : this.StandardizedCity;
    }

    public string GetStandardizedCityAbbreviation()
    {
      return string.IsNullOrEmpty(this.StandardizedCityAbbreviation) ? "" : this.StandardizedCityAbbreviation;
    }

    public string GetStandardizedCountryCode()
    {
      return string.IsNullOrEmpty(this.StandardizedCountryCode) ? "" : this.StandardizedCountryCode;
    }

    public string GetStandardizedDeliveryIndicator()
    {
      return string.IsNullOrEmpty(this.StandardizedDeliveryIndicator) ? "" : this.StandardizedDeliveryIndicator;
    }

    public string GetStandardizedDeliveryPointCheckDigit()
    {
      return string.IsNullOrEmpty(this.StandardizedDeliveryPointCheckDigit) ? "" : this.StandardizedDeliveryPointCheckDigit;
    }

    public string GetStandardizedDeliveryPointCode()
    {
      return string.IsNullOrEmpty(this.StandardizedDeliveryPointCode) ? "" : this.StandardizedDeliveryPointCode;
    }

    public string GetStandardizedMelissaAddressKey()
    {
      return string.IsNullOrEmpty(this.StandardizedMelissaAddressKey) ? "" : this.StandardizedMelissaAddressKey;
    }

    public string GetStandardizedPlus4()
    {
      return string.IsNullOrEmpty(this.StandardizedPlus4) ? "" : this.StandardizedPlus4;
    }

    public string GetStandardizedPostalCode()
    {
      return string.IsNullOrEmpty(this.StandardizedPostalCode) ? "" : this.StandardizedPostalCode;
    }

    public string GetStandardizedPrivateMailbox()
    {
      return string.IsNullOrEmpty(this.StandardizedPrivateMailbox) ? "" : this.StandardizedPrivateMailbox;
    }

    public string GetStandardizedResults()
    {
      return string.IsNullOrEmpty(this.StandardizedResults) ? "" : this.StandardizedResults;
    }

    public string GetStandardizedState()
    {
      return string.IsNullOrEmpty(this.StandardizedState) ? "" : this.StandardizedState;
    }

    public string GetStandardizedStateName()
    {
      return string.IsNullOrEmpty(this.StandardizedStateName) ? "" : this.StandardizedStateName;
    }

    public string GetStandardizedSuite()
    {
      return string.IsNullOrEmpty(this.StandardizedSuite) ? "" : this.StandardizedSuite;
    }

    public string GetStandardizedUrbanization()
    {
      return string.IsNullOrEmpty(this.StandardizedUrbanization) ? "" : this.StandardizedUrbanization;
    }

    public string GetDPVFootNotes()
    {
      return string.IsNullOrEmpty(this.DPVFootNotes) ? "" : this.DPVFootNotes;
    }

    public string GetMoveReturnCode()
    {
      return string.IsNullOrEmpty(this.MoveReturnCode) ? "" : this.MoveReturnCode;
    }

    public string GetPlus4()
    {
      return string.IsNullOrEmpty(this.Plus4) ? "" : this.Plus4;
    }

    public string GetPrivateMailbox()
    {
      return string.IsNullOrEmpty(this.PrivateMailbox) ? "" : this.PrivateMailbox;
    }

    public string GetSuite()
    {
      return string.IsNullOrEmpty(this.Suite) ? "" : this.Suite;
    }
  }
}
