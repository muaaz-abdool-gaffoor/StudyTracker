using Microsoft.AspNetCore.Mvc;
using StudyTracker.Models;

namespace StudyTracker.Controllers
{
    public class SubjectController: Controller
    {
        
        private readonly SubjectManager _subjectManager;
        public SubjectController(SubjectManager subjectmanager)
        {

            _subjectManager = subjectmanager;

        }



        //This is our GET method, its job is just to show the form
        public IActionResult Create()
        {
            return View();
        }


        //This is our POST method, its job is to take the data from the form and do something with it
        [HttpPost] //this tells the program that this method is a POST method, and that form data should come here

        public IActionResult Create (Subject subject)
        {
            _subjectManager.AddSubject(subject);
            return RedirectToAction("index");

        }

        public IActionResult Index()
        {
            var subjects = _subjectManager.ReturnList();
            return View(subjects);
        
        }


    }
}
