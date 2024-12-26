namespace StudentGathering;
class Program
{
    static void Main()
    {
        Classroom[] classrooms =
        {
            new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"} },
            new Classroom { Students = {"Anna", "Viktor", "Vladimir"} },
            new Classroom { Students = {"Bulat", "Alex", "Galina"} }
        };

        Console.WriteLine(string.Join(", ", GatherStudents(classrooms)));
        Console.ReadKey();
    }

    static IEnumerable<string> GatherStudents(Classroom[] classrooms)
    {
        var allStudents = from classroom in classrooms
                          from student in classroom.Students
                          select student;
        foreach (var student in allStudents) { yield return student; }
    }

    class Classroom { public List<string> Students = new List<string>(); }
}
