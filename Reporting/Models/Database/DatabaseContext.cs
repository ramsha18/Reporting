namespace Reporting.Models.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DbContext")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TaskAssignment> TaskAssignments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.contact_no)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.email_id)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.system_id)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Project)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Projects)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.customer_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.contact_no)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.email_id)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.system_id)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.TaskAssignments)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.employee_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.Project)
                .HasForeignKey(e => e.project_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.TaskAssignments)
                .WithRequired(e => e.Task)
                .HasForeignKey(e => e.task_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaskAssignment>()
                .Property(e => e.message)
                .IsUnicode(false);
        }
    }
}
