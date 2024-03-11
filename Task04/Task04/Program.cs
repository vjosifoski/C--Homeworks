namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            while (true)
            {
                Console.WriteLine("Please enter a name:");
                string name = Console.ReadLine();

                names.Add(name);

                Console.WriteLine("Do you want to enter another name (Y/N)?");
                string answer = Console.ReadLine().ToUpper();

                if (answer != "Y")
                {
                    break;
                }
            }

            Console.WriteLine("You have entered the following names:");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
        }
    }
}
