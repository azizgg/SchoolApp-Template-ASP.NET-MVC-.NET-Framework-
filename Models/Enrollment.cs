namespace SchoolApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Enrollment")]
    public partial class Enrollment
    {
        public int EnrollmentID { get; set; }

        public int UserID { get; set; }

        public int CourseID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EnrollDate { get; set; }

        public int? Score { get; set; }

        public bool? Isdeleted { get; set; }

        public virtual Course Course { get; set; }

        public virtual User User { get; set; }
    }
}
