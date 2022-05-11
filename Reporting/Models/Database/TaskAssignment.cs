namespace Reporting.Models.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskAssignment")]
    public partial class TaskAssignment
    {
        public int id { get; set; }

        public int task_id { get; set; }

        public int employee_id { get; set; }

        public int task_type { get; set; }

        [Required]
        public string message { get; set; }

        public int sentiment { get; set; }

        public bool is_completed { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Task Task { get; set; }
    }
}
