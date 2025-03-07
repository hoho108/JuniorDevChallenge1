﻿namespace JuniorDevChallenge1
{
    internal class StudentService
    {

        public List<Student> GetStudentList()
        {
            var studentNamesList = new List<Student>();
            var continueInput = "Y";

            do
            {
                Console.WriteLine("請輸入學生姓名: ");
                string? studentName = Console.ReadLine(); // 讀取學生姓名

                if (string.IsNullOrEmpty(studentName))
                {
                    Console.WriteLine("學生姓名不能為空，請重新輸入");
                    continue;
                }

                try
                {
                    Console.WriteLine("請輸入學生成績: ");
                    int studentScore = Convert.ToInt32(Console.ReadLine());
                    while (studentScore < 0 || studentScore > 100)
                    {
                        Console.WriteLine("輸入成績超過範圍，請重新輸入");
                        studentScore = Convert.ToInt32(Console.ReadLine());
                    }
                    studentNamesList.Add(new Student(studentName, studentScore));
                    Console.WriteLine("是否要輸入另一位學生？(Y/N)");
                    continueInput = Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("輸入的成績格式錯誤，請重新輸入");
                }

            } while (continueInput == "Y" || continueInput == "y");

            return studentNamesList;
        }
    }
}