namespace ExamsSystem.Web.ViewModels.Exams
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using ExamsSystem.Data.Models.Exams;

    public class ExamCreateViewModel
    {
        public ExamCreateViewModel()
        {
        }

        public Exam Exam { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ExamQuestion CurrentQuestion { get; set; }

        public ExamAnswer CurrentAnswer { get; set; }

        public List<ExamQuestion> AllQuestions { get; set; }

        public DateTime ExamTimer { get; set; }

        public void InitQuestions()
        {
            if (this.AllQuestions == null)
            {
                this.AllQuestions = new List<ExamQuestion>();
            }

            if (this.CurrentAnswer == null)
            {
                this.CurrentAnswer = new ExamAnswer();
            }

            if (this.CurrentQuestion == null)
            {
                this.CurrentQuestion = new ExamQuestion();
            }
        }
    }
}
