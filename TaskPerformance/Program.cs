using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 grades separated by new line: ");

            double englishGrade = Convert.ToDouble(Console.ReadLine());
            double mapehGrade = Convert.ToDouble(Console.ReadLine());
            double scienceGrade = Convert.ToDouble(Console.ReadLine());
            double sibikaGrade = Convert.ToDouble(Console.ReadLine());
            double espGrade = Convert.ToDouble(Console.ReadLine());

            double average = (englishGrade + mapehGrade + scienceGrade + sibikaGrade + espGrade) / 5;
            double rounded = Math.Round(average);

            Console.WriteLine("The Average is " + average + " and round off to " + rounded);
            Console.WriteLine("Press any key to exit......");
            Console.ReadKey();

        }
    }
}