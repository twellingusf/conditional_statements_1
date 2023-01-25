namespace Conditional_Statements_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to get in ISM 4300?");
            int n1 = int.Parse(Console.ReadLine());

            if ((n1 >= 90) && (n1 <= 100))
            {
                Console.WriteLine("Your grade will be an A.");
                Console.ReadKey(true);

            }
            else if ((n1 >= 80) && (n1 <= 89))
            {
                Console.WriteLine("Your grade will be an B.");
                Console.ReadKey(true);

            }
            else if ((n1 >= 70) && (n1 <= 79))
            {
                Console.WriteLine("Your grade will be an C.");
                Console.ReadKey(true);

            }
            else if ((n1 >= 60) && (n1 <= 69))
            {
                Console.WriteLine("Your grade will be an D.");
                Console.ReadKey(true);

            }
            else if (n1 < 60)
            {
                Console.WriteLine("Your grade will be an F.");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("Please enter a grade that is 100 or less:");
                Console.ReadKey(true);
            }
            try
            {
                Console.WriteLine("Enter a grade that is 100 or less:");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("The input is: " + n2);
            }
             catch
            {
                Console.WriteLine("Please enter a grade that is 100 or less");
                Console.ReadKey(true);
            }
        }
    }
}