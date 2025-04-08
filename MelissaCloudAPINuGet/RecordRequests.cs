
namespace MelissaData.CloudAPI
{
  public abstract class RecordRequest
  {

  }

  public class BusinessCoderRecordRequest
  {
    public string A1 { get; set; }
    public string A2 { get; set; }
    public string City { get; set; }
    public string Comp { get; set; }
    public string Ctry { get; set; }
    public string Freeform { get; set; }
    public string Mak { get; set; }
    public string Mek { get; set; }
    public string Phone { get; set; }
    public string Postal { get; set; }
    public string Rec { get; set; }
    public string State { get; set; }
    public string Stock { get; set; }
    public string Suite { get; set; }
    public string Web { get; set; }
  }

  public class GlobalAddressVerificationRecordRequest
  {
    public string RecordID { get; set; }
    public string Organization { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string AddressLine3 { get; set; }
    public string AddressLine4 { get; set; }
    public string AddressLine5 { get; set; }
    public string AddressLine6 { get; set; }
    public string AddressLine7 { get; set; }
    public string AddressLine8 { get; set; }
    public string DoubleDependentLocality { get; set; }
    public string DependentLocality { get; set; }
    public string Locality { get; set; }
    public string SubAdministrativeArea { get; set; }
    public string AdministrativeArea { get; set; }
    public string PostalCode { get; set; }
    public string SubNationalArea { get; set; }
    public string Country { get; set; }
  }

  public class GlobalEmailRecordRequest
  {
    public string RecordID { get; set; }
    public string Email { get; set; }
  }

  public class GlobalIPRecordRequest
  {
    public string RecordID { get; set; }
    public string IPAddress { get; set; }
  }

  public class GlobalNameRecordRequest
  {
    public string RecordID { get; set; }
    public string Company { get; set; }
    public string FullName { get; set; }
  }

  public class GlobalPhoneRecordRequest
  {
    public string RecordID { get; set; }
    public string PhoneNumber { get; set; }
    public string Country { get; set; }
    public string CountryOfOrigin { get; set; }
  }

  public class PeopleBusinessSearchRecordRequest : RecordRequest
  {
    public string CustomerID { get; set; }
    public string MatchLevel { get; set; }
    public string MaxRecords { get; set; }
    public string TransmissionReference { get; set; }

    // Address Parameters
    public string AddressLine1 { get; set; }
    public string AdministrativeArea { get; set; }
    public string Country { get; set; }
    public string Locality { get; set; }
    public string PhoneNumber { get; set; }
    public string PostalCode { get; set; }
    public string PremiseNumber { get; set; }
    public string SubpremisesNumber { get; set; }
    public string ThoroughfareName { get; set; }
    public string ThoroughfarePostdirection { get; set; }
    public string ThoroughfarePredirection { get; set; }
    public string ThoroughfareTrailingType { get; set; }

    // Name Parameters
    public string AnyName { get; set; }
    public string CompanyName { get; set; }
    public string FirstName { get; set; }
    public string FullName { get; set; }
    public string LastName { get; set; }
    public string SubUser { get; set; }
  }

  public class PersonatorConsumerRecordRequest
  {
    public string RecordID { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string BirthDay { get; set; }
    public string BirthMonth { get; set; }
    public string BirthYear { get; set; }
    public string City { get; set; }
    public string CompanyName { get; set; }
    public string Country { get; set; }
    public string EmailAddress { get; set; }
    public string FirstName { get; set; }
    public string FreeForm { get; set; }
    public string FullName { get; set; }
    public string IPAddress { get; set; }
    public string LastLine { get; set; }
    public string LastName { get; set; }
    public string MelissaAddressKey { get; set; }
    public string PhoneNumber { get; set; }
    public string PostalCode { get; set; }
    public string SocialSecurity { get; set; }
    public string State { get; set; }
  }

  public class PersonatorIdentityRecordRequest : RecordRequest
  {
    public string TransmissionReference { get; set; }
    public string CustomerID { get; set; }
    public string Actions { get; set; }
    public string AddressOptions { get; set; }
    public string EmailOptions { get; set; }
    public string PhoneOptions { get; set; }
    public string NameOptions { get; set; }
    public string Options { get; set; }
    public string NationalID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
    public string Company { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string DateOfBirth { get; set; }
    public string AccountNumber { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string AddressLine3 { get; set; }
    public string AddressLine4 { get; set; }
    public string AddressLine5 { get; set; }
    public string AddressLine6 { get; set; }
    public string AddressLine7 { get; set; }
    public string AddressLine8 { get; set; }
    public string Locality { get; set; }
    public string AdministrativeArea { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string CountryOfOrigin { get; set; }
    public string State { get; set; }
  }

  public class PropertyRecordRequest
  {
    public string TransmissionReference { get; set; }
    public string CustomerId { get; set; }
    public string Columns { get; set; }
    public string Options { get; set; }
    public string RecordId { get; set; } 
    public string Account { get; set; }
    public string AddressKey { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string APN { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string FIPS { get; set; }
    public string FreeForm { get; set; }
    public string PropertyMAK { get; set; }
    public string OwnerMAK { get; set; }
    public string MAK { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string TransactionID { get; set; }
  }

  public class ReverseGeoCoderRecordRequest : RecordRequest
  {
    public string CustomerId { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string MaxDistance { get; set; }
    public string MaxRecords { get; set; }
    public string Options { get; set; }
    public string TransmissionReference { get; set; }
  }

  public class SmartMoverRecordRequest
  {
    public string RecordID { get; set; }
    public string Company { get; set; }
    public string NameFull { get; set; }
    public string NameFirst { get; set; }
    public string NameMiddle { get; set; }
    public string NamePrefix { get; set; }
    public string NameSuffix { get; set; }
    public string NameLast { get; set; }
    public string Urbanization { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string Suite { get; set; }
    public string PrivateMailbox { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Plus4 { get; set; }
    public string Country { get; set; }
  }

  public class SSNNameMatchRecordRequest
  {
    public string RecordID { get; set; }
    public string SSN { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
  }

  public class StreetRouteRecordRequest
  {
    public string RecordID { get; set; }
    public string StartLatitude { get; set; }
    public string StartLongitude { get; set; }
    public string EndLatitude { get; set; }
    public string EndLongitude { get; set; }
  }
}
