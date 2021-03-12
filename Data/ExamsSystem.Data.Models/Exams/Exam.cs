namespace ExamsSystem.Data.Models.Exams
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using ExamsSystem.Data.Common.Models;

    public class Exam : IDeletableEntity
    {
        public Exam()
        {
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ExamCategory Category { get; set; }

        public virtual ICollection<ApplicationUser> Participants { get; set; }

        //public virtual ExamResult ExamResult { get; set; }

        public DateTime ExamTimer { get; set; }

        public ICollection<ExamQuestion> Questions { get; set; }

        public bool HasNegativePoint { get; set; }

        public virtual ApplicationUser User { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public void EstimateResult()
        {

        }

        public bool CreateExam()
        {
            bool isSucces = false;

            return isSucces;
        }
    }
}
