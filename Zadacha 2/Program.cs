namespace Zadacha_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko uchenika ima: ");
            int students = int.Parse(Console.ReadLine());

            int[] bulgarianGrades = new int[students];
            int[] programmingGrades = new int[students];

            for (int i = 0; i < students; i++)            
            {
                int studentNumber = i + 14;
                Console.WriteLine($"Uchenik {studentNumber}:");
                Console.Write("Ocenka po Bel: ");
                bulgarianGrades[i] = int.Parse(Console.ReadLine());
                Console.Write("Ocenka po Programirane: ");
                programmingGrades[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Uchenici s po visoka ocenka po programirane sa:");
            for (int i = 0; i < students; i++)
            {
                if (programmingGrades[i] > bulgarianGrades[i])
                {
                    int studentNumber = i + 14;
                    Console.WriteLine($"Uchenik {studentNumber}: Bel - {bulgarianGrades[i]}, Programirane - {programmingGrades[i]}");
                }
            }

        }
    }
}
