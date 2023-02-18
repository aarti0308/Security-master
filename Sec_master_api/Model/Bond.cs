using System;
using System.Collections.Generic;

namespace Sec_master_api.Model
{
    public partial class Bond
    {
        public string? SecurityDescription { get; set; }
        public string? SecurityName { get; set; }
        public string? AssetType { get; set; }
        public string? InvestmentType { get; set; }
        public double? TradingFactor { get; set; }
        public double? PricingFactor { get; set; }
        public string? Isin { get; set; }
        public string? BbgTicker { get; set; }
        public string? BbgUniqueId { get; set; }
        public string? Cusip { get; set; }
        public string? Sedol { get; set; }
        public DateTime? FirstCouponDate { get; set; }
        public string? Cap { get; set; }
        public string? Floor { get; set; }
        public long? CouponFrequency { get; set; }
        public double? Coupon { get; set; }
        public string? CouponType { get; set; }
        public string? Spread { get; set; }
        public bool? CallableFlag { get; set; }
        public bool? FixToFloatFlag { get; set; }
        public bool? PutableFlag { get; set; }
        public DateTime? IssueDate { get; set; }
        public string? LastResetDate { get; set; }
        public DateTime? Maturity { get; set; }
        public double? CallNotificationMaxDays { get; set; }
        public string? PutNotificationMaxDays { get; set; }
        public DateTime? PenultimateCouponDate { get; set; }
        public string? ResetFrequency { get; set; }
        public bool? HasPosition { get; set; }
        public double? MacaulayDuration { get; set; }
        public double? _30dVolatility { get; set; }
        public double? _90dVolatility { get; set; }
        public double? Convexity { get; set; }
        public double? _30dayAverageVolume { get; set; }
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
        public string? BloombergIndustryGroup { get; set; }
        public string? BloombergIndustrySubGroup { get; set; }
        public string? BloombergIndustrySector { get; set; }
        public string? CountryOfIssuance { get; set; }
        public string? IssueCurrency { get; set; }
        public string? Issuer { get; set; }
        public string? RiskCurrency { get; set; }
        public string? PutDate { get; set; }
        public string? PutPrice { get; set; }
        public double? AskPrice { get; set; }
        public double? HighPrice { get; set; }
        public double? LowPrice { get; set; }
        public double? OpenPrice { get; set; }
        public double? Volume { get; set; }
        public double? BidPrice { get; set; }
        public double? LastPrice { get; set; }
        public DateTime? CallDate { get; set; }
        public double? CallPrice { get; set; }
        public int Sid { get; set; }
    }
}
