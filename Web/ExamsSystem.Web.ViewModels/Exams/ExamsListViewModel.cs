namespace ExamsSystem.Web.ViewModels.Exams
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ExamsListViewModel
    {
        public ExamCreateViewModel NewExam { get; set; }

        public IEnumerable<ExamViewModel> Exams { get; set; }
    }
}
