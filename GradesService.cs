namespace JuniorDevChallenge1
{
    internal class GradesService
    {
        public void GetStudentScore(List<Student> studentNamesList)
        {
            for (int i = 0; i < studentNamesList.Count; i++)
            {
                // 三元表達式 ?若非a等於b
                string grade = studentNamesList[i].Score >= 90 ? "A" :
                               studentNamesList[i].Score >= 80 ? "B" :
                               studentNamesList[i].Score >= 70 ? "C" :
                               studentNamesList[i].Score >= 60 ? "D" : "F";

                Console.WriteLine($"{studentNamesList[i].Name} 的成績是 {grade}");
            }
        }
    }
}