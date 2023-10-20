public class Student
{
    public int StudentID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Grade { get; set; }

    public Student(int studentID, string firstName, string lastName, int grade)
    {
        StudentID = studentID;
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }
}
