using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CMS.Models
{
    public partial class ContractDbContext : DbContext
    {
        public ContractDbContext()
        {
        }

        public ContractDbContext(DbContextOptions<ContractDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContractAmendmentRequest> ContractAmendmentRequest { get; set; }
        public virtual DbSet<ContractAmendmentRequestARDetails> ContractAmendmentRequestARDetails { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                // optionsBuilder.UseSqlServer("Server=IDC20Intern375\\SQLEXPRESS;Database=ContractDetails;Trusted_Connection=True;");
                optionsBuilder.UseSqlServer("Server=IDC20Intern375,1433;Initial Catalog=ContractDetails;User Id=nivedita4299;Password =Anandita.28;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContractAmendmentRequest>(entity =>
            {
                entity.Property(e => e.CustomerNumber).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.LastModifiedBy).IsUnicode(false);

                entity.Property(e => e.SAPResponseDetails).IsUnicode(false);
            });

            modelBuilder.Entity<ContractAmendmentRequestARDetails>(entity =>
            {
                entity.HasKey(e => new { e.ContractAmendmentRequestId, e.LicensableID });

                entity.Property(e => e.LicensableID).IsUnicode(false);

                entity.Property(e => e.CoaendItemPartNumber).IsUnicode(false);

                entity.Property(e => e.ContractNumber).IsUnicode(false);

                entity.Property(e => e.LanguageCode).IsUnicode(false);

                entity.Property(e => e.LanguageName).IsUnicode(false);

                entity.Property(e => e.ProductGrouping).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);

                entity.HasOne(d => d.ContractAmendmentRequest)
                    .WithMany(p => p.ContractAmendmentRequestARDetails)
                    .HasForeignKey(d => d.ContractAmendmentRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractAddRemoveRequestDetails_ContractAmendmentRequest");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.Entity_ID)
                    .HasName("PKUserInfo");

                entity.Property(e => e.Entity_ID).ValueGeneratedNever();

                entity.Property(e => e.CountryCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SkipPassport)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.skipdc)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelCountryCode).IsUnicode(false);

                entity.Property(e => e.TelExt).IsUnicode(false);

                entity.Property(e => e.TelNumber).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
