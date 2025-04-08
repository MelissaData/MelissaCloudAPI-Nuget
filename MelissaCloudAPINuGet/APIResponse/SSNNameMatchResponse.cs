using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class SSNNameMatchResponse : ResponseBase
  {
    public string Version { get; set; }
    public string TransmissionReference { get; set; }
    public string TransmissionResults { get; set; }
    public string TotalRecords { get; set; }
    public List<SSNNameMatchRecord> Records { get; set; }

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

  public class SSNNameMatchRecord : ResponseBase
  {
    public string RecordID { get; set; }
    public string SSN { get; set; }
    public string IssuingState { get; set; }
    public string Results { get; set; }
    public string ResultsFromDataSource { get; set; }

    // Setters
    public void SetRecordID(string recordID)
    {
      this.RecordID = recordID;
    }

    public void SetSSN(string ssn)
    {
      this.SSN = ssn;
    }

    public void SetIssuingState(string issuingState)
    {
      this.IssuingState = issuingState;
    }

    public void SetResults(string results)
    {
      this.Results = results;
    }
    public void SetResultsFromDataSource(string resultsFromDataSource)
    {
      this.ResultsFromDataSource = resultsFromDataSource;
    }

    // Getters
    public string GetRecordID()
    {
      return string.IsNullOrEmpty(this.RecordID) ? "" : this.RecordID;
    }

    public string GetSSN()
    {
      return string.IsNullOrEmpty(this.SSN) ? "" : this.SSN;
    }

    public string GetIssuingState()
    {
      return string.IsNullOrEmpty(this.IssuingState) ? "" : this.IssuingState;
    }

    public string GetResults()
    {
      return string.IsNullOrEmpty(this.Results) ? "" : this.Results;
    }
    public string GetResultsFromDataSource()
    {
      return string.IsNullOrEmpty(this.ResultsFromDataSource) ? "" : this.ResultsFromDataSource;
    }
  }
}
