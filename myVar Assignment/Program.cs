namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myVar = 5;

            myVar = -1 + 4 * myVar;
            Console.WriteLine(myVar);

            myVar = (35 + 5) % myVar;
            Console.WriteLine(myVar);

            myVar = 14 + -4 * 6 / 12;
            Console.WriteLine(myVar);

            myVar = 2 + 12 / 6 * 1 - myVar % 2;
            Console.WriteLine(myVar);

            myVar = myVar * myVar;
            {
                if (myVar < 10)
                    Console.WriteLine("myVar is less than 4!");
                else
                    Console.WriteLine("myVar is greater than 4!");
            }
        }
    }
}