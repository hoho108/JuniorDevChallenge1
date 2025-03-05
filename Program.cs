namespace JuniorDevChallenge1
{
    internal class Program
    {
        static void Main()
        {
            var studentService = new StudentService();
            var gradesService = new GradesService();
            var studentNamesList = studentService.GetStudentList();
            gradesService.GetStudentScore(studentNamesList);

        }
    }

}
