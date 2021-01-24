using System;

namespace Conditions
{
    class Program
    {
        //Grade Calculuation
        static void Main(string[] args)
        {
            String letterGrade;
            int gradePoint;

            //if...else
            gradePoint = Convert.ToInt32(Console.ReadLine());
            if (gradePoint < 100 && gradePoint >= 90)
            {
                letterGrade = "AA";
                Console.WriteLine(letterGrade);
            }
                
            else if(gradePoint < 90 && gradePoint >= 75)
            {
                letterGrade = "BB";
                Console.WriteLine(letterGrade);
            }
            else if (gradePoint < 75 && gradePoint >= 65)
            {
                letterGrade = "CC";
                Console.WriteLine(letterGrade);
            }
            else if (gradePoint < 65 && gradePoint >= 55)
            {
                letterGrade = "DD";
                Console.WriteLine(letterGrade);
            }
            else if (gradePoint < 55 && gradePoint >= 45)
            {
                letterGrade = "EE";
                Console.WriteLine(letterGrade);
            }
            else
            {
                letterGrade = "FF";
                Console.WriteLine(letterGrade);
            }

            //switch
            switch (letterGrade)
            {
                case "AA":
                    Console.WriteLine("Rank I");
                    break;
                case "BB":
                    Console.WriteLine("Rank II");
                    break;
                case "CC":
                    Console.WriteLine("Rank III");
                    break;
                case "DD":
                    Console.WriteLine("Rank IV");
                    break;
                case "EE":
                    Console.WriteLine("Rank V");
                    break;
                default:
                    Console.WriteLine("Rank VI");
                    break;
            }
        }
    }
}
