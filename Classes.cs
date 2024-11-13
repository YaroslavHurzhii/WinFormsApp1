namespace MauiApp1
{
    public class Assignment
    {
        public Guid AssignmentID { get; set; } = new Guid();
        public string Title { get; set; }
        public string Description { get; set; }

        public int PriorityID { get; set; }
        public Priority Priority { get; set; }

        public int StatusID { get; set; }
        public Status Status { get; set; }

        public override string ToString()
        {
            return $"{Title} - Priority: {Priority.PriorityName}, Status: {Status.StatusName}";
        }
    }

    public class Priority
    {
        public int PriorityID { get; set; }
        public string PriorityName { get; set; }
        public List<Assignment> Tasks { get; set; }
    }

    public class Status
    {
        public int StatusID { get; set; }
        public string StatusName { get; set; }
        public List<Assignment> Tasks { get; set; }
    }
}
