namespace ExamsSystem.Data.Models.Exams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ExamQuestion
    {

        public ExamQuestion()
        {
            this.Answers = new List<ExamAnswer>();
        }

        public int Id { get; set; }

        public string Question { get; set; }

        public List<ExamAnswer> Answers { get; set; }

        public virtual Exam Exam { get; set; }

        public int EstimatedPoints { get => this.AnswerPoints(); }

        public int QuestionPossiblePoints
        {
            get => this.Answers
                       .Where(x => x.AnswerStatus == AnswerStatus.Correct)
                        .Sum(x => x.Point);
        }

        internal int AnswerPoints()
        {

            int points = this.Answers
                        .Where(x => x.IsAnswered && x.AnswerStatus == AnswerStatus.Correct)
                        .Sum(x => x.Point);

            return points;
        }

    }
}
