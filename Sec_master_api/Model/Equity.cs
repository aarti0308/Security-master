using System;
using System.Collections.Generic;

namespace Sec_master_api.Model
{
    public partial class Equity
    {
        public string? SecurityName { get; set; }
        public string? SecurityDescription { get; set; }
        public bool? HasPosition { get; set; }
        public bool? IsActiveSecurity { get; set; }
        public long? LotSize { get; set; }
        public string? BbgUniqueName { get; set; }
        public string? Cusip { get; set; }
        public string? Isin { get; set; }
        public string? Sedol { get; set; }
        public string? BloombergTicker { get; set; }
        public string? BloombergUniqueId { get; set; }
        public string? BbgGlobalId { get; set; }
        public string? TickerAndExchange { get; set; }
        public bool? IsAdrFlag { get; set; }
        public string? AdrUnderlyingTicker { get; set; }
        public string? AdrUnderlyingCurrency { get; set; }
        public string? SharesPerAdr { get; set; }
        public string? IpoDate { get; set; }
        public string? PricingCurrency { get; set; }
        public long? SettleDays { get; set; }
        public double? TotalSharesOutstanding { get; set; }
        public double? VotingRightsPerShare { get; set; }
        public double? AverageVolume20d { get; set; }
        public double? Beta { get; set; }
        public double? ShortInterest { get; set; }
        public double? ReturnYtd { get; set; }
        public double? Volatility90d { get; set; }
        public string? PfAssetClass { get; set; }
        public string? PfCountry { get; set; }
        public string? PfCreditRating { get; set; }
        public string? PfCurrency { get; set; }
        public string? PfInstrument { get; set; }
        public string? PfLiquidityProfile { get; set; }
        public string? PfMaturity { get; set; }
        public string? PfNaicsCode { get; set; }
        public string? PfRegion { get; set; }
        public string? PfSector { get; set; }
        public string? PfSubAssetClass { get; set; }
        public string? CountryOfIssuance { get; set; }
        public string? Exchange { get; set; }
        public string? Issuer { get; set; }
        public string? IssueCurrency { get; set; }
        public string? TradingCurrency { get; set; }
        public string? BbgIndustrySubGroup { get; set; }
        public string? BloombergIndustryGroup { get; set; }
        public string? BloombergSector { get; set; }
        public string? CountryOfIncorporation { get; set; }
        public string? RiskCurrency { get; set; }
        public double? OpenPrice { get; set; }
        public double? ClosePrice { get; set; }
        public double? Volume { get; set; }
        public double? LastPrice { get; set; }
        public double? AskPrice { get; set; }
        public double? BidPrice { get; set; }
        public double? PeRatio { get; set; }
        public DateTime? DividendDeclaredDate { get; set; }
        public DateTime? DividendExDate { get; set; }
        public DateTime? DividendRecordDate { get; set; }
        public DateTime? DividendPayDate { get; set; }
        public double? DividendAmount { get; set; }
        public string? Frequency { get; set; }
        public string? DividendType { get; set; }
        public int Sid { get; set; }
    }
}
