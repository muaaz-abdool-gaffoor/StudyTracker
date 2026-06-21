using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using StudyTracker.Models;

namespace StudyTracker.Controllers
{
    public class TaskController : Controller
    {

        private readonly SubjectManager _subjectManager;

        public TaskController(SubjectManager SubjectManager)
        {
            _subjectManager = SubjectManager;
        
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(int subjectID)
        {

            ViewData["SubjectId"] = subjectID;
            return View();
        
        }


        [HttpPost]
        public IActionResult Create(StudyTask task, int subjectID)
        {
           var subject = _subjectManager.ReturnList()[subjectID];
           subject.AddTask(task);
            return RedirectToAction("Index", "Subject");


        }
    }
}
