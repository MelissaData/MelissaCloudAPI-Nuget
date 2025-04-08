using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class PersonatorSearchResponse : ResponseBase
  {
    public string Version { get; set; }
    public string TransmissionReference { get; set; }
    public string TransmissionResults { get; set; }
    public string TotalPages { get; set; }
    public string TotalRecords { get; set; }
    public List<PersonatorSearchRecord> Records { get; set; }

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

    public void SetTotalPages(string totalPages)
    {
      this.TotalPages = totalPages;
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

    public string GetTotalPages()
    {
      return string.IsNullOrEmpty(this.TotalPages) ? "" : this.TotalPages;
    }

    public string GetTotalRecords()
    {
      return string.IsNullOrEmpty(this.TotalRecords) ? "" : this.TotalRecords;
    }
  }

  public class PersonatorSearchRecord : ResponseBase
  {
    public string RecordID { get; set; }
    public string Results { get; set; }
    public string FullName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DateOfBirth { get; set; }
    public string DateOfDeath { get; set; }
    public string MelissaIdentityKey { get; set; }
    public PersonatorSearchAddress CurrentAddress { get; set; }
    public List<PersonatorSearchAddress> PreviousAddresses { get; set; }
    public List<PersonatorSearchPhone> PhoneRecords { get; set; }
    public List<string> EmailRecords { get; set; }

    // Setters
    public void SetRecordID(string recordID)
    {
      this.RecordID = recordID;
    }

    public void SetResults(string results)
    {
      this.Results = results;
    }

    public void SetFullName(string fullName)
    {
      this.FullName = fullName;
    }

    public void SetFirstName(string firstName)
    {
      this.FirstName = firstName;
    }

    public void SetLastName(string lastName)
    {
      this.LastName = lastName;
    }

    public void SetDateOfBirth(string dateOfBirth)
    {
      this.DateOfBirth = dateOfBirth;
    }

    public void SetDateOfDeath(string dateOfDeath)
    {
      this.DateOfDeath = dateOfDeath;
    }

    public void SetMelissaIdentityKey(string melissaIdentityKey)
    {
      this.MelissaIdentityKey = melissaIdentityKey;
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

    public string GetFullName()
    {
      return string.IsNullOrEmpty(this.FullName) ? "" : this.FullName;
    }

    public string GetFirstName()
    {
      return string.IsNullOrEmpty(this.FirstName) ? "" : this.FirstName;
    }

    public string GetLastName()
    {
      return string.IsNullOrEmpty(this.LastName) ? "" : this.LastName;
    }

    public string GetDateOfBirth()
    {
      return string.IsNullOrEmpty(this.DateOfBirth) ? "" : this.DateOfBirth;
    }

    public string GetDateOfDeath()
    {
      return string.IsNullOrEmpty(this.DateOfDeath) ? "" : this.DateOfDeath;
    }

    public string GetMelissaIdentityKey()
    {
      return string.IsNullOrEmpty(this.MelissaIdentityKey) ? "" : this.MelissaIdentityKey;
    }
  }

  public class PersonatorSearchAddress : ResponseBase
  {
    public string AddressLine1 { get; set; }
    public string Suite { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Plus4 { get; set; }
    public string MelissaAddressKey { get; set; }
    public string MelissaAddressKeyBase { get; set; }
    public string MoveDate { get; set; }

    // Setters
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

    public void SetPlus4(string plus4)
    {
      this.Plus4 = plus4;
    }

    public void SetMelissaAddressKey(string melissaAddressKey)
    {
      this.MelissaAddressKey = melissaAddressKey;
    }

    public void SetMelissaAddressKeyBase(string melissaAddressKeyBase)
    {
      this.MelissaAddressKeyBase = melissaAddressKeyBase;
    }

    public void SetMoveDate(string moveDate)
    {
      this.MoveDate = moveDate;
    }

    // Getters
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

    public string GetPlus4()
    {
      return string.IsNullOrEmpty(this.Plus4) ? "" : this.Plus4;
    }

    public string GetMelissaAddressKey()
    {
      return string.IsNullOrEmpty(this.MelissaAddressKey) ? "" : this.MelissaAddressKey;
    }

    public string GetMelissaAddressKeyBase()
    {
      return string.IsNullOrEmpty(this.MelissaAddressKeyBase) ? "" : this.MelissaAddressKeyBase;
    }

    public string GetMoveDate()
    {
      return string.IsNullOrEmpty(this.MoveDate) ? "" : this.MoveDate;
    }
  }

  public class PersonatorSearchPhone : ResponseBase
  {
    public string phoneNumber { get; set; }

    // Setters
    public void SetPhoneNumber(string phoneNumber)
    {
      this.phoneNumber = phoneNumber;
    }

    // Getters
    public string GetPhoneNumber()
    {
      return string.IsNullOrEmpty(this.phoneNumber) ? "" : this.phoneNumber;
    }
  }
  
  public class PersonatorSearchEmail : ResponseBase
  {
    public string Email { get; set; }

    // Setters
    public void SetEmail(string email)
    {
      this.Email = email;
    }

    // Getters
    public string GetEmail()
    {
      return string.IsNullOrEmpty(this.Email) ? "" : this.Email;
    }
  }
}
