namespace FibonacciSeries
{
    class Fibonacci
    {
        public static void DispalyNumber()
        {
            int n1 = 0, n2 = 1, Number, n3;

            Console.WriteLine("Enter the Number");
            Number = Convert.ToInt32(Console.ReadLine());

            Console.Write(n1 + " " + n2);

            for (int i = 2; i < Number; i++)
            {
                n3 = n1 + n2;
                Console.Write(" " +n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Fibonacci.DispalyNumber();
        }
    }
}
