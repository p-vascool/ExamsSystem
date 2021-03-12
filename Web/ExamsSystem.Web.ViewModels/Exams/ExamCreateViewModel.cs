namespace ExamsSystem.Web.ViewModels.Exams
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using ExamsSystem.Data.Models.Exams;

    public class ExamCreateViewModel
    {
        public Exam Exam { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime ExamTimer { get; set; }
    }
}
