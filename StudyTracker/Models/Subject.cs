namespace StudyTracker.Models
{
    public class Subject
    {

        public int Id { get; set; }
        public string Name { get; set; }

       public string Lecturer { get; set; }

       public double CurrentMark { get; set; }


            //create a list that stores object type Task
     public  List<StudyTask> TaskList = new List<StudyTask>();

        public void AddTask(StudyTask task)
        { 
            TaskList.Add(task);
        
        }

    
        public void RemoveTask(int index)
        { 
        
        }


    }
}
