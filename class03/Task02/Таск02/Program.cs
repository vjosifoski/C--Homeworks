namespace Таск02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int firstNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= firstNumber; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Please enter another number:");
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = secondNumber; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
