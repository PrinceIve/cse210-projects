public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 9a7f840fb4c45f45f87ad3cc060ae2b0a2c4b0fa
