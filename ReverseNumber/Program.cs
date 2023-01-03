namespace ReverseNumber
{
    class Reverse
    {
        public static void DisplayNumber()
        {
            int Number, reverse = 0, reminder;

            Console.WriteLine("Enter the Number");
            Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Reverse Number");
            Console.WriteLine(Number);

            while(Number!=0)
            {
                reminder = Number % 10;
                reverse= reverse * 10+reminder;
                Number = Number / 10;
            }
            Console.WriteLine("After The Reverse Number");
            Console.WriteLine(reverse);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Reverse.DisplayNumber();
        }
    }
}
