namespace JuniorDevChallenge1
{
    internal class Program
    {
        static void Main()
        {
            List<Student> studentNamesList = GetStudentList();

            // 根據學生成績輸出對應的等級
            NewMethod(studentNamesList);
        }

        private static List<Student> GetStudentList()
        {
            // 建立兩個 List 來儲存學生姓名與成績
            var studentNamesList = new List<Student>();
            var continueInput = "Y";

            // 使用 while 迴圈允許使用者不斷輸入學生資料
            while (continueInput == "Y" || continueInput == "y")
            { // 改成 do while 迴圈


                Console.WriteLine("請輸入學生姓名: ");
                string studentName = Console.ReadLine(); // 讀取學生姓名

                try
                {
                    Console.WriteLine("請輸入學生成績: ");
                    try
                    {
                        int studentScore = Convert.ToInt32(Console.ReadLine());
                        while (true)
                        {
                            if (studentScore < 0 || studentScore > 100)
                            {
                                Console.WriteLine("輸入成績超過範圍，請重新輸入");
                                studentScore = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                break;
                            }
                        }
                        studentNamesList.Add(new Student(studentName, studentScore));
                        Console.WriteLine("是否要輸入另一位學生？(Y/N)");
                        continueInput = Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("輸入的成績格式錯誤，請重新輸入");
                        Console.WriteLine("請輸入學生成績: ");
                        int studentScore = Convert.ToInt32(Console.ReadLine());
                        studentNamesList.Add(new Student(studentName, studentScore));
                        Console.WriteLine("是否要輸入另一位學生？(Y/N)");
                        continueInput = Console.ReadLine();

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("輸入的成績格式錯誤，請重新輸入");
                    Console.WriteLine("請輸入學生成績: ");
                    int studentScore = Convert.ToInt32(Console.ReadLine());
                    studentNamesList.Add(new Student(studentName, studentScore));
                    Console.WriteLine("是否要輸入另一位學生？(Y/N)");
                    continueInput = Console.ReadLine();
                }


            }

            return studentNamesList;
        }

        private static void NewMethod(List<Student> studentNamesList)
        {
            // 根據學生成績輸出對應的等級
            for (int i = 0; i < studentNamesList.Count; i++)
            {
                if (studentNamesList[i].Score >= 90)
                {
                    Console.WriteLine(studentNamesList[i].Name + " 的成績是 A");
                }
                else if (studentNamesList[i].Score >= 80)
                {
                    Console.WriteLine(studentNamesList[i].Name + " 的成績是 B");
                }
                else if (studentNamesList[i].Score >= 70)
                {
                    Console.WriteLine(studentNamesList[i].Name + " 的成績是 C");
                }
                else if (studentNamesList[i].Score >= 60)
                {
                    Console.WriteLine(studentNamesList[i].Name + " 的成績是 D");
                }
                else
                {
                    Console.WriteLine(studentNamesList[i].Name + " 的成績是 F");
                }
            }
        }
    }

}
