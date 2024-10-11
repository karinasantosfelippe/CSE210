namespace Learning05
{
    // create a primary constructor with private member variables
    // that it inherits from the base Assignment class,
    // accepts all four parameters, and have it call the base class constructor to set the base class attributes that way  
    public class WritingAssignment (string studentName, string topic, string _title) : Assignment (studentName, topic)
    {
        // method to get the writing information which consists of the title and the student's name
        public string GetWritingInformation() => $"{_title} by {_studentName}";
    }
}