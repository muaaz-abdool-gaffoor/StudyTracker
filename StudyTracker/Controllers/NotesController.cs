using Microsoft.AspNetCore.Mvc;
using StudyTracker.Models;

namespace StudyTracker.Controllers
{
    public class NotesController : Controller
    {
      
       private readonly SubjectManager _subjectManager;
        public NotesController(SubjectManager subjectmanager) { 
        
        _subjectManager = subjectmanager;
        
        
        
        }

        public IActionResult Edit(int subjectID)
        {
          var subject =  _subjectManager.ReturnList()[subjectID];
            ViewData["Notes"] = subject.Notes;
            ViewData["SubjectID"] = subject.Id;
            return View();
        }


        [HttpPost]
        //in this post method, we are not recieving any actual object type, so we will recieve the notes and subjecti as individual values
        public IActionResult Edit(string Notes, int SubjectID)
        {
            var subject = _subjectManager.ReturnList()[SubjectID];
            subject.Notes = Notes;

            return RedirectToAction("Index", "Subject");
        }

    }
}
