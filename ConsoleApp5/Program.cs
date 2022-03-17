using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string no;
            do
            {
                Console.WriteLine("No daxil edin:");
                no = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(no) || no.Length >0 || no.Length <6);


            int studentlimit;
            do
            {
                Console.WriteLine("Studentlimit daxil edin:");
                studentlimit = Console.ReadLine();

            } while (!CheckGroup(studentlimit));

            User user = new User(no, studentlimit);

            Console.WriteLine($"No: {user.No} \nStudentlimit: {user.Studentlimit}");
        }
        static bool CheckNo(string str)
        {
            bool hasUpper = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[0]) && char.IsUpper(str[1]))
                    hasUpper = true;

            }
            return hasUpper;
        }
    }
    
}
