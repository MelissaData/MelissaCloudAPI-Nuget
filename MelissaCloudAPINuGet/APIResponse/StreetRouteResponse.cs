using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class StreetRouteResponse : ResponseBase
  {
    public string Version { get; set; }
    public string Units { get; set; }
    public string TransmissionReference { get; set; }
    public string TransmissionResult { get; set; }
    public string TotalRecords { get; set; }
    public string RecordID { get; set; }
    public string Results { get; set; }
    public string TravelTime { get; set; }
    public string TotalDrivingDistance { get; set; }
    public List<StreetRouteRecord> Records { get; set; }

    // Setters
    public void SetVersion(string version)
    {
      this.Version = version;
    }

    public void SetUnits(string units) 
    {
      this.Units = units;
    }

    public void SetTransmissionReference(string transmissionReference)
    { 
      this.TransmissionReference = transmissionReference;
    }

    public void SetTransmissionResult(string transmissionResult)
    {
      this.TransmissionResult = transmissionResult;
    }

    public void SetTotalRecords(string totalRecords)
    {
      this.TotalRecords = totalRecords;
    }

    public void SetRecordID(string recordID)
    {
      this.RecordID = recordID;
    }

    public void SetResults(string results)
    {
      this.Results = results;
    }

    public void SetTravelTime(string travelTime) 
    {
      this.TravelTime = travelTime;
    }

    public void SetTotalDrivingDistance(string totalDrivingDistance) 
    {
      this.TotalDrivingDistance = totalDrivingDistance;
    }

    // Getters
    public string GetVersion()
    {
      return string.IsNullOrEmpty(this.Version) ? "" : this.Version;
    }

    public string GetUnits()
    {
      return string.IsNullOrEmpty(this.Units) ? "" : this.Units;
    }

    public string GetTransmissionReference()
    {
      return string.IsNullOrEmpty(this.TransmissionReference) ? "" : this.TransmissionReference;
    }

    public string GetTransmissionResult()
    {
      return string.IsNullOrEmpty(this.TransmissionResult) ? "" : this.TransmissionResult;
    }

    public string GetTotalRecords()
    {
      return string.IsNullOrEmpty(this.TotalRecords) ? "" : this.TotalRecords;
    }

    public string GetRecordID()
    {
      return string.IsNullOrEmpty(this.RecordID) ? "" : this.RecordID;
    }

    public string GetResults()
    {
      return string.IsNullOrEmpty(this.Results) ? "" : this.Results;
    }

    public string GetTravelTime()
    {
      return string.IsNullOrEmpty(this.TravelTime) ? "" : this.TravelTime;
    }

    public string GetTotalDrivingDistance()
    {
      return string.IsNullOrEmpty(this.TotalDrivingDistance) ? "" : this.TotalDrivingDistance;
    }
  }

  public class StreetRouteRecord : ResponseBase
  {
    public string RecordID { get; set; }
    public string Results { get; set; }
    public string TravelTime { get; set; }
    public string TotalDrivingDistance { get; set; }

    // Setters
    public void SetRecordID(string recordID)
    {
      this.RecordID = recordID;
    }

    public void SetResults(string results)
    {
      this.Results = results;
    }

    public void SetTravelTime(string travelTime)
    {
      this.TravelTime = travelTime;
    }

    public void SetTotalDrivingDistance(string totalDrivingDistance)
    {
      this.TotalDrivingDistance = totalDrivingDistance;
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

    public string GetTravelTime()
    {
      return string.IsNullOrEmpty(this.TravelTime) ? "" : this.TravelTime;
    }

    public string GetTotalDrivingDistance()
    {
      return string.IsNullOrEmpty(this.TotalDrivingDistance) ? "" : this.TotalDrivingDistance;
    }
  }
}
