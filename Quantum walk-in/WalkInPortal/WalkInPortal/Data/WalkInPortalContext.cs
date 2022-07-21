using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WalkInPortal.Models;

namespace WalkInPortal.Data
{
    public partial class WalkInPortalContext : DbContext
    {
        public WalkInPortalContext()
        {
        }

        public WalkInPortalContext(DbContextOptions<WalkInPortalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<College> Colleges { get; set; } = null!;
        public virtual DbSet<Educationalqualification> Educationalqualifications { get; set; } = null!;
        public virtual DbSet<Expertisetech> Expertiseteches { get; set; } = null!;
        public virtual DbSet<Familiartech> Familiarteches { get; set; } = null!;
        public virtual DbSet<Jobrole> Jobroles { get; set; } = null!;
        public virtual DbSet<Postapplicationguideline> Postapplicationguidelines { get; set; } = null!;
        public virtual DbSet<Prerequisite> Prerequisites { get; set; } = null!;
        public virtual DbSet<Professionalqualification> Professionalqualifications { get; set; } = null!;
        public virtual DbSet<Qualification> Qualifications { get; set; } = null!;
        public virtual DbSet<Qualificationstream> Qualificationstreams { get; set; } = null!;
        public virtual DbSet<Timeslot> Timeslots { get; set; } = null!;
        public virtual DbSet<Userdetail> Userdetails { get; set; } = null!;
        public virtual DbSet<Userwalkinapplication> Userwalkinapplications { get; set; } = null!;
        public virtual DbSet<Walkin> Walkins { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<College>(entity =>
            {
                entity.ToTable("college");

                entity.HasIndex(e => e.QualificationStreamId, "fk_College_QualificationStream1_idx");

                entity.Property(e => e.CollegeName).HasMaxLength(45);

                entity.HasOne(d => d.QualificationStream)
                    .WithMany(p => p.Colleges)
                    .HasForeignKey(d => d.QualificationStreamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_College_QualificationStream1");
            });

            modelBuilder.Entity<Educationalqualification>(entity =>
            {
                entity.HasKey(e => new { e.EducatiionalQualificationsId, e.UserDetailId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("educationalqualification");

                entity.HasIndex(e => e.CollegeId, "fk_EducatiionalQualifications_College1_idx");

                entity.HasIndex(e => e.QualificationId, "fk_EducatiionalQualifications_Qualification1_idx");

                entity.HasIndex(e => e.QualificationStreamId, "fk_EducatiionalQualifications_QualificationStream1_idx");

                entity.HasIndex(e => e.UserDetailId, "fk_EducatiionalQualifications_UserDetail1_idx");

                entity.Property(e => e.EducatiionalQualificationsId).ValueGeneratedOnAdd();

                entity.Property(e => e.CollegeLocation).HasMaxLength(45);

                entity.Property(e => e.UnknownCollegeName).HasMaxLength(255);

                entity.HasOne(d => d.College)
                    .WithMany(p => p.Educationalqualifications)
                    .HasForeignKey(d => d.CollegeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_EducatiionalQualifications_College1");

                entity.HasOne(d => d.Qualification)
                    .WithMany(p => p.Educationalqualifications)
                    .HasForeignKey(d => d.QualificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_EducatiionalQualifications_Qualification1");

                entity.HasOne(d => d.QualificationStream)
                    .WithMany(p => p.Educationalqualifications)
                    .HasForeignKey(d => d.QualificationStreamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_EducatiionalQualifications_QualificationStream1");

                entity.HasOne(d => d.UserDetail)
                    .WithMany(p => p.Educationalqualifications)
                    .HasForeignKey(d => d.UserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_EducatiionalQualifications_UserDetail1");
            });

            modelBuilder.Entity<Expertisetech>(entity =>
            {
                entity.HasKey(e => new { e.ExpertiseTechId, e.ProfessionalQualificationId, e.UserDetailId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("expertisetech");

                entity.HasIndex(e => new { e.ProfessionalQualificationId, e.UserDetailId }, "fk_ExpertiseTech_ProfessionalQualification1_idx");

                entity.Property(e => e.ExpertiseTechId).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(45);

                entity.HasOne(d => d.Professionalqualification)
                    .WithMany(p => p.Expertiseteches)
                    .HasForeignKey(d => new { d.ProfessionalQualificationId, d.UserDetailId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ExpertiseTech_ProfessionalQualification1");
            });

            modelBuilder.Entity<Familiartech>(entity =>
            {
                entity.HasKey(e => new { e.FamiliarTechId, e.ProfessionalQualificationId, e.UserDetailId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("familiartech");

                entity.HasIndex(e => new { e.ProfessionalQualificationId, e.UserDetailId }, "fk_FamiliarTech_ProfessionalQualification1_idx");

                entity.Property(e => e.FamiliarTechId).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(45);

                entity.HasOne(d => d.Professionalqualification)
                    .WithMany(p => p.Familiarteches)
                    .HasForeignKey(d => new { d.ProfessionalQualificationId, d.UserDetailId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_FamiliarTech_ProfessionalQualification1");
            });

            modelBuilder.Entity<Jobrole>(entity =>
            {
                entity.ToTable("jobrole");

                entity.Property(e => e.JobDetails).HasColumnType("json");

                entity.Property(e => e.Title).HasMaxLength(45);

                entity.HasMany(d => d.Userwalkinapplications)
                    .WithMany(p => p.JobRoles)
                    .UsingEntity<Dictionary<string, object>>(
                        "Jobroleuserwalkinapplicationmap",
                        l => l.HasOne<Userwalkinapplication>().WithMany().HasForeignKey("UserDetailId", "WalkInId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_JobRole_has_UserWalkInApplication_UserWalkInApplication1"),
                        r => r.HasOne<Jobrole>().WithMany().HasForeignKey("JobRoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_JobRole_has_UserWalkInApplication_JobRole1"),
                        j =>
                        {
                            j.HasKey("JobRoleId", "UserDetailId", "WalkInId").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                            j.ToTable("jobroleuserwalkinapplicationmap");

                            j.HasIndex(new[] { "JobRoleId" }, "fk_JobRole_has_UserWalkInApplication_JobRole1_idx");

                            j.HasIndex(new[] { "UserDetailId", "WalkInId" }, "fk_JobRole_has_UserWalkInApplication_UserWalkInApplication1_idx");
                        });

                entity.HasMany(d => d.WalkIns)
                    .WithMany(p => p.JobRoles)
                    .UsingEntity<Dictionary<string, object>>(
                        "Jobrolewalkinmap",
                        l => l.HasOne<Walkin>().WithMany().HasForeignKey("WalkInId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_JobRole_has_WalkIn_WalkIn1"),
                        r => r.HasOne<Jobrole>().WithMany().HasForeignKey("JobRoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_JobRole_has_WalkIn_JobRole1"),
                        j =>
                        {
                            j.HasKey("JobRoleId", "WalkInId").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("jobrolewalkinmap");

                            j.HasIndex(new[] { "JobRoleId" }, "fk_JobRole_has_WalkIn_JobRole1_idx");

                            j.HasIndex(new[] { "WalkInId" }, "fk_JobRole_has_WalkIn_WalkIn1_idx");
                        });
            });

            modelBuilder.Entity<Postapplicationguideline>(entity =>
            {
                entity.HasKey(e => e.PostApplicationGuidelinesId)
                    .HasName("PRIMARY");

                entity.ToTable("postapplicationguidelines");

                entity.HasIndex(e => new { e.UserDetailId, e.WalkInId }, "fk_PostApplicationGuidelines_UserWalkInApplication1_idx");

                entity.Property(e => e.Fields).HasColumnType("json");

                entity.HasOne(d => d.Userwalkinapplication)
                    .WithMany(p => p.Postapplicationguidelines)
                    .HasForeignKey(d => new { d.UserDetailId, d.WalkInId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PostApplicationGuidelines_UserWalkInApplication1");
            });

            modelBuilder.Entity<Prerequisite>(entity =>
            {
                entity.ToTable("prerequisite");

                entity.HasIndex(e => e.WalkInId, "fk_PreRequisite_WalkIn1_idx");

                entity.Property(e => e.Fields).HasColumnType("json");

                entity.HasOne(d => d.WalkIn)
                    .WithMany(p => p.Prerequisites)
                    .HasForeignKey(d => d.WalkInId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PreRequisite_WalkIn1");
            });

            modelBuilder.Entity<Professionalqualification>(entity =>
            {
                entity.HasKey(e => new { e.ProfessionalQualificationId, e.UserDetailId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("professionalqualification");

                entity.HasIndex(e => e.UserDetailId, "fk_ProfessionalQualification_UserDetail1_idx");

                entity.Property(e => e.ProfessionalQualificationId).ValueGeneratedOnAdd();

                entity.Property(e => e.Ctc).HasColumnName("CTC");

                entity.Property(e => e.ExpectedCtc).HasColumnName("ExpectedCTC");

                entity.Property(e => e.RoleApplied).HasMaxLength(100);

                entity.HasOne(d => d.UserDetail)
                    .WithMany(p => p.Professionalqualifications)
                    .HasForeignKey(d => d.UserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProfessionalQualification_UserDetail1");
            });

            modelBuilder.Entity<Qualification>(entity =>
            {
                entity.ToTable("qualification");

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<Qualificationstream>(entity =>
            {
                entity.ToTable("qualificationstream");

                entity.HasIndex(e => e.QualificationId, "fk_QualificationStream_Qualification1_idx");

                entity.Property(e => e.QualificationStreamName).HasMaxLength(45);

                entity.HasOne(d => d.Qualification)
                    .WithMany(p => p.Qualificationstreams)
                    .HasForeignKey(d => d.QualificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_QualificationStream_Qualification1");
            });

            modelBuilder.Entity<Timeslot>(entity =>
            {
                entity.ToTable("timeslot");

                entity.HasMany(d => d.Userwalkinapplications)
                    .WithMany(p => p.TimeSlots)
                    .UsingEntity<Dictionary<string, object>>(
                        "Userwalkinapplicationtimeslotmap",
                        l => l.HasOne<Userwalkinapplication>().WithMany().HasForeignKey("UserDetailId", "WalkInId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_TimeSlot_has_UserWalkInApplication_UserWalkInApplication1"),
                        r => r.HasOne<Timeslot>().WithMany().HasForeignKey("TimeSlotId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_TimeSlot_has_UserWalkInApplication_TimeSlot1"),
                        j =>
                        {
                            j.HasKey("TimeSlotId", "UserDetailId", "WalkInId").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                            j.ToTable("userwalkinapplicationtimeslotmap");

                            j.HasIndex(new[] { "TimeSlotId" }, "fk_TimeSlot_has_UserWalkInApplication_TimeSlot1_idx");

                            j.HasIndex(new[] { "UserDetailId", "WalkInId" }, "fk_TimeSlot_has_UserWalkInApplication_UserWalkInApplication_idx");
                        });
            });

            modelBuilder.Entity<Userdetail>(entity =>
            {
                entity.ToTable("userdetail");

                entity.Property(e => e.Email).HasMaxLength(45);

                entity.Property(e => e.FirstName).HasMaxLength(45);

                entity.Property(e => e.LastName).HasMaxLength(45);

                entity.Property(e => e.Password).HasMaxLength(30);

                entity.Property(e => e.PhoneNo).HasMaxLength(20);

                entity.Property(e => e.PortfolioUrl).HasMaxLength(255);

                entity.Property(e => e.ReferredBy).HasMaxLength(255);

                entity.Property(e => e.ResumeUrl).HasMaxLength(255);

                entity.HasMany(d => d.JobRoles)
                    .WithMany(p => p.UserDetails)
                    .UsingEntity<Dictionary<string, object>>(
                        "Userdetailjobrolemap",
                        l => l.HasOne<Jobrole>().WithMany().HasForeignKey("JobRoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_UserDetail_has_JobRole_JobRole1"),
                        r => r.HasOne<Userdetail>().WithMany().HasForeignKey("UserDetailId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_UserDetail_has_JobRole_UserDetail1"),
                        j =>
                        {
                            j.HasKey("UserDetailId", "JobRoleId").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("userdetailjobrolemap");

                            j.HasIndex(new[] { "JobRoleId" }, "fk_UserDetail_has_JobRole_JobRole1_idx");

                            j.HasIndex(new[] { "UserDetailId" }, "fk_UserDetail_has_JobRole_UserDetail1_idx");
                        });
            });

            modelBuilder.Entity<Userwalkinapplication>(entity =>
            {
                entity.HasKey(e => new { e.UserDetailId, e.WalkInId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("userwalkinapplication");

                entity.HasIndex(e => e.UserDetailId, "fk_UserDetail_has_WalkIn_UserDetail1_idx");

                entity.HasIndex(e => e.WalkInId, "fk_UserDetail_has_WalkIn_WalkIn1_idx");

                entity.HasOne(d => d.UserDetail)
                    .WithMany(p => p.Userwalkinapplications)
                    .HasForeignKey(d => d.UserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_UserDetail_has_WalkIn_UserDetail1");

                entity.HasOne(d => d.WalkIn)
                    .WithMany(p => p.Userwalkinapplications)
                    .HasForeignKey(d => d.WalkInId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_UserDetail_has_WalkIn_WalkIn1");
            });

            modelBuilder.Entity<Walkin>(entity =>
            {
                entity.ToTable("walkin");

                entity.Property(e => e.InternshipInfo).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasMany(d => d.TimeSlots)
                    .WithMany(p => p.WalkIns)
                    .UsingEntity<Dictionary<string, object>>(
                        "Walkintimeslotmap",
                        l => l.HasOne<Timeslot>().WithMany().HasForeignKey("TimeSlotId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_WalkIn_has_TimeSlot_TimeSlot1"),
                        r => r.HasOne<Walkin>().WithMany().HasForeignKey("WalkInId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_WalkIn_has_TimeSlot_WalkIn1"),
                        j =>
                        {
                            j.HasKey("WalkInId", "TimeSlotId").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("walkintimeslotmap");

                            j.HasIndex(new[] { "TimeSlotId" }, "fk_WalkIn_has_TimeSlot_TimeSlot1_idx");

                            j.HasIndex(new[] { "WalkInId" }, "fk_WalkIn_has_TimeSlot_WalkIn1_idx");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
