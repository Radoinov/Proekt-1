namespace Zadacha_3
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
                Console.WriteLine($"Uchenik {i + 1}:");
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
                    Console.WriteLine($"Uchenik {i + 1}: Bel - {bulgarianGrades[i]}, Programirane - {programmingGrades[i]}");
                }
            }

            int highest = 0;
            int lowest = 0;
            double highestAvg = (bulgarianGrades[0] + programmingGrades[0]) ;
            double lowestAvg = (bulgarianGrades[0] + programmingGrades[0]);

            for (int i = 1; i < students; i++)
            {
                double avg = (bulgarianGrades[i] + programmingGrades[i]);

                if (avg > highestAvg)
                {
                    highestAvg = avg;
                    highest = i;
                }

                if (avg < lowestAvg)
                {
                    lowestAvg = avg;
                    lowest = i;
                }
            }

            
            Console.WriteLine($"Nai visok uspeh ima: {highest + 1}, Sreden uspeh: {highestAvg}");
            Console.WriteLine($"Ocenka po Bel: {bulgarianGrades[highest]}, Ocenka po Programirane: {programmingGrades[highest]}");

            Console.WriteLine($"Nai nisyk uspeh ima {lowest + 1}, Sreden uspeh: {lowestAvg}");
            Console.WriteLine($"Ocenka po Bel: {bulgarianGrades[lowest]}, Ocenka po Programirane: {programmingGrades[lowest]}");
        }
    }
}
