using System;

namespace Activity1
{
    class Grading
    {
        static float Compute(int Programming, int Multimedia, int Electives)
        {
            int sum = (Programming + Multimedia + Electives);
            float Ave = (float)sum / 3;
            return Ave;
        }
        static void Main(String[] args)
        {
            int programming, multimedia, electives;

            Console.Write("Enter grade in Programming: ");
            programming = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter grade in Multimedia: ");
            multimedia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter grade in Electives: ");
            electives = Convert.ToInt32(Console.ReadLine());

            float Ave = Compute(programming, multimedia, electives);

            Console.WriteLine("  ");
            Console.WriteLine($"Final Grade: {Ave:F2}");
            Console.ReadKey();
        }
    }
}
