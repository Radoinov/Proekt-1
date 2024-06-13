namespace Zadacha_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalCount = 0; 
            int negativeCount = 0; 

            while (true)
            {
                Console.Write("Vavedi chislo: ");
                int nums = int.Parse(Console.ReadLine());

                if (nums == 0)
                {
                    break;
                }

                totalCount++;

                if (nums < 0)
                {
                    negativeCount++;
                }
            }

            Console.WriteLine($"Obshto: {totalCount}");
            Console.WriteLine($"Broi otricatelni chisla: {negativeCount}");
        }
    }
}
