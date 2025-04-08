using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class GlobalEmailResponse : ResponseBase
  {
    public string Version { get; set; }
    public string TransmissionReference { get; set; }
    public string TransmissionResults { get; set; }
    public string TotalRecords { get; set; }
    public List<GlobalEmailRecord> Records { get; set; }

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

  public class GlobalEmailRecord : ResponseBase
  {
    public string RecordID { get; set; }
    public string Results { get; set; }
    public string EmailAddress { get; set; }
    public string MailboxName { get; set; }
    public string DomainName { get; set; }
    public string DomainAuthenticationStatus { get; set; }
    public string TopLevelDomain { get;set; }
    public string TopLevelDomainName { get; set; }
    public string DateChecked { get; set; }
    public string EmailAgeEstimated { get; set; }
    public string DeliverabilityConfidenceScore { get; set; }
    public string DomainAgeEstimated { get;set; }
    public string DomainExpirationDate { get; set; }
    public string DomainCreatedDate { get; set; }
    public string DomainUpdatedDate { get; set; }
    public string DomainEmail { get; set; }
    public string DomainOrganization { get; set; }
    public string DomainAddress1 { get; set; }
    public string DomainLocality { get; set; }
    public string DomainAdministrativeArea {  get; set; }
    public string DomainPostalCode {  get; set; }
    public string DomainCountry { get; set; }
    public string DomainCountryCode { get; set; }
    public string DomainAvailability { get; set; }
    public string DomainPrivateProxy { get; set; }
    public string PrivacyFlag { get; set; }
    public string MXServer { get; set; }
    public string DomainTypeIndicator { get; set; }
    public string BreachCount {  get; set; }

    // Setters
    public void SetRecordID(string recordID)
    {
      this.RecordID = recordID;
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

    public void SetDomainAuthenticationStatus(string domainAuthenticationStatus)
    {
      this.DomainAuthenticationStatus = domainAuthenticationStatus;
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

    public void SetDeliverabilityConfidenceScore(string deliverabilityConfidenceScore)
    {
      this.DeliverabilityConfidenceScore = deliverabilityConfidenceScore;
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

    public void SetDomainCountryCode(string domainCountryCode)
    {
      this.DomainCountryCode = domainCountryCode;
    }

    public void SetDomainAvailability(string domainAvailability)
    {
      this.DomainAvailability = domainAvailability;
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

    public void SetDomainTypeIndicator(string domainTypeIndicator)
    {
      this.DomainTypeIndicator = domainTypeIndicator;
    }

    public void SetBreachCount(string breachCount)
    {
      this.BreachCount = breachCount;
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

    public string GetDomainAuthenticationStatus()
    {
      return string.IsNullOrEmpty(this.DomainAuthenticationStatus) ? "" : this.DomainAuthenticationStatus;
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

    public string GetDeliverabilityConfidenceScore()
    {
      return string.IsNullOrEmpty(this.DeliverabilityConfidenceScore) ? "" : this.DeliverabilityConfidenceScore;
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

    public string GetDomainCountryCode()
    {
      return string.IsNullOrEmpty(this.DomainCountryCode) ? "" : this.DomainCountryCode;
    }

    public string GetDomainAvailability()
    {
      return string.IsNullOrEmpty(this.DomainAvailability) ? "" : this.DomainAvailability;
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

    public string GetDomainTypeIndicator()
    {
      return string.IsNullOrEmpty(this.DomainTypeIndicator) ? "" : this.DomainTypeIndicator;
    }

    public string GetBreachCount()
    {
      return string.IsNullOrEmpty(this.BreachCount) ? "" : this.BreachCount;
    }
  }
}
