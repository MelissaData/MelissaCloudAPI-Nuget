using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class GlobalNameResponse : ResponseBase
  {
    public string Version { get; set; }
    public string TransmissionReference { get; set; }
    public string TransmissionResults { get; set; }
    public string TotalRecords { get; set; }
    public List<GlobalNameRecord> Records { get; set; }

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

  public class GlobalNameRecord : ResponseBase
  {
    public string RecordID { get; set; }
    public string Results { get; set; }
    public string Company { get; set; }
    public string NamePrefix { get; set; }
    public string NameFirst { get; set; }
    public string NameMiddle { get; set; }
    public string NameLast { get; set; }
    public string NameSuffix { get; set; }
    public string NameNickname { get; set; }
    public string NameProfTitle { get; set; }
    public string Gender { get; set; }
    public string NamePrefix2 { get; set; }
    public string NameFirst2 { get; set; }
    public string NameMiddle2 { get; set; }
    public string NameLast2 { get; set; }
    public string NameSuffix2 { get; set; }
    public string NameNickname2 { get; set; }
    public string NameProfTitle2 { get; set; }
    public string Gender2 { get; set; }
    public string Salutation { get; set; }
    public string Extras { get; set; }

    // Setters
    public void SetRecordID(string recordID)
    {
      this.RecordID = recordID;
    }

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

    public void SetNameNickname(string nameNickname)
    {
      this.NameNickname = nameNickname;
    }

    public void SetNameProfTitle(string nameProfTitle)
    {
      this.NameProfTitle = nameProfTitle;
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

    public void SetNameNickname2(string nameNickname2)
    {
      this.NameNickname2 = nameNickname2;
    }

    public void SetNameProfTitle2(string nameProfTitle2)
    {
      this.NameProfTitle2 = nameProfTitle2;
    }

    public void SetGender2(string gender2)
    {
      this.Gender2 = gender2;
    }

    public void SetSalutation(string salutation)
    {
      this.Salutation = salutation;
    }

    public void SetExtras(string extras)
    {
      this.Extras = extras;
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

    public string GetNameNickname()
    {
      return string.IsNullOrEmpty(this.NameNickname) ? "" : this.NameNickname;
    }

    public string GetNameProfTitle()
    {
      return string.IsNullOrEmpty(this.NameProfTitle) ? "" : this.NameProfTitle;
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

    public string GetNameNickname2()
    {
      return string.IsNullOrEmpty(this.NameNickname2) ? "" : this.NameNickname2;
    }

    public string GetNameProfTitle2()
    {
      return string.IsNullOrEmpty(this.NameProfTitle2) ? "" : this.NameProfTitle2;
    }

    public string GetGender2()
    {
      return string.IsNullOrEmpty(this.Gender2) ? "" : this.Gender2;
    }

    public string GetSalutation()
    {
      return string.IsNullOrEmpty(this.Salutation) ? "" : this.Salutation;
    }

    public string GetExtras()
    {
      return string.IsNullOrEmpty(this.Extras) ? "" : this.Extras;
    }
  }
}
