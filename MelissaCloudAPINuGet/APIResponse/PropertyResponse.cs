using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
  public class PropertyResponse : ResponseBase
  {
    public string Version { get; set; }
    public string TransmissionResults { get; set; }
    public string Results { get; set; }
    public string TotalRecords { get; set; }
    public List<PropertyRecord> Records { get; set; }

    // Setters
    public void SetVersion(string version)
    {
      this.Version = version;
    }

    public void SetTransmissionResults(string transmissionResults)
    {
      this.TransmissionResults = transmissionResults;
    }

    public void SetResults(string results)
    {
      this.Results = results;
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

    public string GetTransmissionResults()
    {
      return string.IsNullOrEmpty(this.TransmissionResults) ? "" : this.TransmissionResults;
    }

    public string GetResults()
    {
      return string.IsNullOrEmpty(this.Results) ? "" : this.Results;
    }

    public string GetTotalRecords()
    {
      return string.IsNullOrEmpty(this.TotalRecords) ? "" : this.TotalRecords;
    }
  }

  public class PropertyRecord : ResponseBase
  {
    // For LookupDeeds endpoint
    public PropertyDocInfo DocInfo { get; set; }
    public PropertyTxDefInfo TxDefInfo { get; set; }
    public PropertyTxAmtInfo TxAmtInfo { get; set; }
    public PropertyPrimaryGrantor PrimaryGrantor { get; set; }
    public PropertyPrimaryGrantee PrimaryGrantee { get; set; }
    public PropertyTitleCompInfo TitleCompInfo { get; set; }
    public PropertyMortgage1 Mortgage1 { get; set; }

    // For LookupProperty endpoint
    public string RecordID { get; set; }
    public string Results { get; set; }
    public PropertyParcel Parcel { get; set; }
    public PropertyLegal Legal { get; set; }

    [JsonConverter(typeof(PropertyAddressConverter))]
    public object PropertyAddress { get; set; }

    public PropertyParsedPropertyAddress ParsedPropertyAddress { get; set; }
    public PropertyPrimaryOwner PrimaryOwner { get; set; }
    public PropertyOwnerAddress OwnerAddress { get; set; }
    public PropertyLastDeedOwnerInfo LastDeedOwnerInfo { get; set; }
    public PropertyCurrentDeed CurrentDeed { get; set; }
    public PropertyTax Tax { get; set; }
    public PropertyUseInfo PropertyUseInfo { get; set; }
    public PropertySaleInfo SaleInfo { get; set; }
    public PropertySize PropertySize { get; set; }
    public PropertyPool Pool { get; set; }
    public PropertyIntRoomInfo IntStructInfo { get; set; }
    public PropertyIntRoomInfo IntRoomInfo { get; set; }
    public PropertyIntAmentities IntAmentities { get; set; }
    public PropertyExtStructInfo ExtStructInfo { get; set; }
    public PropertyExtAmentities ExtAmentities { get; set; }
    public PropertyExtBuildings ExtBuildings { get; set; }
    public PropertyUtilities Utilities { get; set; }
    public PropertyParking Parking { get; set; }
    public PropertyYardGardenInfo YardGardenInfo { get; set; }
    public PropertyEstimatedValue EstimatedValue { get; set; }
    public PropertyShape Shape { get; set; }

    // For LookupHomesByOwner endpoint
    public string MAK { get; set; }
    public string BaseMAK { get; set; }
    public string FIPS { get; set; }
    public string APN { get; set; }
    public string PropertyCity { get; set; }
    public string PropertyState { get; set; }
    public string PropertyZip { get; set; }
    public string PropertyPlus4 { get; set; }

    // Setters
    public void SetRecordID(string recordID)
    {
      this.RecordID = recordID;
    }

    public void SetResults(string results)
    {
      this.Results = results;
    }

    public void SetMAK(string mak)
    {
      this.MAK = mak;
    }

    public void SetBaseMAK(string baseMak)
    {
      this.BaseMAK = baseMak;
    }

    public void SetFIPS(string fips)
    {
      this.FIPS = fips;
    }

    public void SetAPN(string apn)
    {
      this.APN = apn;
    }

    public void SetPropertyAddress(string propertyAddress)
    {
      this.PropertyAddress = propertyAddress;
    }

    public void SetPropertyCity(string propertyCity)
    {
      this.PropertyCity = propertyCity;
    }

    public void SetPropertyState(string propertyState)
    {
      this.PropertyState = propertyState;
    }

    public void SetPropertyZip(string propertyZip)
    {
      this.PropertyZip = propertyZip;
    }

    public void SetPropertyPlus4(string propertyPlus4)
    {
      this.PropertyPlus4 = propertyPlus4;
    }

    // Getters
    public string GetRecordID(string recordID)
    {
      return string.IsNullOrEmpty(this.RecordID) ? "" : this.RecordID;
    }

    public string GetResults()
    {
      return string.IsNullOrEmpty(this.Results) ? "" : this.Results;
    }

    public string GetMAK()
    {
      return string.IsNullOrEmpty(this.MAK) ? "" : this.MAK;
    }

    public string GetBaseMAK()
    {
      return string.IsNullOrEmpty(this.BaseMAK) ? "" : this.BaseMAK;
    }

    public string GetFIPS()
    {
      return string.IsNullOrEmpty(this.FIPS) ? "" : this.FIPS;
    }

    public string GetAPN()
    {
      return string.IsNullOrEmpty(this.APN) ? "" : this.APN;
    }

    public string GetPropertyAddress()
    {
      if (this.PropertyAddress is string address)
      {
        return address;
      }

      return string.Empty;
    }

    public string GetPropertyCity()
    {
      return string.IsNullOrEmpty(this.PropertyCity) ? "" : this.PropertyCity;
    }

    public string GetPropertyState()
    {
      return string.IsNullOrEmpty(this.PropertyState) ? "" : this.PropertyState;
    }

    public string GetPropertyZip()
    {
      return string.IsNullOrEmpty(this.PropertyZip) ? "" : this.PropertyZip;
    }

    public string GetPropertyPlus4()
    {
      return string.IsNullOrEmpty(this.PropertyPlus4) ? "" : this.PropertyPlus4;
    }
  }

  public class PropertyDocInfo : ResponseBase
  {
    public string TypeCode { get; set; }
    public string InstrumentNumber { get; set; }
    public string Book { get; set; }
    public string Page { get; set; }
    public string InstrumentDate { get; set; }
    public string RecordingDate { get; set; }

    // Setters
    public void SetTypeCode(string typeCode)
    {
      this.TypeCode = typeCode;
    }

    public void SetInstrumentNumber(string instrumentNumber)
    {
      this.InstrumentNumber = instrumentNumber;
    }

    public void SetBook(string book)
    {
      this.Book = book;
    }

    public void SetPage(string page)
    {
      this.Page = page;
    }

    public void SetInstrumentDate(string instrumentDate)
    {
      this.InstrumentDate = instrumentDate;
    }

    public void SetRecordingDate(string recordingDate)
    {
      this.RecordingDate = recordingDate;
    }

    // Getters
    public string GetTypeCode()
    {
      return string.IsNullOrEmpty(this.TypeCode) ? "" : this.TypeCode;
    }

    public string GetInstrumentNumber()
    {
      return string.IsNullOrEmpty(this.InstrumentNumber) ? "" : this.InstrumentNumber;
    }

    public string GetBook()
    {
      return string.IsNullOrEmpty(this.Book) ? "" : this.Book;
    }

    public string GetPage()
    {
      return string.IsNullOrEmpty(this.Page) ? "" : this.Page;
    }

    public string GetInstrumentDate()
    {
      return string.IsNullOrEmpty(this.InstrumentDate) ? "" : this.InstrumentDate;
    }

    public string GetRecordingDate()
    {
      return string.IsNullOrEmpty(this.RecordingDate) ? "" : this.RecordingDate;
    }
  }

  public class PropertyTxDefInfo : ResponseBase
  {
    public string TransactionType { get; set; }
    public string ForeclosureAuctionSale { get; set; }
    public string TransferInfoDistressCircumstanceCode { get; set; }
    public string QuitcalimFlag { get; set; }
    public string TransferInfoMultiParcelFlag { get; set; }
    public string ArmsLengthFlag { get; set; }
    public string PartialInterest { get; set; }

    // Setters
    public void SetTransactionType(string transactionType)
    {
      this.TransactionType = transactionType;
    }

    public void SetForeclosureAuctionSale(string foreclosureAuctionSale)
    {
      this.ForeclosureAuctionSale = foreclosureAuctionSale;
    }

    public void SetTransferInfoDistressCircumstanceCode(string transferInfoDistressCircumstanceCode)
    {
      this.TransferInfoDistressCircumstanceCode = transferInfoDistressCircumstanceCode;
    }

    public void SetQuitcalimFlag(string quitcalimFlag)
    {
      this.QuitcalimFlag = quitcalimFlag;
    }

    public void SetTransferInfoMultiParcelFlag(string transferInfoMultiParcelFlag)
    {
      this.TransferInfoMultiParcelFlag = transferInfoMultiParcelFlag;
    }

    public void SetArmsLengthFlag(string armsLengthFlag)
    {
      this.ArmsLengthFlag = armsLengthFlag;
    }

    public void SetPartialInterest(string partialInterest)
    {
      this.PartialInterest = partialInterest;
    }

    // Getters
    public string GetTransactionType()
    {
      return string.IsNullOrEmpty(this.TransactionType) ? "" : this.TransactionType;
    }

    public string GetForeclosureAuctionSale()
    {
      return string.IsNullOrEmpty(this.ForeclosureAuctionSale) ? "" : this.ForeclosureAuctionSale;
    }

    public string GetTransferInfoDistressCircumstanceCode()
    {
      return string.IsNullOrEmpty(this.TransferInfoDistressCircumstanceCode) ? "" : this.TransferInfoDistressCircumstanceCode;
    }

    public string GetQuitcalimFlag()
    {
      return string.IsNullOrEmpty(this.QuitcalimFlag) ? "" : this.QuitcalimFlag;
    }

    public string GetTransferInfoMultiParcelFlag()
    {
      return string.IsNullOrEmpty(this.TransferInfoMultiParcelFlag) ? "" : this.TransferInfoMultiParcelFlag;
    }

    public string GetArmsLengthFlag()
    {
      return string.IsNullOrEmpty(this.ArmsLengthFlag) ? "" : this.ArmsLengthFlag;
    }

    public string GetPartialInterest()
    {
      return string.IsNullOrEmpty(this.PartialInterest) ? "" : this.PartialInterest;
    }
  }

  public class PropertyTxAmtInfo : ResponseBase
  {
    public string TransferAmount { get; set; }
    public string TransferAmountInfoAccuracy { get; set; }
    public string TransferTaxTotal { get; set; }
    public string TransferTaxCounty { get; set; }

    // Setters
    public void SetTransferAmount(string transferAmount)
    {
      this.TransferAmount = transferAmount;
    }

    public void SetTransferAmountInfoAccuracy(string transferAmountInfoAccuracy)
    {
      this.TransferAmountInfoAccuracy = transferAmountInfoAccuracy;
    }

    public void SetTransferTaxTotal(string transferTaxTotal)
    {
      this.TransferTaxTotal = transferTaxTotal;
    }

    public void SetTransferTaxCounty(string transferTaxCounty)
    {
      this.TransferTaxCounty = transferTaxCounty;
    }

    // Getters
    public string GetTransferAmount()
    {
      return string.IsNullOrEmpty(this.TransferAmount) ? "" : this.TransferAmount;
    }

    public string GetTransferAmountInfoAccuracy()
    {
      return string.IsNullOrEmpty(this.TransferAmountInfoAccuracy) ? "" : this.TransferAmountInfoAccuracy;
    }

    public string GetTransferTaxTotal()
    {
      return string.IsNullOrEmpty(this.TransferTaxTotal) ? "" : this.TransferTaxTotal;
    }

    public string GetTransferTaxCounty()
    {
      return string.IsNullOrEmpty(this.TransferTaxCounty) ? "" : this.TransferTaxCounty;
    }
  }

  public class PropertyPrimaryGrantor : ResponseBase
  {
    public string Name1Full { get; set; }
    public string Name1First { get; set; }
    public string Name1Middle { get; set; }
    public string Name1Last { get; set; }
    public string Name1Suffix { get; set; }
    public string Name1ClassType { get; set; }
    public string Name1LegalType { get; set; }
    public string Name2Full { get; set; }
    public string Name2First { get; set; }
    public string Name2Middle { get; set; }
    public string Name2Last { get; set; }
    public string Name2Suffix { get; set; }
    public string Name2ClassType { get; set; }
    public string Name2LegalType { get; set; }

    // Setters
    public void SetName1Full(string name1Full)
    {
      this.Name1Full = name1Full;
    }

    public void SetName1First(string name1First)
    {
      this.Name1First = name1First;
    }

    public void SetName1Middle(string name1Middle)
    {
      this.Name1Middle = name1Middle;
    }

    public void SetName1Last(string name1Last)
    {
      this.Name1Last = name1Last;
    }

    public void SetName1Suffix(string name1Suffix)
    {
      this.Name1Suffix = name1Suffix;
    }

    public void SetName1ClassType(string name1ClassType)
    {
      this.Name1ClassType = name1ClassType;
    }

    public void SetName1LegalType(string name1LegalType)
    {
      this.Name1LegalType = name1LegalType;
    }

    public void SetName2Full(string name2Full)
    {
      this.Name2Full = name2Full;
    }

    public void SetName2First(string name2First)
    {
      this.Name2First = name2First;
    }

    public void SetName2Middle(string name2Middle)
    {
      this.Name2Middle = name2Middle;
    }

    public void SetName2Last(string name2Last)
    {
      this.Name2Last = name2Last;
    }

    public void SetName2Suffix(string name2Suffix)
    {
      this.Name2Suffix = name2Suffix;
    }

    public void SetName2ClassType(string name2ClassType)
    {
      this.Name2ClassType = name2ClassType;
    }

    public void SetName2LegalType(string name2LegalType)
    {
      this.Name2LegalType = name2LegalType;
    }

    // Getters
    public string GetName1Full()
    {
      return string.IsNullOrEmpty(this.Name1Full) ? "" : this.Name1Full;
    }

    public string GetName1First()
    {
      return string.IsNullOrEmpty(this.Name1First) ? "" : this.Name1First;
    }

    public string GetName1Middle()
    {
      return string.IsNullOrEmpty(this.Name1Middle) ? "" : this.Name1Middle;
    }

    public string GetName1Last()
    {
      return string.IsNullOrEmpty(this.Name1Last) ? "" : this.Name1Last;
    }

    public string GetName1Suffix()
    {
      return string.IsNullOrEmpty(this.Name1Suffix) ? "" : this.Name1Suffix;
    }

    public string GetName1ClassType()
    {
      return string.IsNullOrEmpty(this.Name1ClassType) ? "" : this.Name1ClassType;
    }

    public string GetName1LegalType()
    {
      return string.IsNullOrEmpty(this.Name1LegalType) ? "" : this.Name1LegalType;
    }

    public string GetName2Full()
    {
      return string.IsNullOrEmpty(this.Name2Full) ? "" : this.Name2Full;
    }

    public string GetName2First()
    {
      return string.IsNullOrEmpty(this.Name2First) ? "" : this.Name2First;
    }

    public string GetName2Middle()
    {
      return string.IsNullOrEmpty(this.Name2Middle) ? "" : this.Name2Middle;
    }

    public string GetName2Last()
    {
      return string.IsNullOrEmpty(this.Name2Last) ? "" : this.Name2Last;
    }

    public string GetName2Suffix()
    {
      return string.IsNullOrEmpty(this.Name2Suffix) ? "" : this.Name2Suffix;
    }

    public string GetName2ClassType()
    {
      return string.IsNullOrEmpty(this.Name2ClassType) ? "" : this.Name2ClassType;
    }

    public string GetName2LegalType()
    {
      return string.IsNullOrEmpty(this.Name2LegalType) ? "" : this.Name2LegalType;
    }
  }

  public class PropertyPrimaryGrantee : ResponseBase
  {
    public string Name1Full { get; set; }
    public string Name1First { get; set; }
    public string Name1Middle { get; set; }
    public string Name1Last { get; set; }
    public string Name1Suffix { get; set; }
    public string Name1ClassType { get; set; }
    public string Name1LegalType { get; set; }
    public string Name2Full { get; set; }
    public string Name2First { get; set; }
    public string Name2Middle { get; set; }
    public string Name2Last { get; set; }
    public string Name2Suffix { get; set; }
    public string Name2ClassType { get; set; }

    // Setters
    public void SetName1Full(string name1Full)
    {
      this.Name1Full = name1Full;
    }

    public void SetName1First(string name1First)
    {
      this.Name1First = name1First;
    }

    public void SetName1Middle(string name1Middle)
    {
      this.Name1Middle = name1Middle;
    }

    public void SetName1Last(string name1Last)
    {
      this.Name1Last = name1Last;
    }

    public void SetName1Suffix(string name1Suffix)
    {
      this.Name1Suffix = name1Suffix;
    }

    public void SetName1ClassType(string name1ClassType)
    {
      this.Name1ClassType = name1ClassType;
    }

    public void SetName1LegalType(string name1LegalType)
    {
      this.Name1LegalType = name1LegalType;
    }

    public void SetName2Full(string name2Full)
    {
      this.Name2Full = name2Full;
    }

    public void SetName2First(string name2First)
    {
      this.Name2First = name2First;
    }

    public void SetName2Middle(string name2Middle)
    {
      this.Name2Middle = name2Middle;
    }

    public void SetName2Last(string name2Last)
    {
      this.Name2Last = name2Last;
    }

    public void SetName2Suffix(string name2Suffix)
    {
      this.Name2Suffix = name2Suffix;
    }

    public void SetName2ClassType(string name2ClassType)
    {
      this.Name2ClassType = name2ClassType;
    }

    // Getters
    public string GetName1Full()
    {
      return string.IsNullOrEmpty(this.Name1Full) ? "" : this.Name1Full;
    }

    public string GetName1First()
    {
      return string.IsNullOrEmpty(this.Name1First) ? "" : this.Name1First;
    }

    public string GetName1Middle()
    {
      return string.IsNullOrEmpty(this.Name1Middle) ? "" : this.Name1Middle;
    }

    public string GetName1Last()
    {
      return string.IsNullOrEmpty(this.Name1Last) ? "" : this.Name1Last;
    }

    public string GetName1Suffix()
    {
      return string.IsNullOrEmpty(this.Name1Suffix) ? "" : this.Name1Suffix;
    }

    public string GetName1ClassType()
    {
      return string.IsNullOrEmpty(this.Name1ClassType) ? "" : this.Name1ClassType;
    }

    public string GetName1LegalType()
    {
      return string.IsNullOrEmpty(this.Name1LegalType) ? "" : this.Name1LegalType;
    }

    public string GetName2Full()
    {
      return string.IsNullOrEmpty(this.Name2Full) ? "" : this.Name2Full;
    }

    public string GetName2First()
    {
      return string.IsNullOrEmpty(this.Name2First) ? "" : this.Name2First;
    }

    public string GetName2Middle()
    {
      return string.IsNullOrEmpty(this.Name2Middle) ? "" : this.Name2Middle;
    }

    public string GetName2Last()
    {
      return string.IsNullOrEmpty(this.Name2Last) ? "" : this.Name2Last;
    }

    public string GetName2Suffix()
    {
      return string.IsNullOrEmpty(this.Name2Suffix) ? "" : this.Name2Suffix;
    }

    public string GetName2ClassType()
    {
      return string.IsNullOrEmpty(this.Name2ClassType) ? "" : this.Name2ClassType;
    }
  }

  public class PropertyTitleCompInfo : ResponseBase
  {
    public string StandardizedName { get; set; }
    public string TitleCompanyRaw { get; set; }

    // Setters
    public void SetStandardizedName(string standardizedName)
    {
      this.StandardizedName = standardizedName;
    }

    public void SetTitleCompanyRaw(string titleCompanyRaw)
    {
      this.TitleCompanyRaw = titleCompanyRaw;
    }

    // Getters
    public string GetStandardizedName()
    {
      return string.IsNullOrEmpty(this.StandardizedName) ? "" : this.StandardizedName;
    }

    public string GetTitleCompanyRaw()
    {
      return string.IsNullOrEmpty(this.TitleCompanyRaw) ? "" : this.TitleCompanyRaw;
    }
  }

  public class PropertyMortgage1 : ResponseBase
  {
    public string DocNumberFormatted { get; set; }
    public string InstrumentNumber { get; set; }
    public string Book { get; set; }
    public string Page { get; set; }
    public string RecordingDate { get; set; }
    public string Type { get; set; }
    public string Amount { get; set; }
    public string LenderFullName { get; set; }
    public string LenderFirstName { get; set; }
    public string LenderLastName { get; set; }
    public string LenderType { get; set; }
    public string IsLenderSeller { get; set; }
    public string TermDate { get; set; }
    public string PrepaymentPenaltyFlag { get; set; }
    public string PrepaymentTerm { get; set; }
    public string InterestRateType { get; set; }
    public string InterestRate { get; set; }
    public string InterestTypeInitial { get; set; }
    public string InterestMargin { get; set; }
    public string InterestRateMax { get; set; }
    public string AdjustableRateIndex { get; set; }
    public string InterestOnlyFlag { get; set; }
    public string InterestOnlyPeriod { get; set; }
    public string AdjustableRateRiderFlag { get; set; }
    public string InterestTypeChangeDate { get; set; }
    public string MinInterestRateFirstChange { get; set; }
    public string MaxInterestRateFirstChange { get; set; }
    public string InterestChangeFreq { get; set; }

    // Setters
    public void SetDocNumberFormatted(string docNumberFormatted)
    {
      this.DocNumberFormatted = docNumberFormatted;
    }

    public void SetInstrumentNumber(string instrumentNumber)
    {
      this.InstrumentNumber = instrumentNumber;
    }

    public void SetBook(string book)
    {
      this.Book = book;
    }

    public void SetPage(string page)
    {
      this.Page = page;
    }

    public void SetRecordingDate(string recordingDate)
    {
      this.RecordingDate = recordingDate;
    }

    public void SetType(string type)
    {
      this.Type = type;
    }

    public void SetAmount(string amount)
    {
      this.Amount = amount;
    }

    public void SetLenderFullName(string lenderFullName)
    {
      this.LenderFullName = lenderFullName;
    }

    public void SetLenderFirstName(string lenderFirstName)
    {
      this.LenderFirstName = lenderFirstName;
    }

    public void SetLenderLastName(string lenderLastName)
    {
      this.LenderLastName = lenderLastName;
    }

    public void SetLenderType(string lenderType)
    {
      this.LenderType = lenderType;
    }

    public void SetIsLenderSeller(string isLenderSeller)
    {
      this.IsLenderSeller = isLenderSeller;
    }

    public void SetTermDate(string termDate)
    {
      this.TermDate = termDate;
    }

    public void SetPrepaymentPenaltyFlag(string prepaymentPenaltyFlag)
    {
      this.PrepaymentPenaltyFlag = prepaymentPenaltyFlag;
    }

    public void SetPrepaymentTerm(string prepaymentTerm)
    {
      this.PrepaymentTerm = prepaymentTerm;
    }

    public void SetInterestRateType(string interestRateType)
    {
      this.InterestRateType = interestRateType;
    }

    public void SetInterestRate(string interestRate)
    {
      this.InterestRate = interestRate;
    }

    public void SetInterestTypeInitial(string interestTypeInitial)
    {
      this.InterestTypeInitial = interestTypeInitial;
    }

    public void SetInterestMargin(string interestMargin)
    {
      this.InterestMargin = interestMargin;
    }

    public void SetInterestRateMax(string interestRateMax)
    {
      this.InterestRateMax = interestRateMax;
    }

    public void SetAdjustableRateIndex(string adjustableRateIndex)
    {
      this.AdjustableRateIndex = adjustableRateIndex;
    }

    public void SetInterestOnlyFlag(string interestOnlyFlag)
    {
      this.InterestOnlyFlag = interestOnlyFlag;
    }

    public void SetInterestOnlyPeriod(string interestOnlyPeriod)
    {
      this.InterestOnlyPeriod = interestOnlyPeriod;
    }

    public void SetAdjustableRateRiderFlag(string adjustableRateRiderFlag)
    {
      this.AdjustableRateRiderFlag = adjustableRateRiderFlag;
    }

    public void SetInterestTypeChangeDate(string interestTypeChangeDate)
    {
      this.InterestTypeChangeDate = interestTypeChangeDate;
    }

    public void SetMinInterestRateFirstChange(string minInterestRateFirstChange)
    {
      this.MinInterestRateFirstChange = minInterestRateFirstChange;
    }

    public void SetMaxInterestRateFirstChange(string maxInterestRateFirstChange)
    {
      this.MaxInterestRateFirstChange = maxInterestRateFirstChange;
    }

    public void SetInterestChangeFreq(string interestChangeFreq)
    {
      this.InterestChangeFreq = interestChangeFreq;
    }

    // Getters
    public string GetDocNumberFormatted()
    {
      return string.IsNullOrEmpty(this.DocNumberFormatted) ? "" : this.DocNumberFormatted;
    }

    public string GetInstrumentNumber()
    {
      return string.IsNullOrEmpty(this.InstrumentNumber) ? "" : this.InstrumentNumber;
    }

    public string GetBook()
    {
      return string.IsNullOrEmpty(this.Book) ? "" : this.Book;
    }

    public string GetPage()
    {
      return string.IsNullOrEmpty(this.Page) ? "" : this.Page;
    }

    public string GetRecordingDate()
    {
      return string.IsNullOrEmpty(this.RecordingDate) ? "" : this.RecordingDate;
    }

    public string GetType()
    {
      return string.IsNullOrEmpty(this.Type) ? "" : this.Type;
    }

    public string GetAmount()
    {
      return string.IsNullOrEmpty(this.Amount) ? "" : this.Amount;
    }

    public string GetLenderFullName()
    {
      return string.IsNullOrEmpty(this.LenderFullName) ? "" : this.LenderFullName;
    }

    public string GetLenderFirstName()
    {
      return string.IsNullOrEmpty(this.LenderFirstName) ? "" : this.LenderFirstName;
    }

    public string GetLenderLastName()
    {
      return string.IsNullOrEmpty(this.LenderLastName) ? "" : this.LenderLastName;
    }

    public string GetLenderType()
    {
      return string.IsNullOrEmpty(this.LenderType) ? "" : this.LenderType;
    }

    public string GetIsLenderSeller()
    {
      return string.IsNullOrEmpty(this.IsLenderSeller) ? "" : this.IsLenderSeller;
    }

    public string GetTermDate()
    {
      return string.IsNullOrEmpty(this.TermDate) ? "" : this.TermDate;
    }

    public string GetPrepaymentPenaltyFlag()
    {
      return string.IsNullOrEmpty(this.PrepaymentPenaltyFlag) ? "" : this.PrepaymentPenaltyFlag;
    }

    public string GetPrepaymentTerm()
    {
      return string.IsNullOrEmpty(this.PrepaymentTerm) ? "" : this.PrepaymentTerm;
    }

    public string GetInterestRateType()
    {
      return string.IsNullOrEmpty(this.InterestRateType) ? "" : this.InterestRateType;
    }

    public string GetInterestRate()
    {
      return string.IsNullOrEmpty(this.InterestRate) ? "" : this.InterestRate;
    }

    public string GetInterestTypeInitial()
    {
      return string.IsNullOrEmpty(this.InterestTypeInitial) ? "" : this.InterestTypeInitial;
    }

    public string GetInterestMargin()
    {
      return string.IsNullOrEmpty(this.InterestMargin) ? "" : this.InterestMargin;
    }

    public string GetInterestRateMax()
    {
      return string.IsNullOrEmpty(this.InterestRateMax) ? "" : this.InterestRateMax;
    }

    public string GetAdjustableRateIndex()
    {
      return string.IsNullOrEmpty(this.AdjustableRateIndex) ? "" : this.AdjustableRateIndex;
    }

    public string GetInterestOnlyFlag()
    {
      return string.IsNullOrEmpty(this.InterestOnlyFlag) ? "" : this.InterestOnlyFlag;
    }

    public string GetInterestOnlyPeriod()
    {
      return string.IsNullOrEmpty(this.InterestOnlyPeriod) ? "" : this.InterestOnlyPeriod;
    }

    public string GetAdjustableRateRiderFlag()
    {
      return string.IsNullOrEmpty(this.AdjustableRateRiderFlag) ? "" : this.AdjustableRateRiderFlag;
    }

    public string GetInterestTypeChangeDate()
    {
      return string.IsNullOrEmpty(this.InterestTypeChangeDate) ? "" : this.InterestTypeChangeDate;
    }

    public string GetMinInterestRateFirstChange()
    {
      return string.IsNullOrEmpty(this.MinInterestRateFirstChange) ? "" : this.MinInterestRateFirstChange;
    }

    public string GetMaxInterestRateFirstChange()
    {
      return string.IsNullOrEmpty(this.MaxInterestRateFirstChange) ? "" : this.MaxInterestRateFirstChange;
    }

    public string GetInterestChangeFreq()
    {
      return string.IsNullOrEmpty(this.InterestChangeFreq) ? "" : this.InterestChangeFreq;
    }
  }

  public class PropertyParcel : ResponseBase
  {
    public string FIPSCode { get; set; }
    public string County { get; set; }
    public string UnformattedAPN { get; set; }
    public string FormattedAPN { get; set; }
    public string AccountNumber { get; set; }
    public string MapBook { get; set; }
    public string MapPage { get; set; }
    public string MinorCivilDivisionName { get; set; }

    // Setters
    public void SetFIPSCode(string fipsCode)
    {
      this.FIPSCode = fipsCode;
    }

    public void SetCounty(string county)
    {
      this.County = county;
    }

    public void SetUnformattedAPN(string unformattedAPN)
    {
      this.UnformattedAPN = unformattedAPN;
    }

    public void SetFormattedAPN(string formattedAPN)
    {
      this.FormattedAPN = formattedAPN;
    }

    public void SetAccountNumber(string accountNumber)
    {
      this.AccountNumber = accountNumber;
    }

    public void SetMapBook(string mapBook)
    {
      this.MapBook = mapBook;
    }

    public void SetMapPage(string mapPage)
    {
      this.MapPage = mapPage;
    }

    public void SetMinorCivilDivisionName(string minorCivilDivisionName)
    {
      this.MinorCivilDivisionName = minorCivilDivisionName;
    }

    // Getters
    public string GetFIPSCode()
    {
      return string.IsNullOrEmpty(this.FIPSCode) ? "" : this.FIPSCode;
    }

    public string GetCounty()
    {
      return string.IsNullOrEmpty(this.County) ? "" : this.County;
    }

    public string GetUnformattedAPN()
    {
      return string.IsNullOrEmpty(this.UnformattedAPN) ? "" : this.UnformattedAPN;
    }

    public string GetFormattedAPN()
    {
      return string.IsNullOrEmpty(this.FormattedAPN) ? "" : this.FormattedAPN;
    }

    public string GetAccountNumber()
    {
      return string.IsNullOrEmpty(this.AccountNumber) ? "" : this.AccountNumber;
    }

    public string GetMapBook()
    {
      return string.IsNullOrEmpty(this.MapBook) ? "" : this.MapBook;
    }

    public string GetMapPage()
    {
      return string.IsNullOrEmpty(this.MapPage) ? "" : this.MapPage;
    }

    public string GetMinorCivilDivisionName()
    {
      return string.IsNullOrEmpty(this.MinorCivilDivisionName) ? "" : this.MinorCivilDivisionName;
    }
  }

  public class PropertyLegal : ResponseBase
  {
    public string LegalDescription { get; set; }
    public string Range { get; set; }
    public string Township { get; set; }
    public string Section { get; set; }
    public string Quarter { get; set; }
    public string QuarterQuarter { get; set; }
    public string Subdivision { get; set; }
    public string Phase { get; set; }
    public string TractNumber { get; set; }
    public string Block1 { get; set; }
    public string LotNumber1 { get; set; }
    public string LotNumber2 { get; set; }
    public string LotNumber3 { get; set; }
    public string Unit { get; set; }

    // Setters
    public void SetLegalDescription(string legalDescription)
    {
      this.LegalDescription = legalDescription;
    }

    public void SetRange(string range)
    {
      this.Range = range;
    }

    public void SetTownship(string township)
    {
      this.Township = township;
    }

    public void SetSection(string section)
    {
      this.Section = section;
    }

    public void SetQuarter(string quarter)
    {
      this.Quarter = quarter;
    }

    public void SetQuarterQuarter(string quarterQuarter)
    {
      this.QuarterQuarter = quarterQuarter;
    }

    public void SetSubdivision(string subdivision)
    {
      this.Subdivision = subdivision;
    }

    public void SetPhase(string phase)
    {
      this.Phase = phase;
    }

    public void SetTractNumber(string tractNumber)
    {
      this.TractNumber = tractNumber;
    }

    public void SetBlock1(string block1)
    {
      this.Block1 = block1;
    }

    public void SetLotNumber1(string lotNumber1)
    {
      this.LotNumber1 = lotNumber1;
    }

    public void SetLotNumber2(string lotNumber2)
    {
      this.LotNumber2 = lotNumber2;
    }

    public void SetLotNumber3(string lotNumber3)
    {
      this.LotNumber3 = lotNumber3;
    }

    public void SetUnit(string unit)
    {
      this.Unit = unit;
    }

    // Getters
    public string GetLegalDescription()
    {
      return string.IsNullOrEmpty(this.LegalDescription) ? "" : this.LegalDescription;
    }

    public string GetRange()
    {
      return string.IsNullOrEmpty(this.Range) ? "" : this.Range;
    }

    public string GetTownship()
    {
      return string.IsNullOrEmpty(this.Township) ? "" : this.Township;
    }

    public string GetSection()
    {
      return string.IsNullOrEmpty(this.Section) ? "" : this.Section;
    }

    public string GetQuarter()
    {
      return string.IsNullOrEmpty(this.Quarter) ? "" : this.Quarter;
    }

    public string GetQuarterQuarter()
    {
      return string.IsNullOrEmpty(this.QuarterQuarter) ? "" : this.QuarterQuarter;
    }

    public string GetSubdivision()
    {
      return string.IsNullOrEmpty(this.Subdivision) ? "" : this.Subdivision;
    }

    public string GetPhase()
    {
      return string.IsNullOrEmpty(this.Phase) ? "" : this.Phase;
    }

    public string GetTractNumber()
    {
      return string.IsNullOrEmpty(this.TractNumber) ? "" : this.TractNumber;
    }

    public string GetBlock1()
    {
      return string.IsNullOrEmpty(this.Block1) ? "" : this.Block1;
    }

    public string GetLotNumber1()
    {
      return string.IsNullOrEmpty(this.LotNumber1) ? "" : this.LotNumber1;
    }

    public string GetLotNumber2()
    {
      return string.IsNullOrEmpty(this.LotNumber2) ? "" : this.LotNumber2;
    }

    public string GetLotNumber3()
    {
      return string.IsNullOrEmpty(this.LotNumber3) ? "" : this.LotNumber3;
    }

    public string GetUnit()
    {
      return string.IsNullOrEmpty(this.Unit) ? "" : this.Unit;
    }
  }

  public class PropertyAddress : ResponseBase
  {
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string AddressKey { get; set; }
    public string MAK { get; set; }
    public string BaseMAK { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string CarrierRoute { get; set; }
    public string PrivacyInfo { get; set; }

    // Setters
    public void SetAddress(string address)
    {
      this.Address = address;
    }

    public void SetCity(string city)
    {
      this.City = city;
    }

    public void SetState(string state)
    {
      this.State = state;
    }

    public void SetZip(string zip)
    {
      this.Zip = zip;
    }

    public void SetAddressKey(string addressKey)
    {
      this.AddressKey = addressKey;
    }

    public void SetMAK(string mak)
    {
      this.MAK = mak;
    }

    public void SetBaseMAK(string baseMak)
    {
      this.BaseMAK = baseMak;
    }

    public void SetLatitude(string latitude)
    {
      this.Latitude = latitude;
    }

    public void SetLongitude(string longitude)
    {
      this.Longitude = longitude;
    }

    public void SetCarrierRoute(string carrierRoute)
    {
      this.CarrierRoute = carrierRoute;
    }

    public void SetPrivacyInfo(string privacyInfo)
    {
      this.PrivacyInfo = privacyInfo;
    }

    // Getters
    public string GetAddress()
    {
      return string.IsNullOrEmpty(this.Address) ? "" : this.Address;
    }

    public string GetCity()
    {
      return string.IsNullOrEmpty(this.City) ? "" : this.City;
    }

    public string GetState()
    {
      return string.IsNullOrEmpty(this.State) ? "" : this.State;
    }

    public string GetZip()
    {
      return string.IsNullOrEmpty(this.Zip) ? "" : this.Zip;
    }

    public string GetAddressKey()
    {
      return string.IsNullOrEmpty(this.AddressKey) ? "" : this.AddressKey;
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

    public string GetCarrierRoute()
    {
      return string.IsNullOrEmpty(this.CarrierRoute) ? "" : this.CarrierRoute;
    }

    public string GetPrivacyInfo()
    {
      return string.IsNullOrEmpty(this.PrivacyInfo) ? "" : this.PrivacyInfo;
    }
  }

  public class PropertyParsedPropertyAddress : ResponseBase
  {
    public string Range { get; set; }
    public string PreDirectional { get; set; }
    public string StreetName { get; set; }
    public string Suffix { get; set; }
    public string PostDirectional { get; set; }
    public string SuiteName { get; set; }
    public string SuiteRange { get; set; }

    // Setters
    public void SetRange(string range)
    {
      this.Range = range;
    }

    public void SetPreDirectional(string preDirectional)
    {
      this.PreDirectional = preDirectional;
    }

    public void SetStreetName(string streetName)
    {
      this.StreetName = streetName;
    }

    public void SetSuffix(string suffix)
    {
      this.Suffix = suffix;
    }

    public void SetPostDirectional(string postDirectional)
    {
      this.PostDirectional = postDirectional;
    }

    public void SetSuiteName(string suiteName)
    {
      this.SuiteName = suiteName;
    }

    public void SetSuiteRange(string suiteRange)
    {
      this.SuiteRange = suiteRange;
    }

    // Getters
    public string GetRange()
    {
      return string.IsNullOrEmpty(this.Range) ? "" : this.Range;
    }

    public string GetPreDirectional()
    {
      return string.IsNullOrEmpty(this.PreDirectional) ? "" : this.PreDirectional;
    }

    public string GetStreetName()
    {
      return string.IsNullOrEmpty(this.StreetName) ? "" : this.StreetName;
    }

    public string GetSuffix()
    {
      return string.IsNullOrEmpty(this.Suffix) ? "" : this.Suffix;
    }

    public string GetPostDirectional()
    {
      return string.IsNullOrEmpty(this.PostDirectional) ? "" : this.PostDirectional;
    }

    public string GetSuiteName()
    {
      return string.IsNullOrEmpty(this.SuiteName) ? "" : this.SuiteName;
    }

    public string GetSuiteRange()
    {
      return string.IsNullOrEmpty(this.SuiteRange) ? "" : this.SuiteRange;
    }
  }

  public class PropertyPrimaryOwner : ResponseBase
  {
    public string Name1Full { get; set; }
    public string Name1First { get; set; }
    public string Name1Middle { get; set; }
    public string Name1Last { get; set; }
    public string Name1Suffix { get; set; }
    public string TrustFlag { get; set; }
    public string CompanyFlag { get; set; }
    public string Name2Full { get; set; }
    public string Name2First { get; set; }
    public string Name2Middle { get; set; }
    public string Name2Last { get; set; }
    public string Name2Suffix { get; set; }
    public string VestingType { get; set; }

    // Setters
    public void SetName1Full(string name1Full)
    {
      this.Name1Full = name1Full;
    }

    public void SetName1First(string name1First)
    {
      this.Name1First = name1First;
    }

    public void SetName1Middle(string name1Middle)
    {
      this.Name1Middle = name1Middle;
    }

    public void SetName1Last(string name1Last)
    {
      this.Name1Last = name1Last;
    }

    public void SetName1Suffix(string name1Suffix)
    {
      this.Name1Suffix = name1Suffix;
    }

    public void SetTrustFlag(string trustFlag)
    {
      this.TrustFlag = trustFlag;
    }

    public void SetCompanyFlag(string companyFlag)
    {
      this.CompanyFlag = companyFlag;
    }

    public void SetName2Full(string name2Full)
    {
      this.Name2Full = name2Full;
    }

    public void SetName2First(string name2First)
    {
      this.Name2First = name2First;
    }

    public void SetName2Middle(string name2Middle)
    {
      this.Name2Middle = name2Middle;
    }

    public void SetName2Last(string name2Last)
    {
      this.Name2Last = name2Last;
    }

    public void SetName2Suffix(string name2Suffix)
    {
      this.Name2Suffix = name2Suffix;
    }

    public void SetVestingType(string vestingType)
    {
      this.VestingType = vestingType;
    }

    // Getters
    public string GetName1Full()
    {
      return string.IsNullOrEmpty(this.Name1Full) ? "" : this.Name1Full;
    }

    public string GetName1First()
    {
      return string.IsNullOrEmpty(this.Name1First) ? "" : this.Name1First;
    }

    public string GetName1Middle()
    {
      return string.IsNullOrEmpty(this.Name1Middle) ? "" : this.Name1Middle;
    }

    public string GetName1Last()
    {
      return string.IsNullOrEmpty(this.Name1Last) ? "" : this.Name1Last;
    }

    public string GetName1Suffix()
    {
      return string.IsNullOrEmpty(this.Name1Suffix) ? "" : this.Name1Suffix;
    }

    public string GetTrustFlag()
    {
      return string.IsNullOrEmpty(this.TrustFlag) ? "" : this.TrustFlag;
    }

    public string GetCompanyFlag()
    {
      return string.IsNullOrEmpty(this.CompanyFlag) ? "" : this.CompanyFlag;
    }

    public string GetName2Full()
    {
      return string.IsNullOrEmpty(this.Name2Full) ? "" : this.Name2Full;
    }

    public string GetName2First()
    {
      return string.IsNullOrEmpty(this.Name2First) ? "" : this.Name2First;
    }

    public string GetName2Middle()
    {
      return string.IsNullOrEmpty(this.Name2Middle) ? "" : this.Name2Middle;
    }

    public string GetName2Last()
    {
      return string.IsNullOrEmpty(this.Name2Last) ? "" : this.Name2Last;
    }

    public string GetName2Suffix()
    {
      return string.IsNullOrEmpty(this.Name2Suffix) ? "" : this.Name2Suffix;
    }

    public string GetVestingType()
    {
      return string.IsNullOrEmpty(this.VestingType) ? "" : this.VestingType;
    }
  }

  public class PropertyOwnerAddress : ResponseBase
  {
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string CarrierRoute { get; set; }
    public string MAK { get; set; }
    public string BaseMAK { get; set; }
    public string FormatInfo { get; set; }
    public string PrivacyInfo { get; set; }

    // Setters
    public void SetAddress(string address)
    {
      this.Address = address;
    }

    public void SetCity(string city)
    {
      this.City = city;
    }

    public void SetState(string state)
    {
      this.State = state;
    }

    public void SetZip(string zip)
    {
      this.Zip = zip;
    }

    public void SetCarrierRoute(string carrierRoute)
    {
      this.CarrierRoute = carrierRoute;
    }

    public void SetMAK(string mak)
    {
      this.MAK = mak;
    }

    public void SetBaseMAK(string baseMak)
    {
      this.BaseMAK = baseMak;
    }

    public void SetFormatInfo(string formatInfo)
    {
      this.FormatInfo = formatInfo;
    }

    public void SetPrivacyInfo(string privacyInfo)
    {
      this.PrivacyInfo = privacyInfo;
    }

    // Getters
    public string GetAddress()
    {
      return string.IsNullOrEmpty(this.Address) ? "" : this.Address;
    }

    public string GetCity()
    {
      return string.IsNullOrEmpty(this.City) ? "" : this.City;
    }

    public string GetState()
    {
      return string.IsNullOrEmpty(this.State) ? "" : this.State;
    }

    public string GetZip()
    {
      return string.IsNullOrEmpty(this.Zip) ? "" : this.Zip;
    }

    public string GetCarrierRoute()
    {
      return string.IsNullOrEmpty(this.CarrierRoute) ? "" : this.CarrierRoute;
    }

    public string GetMAK()
    {
      return string.IsNullOrEmpty(this.MAK) ? "" : this.MAK;
    }

    public string GetBaseMAK()
    {
      return string.IsNullOrEmpty(this.BaseMAK) ? "" : this.BaseMAK;
    }

    public string GetFormatInfo()
    {
      return string.IsNullOrEmpty(this.FormatInfo) ? "" : this.FormatInfo;
    }

    public string GetPrivacyInfo()
    {
      return string.IsNullOrEmpty(this.PrivacyInfo) ? "" : this.PrivacyInfo;
    }
  }

  public class PropertyLastDeedOwnerInfo : ResponseBase
  {
    public string Name1Full { get; set; }
    public string Name1First { get; set; }
    public string Name1Middle { get; set; }
    public string Name1Last { get; set; }
    public string Name1Suffix { get; set; }
    public string Name2Full { get; set; }
    public string Name2First { get; set; }
    public string Name2Middle { get; set; }
    public string Name2Last { get; set; }
    public string Name2Suffix { get; set; }

    // Setters
    public void SetName1Full(string name1Full)
    {
      this.Name1Full = name1Full;
    }

    public void SetName1First(string name1First)
    {
      this.Name1First = name1First;
    }

    public void SetName1Middle(string name1Middle)
    {
      this.Name1Middle = name1Middle;
    }

    public void SetName1Last(string name1Last)
    {
      this.Name1Last = name1Last;
    }

    public void SetName1Suffix(string name1Suffix)
    {
      this.Name1Suffix = name1Suffix;
    }

    public void SetName2Full(string name2Full)
    {
      this.Name2Full = name2Full;
    }

    public void SetName2First(string name2First)
    {
      this.Name2First = name2First;
    }

    public void SetName2Middle(string name2Middle)
    {
      this.Name2Middle = name2Middle;
    }

    public void SetName2Last(string name2Last)
    {
      this.Name2Last = name2Last;
    }

    public void SetName2Suffix(string name2Suffix)
    {
      this.Name2Suffix = name2Suffix;
    }

    // Getters
    public string GetName1Full()
    {
      return string.IsNullOrEmpty(this.Name1Full) ? "" : this.Name1Full;
    }

    public string GetName1First()
    {
      return string.IsNullOrEmpty(this.Name1First) ? "" : this.Name1First;
    }

    public string GetName1Middle()
    {
      return string.IsNullOrEmpty(this.Name1Middle) ? "" : this.Name1Middle;
    }

    public string GetName1Last()
    {
      return string.IsNullOrEmpty(this.Name1Last) ? "" : this.Name1Last;
    }

    public string GetName1Suffix()
    {
      return string.IsNullOrEmpty(this.Name1Suffix) ? "" : this.Name1Suffix;
    }

    public string GetName2Full()
    {
      return string.IsNullOrEmpty(this.Name2Full) ? "" : this.Name2Full;
    }

    public string GetName2First()
    {
      return string.IsNullOrEmpty(this.Name2First) ? "" : this.Name2First;
    }

    public string GetName2Middle()
    {
      return string.IsNullOrEmpty(this.Name2Middle) ? "" : this.Name2Middle;
    }

    public string GetName2Last()
    {
      return string.IsNullOrEmpty(this.Name2Last) ? "" : this.Name2Last;
    }

    public string GetName2Suffix()
    {
      return string.IsNullOrEmpty(this.Name2Suffix) ? "" : this.Name2Suffix;
    }
  }

  public class PropertyCurrentDeed : ResponseBase
  {
    public string MortgageAmount { get; set; }
    public string MortgageDate { get; set; }
    public string MortgageLoanTypeCode { get; set; }
    public string MortgageDueDate { get; set; }
    public string LenderName { get; set; }
    public string SecondMortgageAmount { get; set; }

    // Setters
    public void SetMortgageAmount(string mortgageAmount)
    {
      this.MortgageAmount = mortgageAmount;
    }

    public void SetMortgageDate(string mortgageDate)
    {
      this.MortgageDate = mortgageDate;
    }

    public void SetMortgageLoanTypeCode(string mortgageLoanTypeCode)
    {
      this.MortgageLoanTypeCode = mortgageLoanTypeCode;
    }

    public void SetMortgageDueDate(string mortgageDueDate)
    {
      this.MortgageDueDate = mortgageDueDate;
    }

    public void SetLenderName(string lenderName)
    {
      this.LenderName = lenderName;
    }

    public void SetSecondMortgageAmount(string secondMortgageAmount)
    {
      this.SecondMortgageAmount = secondMortgageAmount;
    }

    // Getters
    public string GetMortgageAmount()
    {
      return string.IsNullOrEmpty(this.MortgageAmount) ? "" : this.MortgageAmount;
    }

    public string GetMortgageDate()
    {
      return string.IsNullOrEmpty(this.MortgageDate) ? "" : this.MortgageDate;
    }

    public string GetMortgageLoanTypeCode()
    {
      return string.IsNullOrEmpty(this.MortgageLoanTypeCode) ? "" : this.MortgageLoanTypeCode;
    }

    public string GetMortgageDueDate()
    {
      return string.IsNullOrEmpty(this.MortgageDueDate) ? "" : this.MortgageDueDate;
    }

    public string GetLenderName()
    {
      return string.IsNullOrEmpty(this.LenderName) ? "" : this.LenderName;
    }

    public string GetSecondMortgageAmount()
    {
      return string.IsNullOrEmpty(this.SecondMortgageAmount) ? "" : this.SecondMortgageAmount;
    }
  }

  public class PropertyTax : ResponseBase
  {
    public string YearAssessed { get; set; }
    public string AssessedValueTotal { get; set; }
    public string AssessedValueImprovements { get; set; }
    public string AssessedValueLand { get; set; }
    public string AssessedImprovementsPerc { get; set; }
    public string MarketValueYear { get; set; }
    public string MarketValueTotal { get; set; }
    public string MarketValueImprovements { get; set; }
    public string MarketValueLand { get; set; }
    public string MarketImprovementsPerc { get; set; }
    public string TaxFiscalYear { get; set; }
    public string TaxRateArea { get; set; }
    public string TaxBilledAmount { get; set; }
    public string TaxDelinquentYear { get; set; }
    public string LastTaxRollUpdate { get; set; }
    public string AssrLastUpdated { get; set; }
    public string TaxExemptionHomeowner { get; set; }
    public string TaxExemptionDisabled { get; set; }
    public string TaxExemptionSenior { get; set; }
    public string TaxExemptionVeteran { get; set; }
    public string TaxExemptionWidow { get; set; }
    public string TaxExemptionAdditional { get; set; }

    // Setters
    public void SetYearAssessed(string yearAssessed)
    {
      this.YearAssessed = yearAssessed;
    }

    public void SetAssessedValueTotal(string assessedValueTotal)
    {
      this.AssessedValueTotal = assessedValueTotal;
    }

    public void SetAssessedValueImprovements(string assessedValueImprovements)
    {
      this.AssessedValueImprovements = assessedValueImprovements;
    }

    public void SetAssessedValueLand(string assessedValueLand)
    {
      this.AssessedValueLand = assessedValueLand;
    }

    public void SetAssessedImprovementsPerc(string assessedImprovementsPerc)
    {
      this.AssessedImprovementsPerc = assessedImprovementsPerc;
    }

    public void SetMarketValueYear(string marketValueYear)
    {
      this.MarketValueYear = marketValueYear;
    }

    public void SetMarketValueTotal(string marketValueTotal)
    {
      this.MarketValueTotal = marketValueTotal;
    }

    public void SetMarketValueImprovements(string marketValueImprovements)
    {
      this.MarketValueImprovements = marketValueImprovements;
    }

    public void SetMarketValueLand(string marketValueLand)
    {
      this.MarketValueLand = marketValueLand;
    }

    public void SetMarketImprovementsPerc(string marketImprovementsPerc)
    {
      this.MarketImprovementsPerc = marketImprovementsPerc;
    }

    public void SetTaxFiscalYear(string taxFiscalYear)
    {
      this.TaxFiscalYear = taxFiscalYear;
    }

    public void SetTaxRateArea(string taxRateArea)
    {
      this.TaxRateArea = taxRateArea;
    }

    public void SetTaxBilledAmount(string taxBilledAmount)
    {
      this.TaxBilledAmount = taxBilledAmount;
    }

    public void SetTaxDelinquentYear(string taxDelinquentYear)
    {
      this.TaxDelinquentYear = taxDelinquentYear;
    }

    public void SetLastTaxRollUpdate(string lastTaxRollUpdate)
    {
      this.LastTaxRollUpdate = lastTaxRollUpdate;
    }

    public void SetAssrLastUpdated(string assrLastUpdated)
    {
      this.AssrLastUpdated = assrLastUpdated;
    }

    public void SetTaxExemptionHomeowner(string taxExemptionHomeowner)
    {
      this.TaxExemptionHomeowner = taxExemptionHomeowner;
    }

    public void SetTaxExemptionDisabled(string taxExemptionDisabled)
    {
      this.TaxExemptionDisabled = taxExemptionDisabled;
    }

    public void SetTaxExemptionSenior(string taxExemptionSenior)
    {
      this.TaxExemptionSenior = taxExemptionSenior;
    }

    public void SetTaxExemptionVeteran(string taxExemptionVeteran)
    {
      this.TaxExemptionVeteran = taxExemptionVeteran;
    }

    public void SetTaxExemptionWidow(string taxExemptionWidow)
    {
      this.TaxExemptionWidow = taxExemptionWidow;
    }

    public void SetTaxExemptionAdditional(string taxExemptionAdditional)
    {
      this.TaxExemptionAdditional = taxExemptionAdditional;
    }

    // Getters
    public string GetYearAssessed()
    {
      return string.IsNullOrEmpty(this.YearAssessed) ? "" : this.YearAssessed;
    }

    public string GetAssessedValueTotal()
    {
      return string.IsNullOrEmpty(this.AssessedValueTotal) ? "" : this.AssessedValueTotal;
    }

    public string GetAssessedValueImprovements()
    {
      return string.IsNullOrEmpty(this.AssessedValueImprovements) ? "" : this.AssessedValueImprovements;
    }

    public string GetAssessedValueLand()
    {
      return string.IsNullOrEmpty(this.AssessedValueLand) ? "" : this.AssessedValueLand;
    }

    public string GetAssessedImprovementsPerc()
    {
      return string.IsNullOrEmpty(this.AssessedImprovementsPerc) ? "" : this.AssessedImprovementsPerc;
    }

    public string GetMarketValueYear()
    {
      return string.IsNullOrEmpty(this.MarketValueYear) ? "" : this.MarketValueYear;
    }

    public string GetMarketValueTotal()
    {
      return string.IsNullOrEmpty(this.MarketValueTotal) ? "" : this.MarketValueTotal;
    }

    public string GetMarketValueImprovements()
    {
      return string.IsNullOrEmpty(this.MarketValueImprovements) ? "" : this.MarketValueImprovements;
    }

    public string GetMarketValueLand()
    {
      return string.IsNullOrEmpty(this.MarketValueLand) ? "" : this.MarketValueLand;
    }

    public string GetMarketImprovementsPerc()
    {
      return string.IsNullOrEmpty(this.MarketImprovementsPerc) ? "" : this.MarketImprovementsPerc;
    }

    public string GetTaxFiscalYear()
    {
      return string.IsNullOrEmpty(this.TaxFiscalYear) ? "" : this.TaxFiscalYear;
    }

    public string GetTaxRateArea()
    {
      return string.IsNullOrEmpty(this.TaxRateArea) ? "" : this.TaxRateArea;
    }

    public string GetTaxBilledAmount()
    {
      return string.IsNullOrEmpty(this.TaxBilledAmount) ? "" : this.TaxBilledAmount;
    }

    public string GetTaxDelinquentYear()
    {
      return string.IsNullOrEmpty(this.TaxDelinquentYear) ? "" : this.TaxDelinquentYear;
    }

    public string GetLastTaxRollUpdate()
    {
      return string.IsNullOrEmpty(this.LastTaxRollUpdate) ? "" : this.LastTaxRollUpdate;
    }

    public string GetAssrLastUpdated()
    {
      return string.IsNullOrEmpty(this.AssrLastUpdated) ? "" : this.AssrLastUpdated;
    }

    public string GetTaxExemptionHomeowner()
    {
      return string.IsNullOrEmpty(this.TaxExemptionHomeowner) ? "" : this.TaxExemptionHomeowner;
    }

    public string GetTaxExemptionDisabled()
    {
      return string.IsNullOrEmpty(this.TaxExemptionDisabled) ? "" : this.TaxExemptionDisabled;
    }

    public string GetTaxExemptionSenior()
    {
      return string.IsNullOrEmpty(this.TaxExemptionSenior) ? "" : this.TaxExemptionSenior;
    }

    public string GetTaxExemptionVeteran()
    {
      return string.IsNullOrEmpty(this.TaxExemptionVeteran) ? "" : this.TaxExemptionVeteran;
    }

    public string GetTaxExemptionWidow()
    {
      return string.IsNullOrEmpty(this.TaxExemptionWidow) ? "" : this.TaxExemptionWidow;
    }

    public string GetTaxExemptionAdditional()
    {
      return string.IsNullOrEmpty(this.TaxExemptionAdditional) ? "" : this.TaxExemptionAdditional;
    }
  }

  public class PropertyUseInfo : ResponseBase
  {
    public string YearBuilt { get; set; }
    public string YearBuiltEffective { get; set; }
    public string ZonedCodeLocal { get; set; }
    public string PropertyUseMuni { get; set; }
    public string PropertyUseGroup { get; set; }
    public string PropertyUseStandardized { get; set; }

    // Setters
    public void SetYearBuilt(string yearBuilt)
    {
      this.YearBuilt = yearBuilt;
    }

    public void SetYearBuiltEffective(string yearBuiltEffective)
    {
      this.YearBuiltEffective = yearBuiltEffective;
    }

    public void SetZonedCodeLocal(string zonedCodeLocal)
    {
      this.ZonedCodeLocal = zonedCodeLocal;
    }

    public void SetPropertyUseMuni(string propertyUseMuni)
    {
      this.PropertyUseMuni = propertyUseMuni;
    }

    public void SetPropertyUseGroup(string propertyUseGroup)
    {
      this.PropertyUseGroup = propertyUseGroup;
    }

    public void SetPropertyUseStandardized(string propertyUseStandardized)
    {
      this.PropertyUseStandardized = propertyUseStandardized;
    }

    // Getters
    public string GetYearBuilt()
    {
      return string.IsNullOrEmpty(this.YearBuilt) ? "" : this.YearBuilt;
    }

    public string GetYearBuiltEffective()
    {
      return string.IsNullOrEmpty(this.YearBuiltEffective) ? "" : this.YearBuiltEffective;
    }

    public string GetZonedCodeLocal()
    {
      return string.IsNullOrEmpty(this.ZonedCodeLocal) ? "" : this.ZonedCodeLocal;
    }

    public string GetPropertyUseMuni()
    {
      return string.IsNullOrEmpty(this.PropertyUseMuni) ? "" : this.PropertyUseMuni;
    }

    public string GetPropertyUseGroup()
    {
      return string.IsNullOrEmpty(this.PropertyUseGroup) ? "" : this.PropertyUseGroup;
    }

    public string GetPropertyUseStandardized()
    {
      return string.IsNullOrEmpty(this.PropertyUseStandardized) ? "" : this.PropertyUseStandardized;
    }
  }

  public class PropertySaleInfo : ResponseBase
  {
    public string AssessorLastSaleDate { get; set; }
    public string AssessorLastSaleAmount { get; set; }
    public string AssessorPriorSaleDate { get; set; }
    public string AssessorPriorSaleAmount { get; set; }
    public string LastOwnershipTransferDate { get; set; }
    public string LastOwnershipTransferDocumentNumber { get; set; }
    public string DeedLastSaleDocumentBook { get; set; }
    public string DeedLastSaleDocumentPage { get; set; }
    public string DeedLastDocumentNumber { get; set; }
    public string DeedLastSaleDate { get; set; }
    public string DeedLastSalePrice { get; set; }

    // Setters
    public void SetAssessorLastSaleDate(string assessorLastSaleDate)
    {
      this.AssessorLastSaleDate = assessorLastSaleDate;
    }

    public void SetAssessorLastSaleAmount(string assessorLastSaleAmount)
    {
      this.AssessorLastSaleAmount = assessorLastSaleAmount;
    }

    public void SetAssessorPriorSaleDate(string assessorPriorSaleDate)
    {
      this.AssessorPriorSaleDate = assessorPriorSaleDate;
    }

    public void SetAssessorPriorSaleAmount(string assessorPriorSaleAmount)
    {
      this.AssessorPriorSaleAmount = assessorPriorSaleAmount;
    }

    public void SetLastOwnershipTransferDate(string lastOwnershipTransferDate)
    {
      this.LastOwnershipTransferDate = lastOwnershipTransferDate;
    }

    public void SetLastOwnershipTransferDocumentNumber(string lastOwnershipTransferDocumentNumber)
    {
      this.LastOwnershipTransferDocumentNumber = lastOwnershipTransferDocumentNumber;
    }

    public void SetDeedLastSaleDocumentBook(string deedLastSaleDocumentBook)
    {
      this.DeedLastSaleDocumentBook = deedLastSaleDocumentBook;
    }

    public void SetDeedLastSaleDocumentPage(string deedLastSaleDocumentPage)
    {
      this.DeedLastSaleDocumentPage = deedLastSaleDocumentPage;
    }

    public void SetDeedLastDocumentNumber(string deedLastDocumentNumber)
    {
      this.DeedLastDocumentNumber = deedLastDocumentNumber;
    }

    public void SetDeedLastSaleDate(string deedLastSaleDate)
    {
      this.DeedLastSaleDate = deedLastSaleDate;
    }

    public void SetDeedLastSalePrice(string deedLastSalePrice)
    {
      this.DeedLastSalePrice = deedLastSalePrice;
    }

    // Getters
    public string GetAssessorLastSaleDate()
    {
      return string.IsNullOrEmpty(this.AssessorLastSaleDate) ? "" : this.AssessorLastSaleDate;
    }

    public string GetAssessorLastSaleAmount()
    {
      return string.IsNullOrEmpty(this.AssessorLastSaleAmount) ? "" : this.AssessorLastSaleAmount;
    }

    public string GetAssessorPriorSaleDate()
    {
      return string.IsNullOrEmpty(this.AssessorPriorSaleDate) ? "" : this.AssessorPriorSaleDate;
    }

    public string GetAssessorPriorSaleAmount()
    {
      return string.IsNullOrEmpty(this.AssessorPriorSaleAmount) ? "" : this.AssessorPriorSaleAmount;
    }

    public string GetLastOwnershipTransferDate()
    {
      return string.IsNullOrEmpty(this.LastOwnershipTransferDate) ? "" : this.LastOwnershipTransferDate;
    }

    public string GetLastOwnershipTransferDocumentNumber()
    {
      return string.IsNullOrEmpty(this.LastOwnershipTransferDocumentNumber) ? "" : this.LastOwnershipTransferDocumentNumber;
    }

    public string GetDeedLastSaleDocumentBook()
    {
      return string.IsNullOrEmpty(this.DeedLastSaleDocumentBook) ? "" : this.DeedLastSaleDocumentBook;
    }

    public string GetDeedLastSaleDocumentPage()
    {
      return string.IsNullOrEmpty(this.DeedLastSaleDocumentPage) ? "" : this.DeedLastSaleDocumentPage;
    }

    public string GetDeedLastDocumentNumber()
    {
      return string.IsNullOrEmpty(this.DeedLastDocumentNumber) ? "" : this.DeedLastDocumentNumber;
    }

    public string GetDeedLastSaleDate()
    {
      return string.IsNullOrEmpty(this.DeedLastSaleDate) ? "" : this.DeedLastSaleDate;
    }

    public string GetDeedLastSalePrice()
    {
      return string.IsNullOrEmpty(this.DeedLastSalePrice) ? "" : this.DeedLastSalePrice;
    }
  }

  public class PropertySize : ResponseBase
  {
    public string AreaBuilding { get; set; }
    public string Area1stFloor { get; set; }
    public string Area2ndFloor { get; set; }
    public string AreaUpperFloors { get; set; }
    public string AreaLotAcres { get; set; }
    public string AreaLotSF { get; set; }
    public string LotDepth { get; set; }
    public string LotWidth { get; set; }
    public string AtticArea { get; set; }
    public string AtticFlag { get; set; }
    public string BasementArea { get; set; }
    public string BasementAreaFinished { get; set; }
    public string BasementAreaUnfinished { get; set; }
    public string ParkingGarage { get; set; }
    public string ParkingGarageArea { get; set; }
    public string ParkingCarport { get; set; }
    public string ParkingCarportArea { get; set; }

    // Setters
    public void SetAreaBuilding(string areaBuilding)
    {
      this.AreaBuilding = areaBuilding;
    }

    public void SetArea1stFloor(string area1stFloor)
    {
      this.Area1stFloor = area1stFloor;
    }

    public void SetArea2ndFloor(string area2ndFloor)
    {
      this.Area2ndFloor = area2ndFloor;
    }

    public void SetAreaUpperFloors(string areaUpperFloors)
    {
      this.AreaUpperFloors = areaUpperFloors;
    }

    public void SetAreaLotAcres(string areaLotAcres)
    {
      this.AreaLotAcres = areaLotAcres;
    }

    public void SetAreaLotSF(string areaLotSF)
    {
      this.AreaLotSF = areaLotSF;
    }

    public void SetLotDepth(string lotDepth)
    {
      this.LotDepth = lotDepth;
    }

    public void SetLotWidth(string lotWidth)
    {
      this.LotWidth = lotWidth;
    }

    public void SetAtticArea(string atticArea)
    {
      this.AtticArea = atticArea;
    }

    public void SetAtticFlag(string atticFlag)
    {
      this.AtticFlag = atticFlag;
    }

    public void SetBasementArea(string basementArea)
    {
      this.BasementArea = basementArea;
    }

    public void SetBasementAreaFinished(string basementAreaFinished)
    {
      this.BasementAreaFinished = basementAreaFinished;
    }

    public void SetBasementAreaUnfinished(string basementAreaUnfinished)
    {
      this.BasementAreaUnfinished = basementAreaUnfinished;
    }

    public void SetParkingGarage(string parkingGarage)
    {
      this.ParkingGarage = parkingGarage;
    }

    public void SetParkingGarageArea(string parkingGarageArea)
    {
      this.ParkingGarageArea = parkingGarageArea;
    }

    public void SetParkingCarport(string parkingCarport)
    {
      this.ParkingCarport = parkingCarport;
    }

    public void SetParkingCarportArea(string parkingCarportArea)
    {
      this.ParkingCarportArea = parkingCarportArea;
    }

    // Getters
    public string GetAreaBuilding()
    {
      return string.IsNullOrEmpty(this.AreaBuilding) ? "" : this.AreaBuilding;
    }

    public string GetArea1stFloor()
    {
      return string.IsNullOrEmpty(this.Area1stFloor) ? "" : this.Area1stFloor;
    }

    public string GetArea2ndFloor()
    {
      return string.IsNullOrEmpty(this.Area2ndFloor) ? "" : this.Area2ndFloor;
    }

    public string GetAreaUpperFloors()
    {
      return string.IsNullOrEmpty(this.AreaUpperFloors) ? "" : this.AreaUpperFloors;
    }

    public string GetAreaLotAcres()
    {
      return string.IsNullOrEmpty(this.AreaLotAcres) ? "" : this.AreaLotAcres;
    }

    public string GetAreaLotSF()
    {
      return string.IsNullOrEmpty(this.AreaLotSF) ? "" : this.AreaLotSF;
    }

    public string GetLotDepth()
    {
      return string.IsNullOrEmpty(this.LotDepth) ? "" : this.LotDepth;
    }

    public string GetLotWidth()
    {
      return string.IsNullOrEmpty(this.LotWidth) ? "" : this.LotWidth;
    }

    public string GetAtticArea()
    {
      return string.IsNullOrEmpty(this.AtticArea) ? "" : this.AtticArea;
    }

    public string GetAtticFlag()
    {
      return string.IsNullOrEmpty(this.AtticFlag) ? "" : this.AtticFlag;
    }

    public string GetBasementArea()
    {
      return string.IsNullOrEmpty(this.BasementArea) ? "" : this.BasementArea;
    }

    public string GetBasementAreaFinished()
    {
      return string.IsNullOrEmpty(this.BasementAreaFinished) ? "" : this.BasementAreaFinished;
    }

    public string GetBasementAreaUnfinished()
    {
      return string.IsNullOrEmpty(this.BasementAreaUnfinished) ? "" : this.BasementAreaUnfinished;
    }

    public string GetParkingGarage()
    {
      return string.IsNullOrEmpty(this.ParkingGarage) ? "" : this.ParkingGarage;
    }

    public string GetParkingGarageArea()
    {
      return string.IsNullOrEmpty(this.ParkingGarageArea) ? "" : this.ParkingGarageArea;
    }

    public string GetParkingCarport()
    {
      return string.IsNullOrEmpty(this.ParkingCarport) ? "" : this.ParkingCarport;
    }

    public string GetParkingCarportArea()
    {
      return string.IsNullOrEmpty(this.ParkingCarportArea) ? "" : this.ParkingCarportArea;
    }
  }

  public class PropertyPool : ResponseBase
  {
    public string Pool { get; set; }
    public string PoolArea { get; set; } 
    public string SaunaFlag { get; set; }

    // Setters
    public void SetPool(string pool)
    {
      this.Pool = pool;
    }

    public void SetPoolArea(string poolArea)
    {
      this.PoolArea = poolArea;
    }

    public void SetSaunaFlag(string saunaFlag)
    {
      this.SaunaFlag = saunaFlag;
    }

    // Getters
    public string GetPool()
    {
      return string.IsNullOrEmpty(this.Pool) ? "" : this.Pool;
    }

    public string GetPoolArea()
    {
      return string.IsNullOrEmpty(this.PoolArea) ? "" : this.PoolArea;
    }

    public string GetSaunaFlag()
    {
      return string.IsNullOrEmpty(this.SaunaFlag) ? "" : this.SaunaFlag;
    }
  }

  public class PropertyIntStructInfo : ResponseBase
  {
    public string Foundation { get; set; }
    public string Construction { get; set; }
    public string InteriorStructure { get; set; }
    public string PlumbingFixturesCount { get; set; }
    public string ConstructionFireResistanceClass { get; set; }
    public string SafetyFireSprinklersFlag { get; set; }
    public string FlooringMaterialPrimary { get; set; }

    // Setters
    public void SetFoundation(string foundation)
    {
      this.Foundation = foundation;
    }

    public void SetConstruction(string construction)
    {
      this.Construction = construction;
    }

    public void SetInteriorStructure(string interiorStructure)
    {
      this.InteriorStructure = interiorStructure;
    }

    public void SetPlumbingFixturesCount(string plumbingFixturesCount)
    {
      this.PlumbingFixturesCount = plumbingFixturesCount;
    }

    public void SetConstructionFireResistanceClass(string constructionFireResistanceClass)
    {
      this.ConstructionFireResistanceClass = constructionFireResistanceClass;
    }

    public void SetSafetyFireSprinklersFlag(string safetyFireSprinklersFlag)
    {
      this.SafetyFireSprinklersFlag = safetyFireSprinklersFlag;
    }

    public void SetFlooringMaterialPrimary(string flooringMaterialPrimary)
    {
      this.FlooringMaterialPrimary = flooringMaterialPrimary;
    }

    // Getters
    public string GetFoundation()
    {
      return string.IsNullOrEmpty(this.Foundation) ? "" : this.Foundation;
    }

    public string GetConstruction()
    {
      return string.IsNullOrEmpty(this.Construction) ? "" : this.Construction;
    }

    public string GetInteriorStructure()
    {
      return string.IsNullOrEmpty(this.InteriorStructure) ? "" : this.InteriorStructure;
    }

    public string GetPlumbingFixturesCount()
    {
      return string.IsNullOrEmpty(this.PlumbingFixturesCount) ? "" : this.PlumbingFixturesCount;
    }

    public string GetConstructionFireResistanceClass()
    {
      return string.IsNullOrEmpty(this.ConstructionFireResistanceClass) ? "" : this.ConstructionFireResistanceClass;
    }

    public string GetSafetyFireSprinklersFlag()
    {
      return string.IsNullOrEmpty(this.SafetyFireSprinklersFlag) ? "" : this.SafetyFireSprinklersFlag;
    }

    public string GetFlooringMaterialPrimary()
    {
      return string.IsNullOrEmpty(this.FlooringMaterialPrimary) ? "" : this.FlooringMaterialPrimary;
    }
  }

  public class PropertyIntRoomInfo : ResponseBase
  {
    public string BathCount { get; set; }
    public string BathPartialCount { get; set; }
    public string BedroomsCount { get; set; }
    public string RoomsCount { get; set; }
    public string StoriesCount { get; set; }
    public string UnitsCount { get; set; }
    public string BonusRoomFlag { get; set; }
    public string BreakfastNookFlag { get; set; }
    public string CellarFlag { get; set; }
    public string ExerciseFlag { get; set; }
    public string FamilyCode { get; set; }
    public string GameFlag { get; set; }
    public string GreatFlag { get; set; }
    public string HobbyFlag { get; set; }
    public string LaundryFlag { get; set; }
    public string MediaFlag { get; set; }
    public string MudFlag { get; set; }
    public string OfficeArea { get; set; }
    public string OfficeFlag { get; set; }
    public string SafeRoomFlag { get; set; }
    public string SittingFlag { get; set; }
    public string StormFlag { get; set; }
    public string StudyFlag { get; set; }
    public string SunroomFlag { get; set; }
    public string UtilityArea { get; set; }
    public string UtilityCode { get; set; }

    // Setters
    public void SetBathCount(string bathCount)
    {
      this.BathCount = bathCount;
    }

    public void SetBathPartialCount(string bathPartialCount)
    {
      this.BathPartialCount = bathPartialCount;
    }

    public void SetBedroomsCount(string bedroomsCount)
    {
      this.BedroomsCount = bedroomsCount;
    }

    public void SetRoomsCount(string roomsCount)
    {
      this.RoomsCount = roomsCount;
    }

    public void SetStoriesCount(string storiesCount)
    {
      this.StoriesCount = storiesCount;
    }

    public void SetUnitsCount(string unitsCount)
    {
      this.UnitsCount = unitsCount;
    }

    public void SetBonusRoomFlag(string bonusRoomFlag)
    {
      this.BonusRoomFlag = bonusRoomFlag;
    }

    public void SetBreakfastNookFlag(string breakfastNookFlag)
    {
      this.BreakfastNookFlag = breakfastNookFlag;
    }

    public void SetCellarFlag(string cellarFlag)
    {
      this.CellarFlag = cellarFlag;
    }

    public void SetExerciseFlag(string exerciseFlag)
    {
      this.ExerciseFlag = exerciseFlag;
    }

    public void SetFamilyCode(string familyCode)
    {
      this.FamilyCode = familyCode;
    }

    public void SetGameFlag(string gameFlag)
    {
      this.GameFlag = gameFlag;
    }

    public void SetGreatFlag(string greatFlag)
    {
      this.GreatFlag = greatFlag;
    }

    public void SetHobbyFlag(string hobbyFlag)
    {
      this.HobbyFlag = hobbyFlag;
    }

    public void SetLaundryFlag(string laundryFlag)
    {
      this.LaundryFlag = laundryFlag;
    }

    public void SetMediaFlag(string mediaFlag)
    {
      this.MediaFlag = mediaFlag;
    }

    public void SetMudFlag(string mudFlag)
    {
      this.MudFlag = mudFlag;
    }

    public void SetOfficeArea(string officeArea)
    {
      this.OfficeArea = officeArea;
    }

    public void SetOfficeFlag(string officeFlag)
    {
      this.OfficeFlag = officeFlag;
    }

    public void SetSafeRoomFlag(string safeRoomFlag)
    {
      this.SafeRoomFlag = safeRoomFlag;
    }

    public void SetSittingFlag(string sittingFlag)
    {
      this.SittingFlag = sittingFlag;
    }

    public void SetStormFlag(string stormFlag)
    {
      this.StormFlag = stormFlag;
    }

    public void SetStudyFlag(string studyFlag)
    {
      this.StudyFlag = studyFlag;
    }

    public void SetSunroomFlag(string sunroomFlag)
    {
      this.SunroomFlag = sunroomFlag;
    }

    public void SetUtilityArea(string utilityArea)
    {
      this.UtilityArea = utilityArea;
    }

    public void SetUtilityCode(string utilityCode)
    {
      this.UtilityCode = utilityCode;
    }

    // Getters
    public string GetBathCount()
    {
      return string.IsNullOrEmpty(this.BathCount) ? "" : this.BathCount;
    }

    public string GetBathPartialCount()
    {
      return string.IsNullOrEmpty(this.BathPartialCount) ? "" : this.BathPartialCount;
    }

    public string GetBedroomsCount()
    {
      return string.IsNullOrEmpty(this.BedroomsCount) ? "" : this.BedroomsCount;
    }

    public string GetRoomsCount()
    {
      return string.IsNullOrEmpty(this.RoomsCount) ? "" : this.RoomsCount;
    }

    public string GetStoriesCount()
    {
      return string.IsNullOrEmpty(this.StoriesCount) ? "" : this.StoriesCount;
    }

    public string GetUnitsCount()
    {
      return string.IsNullOrEmpty(this.UnitsCount) ? "" : this.UnitsCount;
    }

    public string GetBonusRoomFlag()
    {
      return string.IsNullOrEmpty(this.BonusRoomFlag) ? "" : this.BonusRoomFlag;
    }

    public string GetBreakfastNookFlag()
    {
      return string.IsNullOrEmpty(this.BreakfastNookFlag) ? "" : this.BreakfastNookFlag;
    }

    public string GetCellarFlag()
    {
      return string.IsNullOrEmpty(this.CellarFlag) ? "" : this.CellarFlag;
    }

    public string GetExerciseFlag()
    {
      return string.IsNullOrEmpty(this.ExerciseFlag) ? "" : this.ExerciseFlag;
    }

    public string GetFamilyCode()
    {
      return string.IsNullOrEmpty(this.FamilyCode) ? "" : this.FamilyCode;
    }

    public string GetGameFlag()
    {
      return string.IsNullOrEmpty(this.GameFlag) ? "" : this.GameFlag;
    }

    public string GetGreatFlag()
    {
      return string.IsNullOrEmpty(this.GreatFlag) ? "" : this.GreatFlag;
    }

    public string GetHobbyFlag()
    {
      return string.IsNullOrEmpty(this.HobbyFlag) ? "" : this.HobbyFlag;
    }

    public string GetLaundryFlag()
    {
      return string.IsNullOrEmpty(this.LaundryFlag) ? "" : this.LaundryFlag;
    }

    public string GetMediaFlag()
    {
      return string.IsNullOrEmpty(this.MediaFlag) ? "" : this.MediaFlag;
    }

    public string GetMudFlag()
    {
      return string.IsNullOrEmpty(this.MudFlag) ? "" : this.MudFlag;
    }

    public string GetOfficeArea()
    {
      return string.IsNullOrEmpty(this.OfficeArea) ? "" : this.OfficeArea;
    }

    public string GetOfficeFlag()
    {
      return string.IsNullOrEmpty(this.OfficeFlag) ? "" : this.OfficeFlag;
    }

    public string GetSafeRoomFlag()
    {
      return string.IsNullOrEmpty(this.SafeRoomFlag) ? "" : this.SafeRoomFlag;
    }

    public string GetSittingFlag()
    {
      return string.IsNullOrEmpty(this.SittingFlag) ? "" : this.SittingFlag;
    }

    public string GetStormFlag()
    {
      return string.IsNullOrEmpty(this.StormFlag) ? "" : this.StormFlag;
    }

    public string GetStudyFlag()
    {
      return string.IsNullOrEmpty(this.StudyFlag) ? "" : this.StudyFlag;
    }

    public string GetSunroomFlag()
    {
      return string.IsNullOrEmpty(this.SunroomFlag) ? "" : this.SunroomFlag;
    }

    public string GetUtilityArea()
    {
      return string.IsNullOrEmpty(this.UtilityArea) ? "" : this.UtilityArea;
    }

    public string GetUtilityCode()
    {
      return string.IsNullOrEmpty(this.UtilityCode) ? "" : this.UtilityCode;
    }
  }

  public class PropertyIntAmentities : ResponseBase
  {
    public string Fireplace { get; set; }
    public string FireplaceCount { get; set; }
    public string AccessabilityElevatorFlag { get; set; }
    public string AccessabilityHandicapFlag { get; set; }
    public string EscalatorFlag { get; set; }
    public string CentralVacuumFlag { get; set; }
    public string IntercomFlag { get; set; }
    public string SoundSystemFlag { get; set; }
    public string WetBarFlag { get; set; }
    public string SecurityAlarmFlag { get; set; }

    // Setters
    public void SetFireplace(string fireplace)
    {
      this.Fireplace = fireplace;
    }

    public void SetFireplaceCount(string fireplaceCount)
    {
      this.FireplaceCount = fireplaceCount;
    }

    public void SetAccessabilityElevatorFlag(string accessabilityElevatorFlag)
    {
      this.AccessabilityElevatorFlag = accessabilityElevatorFlag;
    }

    public void SetAccessabilityHandicapFlag(string accessabilityHandicapFlag)
    {
      this.AccessabilityHandicapFlag = accessabilityHandicapFlag;
    }

    public void SetEscalatorFlag(string escalatorFlag)
    {
      this.EscalatorFlag = escalatorFlag;
    }

    public void SetCentralVacuumFlag(string centralVacuumFlag)
    {
      this.CentralVacuumFlag = centralVacuumFlag;
    }

    public void SetIntercomFlag(string intercomFlag)
    {
      this.IntercomFlag = intercomFlag;
    }

    public void SetSoundSystemFlag(string soundSystemFlag)
    {
      this.SoundSystemFlag = soundSystemFlag;
    }

    public void SetWetBarFlag(string wetBarFlag)
    {
      this.WetBarFlag = wetBarFlag;
    }

    public void SetSecurityAlarmFlag(string securityAlarmFlag)
    {
      this.SecurityAlarmFlag = securityAlarmFlag;
    }

    // Getters
    public string GetFireplace()
    {
      return string.IsNullOrEmpty(this.Fireplace) ? "" : this.Fireplace;
    }

    public string GetFireplaceCount()
    {
      return string.IsNullOrEmpty(this.FireplaceCount) ? "" : this.FireplaceCount;
    }

    public string GetAccessabilityElevatorFlag()
    {
      return string.IsNullOrEmpty(this.AccessabilityElevatorFlag) ? "" : this.AccessabilityElevatorFlag;
    }

    public string GetAccessabilityHandicapFlag()
    {
      return string.IsNullOrEmpty(this.AccessabilityHandicapFlag) ? "" : this.AccessabilityHandicapFlag;
    }

    public string GetEscalatorFlag()
    {
      return string.IsNullOrEmpty(this.EscalatorFlag) ? "" : this.EscalatorFlag;
    }

    public string GetCentralVacuumFlag()
    {
      return string.IsNullOrEmpty(this.CentralVacuumFlag) ? "" : this.CentralVacuumFlag;
    }

    public string GetIntercomFlag()
    {
      return string.IsNullOrEmpty(this.IntercomFlag) ? "" : this.IntercomFlag;
    }

    public string GetSoundSystemFlag()
    {
      return string.IsNullOrEmpty(this.SoundSystemFlag) ? "" : this.SoundSystemFlag;
    }

    public string GetWetBarFlag()
    {
      return string.IsNullOrEmpty(this.WetBarFlag) ? "" : this.WetBarFlag;
    }

    public string GetSecurityAlarmFlag()
    {
      return string.IsNullOrEmpty(this.SecurityAlarmFlag) ? "" : this.SecurityAlarmFlag;
    }
  }

  public class PropertyExtStructInfo : ResponseBase
  {
    public string StructureStyle { get; set; }
    public string Exterior1Code { get; set; }
    public string RoofMaterial { get; set; }
    public string RoofConstruction { get; set; }
    public string StormShutterFlag { get; set; }
    public string OverheadDoorFlag { get; set; }

    // Setters
    public void SetStructureStyle(string structureStyle)
    {
      this.StructureStyle = structureStyle;
    }

    public void SetExterior1Code(string exterior1Code)
    {
      this.Exterior1Code = exterior1Code;
    }

    public void SetRoofMaterial(string roofMaterial)
    {
      this.RoofMaterial = roofMaterial;
    }

    public void SetRoofConstruction(string roofConstruction)
    {
      this.RoofConstruction = roofConstruction;
    }

    public void SetStormShutterFlag(string stormShutterFlag)
    {
      this.StormShutterFlag = stormShutterFlag;
    }

    public void SetOverheadDoorFlag(string overheadDoorFlag)
    {
      this.OverheadDoorFlag = overheadDoorFlag;
    }

    // Getters
    public string GetStructureStyle()
    {
      return string.IsNullOrEmpty(this.StructureStyle) ? "" : this.StructureStyle;
    }

    public string GetExterior1Code()
    {
      return string.IsNullOrEmpty(this.Exterior1Code) ? "" : this.Exterior1Code;
    }

    public string GetRoofMaterial()
    {
      return string.IsNullOrEmpty(this.RoofMaterial) ? "" : this.RoofMaterial;
    }

    public string GetRoofConstruction()
    {
      return string.IsNullOrEmpty(this.RoofConstruction) ? "" : this.RoofConstruction;
    }

    public string GetStormShutterFlag()
    {
      return string.IsNullOrEmpty(this.StormShutterFlag) ? "" : this.StormShutterFlag;
    }

    public string GetOverheadDoorFlag()
    {
      return string.IsNullOrEmpty(this.OverheadDoorFlag) ? "" : this.OverheadDoorFlag;
    }
  }

  public class PropertyExtAmentities : ResponseBase
  {
    public string ViewDescription { get; set; }
    public string PorchCode { get; set; }
    public string PorchArea { get; set; }
    public string PatioArea { get; set; }
    public string DeckFlag { get; set; }
    public string DeckArea { get; set; }
    public string FeatureBalconyFlag { get; set; }
    public string BalconyArea { get; set; }
    public string BreezewayFlag { get; set; }

    // Setters
    public void SetViewDescription(string viewDescription)
    {
      this.ViewDescription = viewDescription;
    }

    public void SetPorchCode(string porchCode)
    {
      this.PorchCode = porchCode;
    }

    public void SetPorchArea(string porchArea)
    {
      this.PorchArea = porchArea;
    }

    public void SetPatioArea(string patioArea)
    {
      this.PatioArea = patioArea;
    }

    public void SetDeckFlag(string deckFlag)
    {
      this.DeckFlag = deckFlag;
    }

    public void SetDeckArea(string deckArea)
    {
      this.DeckArea = deckArea;
    }

    public void SetFeatureBalconyFlag(string featureBalconyFlag)
    {
      this.FeatureBalconyFlag = featureBalconyFlag;
    }

    public void SetBalconyArea(string balconyArea)
    {
      this.BalconyArea = balconyArea;
    }

    public void SetBreezewayFlag(string breezewayFlag)
    {
      this.BreezewayFlag = breezewayFlag;
    }

    // Getters
    public string GetViewDescription()
    {
      return string.IsNullOrEmpty(this.ViewDescription) ? "" : this.ViewDescription;
    }

    public string GetPorchCode()
    {
      return string.IsNullOrEmpty(this.PorchCode) ? "" : this.PorchCode;
    }

    public string GetPorchArea()
    {
      return string.IsNullOrEmpty(this.PorchArea) ? "" : this.PorchArea;
    }

    public string GetPatioArea()
    {
      return string.IsNullOrEmpty(this.PatioArea) ? "" : this.PatioArea;
    }

    public string GetDeckFlag()
    {
      return string.IsNullOrEmpty(this.DeckFlag) ? "" : this.DeckFlag;
    }

    public string GetDeckArea()
    {
      return string.IsNullOrEmpty(this.DeckArea) ? "" : this.DeckArea;
    }

    public string GetFeatureBalconyFlag()
    {
      return string.IsNullOrEmpty(this.FeatureBalconyFlag) ? "" : this.FeatureBalconyFlag;
    }

    public string GetBalconyArea()
    {
      return string.IsNullOrEmpty(this.BalconyArea) ? "" : this.BalconyArea;
    }

    public string GetBreezewayFlag()
    {
      return string.IsNullOrEmpty(this.BreezewayFlag) ? "" : this.BreezewayFlag;
    }
  }

  public class PropertyExtBuildings : ResponseBase
  {
    public string BuildingsCount { get; set; }
    public string BathHouseArea { get; set; }
    public string BathHouseFlag { get; set; }
    public string BoatHouseArea { get; set; }
    public string BoatHouseFlag { get; set; }
    public string CabinArea { get; set; }
    public string CabinFlag { get; set; }
    public string CanopyArea { get; set; }
    public string CanopyFlag { get; set; }
    public string GazeboArea { get; set; }
    public string GazeboFlag { get; set; }
    public string GranaryArea { get; set; }
    public string GranaryFlag { get; set; } 
    public string GreenHouseArea { get; set; }
    public string GreenHouseFlag { get; set; }
    public string GuestHouseArea { get; set; }
    public string GuestHouseFlag { get; set; }
    public string KennelArea { get; set; }
    public string KennelFlag { get; set; }
    public string LeanToArea { get; set; }
    public string LeanToFlag { get; set; }
    public string LoadingPlatformArea { get; set; }
    public string LoadingPlatformFlag { get; set; }
    public string MilkHouseArea { get; set; }
    public string MilkHouseFlag { get; set; }
    public string OutdoorKitchenFireplaceFlag { get; set; }
    public string PoolHouseArea { get; set; }
    public string PoolHouseFlag { get; set; }
    public string PoultryHouseArea { get; set; }
    public string PoultryHouseFlag { get; set; }
    public string QuonsetArea { get; set; }
    public string QuonsetFlag { get; set; }
    public string ShedArea { get; set; }
    public string ShedCode { get; set; }
    public string SiloArea { get; set; }
    public string SiloFlag { get; set; }
    public string StableArea { get; set; }
    public string StableFlag { get; set; }
    public string StorageBuildingArea { get; set; }
    public string StorageBuildingFlag { get; set; }
    public string UtilityBuildingArea { get; set; }
    public string UtilityBuildingFlag { get; set; }
    public string PoleStructureArea { get; set; }
    public string PoleStructureFlag { get; set; }

    // Setters
    public void SetBuildingsCount(string buildingsCount)
    {
      this.BuildingsCount = buildingsCount;
    }

    public void SetBathHouseArea(string bathHouseArea)
    {
      this.BathHouseArea = bathHouseArea;
    }

    public void SetBathHouseFlag(string bathHouseFlag)
    {
      this.BathHouseFlag = bathHouseFlag;
    }

    public void SetBoatHouseArea(string boatHouseArea)
    {
      this.BoatHouseArea = boatHouseArea;
    }

    public void SetBoatHouseFlag(string boatHouseFlag)
    {
      this.BoatHouseFlag = boatHouseFlag;
    }

    public void SetCabinArea(string cabinArea)
    {
      this.CabinArea = cabinArea;
    }

    public void SetCabinFlag(string cabinFlag)
    {
      this.CabinFlag = cabinFlag;
    }

    public void SetCanopyArea(string canopyArea)
    {
      this.CanopyArea = canopyArea;
    }

    public void SetCanopyFlag(string canopyFlag)
    {
      this.CanopyFlag = canopyFlag;
    }

    public void SetGazeboArea(string gazeboArea)
    {
      this.GazeboArea = gazeboArea;
    }

    public void SetGazeboFlag(string gazeboFlag)
    {
      this.GazeboFlag = gazeboFlag;
    }

    public void SetGranaryArea(string granaryArea)
    {
      this.GranaryArea = granaryArea;
    }

    public void SetGranaryFlag(string granaryFlag)
    {
      this.GranaryFlag = granaryFlag;
    }

    public void SetGreenHouseArea(string greenHouseArea)
    {
      this.GreenHouseArea = greenHouseArea;
    }

    public void SetGreenHouseFlag(string greenHouseFlag)
    {
      this.GreenHouseFlag = greenHouseFlag;
    }

    public void SetGuestHouseArea(string guestHouseArea)
    {
      this.GuestHouseArea = guestHouseArea;
    }

    public void SetGuestHouseFlag(string guestHouseFlag)
    {
      this.GuestHouseFlag = guestHouseFlag;
    }

    public void SetKennelArea(string kennelArea)
    {
      this.KennelArea = kennelArea;
    }

    public void SetKennelFlag(string kennelFlag)
    {
      this.KennelFlag = kennelFlag;
    }

    public void SetLeanToArea(string leanToArea)
    {
      this.LeanToArea = leanToArea;
    }

    public void SetLeanToFlag(string leanToFlag)
    {
      this.LeanToFlag = leanToFlag;
    }

    public void SetLoadingPlatformArea(string loadingPlatformArea)
    {
      this.LoadingPlatformArea = loadingPlatformArea;
    }

    public void SetLoadingPlatformFlag(string loadingPlatformFlag)
    {
      this.LoadingPlatformFlag = loadingPlatformFlag;
    }

    public void SetMilkHouseArea(string milkHouseArea)
    {
      this.MilkHouseArea = milkHouseArea;
    }

    public void SetMilkHouseFlag(string milkHouseFlag)
    {
      this.MilkHouseFlag = milkHouseFlag;
    }

    public void SetOutdoorKitchenFireplaceFlag(string outdoorKitchenFireplaceFlag)
    {
      this.OutdoorKitchenFireplaceFlag = outdoorKitchenFireplaceFlag;
    }

    public void SetPoolHouseArea(string poolHouseArea)
    {
      this.PoolHouseArea = poolHouseArea;
    }

    public void SetPoolHouseFlag(string poolHouseFlag)
    {
      this.PoolHouseFlag = poolHouseFlag;
    }

    public void SetPoultryHouseArea(string poultryHouseArea)
    {
      this.PoultryHouseArea = poultryHouseArea;
    }

    public void SetPoultryHouseFlag(string poultryHouseFlag)
    {
      this.PoultryHouseFlag = poultryHouseFlag;
    }

    public void SetQuonsetArea(string quonsetArea)
    {
      this.QuonsetArea = quonsetArea;
    }

    public void SetQuonsetFlag(string quonsetFlag)
    {
      this.QuonsetFlag = quonsetFlag;
    }

    public void SetShedArea(string shedArea)
    {
      this.ShedArea = shedArea;
    }

    public void SetShedCode(string shedCode)
    {
      this.ShedCode = shedCode;
    }

    public void SetSiloArea(string siloArea)
    {
      this.SiloArea = siloArea;
    }

    public void SetSiloFlag(string siloFlag)
    {
      this.SiloFlag = siloFlag;
    }

    public void SetStableArea(string stableArea)
    {
      this.StableArea = stableArea;
    }

    public void SetStableFlag(string stableFlag)
    {
      this.StableFlag = stableFlag;
    }

    public void SetStorageBuildingArea(string storageBuildingArea)
    {
      this.StorageBuildingArea = storageBuildingArea;
    }

    public void SetStorageBuildingFlag(string storageBuildingFlag)
    {
      this.StorageBuildingFlag = storageBuildingFlag;
    }

    public void SetUtilityBuildingArea(string utilityBuildingArea)
    {
      this.UtilityBuildingArea = utilityBuildingArea;
    }

    public void SetUtilityBuildingFlag(string utilityBuildingFlag)
    {
      this.UtilityBuildingFlag = utilityBuildingFlag;
    }

    public void SetPoleStructureArea(string poleStructureArea)
    {
      this.PoleStructureArea = poleStructureArea;
    }

    public void SetPoleStructureFlag(string poleStructureFlag)
    {
      this.PoleStructureFlag = poleStructureFlag;
    }

    // Getters
    public string GetBuildingsCount()
    {
      return string.IsNullOrEmpty(this.BuildingsCount) ? "" : this.BuildingsCount;
    }

    public string GetBathHouseArea()
    {
      return string.IsNullOrEmpty(this.BathHouseArea) ? "" : this.BathHouseArea;
    }

    public string GetBathHouseFlag()
    {
      return string.IsNullOrEmpty(this.BathHouseFlag) ? "" : this.BathHouseFlag;
    }

    public string GetBoatHouseArea()
    {
      return string.IsNullOrEmpty(this.BoatHouseArea) ? "" : this.BoatHouseArea;
    }

    public string GetBoatHouseFlag()
    {
      return string.IsNullOrEmpty(this.BoatHouseFlag) ? "" : this.BoatHouseFlag;
    }

    public string GetCabinArea()
    {
      return string.IsNullOrEmpty(this.CabinArea) ? "" : this.CabinArea;
    }

    public string GetCabinFlag()
    {
      return string.IsNullOrEmpty(this.CabinFlag) ? "" : this.CabinFlag;
    }

    public string GetCanopyArea()
    {
      return string.IsNullOrEmpty(this.CanopyArea) ? "" : this.CanopyArea;
    }

    public string GetCanopyFlag()
    {
      return string.IsNullOrEmpty(this.CanopyFlag) ? "" : this.CanopyFlag;
    }

    public string GetGazeboArea()
    {
      return string.IsNullOrEmpty(this.GazeboArea) ? "" : this.GazeboArea;
    }

    public string GetGazeboFlag()
    {
      return string.IsNullOrEmpty(this.GazeboFlag) ? "" : this.GazeboFlag;
    }

    public string GetGranaryArea()
    {
      return string.IsNullOrEmpty(this.GranaryArea) ? "" : this.GranaryArea;
    }

    public string GetGranaryFlag()
    {
      return string.IsNullOrEmpty(this.GranaryFlag) ? "" : this.GranaryFlag;
    }

    public string GetGreenHouseArea()
    {
      return string.IsNullOrEmpty(this.GreenHouseArea) ? "" : this.GreenHouseArea;
    }

    public string GetGreenHouseFlag()
    {
      return string.IsNullOrEmpty(this.GreenHouseFlag) ? "" : this.GreenHouseFlag;
    }

    public string GetGuestHouseArea()
    {
      return string.IsNullOrEmpty(this.GuestHouseArea) ? "" : this.GuestHouseArea;
    }

    public string GetGuestHouseFlag()
    {
      return string.IsNullOrEmpty(this.GuestHouseFlag) ? "" : this.GuestHouseFlag;
    }

    public string GetKennelArea()
    {
      return string.IsNullOrEmpty(this.KennelArea) ? "" : this.KennelArea;
    }

    public string GetKennelFlag()
    {
      return string.IsNullOrEmpty(this.KennelFlag) ? "" : this.KennelFlag;
    }

    public string GetLeanToArea()
    {
      return string.IsNullOrEmpty(this.LeanToArea) ? "" : this.LeanToArea;
    }

    public string GetLeanToFlag()
    {
      return string.IsNullOrEmpty(this.LeanToFlag) ? "" : this.LeanToFlag;
    }

    public string GetLoadingPlatformArea()
    {
      return string.IsNullOrEmpty(this.LoadingPlatformArea) ? "" : this.LoadingPlatformArea;
    }

    public string GetLoadingPlatformFlag()
    {
      return string.IsNullOrEmpty(this.LoadingPlatformFlag) ? "" : this.LoadingPlatformFlag;
    }

    public string GetMilkHouseArea()
    {
      return string.IsNullOrEmpty(this.MilkHouseArea) ? "" : this.MilkHouseArea;
    }

    public string GetMilkHouseFlag()
    {
      return string.IsNullOrEmpty(this.MilkHouseFlag) ? "" : this.MilkHouseFlag;
    }

    public string GetOutdoorKitchenFireplaceFlag()
    {
      return string.IsNullOrEmpty(this.OutdoorKitchenFireplaceFlag) ? "" : this.OutdoorKitchenFireplaceFlag;
    }

    public string GetPoolHouseArea()
    {
      return string.IsNullOrEmpty(this.PoolHouseArea) ? "" : this.PoolHouseArea;
    }

    public string GetPoolHouseFlag()
    {
      return string.IsNullOrEmpty(this.PoolHouseFlag) ? "" : this.PoolHouseFlag;
    }

    public string GetPoultryHouseArea()
    {
      return string.IsNullOrEmpty(this.PoultryHouseArea) ? "" : this.PoultryHouseArea;
    }

    public string GetPoultryHouseFlag()
    {
      return string.IsNullOrEmpty(this.PoultryHouseFlag) ? "" : this.PoultryHouseFlag;
    }

    public string GetQuonsetArea()
    {
      return string.IsNullOrEmpty(this.QuonsetArea) ? "" : this.QuonsetArea;
    }

    public string GetQuonsetFlag()
    {
      return string.IsNullOrEmpty(this.QuonsetFlag) ? "" : this.QuonsetFlag;
    }

    public string GetShedArea()
    {
      return string.IsNullOrEmpty(this.ShedArea) ? "" : this.ShedArea;
    }

    public string GetShedCode()
    {
      return string.IsNullOrEmpty(this.ShedCode) ? "" : this.ShedCode;
    }

    public string GetSiloArea()
    {
      return string.IsNullOrEmpty(this.SiloArea) ? "" : this.SiloArea;
    }

    public string GetSiloFlag()
    {
      return string.IsNullOrEmpty(this.SiloFlag) ? "" : this.SiloFlag;
    }

    public string GetStableArea()
    {
      return string.IsNullOrEmpty(this.StableArea) ? "" : this.StableArea;
    }

    public string GetStableFlag()
    {
      return string.IsNullOrEmpty(this.StableFlag) ? "" : this.StableFlag;
    }

    public string GetStorageBuildingArea()
    {
      return string.IsNullOrEmpty(this.StorageBuildingArea) ? "" : this.StorageBuildingArea;
    }

    public string GetStorageBuildingFlag()
    {
      return string.IsNullOrEmpty(this.StorageBuildingFlag) ? "" : this.StorageBuildingFlag;
    }

    public string GetUtilityBuildingArea()
    {
      return string.IsNullOrEmpty(this.UtilityBuildingArea) ? "" : this.UtilityBuildingArea;
    }

    public string GetUtilityBuildingFlag()
    {
      return string.IsNullOrEmpty(this.UtilityBuildingFlag) ? "" : this.UtilityBuildingFlag;
    }

    public string GetPoleStructureArea()
    {
      return string.IsNullOrEmpty(this.PoleStructureArea) ? "" : this.PoleStructureArea;
    }

    public string GetPoleStructureFlag()
    {
      return string.IsNullOrEmpty(this.PoleStructureFlag) ? "" : this.PoleStructureFlag;
    }
  }

  public class PropertyUtilities : ResponseBase
  {
    public string HVACCoolingDetail { get; set; }
    public string HVACHeatingDetail { get; set; }
    public string HVACHeatingFuel { get; set; }
    public string SewageUsage { get; set; }
    public string WaterSource { get; set; }
    public string MobileHomeHookupFlag { get; set; }

    // Setters
    public void SetHVACCoolingDetail(string hvacCoolingDetail)
    {
      this.HVACCoolingDetail = hvacCoolingDetail;
    }

    public void SetHVACHeatingDetail(string hvacHeatingDetail)
    {
      this.HVACHeatingDetail = hvacHeatingDetail;
    }

    public void SetHVACHeatingFuel(string hvacHeatingFuel)
    {
      this.HVACHeatingFuel = hvacHeatingFuel;
    }

    public void SetSewageUsage(string sewageUsage)
    {
      this.SewageUsage = sewageUsage;
    }

    public void SetWaterSource(string waterSource)
    {
      this.WaterSource = waterSource;
    }

    public void SetMobileHomeHookupFlag(string mobileHomeHookupFlag)
    {
      this.MobileHomeHookupFlag = mobileHomeHookupFlag;
    }

    // Getters
    public string GetHVACCoolingDetail()
    {
      return string.IsNullOrEmpty(this.HVACCoolingDetail) ? "" : this.HVACCoolingDetail;
    }

    public string GetHVACHeatingDetail()
    {
      return string.IsNullOrEmpty(this.HVACHeatingDetail) ? "" : this.HVACHeatingDetail;
    }

    public string GetHVACHeatingFuel()
    {
      return string.IsNullOrEmpty(this.HVACHeatingFuel) ? "" : this.HVACHeatingFuel;
    }

    public string GetSewageUsage()
    {
      return string.IsNullOrEmpty(this.SewageUsage) ? "" : this.SewageUsage;
    }

    public string GetWaterSource()
    {
      return string.IsNullOrEmpty(this.WaterSource) ? "" : this.WaterSource;
    }

    public string GetMobileHomeHookupFlag()
    {
      return string.IsNullOrEmpty(this.MobileHomeHookupFlag) ? "" : this.MobileHomeHookupFlag;
    }
  }

  public class PropertyParking : ResponseBase
  {
    public string RVParkingFlag { get; set; }
    public string ParkingSpaceCount { get; set; }
    public string DrivewayArea { get; set; }
    public string DrivewayMaterial { get; set; }

    // Setters
    public void SetRVParkingFlag(string rvParkingFlag)
    {
      this.RVParkingFlag = rvParkingFlag;
    }

    public void SetParkingSpaceCount(string parkingSpaceCount)
    {
      this.ParkingSpaceCount = parkingSpaceCount;
    }

    public void SetDrivewayArea(string drivewayArea)
    {
      this.DrivewayArea = drivewayArea;
    }

    public void SetDrivewayMaterial(string drivewayMaterial)
    {
      this.DrivewayMaterial = drivewayMaterial;
    }

    // Getters
    public string GetRVParkingFlag()
    {
      return string.IsNullOrEmpty(this.RVParkingFlag) ? "" : this.RVParkingFlag;
    }

    public string GetParkingSpaceCount()
    {
      return string.IsNullOrEmpty(this.ParkingSpaceCount) ? "" : this.ParkingSpaceCount;
    }

    public string GetDrivewayArea()
    {
      return string.IsNullOrEmpty(this.DrivewayArea) ? "" : this.DrivewayArea;
    }

    public string GetDrivewayMaterial()
    {
      return string.IsNullOrEmpty(this.DrivewayMaterial) ? "" : this.DrivewayMaterial;
    }
  }

  public class PropertyYardGardenInfo : ResponseBase
  {
    public string TopographyCode { get; set; }
    public string FenceCode { get; set; }
    public string FenceArea { get; set; }
    public string CourtyardFlag { get; set; }
    public string CourtyardArea { get; set; }
    public string ArborPergolaFlag { get; set; }
    public string SprinklersFlag { get; set; }
    public string GolfCourseGreenFlag { get; set; }
    public string TennisCourtFlag { get; set; }
    public string SportsCourtFlag { get; set; }
    public string AreanFlag { get; set; }
    public string WaterFeatureFlag { get; set; }
    public string PondFlag { get; set; }
    public string BoatLiftFlag { get; set; }

    // Setters
    public void SetTopographyCode(string topographyCode)
    {
      this.TopographyCode = topographyCode;
    }

    public void SetFenceCode(string fenceCode)
    {
      this.FenceCode = fenceCode;
    }

    public void SetFenceArea(string fenceArea)
    {
      this.FenceArea = fenceArea;
    }

    public void SetCourtyardFlag(string courtyardFlag)
    {
      this.CourtyardFlag = courtyardFlag;
    }

    public void SetCourtyardArea(string courtyardArea)
    {
      this.CourtyardArea = courtyardArea;
    }

    public void SetArborPergolaFlag(string arborPergolaFlag)
    {
      this.ArborPergolaFlag = arborPergolaFlag;
    }

    public void SetSprinklersFlag(string sprinklersFlag)
    {
      this.SprinklersFlag = sprinklersFlag;
    }

    public void SetGolfCourseGreenFlag(string golfCourseGreenFlag)
    {
      this.GolfCourseGreenFlag = golfCourseGreenFlag;
    }

    public void SetTennisCourtFlag(string tennisCourtFlag)
    {
      this.TennisCourtFlag = tennisCourtFlag;
    }

    public void SetSportsCourtFlag(string sportsCourtFlag)
    {
      this.SportsCourtFlag = sportsCourtFlag;
    }

    public void SetAreanFlag(string areanFlag)
    {
      this.AreanFlag = areanFlag;
    }

    public void SetWaterFeatureFlag(string waterFeatureFlag)
    {
      this.WaterFeatureFlag = waterFeatureFlag;
    }

    public void SetPondFlag(string pondFlag)
    {
      this.PondFlag = pondFlag;
    }

    public void SetBoatLiftFlag(string boatLiftFlag)
    {
      this.BoatLiftFlag = boatLiftFlag;
    }

    // Getters
    public string GetTopographyCode()
    {
      return string.IsNullOrEmpty(this.TopographyCode) ? "" : this.TopographyCode;
    }

    public string GetFenceCode()
    {
      return string.IsNullOrEmpty(this.FenceCode) ? "" : this.FenceCode;
    }

    public string GetFenceArea()
    {
      return string.IsNullOrEmpty(this.FenceArea) ? "" : this.FenceArea;
    }

    public string GetCourtyardFlag()
    {
      return string.IsNullOrEmpty(this.CourtyardFlag) ? "" : this.CourtyardFlag;
    }

    public string GetCourtyardArea()
    {
      return string.IsNullOrEmpty(this.CourtyardArea) ? "" : this.CourtyardArea;
    }

    public string GetArborPergolaFlag()
    {
      return string.IsNullOrEmpty(this.ArborPergolaFlag) ? "" : this.ArborPergolaFlag;
    }

    public string GetSprinklersFlag()
    {
      return string.IsNullOrEmpty(this.SprinklersFlag) ? "" : this.SprinklersFlag;
    }

    public string GetGolfCourseGreenFlag()
    {
      return string.IsNullOrEmpty(this.GolfCourseGreenFlag) ? "" : this.GolfCourseGreenFlag;
    }

    public string GetTennisCourtFlag()
    {
      return string.IsNullOrEmpty(this.TennisCourtFlag) ? "" : this.TennisCourtFlag;
    }

    public string GetSportsCourtFlag()
    {
      return string.IsNullOrEmpty(this.SportsCourtFlag) ? "" : this.SportsCourtFlag;
    }

    public string GetAreanFlag()
    {
      return string.IsNullOrEmpty(this.AreanFlag) ? "" : this.AreanFlag;
    }

    public string GetWaterFeatureFlag()
    {
      return string.IsNullOrEmpty(this.WaterFeatureFlag) ? "" : this.WaterFeatureFlag;
    }

    public string GetPondFlag()
    {
      return string.IsNullOrEmpty(this.PondFlag) ? "" : this.PondFlag;
    }

    public string GetBoatLiftFlag()
    {
      return string.IsNullOrEmpty(this.BoatLiftFlag) ? "" : this.BoatLiftFlag;
    }
  }

  public class PropertyEstimatedValue : ResponseBase
  { 
    public string EstimatedValue { get; set; }
    public string EstimatedMinValue { get; set; }
    public string EstimatedMaxValue { get; set; }
    public string ConfidenceScore { get; set; }
    public string ValuationDate { get; set; }

    // Setters
    public void SetEstimatedValue(string estimatedValue)
    {
      this.EstimatedValue = estimatedValue;
    }

    public void SetEstimatedMinValue(string estimatedMinValue)
    {
      this.EstimatedMinValue = estimatedMinValue;
    }

    public void SetEstimatedMaxValue(string estimatedMaxValue)
    {
      this.EstimatedMaxValue = estimatedMaxValue;
    }

    public void SetConfidenceScore(string confidenceScore)
    {
      this.ConfidenceScore = confidenceScore;
    }

    public void SetValuationDate(string valuationDate)
    {
      this.ValuationDate = valuationDate;
    }

    // Getters
    public string GetEstimatedValue()
    {
      return string.IsNullOrEmpty(this.EstimatedValue) ? "" : this.EstimatedValue;
    }

    public string GetEstimatedMinValue()
    {
      return string.IsNullOrEmpty(this.EstimatedMinValue) ? "" : this.EstimatedMinValue;
    }

    public string GetEstimatedMaxValue()
    {
      return string.IsNullOrEmpty(this.EstimatedMaxValue) ? "" : this.EstimatedMaxValue;
    }

    public string GetConfidenceScore()
    {
      return string.IsNullOrEmpty(this.ConfidenceScore) ? "" : this.ConfidenceScore;
    }

    public string GetValuationDate()
    {
      return string.IsNullOrEmpty(this.ValuationDate) ? "" : this.ValuationDate;
    }
  }

  public class PropertyShape : ResponseBase
  {
    public string WellKnownText { get; set; }

    // Setters
    public void SetWellKnownText(string wellKnownText)
    {
      this.WellKnownText = wellKnownText;
    }

    // Getters
    public string GetWellKnownText()
    {
      return string.IsNullOrEmpty(this.WellKnownText) ? "" : this.WellKnownText;
    }
  }

  /// <summary>
  /// This class handles the conversion between string or object 
  /// Applied to PropertyAddress as 2 unique endpoints return a PropertyAddress, but one returns as an object and one as a string
  /// </summary>
  public class PropertyAddressConverter : JsonConverter
  {
    public override bool CanConvert(Type objectType)
    {
      return objectType == typeof(PropertyAddress) || objectType == typeof(string);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
      JToken token = JToken.Load(reader);
      if (token.Type == JTokenType.Object)
      {
        return token.ToObject<PropertyAddress>();
      }
      if (token.Type == JTokenType.String)
      {
        return token.ToObject<string>();
      }
      return null;
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
      if (value is PropertyAddress)
      {
        serializer.Serialize(writer, value);
      }
      else
      {
        writer.WriteValue(value.ToString());
      }
    }
  }
}
