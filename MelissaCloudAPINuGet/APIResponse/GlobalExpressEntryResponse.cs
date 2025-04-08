using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class GlobalExpressEntryResponse : ResponseBase
  {
    public string Version { get; set; }
    public string ResultCode { get; set; }
    public string ErrorString { get; set; }

    public List<GlobalExpressEntryRecord> Results { get; set; }

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

  public class GlobalExpressEntryRecord : ResponseBase
  {
    // For GlobalExpressAddress endpoint
    public GlobalExpressEntryAddress Address { get; set; }

    // For GlobalExpressCountry endpoint
    public string Country { get; set; }
    public string English { get; set; }
    public string Spanish { get; set; }
    public string French { get; set; }
    public string German { get; set; }
    public string SimplifiedChinese { get; set; }
    public string Char2ISO { get; set; }
    public string Char3ISO { get; set; }
    public string ISONumeric { get; set; }

    // Setters
    public void SetCountry(string country)
    {
      this.Country = country;
    }

    public void SetEnglish(string english)
    {
      this.English = english;
    }

    public void SetSpanish(string spanish)
    {
      this.Spanish = spanish;
    }

    public void SetFrench(string french)
    {
      this.French = french;
    }

    public void SetGerman(string german)
    {
      this.German = german;
    }

    public void SetSimplifiedChinese(string simplifiedChinese)
    {
      this.SimplifiedChinese = simplifiedChinese;
    }

    public void SetChar2ISO(string char2ISO)
    {
      this.Char2ISO = char2ISO;
    }

    public void SetChar3ISO(string char3ISO)
    {
      this.Char3ISO = char3ISO;
    }

    public void SetISONumeric(string isoNumeric)
    {
      this.ISONumeric = isoNumeric;
    }

    // Getters
    public string GetCountry()
    {
      return string.IsNullOrEmpty(this.Country) ? "" : this.Country;
    }

    public string GetEnglish()
    {
      return string.IsNullOrEmpty(this.English) ? "" : this.English;
    }

    public string GetSpanish()
    {
      return string.IsNullOrEmpty(this.Spanish) ? "" : this.Spanish;
    }

    public string GetFrench()
    {
      return string.IsNullOrEmpty(this.French) ? "" : this.French;
    }

    public string GetGerman()
    {
      return string.IsNullOrEmpty(this.German) ? "" : this.German;
    }

    public string GetSimplifiedChinese()
    {
      return string.IsNullOrEmpty(this.SimplifiedChinese) ? "" : this.SimplifiedChinese;
    }

    public string GetChar2ISO()
    {
      return string.IsNullOrEmpty(this.Char2ISO) ? "" : this.Char2ISO;
    }

    public string GetChar3ISO()
    {
      return string.IsNullOrEmpty(this.Char3ISO) ? "" : this.Char3ISO;
    }

    public string GetISONumeric()
    {
      return string.IsNullOrEmpty(this.ISONumeric) ? "" : this.ISONumeric;
    }
  }

  public class GlobalExpressEntryAddress : ResponseBase
  {
    public string Address { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string Address3 { get; set; }
    public string Address4 { get; set; }
    public string Address5 { get; set; }
    public string Address6 { get; set; }
    public string Address7 { get; set; }
    public string Address8 { get; set; }
    public string Address9 { get; set; }
    public string Address10 { get; set; }
    public string Address11 { get; set; }
    public string Address12 { get; set; }
    public string DeliveryAddress { get; set; }
    public string DeliveryAddress1 { get; set; }
    public string DeliveryAddress2 { get; set; }
    public string DeliveryAddress3 { get; set; }
    public string DeliveryAddress4 { get; set; }
    public string DeliveryAddress5 { get; set; }
    public string DeliveryAddress6 { get; set; }
    public string DeliveryAddress7 { get; set; }
    public string DeliveryAddress8 { get; set; }
    public string DeliveryAddress9 { get; set; }
    public string DeliveryAddress10 { get; set; }
    public string DeliveryAddress11 { get; set; }
    public string DeliveryAddress12 { get; set; }
    public string CountryName { get; set; }
    public string ISO3166_2 { get; set; }
    public string ISO3166_3 { get; set; }
    public string ISO3166_N { get; set; }
    public string SuperAdministrativeArea { get; set; }
    public string AdministrativeArea { get; set; }
    public string SubAdministrativeArea { get; set; }
    public string Locality { get; set; }
    public string CityAccepted { get; set; }
    public string CityNotAccepted { get; set; }
    public string DependentLocality { get; set; }
    public string DoubleDependentLocality { get; set; }
    public string Thoroughfare { get; set; }
    public string DependentThoroughfare { get; set; }
    public string Building { get; set; }
    public string Premise { get; set; }
    public string SubBuilding { get; set; }
    public string PostalCode { get; set; }
    public string PostalCodePrimary { get; set; }
    public string PostalCodeSecondary { get; set; }
    public string Organization { get; set; }
    public string PostBox { get; set; }
    public string Unmatched { get; set; }
    public string GeneralDelivery { get; set; }
    public string DeliveryInstallation { get; set; }
    public string Route { get; set; }
    public string AdditionalContent { get; set; }
    public string CountrySubdivisionCode { get; set; }
    public string MAK { get; set; }
    public string BaseMAK { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string DistanceFromPoint { get; set; }

    // Setters
    public void SetAddress(string address)
    {
      this.Address = address;
    }

    public void SetAddress1(string address1)
    {
      this.Address1 = address1;
    }

    public void SetAddress2(string address2)
    {
      this.Address2 = address2;
    }

    public void SetAddress3(string address3)
    {
      this.Address3 = address3;
    }

    public void SetAddress4(string address4)
    {
      this.Address4 = address4;
    }

    public void SetAddress5(string address5)
    {
      this.Address5 = address5;
    }

    public void SetAddress6(string address6)
    {
      this.Address6 = address6;
    }

    public void SetAddress7(string address7)
    {
      this.Address7 = address7;
    }

    public void SetAddress8(string address8)
    {
      this.Address8 = address8;
    }

    public void SetAddress9(string address9)
    {
      this.Address9 = address9;
    }

    public void SetAddress10(string address10)
    {
      this.Address10 = address10;
    }

    public void SetAddress11(string address11)
    {
      this.Address11 = address11;
    }

    public void SetAddress12(string address12)
    {
      this.Address12 = address12;
    }

    public void SetDeliveryAddress(string deliveryAddress)
    {
      this.DeliveryAddress = deliveryAddress;
    }

    public void SetDeliveryAddress1(string deliveryAddress1)
    {
      this.DeliveryAddress1 = deliveryAddress1;
    }

    public void SetDeliveryAddress2(string deliveryAddress2)
    {
      this.DeliveryAddress2 = deliveryAddress2;
    }

    public void SetDeliveryAddress3(string deliveryAddress3)
    {
      this.DeliveryAddress3 = deliveryAddress3;
    }

    public void SetDeliveryAddress4(string deliveryAddress4)
    {
      this.DeliveryAddress4 = deliveryAddress4;
    }

    public void SetDeliveryAddress5(string deliveryAddress5)
    {
      this.DeliveryAddress5 = deliveryAddress5;
    }

    public void SetDeliveryAddress6(string deliveryAddress6)
    {
      this.DeliveryAddress6 = deliveryAddress6;
    }

    public void SetDeliveryAddress7(string deliveryAddress7)
    {
      this.DeliveryAddress7 = deliveryAddress7;
    }

    public void SetDeliveryAddress8(string deliveryAddress8)
    {
      this.DeliveryAddress8 = deliveryAddress8;
    }

    public void SetDeliveryAddress9(string deliveryAddress9)
    {
      this.DeliveryAddress9 = deliveryAddress9;
    }

    public void SetDeliveryAddress10(string deliveryAddress10)
    {
      this.DeliveryAddress10 = deliveryAddress10;
    }

    public void SetDeliveryAddress11(string deliveryAddress11)
    {
      this.DeliveryAddress11 = deliveryAddress11;
    }

    public void SetDeliveryAddress12(string deliveryAddress12)
    {
      this.DeliveryAddress12 = deliveryAddress12;
    }

    public void SetCountryName(string countryName)
    {
      this.CountryName = countryName;
    }

    public void SetISO3166_2(string iso3166_2)
    {
      this.ISO3166_2 = iso3166_2;
    }

    public void SetISO3166_3(string iso3166_3)
    {
      this.ISO3166_3 = iso3166_3;
    }

    public void SetISO3166_N(string iso3166_N)
    {
      this.ISO3166_N = iso3166_N;
    }

    public void SetSuperAdministrativeArea(string superAdministrativeArea)
    {
      this.SuperAdministrativeArea = superAdministrativeArea;
    }

    public void SetAdministrativeArea(string administrativeArea)
    {
      this.AdministrativeArea = administrativeArea;
    }

    public void SetSubAdministrativeArea(string subAdministrativeArea)
    {
      this.SubAdministrativeArea = subAdministrativeArea;
    }

    public void SetLocality(string locality)
    {
      this.Locality = locality;
    }

    public void SetCityAccepted(string cityAccepted)
    {
      this.CityAccepted = cityAccepted;
    }

    public void SetCityNotAccepted(string cityNotAccepted)
    {
      this.CityNotAccepted = cityNotAccepted;
    }

    public void SetDependentLocality(string dependentLocality)
    {
      this.DependentLocality = dependentLocality;
    }

    public void SetDoubleDependentLocality(string doubleDependentLocality)
    {
      this.DoubleDependentLocality = doubleDependentLocality;
    }

    public void SetThoroughfare(string thoroughfare)
    {
      this.Thoroughfare = thoroughfare;
    }

    public void SetDependentThoroughfare(string dependentThoroughfare)
    {
      this.DependentThoroughfare = dependentThoroughfare;
    }

    public void SetBuilding(string building)
    {
      this.Building = building;
    }

    public void SetPremise(string premise)
    {
      this.Premise = premise;
    }

    public void SetSubBuilding(string subBuilding)
    {
      this.SubBuilding = subBuilding;
    }

    public void SetPostalCode(string postalCode)
    {
      this.PostalCode = postalCode;
    }

    public void SetPostalCodePrimary(string postalCodePrimary)
    {
      this.PostalCodePrimary = postalCodePrimary;
    }

    public void SetPostalCodeSecondary(string postalCodeSecondary)
    {
      this.PostalCodeSecondary = postalCodeSecondary;
    }

    public void SetOrganization(string organization)
    {
      this.Organization = organization;
    }

    public void SetPostBox(string postBox)
    {
      this.PostBox = postBox;
    }

    public void SetUnmatched(string unmatched)
    {
      this.Unmatched = unmatched;
    }

    public void SetGeneralDelivery(string generalDelivery)
    {
      this.GeneralDelivery = generalDelivery;
    }

    public void SetDeliveryInstallation(string deliveryInstallation)
    {
      this.DeliveryInstallation = deliveryInstallation;
    }

    public void SetRoute(string route)
    {
      this.Route = route;
    }

    public void SetAdditionalContent(string additionalContent)
    {
      this.AdditionalContent = additionalContent;
    }

    public void SetCountrySubdivisionCode(string countrySubdivisionCode)
    {
      this.CountrySubdivisionCode = countrySubdivisionCode;
    }

    public void SetMAK(string mak)
    {
      this.MAK = mak;
    }

    public void SetBaseMAK(string baseMAK)
    {
      this.BaseMAK = baseMAK;
    }

    public void SetLatitude(string latitude)
    {
      this.Latitude = latitude;
    }

    public void SetLongitude(string longitude)
    {
      this.Longitude = longitude;
    }

    public void SetDistanceFromPoint(string distanceFromPoint)
    {
      this.DistanceFromPoint = distanceFromPoint;
    }

    // Getters
    public string GetAddress()
    {
      return string.IsNullOrEmpty(this.Address) ? "" : this.Address;
    }

    public string GetAddress1()
    {
      return string.IsNullOrEmpty(this.Address1) ? "" : this.Address1;
    }

    public string GetAddress2()
    {
      return string.IsNullOrEmpty(this.Address2) ? "" : this.Address2;
    }

    public string GetAddress3()
    {
      return string.IsNullOrEmpty(this.Address3) ? "" : this.Address3;
    }

    public string GetAddress4()
    {
      return string.IsNullOrEmpty(this.Address4) ? "" : this.Address4;
    }

    public string GetAddress5()
    {
      return string.IsNullOrEmpty(this.Address5) ? "" : this.Address5;
    }

    public string GetAddress6()
    {
      return string.IsNullOrEmpty(this.Address6) ? "" : this.Address6;
    }

    public string GetAddress7()
    {
      return string.IsNullOrEmpty(this.Address7) ? "" : this.Address7;
    }

    public string GetAddress8()
    {
      return string.IsNullOrEmpty(this.Address8) ? "" : this.Address8;
    }

    public string GetAddress9()
    {
      return string.IsNullOrEmpty(this.Address9) ? "" : this.Address9;
    }

    public string GetAddress10()
    {
      return string.IsNullOrEmpty(this.Address10) ? "" : this.Address10;
    }

    public string GetAddress11()
    {
      return string.IsNullOrEmpty(this.Address11) ? "" : this.Address11;
    }

    public string GetAddress12()
    {
      return string.IsNullOrEmpty(this.Address12) ? "" : this.Address12;
    }

    public string GetDeliveryAddress()
    {
      return string.IsNullOrEmpty(this.DeliveryAddress) ? "" : this.DeliveryAddress;
    }

    public string GetDeliveryAddress1()
    {
      return string.IsNullOrEmpty(this.DeliveryAddress1) ? "" : this.DeliveryAddress1;
    }

    public string GetDeliveryAddress2()
    {
      return string.IsNullOrEmpty(this.DeliveryAddress2) ? "" : this.DeliveryAddress2;
    }

    public string GetDeliveryAddress3()
    {
      return string.IsNullOrEmpty(this.DeliveryAddress3) ? "" : this.DeliveryAddress3;
    }

    public string GetDeliveryAddress4()
    {
      return string.IsNullOrEmpty(this.DeliveryAddress4) ? "" : this.DeliveryAddress4;
    }

    public string GetDeliveryAddress5()
    {
      return string.IsNullOrEmpty(this.DeliveryAddress5) ? "" : this.DeliveryAddress5;
    }

    public string GetDeliveryAddress6()
    {
      return string.IsNullOrEmpty(this.DeliveryAddress6) ? "" : this.DeliveryAddress6;
    }

    public string GetDeliveryAddress7()
    {
      return string.IsNullOrEmpty(this.DeliveryAddress7) ? "" : this.DeliveryAddress7;
    }

    public string GetDeliveryAddress8()
    {
      return string.IsNullOrEmpty(this.DeliveryAddress8) ? "" : this.DeliveryAddress8;
    }

    public string GetDeliveryAddress9()
    {
      return string.IsNullOrEmpty(this.DeliveryAddress9) ? "" : this.DeliveryAddress9;
    }

    public string GetDeliveryAddress10()
    {
      return string.IsNullOrEmpty(this.DeliveryAddress10) ? "" : this.DeliveryAddress10;
    }

    public string GetDeliveryAddress11()
    {
      return string.IsNullOrEmpty(this.DeliveryAddress11) ? "" : this.DeliveryAddress11;
    }

    public string GetDeliveryAddress12()
    {
      return string.IsNullOrEmpty(this.DeliveryAddress12) ? "" : this.DeliveryAddress12;
    }

    public string GetCountryName()
    {
      return string.IsNullOrEmpty(this.CountryName) ? "" : this.CountryName;
    }

    public string GetISO3166_2()
    {
      return string.IsNullOrEmpty(this.ISO3166_2) ? "" : this.ISO3166_2;
    }

    public string GetISO3166_3()
    {
      return string.IsNullOrEmpty(this.ISO3166_3) ? "" : this.ISO3166_3;
    }

    public string GetISO3166_N()
    {
      return string.IsNullOrEmpty(this.ISO3166_N) ? "" : this.ISO3166_N;
    }

    public string GetSuperAdministrativeArea()
    {
      return string.IsNullOrEmpty(this.SuperAdministrativeArea) ? "" : this.SuperAdministrativeArea;
    }

    public string GetAdministrativeArea()
    {
      return string.IsNullOrEmpty(this.AdministrativeArea) ? "" : this.AdministrativeArea;
    }

    public string GetSubAdministrativeArea()
    {
      return string.IsNullOrEmpty(this.SubAdministrativeArea) ? "" : this.SubAdministrativeArea;
    }

    public string GetLocality()
    {
      return string.IsNullOrEmpty(this.Locality) ? "" : this.Locality;
    }

    public string GetCityAccepted()
    {
      return string.IsNullOrEmpty(this.CityAccepted) ? "" : this.CityAccepted;
    }

    public string GetCityNotAccepted()
    {
      return string.IsNullOrEmpty(this.CityNotAccepted) ? "" : this.CityNotAccepted;
    }

    public string GetDependentLocality()
    {
      return string.IsNullOrEmpty(this.DependentLocality) ? "" : this.DependentLocality;
    }

    public string GetDoubleDependentLocality()
    {
      return string.IsNullOrEmpty(this.DoubleDependentLocality) ? "" : this.DoubleDependentLocality;
    }

    public string GetThoroughfare()
    {
      return string.IsNullOrEmpty(this.Thoroughfare) ? "" : this.Thoroughfare;
    }

    public string GetDependentThoroughfare()
    {
      return string.IsNullOrEmpty(this.DependentThoroughfare) ? "" : this.DependentThoroughfare;
    }

    public string GetBuilding()
    {
      return string.IsNullOrEmpty(this.Building) ? "" : this.Building;
    }

    public string GetPremise()
    {
      return string.IsNullOrEmpty(this.Premise) ? "" : this.Premise;
    }

    public string GetSubBuilding()
    {
      return string.IsNullOrEmpty(this.SubBuilding) ? "" : this.SubBuilding;
    }

    public string GetPostalCode()
    {
      return string.IsNullOrEmpty(this.PostalCode) ? "" : this.PostalCode;
    }

    public string GetPostalCodePrimary()
    {
      return string.IsNullOrEmpty(this.PostalCodePrimary) ? "" : this.PostalCodePrimary;
    }

    public string GetPostalCodeSecondary()
    {
      return string.IsNullOrEmpty(this.PostalCodeSecondary) ? "" : this.PostalCodeSecondary;
    }

    public string GetOrganization()
    {
      return string.IsNullOrEmpty(this.Organization) ? "" : this.Organization;
    }

    public string GetPostBox()
    {
      return string.IsNullOrEmpty(this.PostBox) ? "" : this.PostBox;
    }

    public string GetUnmatched()
    {
      return string.IsNullOrEmpty(this.Unmatched) ? "" : this.Unmatched;
    }

    public string GetGeneralDelivery()
    {
      return string.IsNullOrEmpty(this.GeneralDelivery) ? "" : this.GeneralDelivery;
    }

    public string GetDeliveryInstallation()
    {
      return string.IsNullOrEmpty(this.DeliveryInstallation) ? "" : this.DeliveryInstallation;
    }

    public string GetRoute()
    {
      return string.IsNullOrEmpty(this.Route) ? "" : this.Route;
    }

    public string GetAdditionalContent()
    {
      return string.IsNullOrEmpty(this.AdditionalContent) ? "" : this.AdditionalContent;
    }

    public string GetCountrySubdivisionCode()
    {
      return string.IsNullOrEmpty(this.CountrySubdivisionCode) ? "" : this.CountrySubdivisionCode;
    }

    public string GetMAK()
    {
      return string.IsNullOrEmpty(this.MAK) ? "" : this.MAK;
    }

    public string GetBaseMAK()
    {
      return string.IsNullOrEmpty(this.BaseMAK) ? "" : this.BaseMAK;
    }

    public string GetLatitude()
    {
      return string.IsNullOrEmpty(this.Latitude) ? "" : this.Latitude;
    }

    public string GetLongitude()
    {
      return string.IsNullOrEmpty(this.Longitude) ? "" : this.Longitude;
    }

    public string GetDistanceFromPoint()
    {
      return string.IsNullOrEmpty(this.DistanceFromPoint) ? "" : this.DistanceFromPoint;
    }
  }
}
