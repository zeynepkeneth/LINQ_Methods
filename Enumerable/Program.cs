// See https://aka.ms/new-console-template for more information

List<Student> studentList = new List<Student>
        {
            new Student(1, "John", "Doe", 85),
            new Student(2, "Jane", "Smith", 92),
            new Student(3, "Michael", "Johnson", 78),
            new Student(4, "Emily", "Brown", 95),
            new Student(5, "David", "Wilson", 89)
        };

//take
Console.WriteLine("Student list before:");
foreach (Student student in studentList)
    Console.WriteLine($"ID: {student.StudentID}, Name: {student.FirstName} {student.LastName}, Grade: {student.Grade}");
var firstThreeStudents = studentList.Take(3);
Console.WriteLine("First Three Students:");
foreach (Student student in firstThreeStudents)
    Console.WriteLine($"ID: {student.StudentID}, Name: {student.FirstName} {student.LastName}, Grade: {student.Grade}");
Console.WriteLine("\nend of take method:");

//skip
Console.WriteLine("Student list before:");
foreach (Student student in studentList)
    Console.WriteLine($"ID: {student.StudentID}, Name: {student.FirstName} {student.LastName}, Grade: {student.Grade}");
var remainingStudents = studentList.Skip(2);
Console.WriteLine("Remaining Students (after skipping the first 2):");
foreach (Student student in remainingStudents)
    Console.WriteLine($"ID: {student.StudentID}, Name: {student.FirstName} {student.LastName}, Grade: {student.Grade}");
Console.WriteLine("\nend of skip method:");

//Concat

List<Student> anotherStudentList = new List<Student>
        {
            new Student(6, "Sarah", "Miller", 88),
            new Student(7, "Robert", "Anderson", 91),
            new Student(8, "Amanda", "Wilson", 77),
            new Student(9, "Daniel", "Davis", 93),
            new Student(10, "Linda", "Moore", 85),
            new Student(11, "James", "Taylor", 79)
        };

var combinedStudentList = studentList.Concat(anotherStudentList);
Console.WriteLine("Combined Student List:");
foreach (Student student in combinedStudentList)
    Console.WriteLine($"ID: {student.StudentID}, Name: {student.FirstName} {student.LastName}, Grade: {student.Grade}");
Console.WriteLine("\nend of concat method:");

//Distinct
IEnumerable<int> distinctGrades = combinedStudentList.Select(student => student.Grade).Distinct();

Console.WriteLine("\nDistinct Grades:");
foreach (double grade in distinctGrades)
{
    Console.Write(grade + ", ");
}
Console.WriteLine("\nend of distinct method:");

//all
bool allPass = studentList.All(student => student.Grade >= 70);
Console.WriteLine("All students pass: " + allPass);
Console.WriteLine("\nend of all method:");

//Any
bool hasHighAchiever = studentList.Any(student => student.Grade > 90);
Console.WriteLine("At least one high achiever: " + hasHighAchiever);
Console.WriteLine("\nend of any method:");

//Where
var highAchievers = studentList.Where(student => student.Grade >= 90);
Console.WriteLine("High Achievers:");
foreach (var student in highAchievers)
    Console.WriteLine($"ID: {student.StudentID}, Name: {student.FirstName} {student.LastName}, Grade: {student.Grade}");
Console.WriteLine("\nend of where method:");

//OrderBy
var sortedStudents = studentList.OrderByDescending(student => student.Grade);

Console.WriteLine("\nStudents Ordered by Grade :");
foreach (var student in sortedStudents)
    Console.WriteLine($"ID: {student.StudentID}, Name: {student.FirstName} {student.LastName}, Grade: {student.Grade}");
Console.WriteLine("\nend of OrderBy method:");
