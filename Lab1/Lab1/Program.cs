using System;
namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string str;
            Console.Write("Please enter value 1 : ");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(val1);*/
            string name;
            string lname;
            int std;
            float grade;

            name = Console.ReadLine();
            lname = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out std);
            float.TryParse(Console.ReadLine(), out grade);

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("LastName: {0}", lname);
            Console.WriteLine("Student ID: {0}", std);
            Console.WriteLine("Grade: {0}", grade);
        }
    }
}

