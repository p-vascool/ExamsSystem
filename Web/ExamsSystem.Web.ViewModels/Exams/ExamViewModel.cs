namespace ExamsSystem.Web.ViewModels.Exams
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AutoMapper;
    using ExamsSystem.Data.Models.Exams;
    using ExamsSystem.Services.Mapping;

    public class ExamViewModel: IMapFrom<Exam>
    {
        public ExamViewModel()
        {
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ExamCategory Category { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ExamTimer { get; set; }

        public ICollection<ExamQuestion> Questions { get; set; }

        public bool HasNegativePoint { get; set; }
    }
}
