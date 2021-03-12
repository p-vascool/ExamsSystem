namespace ExamsSystem.Data.Models.Exams
{

    using System;
    using System.Collections.Generic;
    using System.Text;

    using ExamsSystem.Data.Common.Models;

    public class ExamCategory : IDeletableEntity
    {
        public ExamCategory()
        {
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public virtual ApplicationUser User { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get ; set ; }
    }
}
