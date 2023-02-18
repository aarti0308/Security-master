using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sec_master_api.Model
{
    public partial class SecMaster_AAContext : DbContext
    {
        public SecMaster_AAContext()
        {
        }

        public SecMaster_AAContext(DbContextOptions<SecMaster_AAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bond> Bonds { get; set; } = null!;
        public virtual DbSet<Equity> Equities { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                // optionsBuilder.UseSqlServer("Server = 192.168.0.13\\\\\\\\sqlexpress,58264; Database = SecMaster_AA; User = sa; Password=sa@12345678");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bond>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__bond__CA19597053896753");

                entity.ToTable("bond");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.AskPrice).HasColumnName("Ask Price");

                entity.Property(e => e.AssetType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Asset Type");

                entity.Property(e => e.BbgTicker)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BBG Ticker");

                entity.Property(e => e.BbgUniqueId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BBG Unique ID");

                entity.Property(e => e.BidPrice).HasColumnName("Bid Price");

                entity.Property(e => e.BloombergIndustryGroup)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg Industry Group");

                entity.Property(e => e.BloombergIndustrySector)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg Industry Sector");

                entity.Property(e => e.BloombergIndustrySubGroup)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg Industry Sub Group");

                entity.Property(e => e.CallDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Call Date");

                entity.Property(e => e.CallNotificationMaxDays).HasColumnName("Call Notification Max Days");

                entity.Property(e => e.CallPrice).HasColumnName("Call Price");

                entity.Property(e => e.CallableFlag).HasColumnName("Callable Flag");

                entity.Property(e => e.Cap)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CountryOfIssuance)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Country of Issuance");

                entity.Property(e => e.CouponFrequency).HasColumnName("Coupon Frequency");

                entity.Property(e => e.CouponType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Coupon Type");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.FirstCouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("First Coupon Date");

                entity.Property(e => e.FixToFloatFlag).HasColumnName("Fix to Float Flag");

                entity.Property(e => e.Floor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HasPosition).HasColumnName("Has Position");

                entity.Property(e => e.HighPrice).HasColumnName("High Price");

                entity.Property(e => e.InvestmentType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Investment Type");

                entity.Property(e => e.Isin)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.IssueCurrency)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Issue Currency");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Issue Date");

                entity.Property(e => e.Issuer)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrice).HasColumnName("Last Price");

                entity.Property(e => e.LastResetDate)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Last Reset Date");

                entity.Property(e => e.LowPrice).HasColumnName("Low Price");

                entity.Property(e => e.MacaulayDuration).HasColumnName("Macaulay Duration");

                entity.Property(e => e.Maturity).HasColumnType("datetime");

                entity.Property(e => e.OpenPrice).HasColumnName("Open Price");

                entity.Property(e => e.PenultimateCouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Penultimate Coupon Date");

                entity.Property(e => e.PfAssetClass)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Asset Class");

                entity.Property(e => e.PfCountry)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Country");

                entity.Property(e => e.PfCreditRating)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Credit Rating");

                entity.Property(e => e.PfCurrency)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Currency");

                entity.Property(e => e.PfInstrument)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Instrument");

                entity.Property(e => e.PfLiquidityProfile)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Liquidity Profile");

                entity.Property(e => e.PfMaturity)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Maturity");

                entity.Property(e => e.PfNaicsCode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF NAICS Code");

                entity.Property(e => e.PfRegion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Region");

                entity.Property(e => e.PfSector)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Sector");

                entity.Property(e => e.PfSubAssetClass)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Sub Asset Class");

                entity.Property(e => e.PricingFactor).HasColumnName("Pricing Factor");

                entity.Property(e => e.PutDate)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Put Date");

                entity.Property(e => e.PutNotificationMaxDays)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Put Notification Max Days");

                entity.Property(e => e.PutPrice)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Put Price");

                entity.Property(e => e.PutableFlag).HasColumnName("Putable Flag");

                entity.Property(e => e.ResetFrequency)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Reset Frequency");

                entity.Property(e => e.RiskCurrency)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Risk Currency");

                entity.Property(e => e.SecurityDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Security Description");

                entity.Property(e => e.SecurityName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Security Name");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.Spread)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TradingFactor).HasColumnName("Trading Factor");

                entity.Property(e => e._30dVolatility).HasColumnName("30D Volatility");

                entity.Property(e => e._30dayAverageVolume).HasColumnName("30Day Average Volume");

                entity.Property(e => e._90dVolatility).HasColumnName("90D Volatility");
            });

            modelBuilder.Entity<Equity>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Equity__CA1959701DF922FA");

                entity.ToTable("Equity");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.AdrUnderlyingCurrency)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADR Underlying Currency");

                entity.Property(e => e.AdrUnderlyingTicker)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADR Underlying Ticker");

                entity.Property(e => e.AskPrice).HasColumnName("Ask Price");

                entity.Property(e => e.AverageVolume20d).HasColumnName("Average Volume - 20D");

                entity.Property(e => e.BbgGlobalId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BBG Global ID");

                entity.Property(e => e.BbgIndustrySubGroup)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BBG Industry Sub Group");

                entity.Property(e => e.BbgUniqueName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BBG Unique Name");

                entity.Property(e => e.BidPrice).HasColumnName("Bid Price");

                entity.Property(e => e.BloombergIndustryGroup)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg Industry Group");

                entity.Property(e => e.BloombergSector)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg Sector");

                entity.Property(e => e.BloombergTicker)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg Ticker");

                entity.Property(e => e.BloombergUniqueId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg Unique ID");

                entity.Property(e => e.ClosePrice).HasColumnName("Close Price");

                entity.Property(e => e.CountryOfIncorporation)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Country of Incorporation");

                entity.Property(e => e.CountryOfIssuance)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Country of Issuance");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.DividendAmount).HasColumnName("Dividend Amount");

                entity.Property(e => e.DividendDeclaredDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Dividend Declared Date");

                entity.Property(e => e.DividendExDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Dividend Ex Date");

                entity.Property(e => e.DividendPayDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Dividend Pay Date");

                entity.Property(e => e.DividendRecordDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Dividend Record Date ");

                entity.Property(e => e.DividendType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Dividend Type");

                entity.Property(e => e.Exchange)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency).IsUnicode(false);

                entity.Property(e => e.HasPosition).HasColumnName("Has Position");

                entity.Property(e => e.IpoDate)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IPO Date");

                entity.Property(e => e.IsActiveSecurity).HasColumnName("Is Active Security");

                entity.Property(e => e.IsAdrFlag).HasColumnName("Is ADR Flag");

                entity.Property(e => e.Isin)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.IssueCurrency)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Issue Currency");

                entity.Property(e => e.Issuer)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrice).HasColumnName("Last Price");

                entity.Property(e => e.LotSize).HasColumnName("Lot Size");

                entity.Property(e => e.OpenPrice).HasColumnName("Open Price");

                entity.Property(e => e.PeRatio).HasColumnName("PE Ratio");

                entity.Property(e => e.PfAssetClass)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Asset Class");

                entity.Property(e => e.PfCountry)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Country");

                entity.Property(e => e.PfCreditRating)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Credit Rating");

                entity.Property(e => e.PfCurrency)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Currency");

                entity.Property(e => e.PfInstrument)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Instrument");

                entity.Property(e => e.PfLiquidityProfile)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Liquidity Profile");

                entity.Property(e => e.PfMaturity)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Maturity");

                entity.Property(e => e.PfNaicsCode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF NAICS Code");

                entity.Property(e => e.PfRegion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Region");

                entity.Property(e => e.PfSector)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Sector");

                entity.Property(e => e.PfSubAssetClass)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PF Sub Asset Class");

                entity.Property(e => e.PricingCurrency)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Pricing Currency");

                entity.Property(e => e.ReturnYtd).HasColumnName("Return - YTD");

                entity.Property(e => e.RiskCurrency)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Risk Currency");

                entity.Property(e => e.SecurityDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Security Description");

                entity.Property(e => e.SecurityName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Security Name");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.SettleDays).HasColumnName("Settle Days");

                entity.Property(e => e.SharesPerAdr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Shares Per ADR");

                entity.Property(e => e.ShortInterest).HasColumnName("Short Interest");

                entity.Property(e => e.TickerAndExchange)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Ticker and Exchange");

                entity.Property(e => e.TotalSharesOutstanding).HasColumnName("Total Shares Outstanding");

                entity.Property(e => e.TradingCurrency)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Trading Currency");

                entity.Property(e => e.Volatility90d).HasColumnName("Volatility - 90D");

                entity.Property(e => e.VotingRightsPerShare).HasColumnName("Voting Rights Per Share");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
