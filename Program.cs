using System;

namespace Activity1
{
    class Grading
    {
        static float Compute(int Science, int Math, int English, int Filipino)
        {
            int sum = (Science + Math + English + Filipino);
            float Ave = (float)sum / 4;
            return Ave;
        }
        static void Main(String[] args)
        {
            int science, math, english, filipino;

            Console.Write("Enter grade in Science: ");
            science = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter grade in Math: ");
            math = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter grade in English: ");
            english = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter grade in Filipino: ");
            filipino = Convert.ToInt32(Console.ReadLine());

            float Ave = Compute(science, math, english, filipino);

            Console.WriteLine("  ");
            Console.WriteLine($"Final Grade: {Ave:F2}");
            Console.ReadKey();
        }
    }
}
