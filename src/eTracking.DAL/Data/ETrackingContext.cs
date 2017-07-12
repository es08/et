using Microsoft.EntityFrameworkCore;
using eTracking.Model;
using eTracking.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;

namespace eTracking.DAL
{
    public class ETrackingContext //: DbContext
        : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ETrackingContext(DbContextOptions<ETrackingContext> options) : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectStatus> ProjectStatus { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<BorrowingType> BorrowingTypes { get; set; }
        public DbSet<WorkFlow> WorkFlows { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Project_Staff> Project_Staffs { get; set; }
        public DbSet<Activity_WorkFlow> Activity_WorkFlows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().ToTable("ApplicationUser");
            modelBuilder.Entity<ApplicationRole>().ToTable("ApplicationRole");

            modelBuilder.Entity<Major>().ToTable("Major");
            modelBuilder.Entity<Position>().ToTable("Position");

            //modelBuilder.Entity<Project>().ToTable("Project").Property(x => x.CoordinatorID).HasColumnName("CoordinatorID");
            //modelBuilder.Entity<Project>().Property(x => x.CreatorID).HasColumnName("CreatorID");

            modelBuilder.Entity<Project>(c =>
            {
                c.ToTable("Project");
                //.Property(x => x.CoordinatorID).HasColumnName("CoordinatorID");
                //c.Property(x => x.CreatorID).HasColumnName("CreatorID");
                //c.Property(x => x.StatusID).HasColumnName("StatusID");
            });

            modelBuilder.Entity<Activity>(c =>
            {
                c.ToTable("Activity");
                //c.Property(x => x.CreatorID).HasColumnName("CreatorID");
                //c.Property(x => x.ActivatorID).HasColumnName("ActivatorID");
              //  c.HasOne(x => x.Project).WithMany(p => p.Activities).HasForeignKey(a => a.ProjectID)
                //.OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);
                c.HasOne(x => x.Creator).WithMany(p => p.Creators).HasForeignKey(a => a.CreatorID)
                .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);
                c.HasOne(x => x.Activator).WithMany(p => p.Activators).HasForeignKey(a => a.ActivatorID)
                .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);
            });

            //modelBuilder.Entity<Project_Status>()
            //    .HasKey(bc => new { bc.ProjectId, bc.ProjectStatusId });

            //modelBuilder.Entity<Project_Status>()
            //    .HasOne(ps => ps.Project)
            //    .WithMany(p => p.Project_Status)
            //    .HasForeignKey(ps => ps.ProjectId);

            //modelBuilder.Entity<Project_Status>()
            //    .HasOne(ps => ps.ProjectStatus)
            //    .WithMany(p => p.Project_Status)
            //    .HasForeignKey(ps => ps.ProjectStatusId);


            //modelBuilder.Entity<Project_Staff>()
            //  .HasKey(bc => new { bc.ProjectId, bc.StaffId });

            //modelBuilder.Entity<Project_Staff>()
            //    .HasOne(ps => ps.Project)
            //    .WithMany(p => p.Project_Staff)
            //    .HasForeignKey(ps => ps.ProjectId);

            //modelBuilder.Entity<Project_Staff>()
            //    .HasOne(ps => ps.Project)
            //    .WithMany(p => p.Project_Staff)
            //    .HasForeignKey(ps => ps.StaffId);

            modelBuilder.Entity<Project_Staff>(c =>
            {
                c.ToTable("Project_Staff").HasKey(bc => new { bc.ProjectID, bc.StaffID });
                c.HasOne(ps => ps.Project).WithMany(p => p.ProjectStaffs).HasForeignKey(ps => ps.ProjectID)
                .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);
                //c.HasOne(ps => ps.Project).WithMany(p => p.ProjectStaffs).HasForeignKey(ps => ps.StaffID);

            });

            modelBuilder.Entity<Activity_WorkFlow>(c =>
            {
                c.ToTable("Activity_WorkFlow").HasKey(bc => new { bc.ActivityID, bc.WorkFlowID });
                //c.HasOne(ps => ps.WorkFlow).WithMany(p => p.WorkFlows).HasForeignKey(ps => ps.ActivityID);
                c.HasOne(ps => ps.Activity).WithMany(p => p.WorkFlows).HasForeignKey(ps => ps.ActivityID)
                .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);
            });

            //modelBuilder.Entity<Project_Staff>().ToTable("ProjectStaff");
            modelBuilder.Entity<Staff>().ToTable("Staff");
            modelBuilder.Entity<BorrowingType>().ToTable("BorrowingType");
            modelBuilder.Entity<WorkFlow>().ToTable("WorkFlow");
        }
    }
}
