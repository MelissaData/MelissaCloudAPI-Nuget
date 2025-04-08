using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class BusinessCoderPostRequest : PostRequestBase<BusinessCoderRecordRequest>
  {
    public string Cols { get; set; }
    public string Id { get; set; }
    public string Opt { get; set; }
    public string T { get; set; }
    public List<BusinessCoderRecordRequest> Records { get; set; }
  }

  public class GlobalAddressVerificationPostRequest : PostRequestBase<GlobalAddressVerificationRecordRequest> 
  {
    public string CustomerID { get; set; }
  }

  public class GlobalEmailPostRequest : PostRequestBase<GlobalEmailRecordRequest> 
  {
    public string CustomerID { get; set; }
  }

  public class GlobalIPPostRequest : PostRequestBase<GlobalIPRecordRequest> 
  {
    public string CustomerID { get; set; }
  }

  public class GlobalNamePostRequest : PostRequestBase<GlobalNameRecordRequest> 
  {
    public string CustomerID { get; set; }
  }

  public class GlobalPhonePostRequest : PostRequestBase<GlobalPhoneRecordRequest>
  {
    public string CustomerID { get; set; }
  }

  public class PersonatorConsumerPostRequest : PostRequestBase<PersonatorConsumerRecordRequest>
  {
    public string CustomerID { get; set; }
  }

  public class PropertyPostRequest : PostRequestBase<PropertyRecordRequest>
  {
    public string CustomerId { get; set; }
    public string Columns { get; set; }
    public string TotalRecords { get; set; }
    public string APN { get; set; }
    public string FIPS { get; set; }
    public string FreeForm { get; set; }
    public string PropertyMAK { get; set; }
    public string OwnerMAK { get; set; }
  }

  public class SSNNameMatchPostRequest : PostRequestBase<SSNNameMatchRecordRequest> 
  {
    public string CustomerID { get; set; }
  }

  public class StreetRoutePostRequest : PostRequestBase<StreetRouteRecordRequest> 
  {
    public string CustomerID { get; set; }
  }

  public class SmartMoverPostRequest : PostRequestBase<SmartMoverRecordRequest>
  {
    public string CustomerID { get; set; }
    public string JobID { get; set; }
    public string PAFId { get; set; }
    public string ExecutionID { get; set; }
    public string Actions { get; set; }
    public string Columns { get; set; }
    public string OptSmartMoverListName { get; set; }
  };
}
