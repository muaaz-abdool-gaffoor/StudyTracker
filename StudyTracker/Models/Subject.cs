namespace StudyTracker.Models
{
    public class Subject
    {

        public string Name { get; set; }

       public string Lecturer { get; set; }

       public double CurrentMark { get; set; }


            //create a list that stores object type Task
       List<Task> TaskList = new List<Task>();

        public void AddTask(Task task)
        { 
            TaskList.Add(task);
        
        }


    }
}
