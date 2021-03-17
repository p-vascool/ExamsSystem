namespace ExamsSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ExamsSystem.Data.Common.Repositories;
    using ExamsSystem.Data.Models.Exams;
    using ExamsSystem.Services.Data.Exams;
    using ExamsSystem.Web.ViewModels.Exams;
    using Microsoft.AspNetCore.Mvc;

    public class ExamsController : BaseController
    {
        private readonly IExamsService examsService;

        private readonly IDeletableEntityRepository<Exam> repository;

        public ExamsController(IExamsService examsService, IDeletableEntityRepository<Exam> repository)
        {
            this.repository = repository;
            this.examsService = examsService;
        }

        public IActionResult All()
        {
            var allExams = this.examsService.GetAll<ExamViewModel>();
            var model = new ExamsListViewModel { Exams = allExams };
            return this.View(model);
        }

        public async Task<IActionResult> Create(ExamCreateViewModel model)
        {
            var exam = new Exam() { Name = model.Name, Description = model.Description, CreatedOn = DateTime.UtcNow };

            await this.repository.AddAsync(exam);
            await this.repository.SaveChangesAsync();
            return this.RedirectToAction("InsertExam", model);
        }

        public IActionResult CreateAnswer(ExamCreateViewModel model)
        {
            model.InitQuestions();
            this.examsService.AssignAnswer(model.CurrentQuestion, model.CurrentAnswer);
            this.examsService.AssignQuestion(model.Exam, model.CurrentQuestion);
            model.AllQuestions.Add(model.CurrentQuestion);

            return this.View("InsertExam", model);
        }

        public IActionResult InsertExam(ExamCreateViewModel model)
        {
            if (model.Exam == null)
            {
                model = new ExamCreateViewModel();
                model.InitQuestions();
            }

            return this.View(model);
        }
    }
}
