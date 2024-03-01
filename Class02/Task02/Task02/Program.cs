namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 5;
            double secondNumber = 8;

            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            Console.WriteLine($"This is the First Number: {firstNumber} and this is the Second Number: {secondNumber}");

            Console.WriteLine("Imput the First Number");
            string inputFirstNumber = Console.ReadLine();
            double convertedFirstNumber = Convert.ToDouble(inputFirstNumber);

            Console.WriteLine("Imput the Second Number");
            string inputSecondNumber = Console.ReadLine();
            double convertedSecondNumber = Convert.ToDouble(inputSecondNumber);

            convertedFirstNumber = convertedFirstNumber + convertedSecondNumber;
            convertedSecondNumber = convertedFirstNumber - convertedSecondNumber;
            convertedFirstNumber = convertedFirstNumber - convertedSecondNumber;

            Console.WriteLine($"This is the First Number: {convertedFirstNumber} and this is the Second Number: {convertedSecondNumber}");
        }
    }
}
