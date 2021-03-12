namespace ExamsSystem.Services.Data.Exams
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using ExamsSystem.Data.Models.Exams;

    public interface IExamsService
    {
        bool CreateNewExam(Exam exam);

        IEnumerable<T> GetAll<T>();
    }
}
