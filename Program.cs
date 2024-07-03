namespace _8projtower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            int couple = 0;
            int notcouple = 0;

            int i = 0;

            while (i <= number)
            {
                if (i % 2 == 0)
                {
                    couple++;
                }
                else
                {
                    notcouple++;
                }
                i++;

                Console.WriteLine("Количетсво парных: " + couple);
                Console.WriteLine("Количество непарных: " + notcouple);
            }
        }
    }
}
