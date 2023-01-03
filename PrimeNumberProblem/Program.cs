namespace PrimeNumberProblem
{
   class PrimeNumber
    {
        public static void DisplayPrimeNumber()
        {
            bool prime = true;

            Console.WriteLine("INPUT ANY NUMBER");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    Console.WriteLine("{0} NUMBER IS NOT A PRIME NUMBER ", num);
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine("{0} NUMBER IS A PRIME NUMBER ", num);
                Console.ReadLine();
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            PrimeNumber.DisplayPrimeNumber();
        }
    }
}
