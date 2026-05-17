namespace StudyTracker.Models
{
    public class SubjectManager
    {
        //A list that holds all the subjects for displaying


        private List<Subject> ListStorage { get; set; } = new List<Subject>();




        //variable type = Subject ---- Variable name = subject
        //A method that adds a subject to the list
        public void AddSubject(Subject subject)
        {
            ListStorage.Add(subject);

        }


        //A method that returns the list of subjects
        //usually wed say something like public int ReturnNumber
        //but here we want to return a list of subjects so we say public List<Subject> ReturnList
        public List<Subject> ReturnList()
        { 
        return ListStorage;
        }
    }
}
