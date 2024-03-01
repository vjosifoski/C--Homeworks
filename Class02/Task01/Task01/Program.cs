namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 15;
            int num3 = 20;
            int num4 = 30;

            int avg = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine($"The average of the numbers {num1}, {num2}, {num3}, and {num4} is: {avg}");


            Console.WriteLine("Imput the First Number");
            string inputFirstNumber = Console.ReadLine();
            double convertedFirstNumber = Convert.ToDouble(inputFirstNumber);

            Console.WriteLine("Imput the Second Number");
            string inputSecondNumber = Console.ReadLine();
            double convertedSecondNumber = Convert.ToDouble(inputSecondNumber);

            Console.WriteLine("Imput the Third Number");
            string inputThirdNumber = Console.ReadLine();
            double convertedThirdNumber = Convert.ToDouble(inputThirdNumber);

            Console.WriteLine("Imput the Forth Number");
            string inputForthNumber = Console.ReadLine();
            double convertedForthNumber = Convert.ToDouble(inputForthNumber);

            double convertedResultAverageNumber = (convertedFirstNumber + convertedSecondNumber + convertedThirdNumber + convertedForthNumber) / 4;

            Console.WriteLine($"The Converted Average Number out of the 4 is : {convertedResultAverageNumber}");
        }
    }
}
