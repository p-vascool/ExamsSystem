namespace ExamsSystem.Data.Models.Exams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ExamResult
    {
        public ExamResult()
        {
        }

        public virtual Exam Exam { get; set; }
        
        public int ExamId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int UserId { get; set; }

        public int Points { get => this.GetEstimatedPoints(); }

        public int MaxPoint { get => this.GetMaxPoints(); }

        public decimal Percent { get => this.GetPercentResult(); }

        public DateTime EstimatedTime { get; set; }

        public DateTime When { get; set; }

        public int GetEstimatedPoints()
        {
            int points = this.Exam
                             .Questions
                             .Sum(x => x.EstimatedPoints);
            return points;
        }

        public int GetMaxPoints()
        {
            int points = 0;
            points = this.Exam
                         .Questions
                         .Sum(x => x.QuestionPossiblePoints);

            return points;
        }

        public decimal GetPercentResult()
        {
            decimal percent = 0m;
            percent = (this.Points / this.MaxPoint) * 100;

            return percent;
        }
    }
}
