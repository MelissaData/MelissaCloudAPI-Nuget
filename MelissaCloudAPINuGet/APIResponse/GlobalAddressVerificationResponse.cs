using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class GlobalAddressVerificationResponse : ResponseBase
  {
    public string Version { get; set; }
    public string TransmissionReference { get; set; }
    public string TransmissionResults { get; set; }
    public string TotalRecords { get; set; }
    public List<GlobalAddressVerificationRecord> Records { get; set; }

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

  public class GlobalAddressVerificationRecord : ResponseBase
  {
    public string RecordID { get; set; }
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
    public string PostalCodeType { get; set; }
    public string AddressType { get; set; }
    public string AddressKey { get; set; }
    public string SubNationalArea { get; set; }
    public string CountryName { get; set; }
    public string CountryISO3166_1_Alpha2 { get; set; }
    public string CountryISO3166_1_Alpha3 { get; set; }
    public string CountryISO3166_1_Numeric { get; set; }
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
    public string DeliveryIndicator { get; set; }
    public string MelissaAddressKey { get; set; }
    public string MelissaAddressKeyBase { get; set; }
    public string PostOfficeLocation { get; set; }
    public string SubPremiseLevel { get; set; } 
    public string SubPremiseLevelType { get; set; }
    public string SubPremiseLevelNumber { get; set; }
    public string SubBuilding { get; set; }
    public string SubBuildingType { get; set; }
    public string SubBuildingNumber { get; set; }
    public string UTC { get; set; }
    public string DST { get; set; }
    public string DeliveryPointSuffix { get; set; }
    public string CensusKey { get; set; }
    public GlobalAddressVerificationExtras Extras {  get; set; }

    // Setters
    public void SetRecordID(string recordID)
    {
      this.RecordID = recordID;
    }

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

    public void SetPostalCodeType(string postalCodeType)
    {
      this.PostalCodeType = postalCodeType;
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

    public void SetCountryISO3166_1_Alpha2(string countryISO3166_1_Alpha2)
    {
      this.CountryISO3166_1_Alpha2 = countryISO3166_1_Alpha2;
    }

    public void SetCountryISO3166_1_Alpha3(string countryISO3166_1_Alpha3)
    {
      this.CountryISO3166_1_Alpha3 = countryISO3166_1_Alpha3;
    }

    public void SetCountryISO3166_1_Numeric(string countryISO3166_1_Numeric)
    {
      this.CountryISO3166_1_Numeric = countryISO3166_1_Numeric;
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

    public void SetPostOfficeLocation(string postOfficeLocation)
    {
      this.PostOfficeLocation = postOfficeLocation;
    }

    public void SetSubPremiseLevel(string subPremiseLevel)
    {
      this.SubPremiseLevel = subPremiseLevel;
    }

    public void SetSubPremiseLevelType(string subPremiseLevelType)
    {
      this.SubPremiseLevelType = subPremiseLevelType;
    }

    public void SetSubPremiseLevelNumber(string subPremiseLevelNumber)
    {
      this.SubPremiseLevelNumber = subPremiseLevelNumber;
    }

    public void SetSubBuilding(string subBuilding)
    {
      this.SubBuilding = subBuilding;
    }

    public void SetSubBuildingType(string subBuildingType)
    {
      this.SubBuildingType = subBuildingType;
    }

    public void SetSubBuildingNumber(string subBuildingNumber)
    {
      this.SubBuildingNumber = subBuildingNumber;
    }

    public void SetUTC(string utc)
    {
      this.UTC = utc;
    }

    public void SetDST(string dst)
    {
      this.DST = dst;
    }

    public void SetDeliveryPointSuffix(string deliveryPointSuffix)
    {
      this.DeliveryPointSuffix = deliveryPointSuffix;
    }

    public void SetCensusKey(string censusKey)
    {
      this.CensusKey = censusKey;
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

    public string GetPostalCodeType()
    {
      return string.IsNullOrEmpty(this.PostalCodeType) ? "" : this.PostalCodeType;
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

    public string GetCountryISO3166_1_Alpha2()
    {
      return string.IsNullOrEmpty(this.CountryISO3166_1_Alpha2) ? "" : this.CountryISO3166_1_Alpha2;
    }

    public string GetCountryISO3166_1_Alpha3()
    {
      return string.IsNullOrEmpty(this.CountryISO3166_1_Alpha3) ? "" : this.CountryISO3166_1_Alpha3;
    }

    public string GetCountryISO3166_1_Numeric()
    {
      return string.IsNullOrEmpty(this.CountryISO3166_1_Numeric) ? "" : this.CountryISO3166_1_Numeric;
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

    public string GetPostOfficeLocation()
    {
      return string.IsNullOrEmpty(this.PostOfficeLocation) ? "" : this.PostOfficeLocation;
    }

    public string GetSubPremiseLevel()
    {
      return string.IsNullOrEmpty(this.SubPremiseLevel) ? "" : this.SubPremiseLevel;
    }

    public string GetSubPremiseLevelType()
    {
      return string.IsNullOrEmpty(this.SubPremiseLevelType) ? "" : this.SubPremiseLevelType;
    }

    public string GetSubPremiseLevelNumber()
    {
      return string.IsNullOrEmpty(this.SubPremiseLevelNumber) ? "" : this.SubPremiseLevelNumber;
    }

    public string GetSubBuilding()
    {
      return string.IsNullOrEmpty(this.SubBuilding) ? "" : this.SubBuilding;
    }

    public string GetSubBuildingType()
    {
      return string.IsNullOrEmpty(this.SubBuildingType) ? "" : this.SubBuildingType;
    }

    public string GetSubBuildingNumber()
    {
      return string.IsNullOrEmpty(this.SubBuildingNumber) ? "" : this.SubBuildingNumber;
    }

    public string GetUTC()
    {
      return string.IsNullOrEmpty(this.UTC) ? "" : this.UTC;
    }

    public string GetDST()
    {
      return string.IsNullOrEmpty(this.DST) ? "" : this.DST;
    }

    public string GetDeliveryPointSuffix()
    {
      return string.IsNullOrEmpty(this.DeliveryPointSuffix) ? "" : this.DeliveryPointSuffix;
    }

    public string GetCensusKey()
    {
      return string.IsNullOrEmpty(this.CensusKey) ? "" : this.CensusKey;
    }
  }

  public class GlobalAddressVerificationExtras : ResponseBase
  {
    public string DaylightSavingsTimezone { get; set; }
    public string DaylightSavingsUTC { get; set; }
    public string LocalDateTime { get; set; }
    public string StandardTimezone { get; set; }
    public string UPRN { get; set; }
    public string CarrierRoute { get; set; }
    public string CBSACode { get; set; }
    public string CBSADivisionCode { get; set; }
    public string CBSADivisionLevel { get; set; }
    public string CBSADivisionTitle { get; set; }
    public string CBSALevel { get; set; }
    public string CBSATitle { get; set; }
    public string CensusBlock { get; set; }
    public string CensusTract { get; set; }
    public string CongressionalDistrict { get; set; }
    public string CountyFIPS { get; set; }
    public string CountyName { get; set; }
    public string CountySubdivisionCode { get; set; }
    public string CountySubdivisionName { get; set; }
    public string DeliveryPointCheckDigit { get; set; }
    public string DeliveryPointCode { get; set; }
    public string ElementarySchoolDistrictCode { get; set; }
    public string ElementarySchoolDistrictName { get; set; }
    public string PlaceCode { get; set; }
    public string PlaceName { get; set; }
    public string SecondarySchoolDistrictCode { get; set; }
    public string SecondarySchoolDistrictName { get; set; }
    public string StateDistrictLower { get; set; }
    public string StateDistrictUpper { get; set; }
    public string UnifiedSchoolDistrictCode { get; set; }
    public string UnifiedSchoolDistrictName { get; set; }

    // Setters
    public void SetDaylightSavingsTimezone(string daylightSavingsTimezone)
    {
      this.DaylightSavingsTimezone = daylightSavingsTimezone;
    }

    public void SetDaylightSavingsUTC(string daylightSavingsUTC)
    {
      this.DaylightSavingsUTC = daylightSavingsUTC;
    }

    public void SetLocalDateTime(string localDateTime)
    {
      this.LocalDateTime = localDateTime;
    }

    public void SetStandardTimezone(string standardTimezone)
    {
      this.StandardTimezone = standardTimezone;
    }

    public void SetUPRN(string uprn)
    {
      this.UPRN = uprn;
    }

    public void SetCarrierRoute(string carrierRoute)
    {
      this.CarrierRoute = carrierRoute;
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

    public void SetCensusBlock(string censusBlock)
    {
      this.CensusBlock = censusBlock;
    }

    public void SetCensusTract(string censusTract)
    {
      this.CensusTract = censusTract;
    }

    public void SetCongressionalDistrict(string congressionalDistrict)
    {
      this.CongressionalDistrict = congressionalDistrict;
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

    public void SetDeliveryPointCheckDigit(string deliveryPointCheckDigit)
    {
      this.DeliveryPointCheckDigit = deliveryPointCheckDigit;
    }

    public void SetDeliveryPointCode(string deliveryPointCode)
    {
      this.DeliveryPointCode = deliveryPointCode;
    }

    public void SetElementarySchoolDistrictCode(string elementarySchoolDistrictCode)
    {
      this.ElementarySchoolDistrictCode = elementarySchoolDistrictCode;
    }

    public void SetElementarySchoolDistrictName(string elementarySchoolDistrictName)
    {
      this.ElementarySchoolDistrictName = elementarySchoolDistrictName;
    }

    public void SetPlaceCode(string placeCode)
    {
      this.PlaceCode = placeCode;
    }

    public void SetPlaceName(string placeName)
    {
      this.PlaceName = placeName;
    }

    public void SetSecondarySchoolDistrictCode(string secondarySchoolDistrictCode)
    {
      this.SecondarySchoolDistrictCode = secondarySchoolDistrictCode;
    }

    public void SetSecondarySchoolDistrictName(string secondarySchoolDistrictName)
    {
      this.SecondarySchoolDistrictName = secondarySchoolDistrictName;
    }

    public void SetStateDistrictLower(string stateDistrictLower)
    {
      this.StateDistrictLower = stateDistrictLower;
    }

    public void SetStateDistrictUpper(string stateDistrictUpper)
    {
      this.StateDistrictUpper = stateDistrictUpper;
    }

    public void SetUnifiedSchoolDistrictCode(string unifiedSchoolDistrictCode)
    {
      this.UnifiedSchoolDistrictCode = unifiedSchoolDistrictCode;
    }

    public void SetUnifiedSchoolDistrictName(string unifiedSchoolDistrictName)
    {
      this.UnifiedSchoolDistrictName = unifiedSchoolDistrictName;
    }

    // Getters
    public string GetDaylightSavingsTimezone()
    {
      return string.IsNullOrEmpty(this.DaylightSavingsTimezone) ? "" : this.DaylightSavingsTimezone;
    }

    public string GetDaylightSavingsUTC()
    {
      return string.IsNullOrEmpty(this.DaylightSavingsUTC) ? "" : this.DaylightSavingsUTC;
    }

    public string GetLocalDateTime()
    {
      return string.IsNullOrEmpty(this.LocalDateTime) ? "" : this.LocalDateTime;
    }

    public string GetStandardTimezone()
    {
      return string.IsNullOrEmpty(this.StandardTimezone) ? "" : this.StandardTimezone;
    }

    public string GetUPRN()
    {
      return string.IsNullOrEmpty(this.UPRN) ? "" : this.UPRN;
    }

    public string GetCarrierRoute()
    {
      return string.IsNullOrEmpty(this.CarrierRoute) ? "" : this.CarrierRoute;
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

    public string GetCensusBlock()
    {
      return string.IsNullOrEmpty(this.CensusBlock) ? "" : this.CensusBlock;
    }

    public string GetCensusTract()
    {
      return string.IsNullOrEmpty(this.CensusTract) ? "" : this.CensusTract;
    }

    public string GetCongressionalDistrict()
    {
      return string.IsNullOrEmpty(this.CongressionalDistrict) ? "" : this.CongressionalDistrict;
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

    public string GetDeliveryPointCheckDigit()
    {
      return string.IsNullOrEmpty(this.DeliveryPointCheckDigit) ? "" : this.DeliveryPointCheckDigit;
    }

    public string GetDeliveryPointCode()
    {
      return string.IsNullOrEmpty(this.DeliveryPointCode) ? "" : this.DeliveryPointCode;
    }

    public string GetElementarySchoolDistrictCode()
    {
      return string.IsNullOrEmpty(this.ElementarySchoolDistrictCode) ? "" : this.ElementarySchoolDistrictCode;
    }

    public string GetElementarySchoolDistrictName()
    {
      return string.IsNullOrEmpty(this.ElementarySchoolDistrictName) ? "" : this.ElementarySchoolDistrictName;
    }

    public string GetPlaceCode()
    {
      return string.IsNullOrEmpty(this.PlaceCode) ? "" : this.PlaceCode;
    }

    public string GetPlaceName()
    {
      return string.IsNullOrEmpty(this.PlaceName) ? "" : this.PlaceName;
    }

    public string GetSecondarySchoolDistrictCode()
    {
      return string.IsNullOrEmpty(this.SecondarySchoolDistrictCode) ? "" : this.SecondarySchoolDistrictCode;
    }

    public string GetSecondarySchoolDistrictName()
    {
      return string.IsNullOrEmpty(this.SecondarySchoolDistrictName) ? "" : this.SecondarySchoolDistrictName;
    }

    public string GetStateDistrictLower()
    {
      return string.IsNullOrEmpty(this.StateDistrictLower) ? "" : this.StateDistrictLower;
    }

    public string GetStateDistrictUpper()
    {
      return string.IsNullOrEmpty(this.StateDistrictUpper) ? "" : this.StateDistrictUpper;
    }

    public string GetUnifiedSchoolDistrictCode()
    {
      return string.IsNullOrEmpty(this.UnifiedSchoolDistrictCode) ? "" : this.UnifiedSchoolDistrictCode;
    }

    public string GetUnifiedSchoolDistrictName()
    {
      return string.IsNullOrEmpty(this.UnifiedSchoolDistrictName) ? "" : this.UnifiedSchoolDistrictName;
    }
  }
}
