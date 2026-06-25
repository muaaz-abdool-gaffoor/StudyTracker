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
        
  
        public IActionResult Create(int subjectID)
        {

            ViewData["SubjectId"] = subjectID;
            return View();
        
        }


        [HttpPost]
        public IActionResult Create(StudyTask task, int subjectID, bool IsComplete)
        {
           var subject = _subjectManager.ReturnList()[subjectID];

            task.IsComplete = Request.Form["IsComplete"].Contains("true");
            subject.AddTask(task);
            return RedirectToAction("Index", "Subject");


        }

        public IActionResult Index (int SubjectID)
        {
            var subject = _subjectManager.ReturnList()[SubjectID];
            return View(subject.TaskList);

        }
    }
}
