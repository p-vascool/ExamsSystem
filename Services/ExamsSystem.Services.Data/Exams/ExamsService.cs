namespace ExamsSystem.Services.Data.Exams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using ExamsSystem.Data.Common.Repositories;
    using ExamsSystem.Data.Models.Exams;
    using ExamsSystem.Services.Mapping;

    public class ExamsService : IExamsService
    {
        private readonly IDeletableEntityRepository<Exam> examRepository;

        public ExamsService(IDeletableEntityRepository<Exam> examRepository)
        {
            this.examRepository = examRepository;
        }

        public bool CreateNewExam(Exam exam)
        {
            return exam.CreateExam();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.examRepository.All().To<T>().ToList();
        }
    }
}
