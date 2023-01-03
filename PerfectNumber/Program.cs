namespace PerfectNumber
{
    class PerfectNumber1
    {
        public static void DisplayNumber()
        {
            int i, sum=0;
            int mn, mx, n;
            
            Console.WriteLine("Enter The Starting range of Number");
            mn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Ending Range OF Number");
            mx= Convert.ToInt32(Console.ReadLine());

            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)

                        sum = sum + i;
                    i++;

                }
                if (sum == n)
                {
                    Console.WriteLine(" " + n);
                }
            }
           

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            PerfectNumber1.DisplayNumber();
        }
    }
}
