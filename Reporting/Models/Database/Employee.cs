namespace Reporting.Models.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            TaskAssignments = new HashSet<TaskAssignment>();
        }

        public int id { get; set; }

        [Required]
        public string name { get; set; }

        public int position { get; set; }

        public int salary { get; set; }

        public int previous_expirence_in_months { get; set; }

        [StringLength(50)]
        public string contact_no { get; set; }

        [Required]
        [StringLength(50)]
        public string email_id { get; set; }

        [Required]
        [StringLength(50)]
        public string system_id { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskAssignment> TaskAssignments { get; set; }
    }
}
