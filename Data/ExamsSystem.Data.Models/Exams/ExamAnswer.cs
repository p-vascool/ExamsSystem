namespace ExamsSystem.Data.Models.Exams
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ExamAnswer
    {
        public ExamAnswer()
        {
        }

        public int Id { get; set; }

        public int AnswerNo { get; set; }

        public string Answer { get; set; }

        public int Point { get; set; }

        public bool IsAnswered { get; set; }

        public AnswerStatus AnswerStatus { get; set; }

        public virtual ExamQuestion Question { get; set; }
    }
}
