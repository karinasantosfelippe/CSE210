namespace Learning05
{
    // create a primary constructor with private member variables
    // that it inherits from the base Assignment class,
    // accepts all four parameters, and have it call the base class constructor to set the base class attributes that way  
    public class MathAssignment(string studentName, string topic, string _textbookSection, string _problems) : Assignment(studentName, topic)
    {
        // method to display the Math homework list including the section number and the problems
        public string GetHomeworkList () => $"Section {_textbookSection} Problems {_problems}";
    }
}