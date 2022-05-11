namespace Reporting.Models.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Projects = new HashSet<Project>();
        }

        public int id { get; set; }

        [Required]
        public string name { get; set; }

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

        [StringLength(255)]
        public string Project { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project> Projects { get; set; }
    }
}
