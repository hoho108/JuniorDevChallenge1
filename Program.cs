namespace JuniorDevChallenge1
{
    internal class Program
    {
        static void Main()
        {
            var studentService = new StudentService();
            var studentNamesList = studentService.GetStudentList();
            studentService.GetStudentScore(studentNamesList);

            //List<Student> studentNamesList = StudentService.GetStudentList();
            //StudentService.GetStudentScore(studentNamesList);
        }
    }

}
