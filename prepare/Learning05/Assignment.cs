namespace Learning05
{
    public class Assignment(string studentName, string _topic)
    {
        protected string _studentName = studentName;

        public string GetSummary() => $"{_studentName} - {_topic}";
    }
}