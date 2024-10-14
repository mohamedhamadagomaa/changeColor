namespace changeColor.Console2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            while (true)
            {
                // the while loop for looping each time end the process
                Console.WriteLine("Choose the select option: ");
                Console.WriteLine("[1] change the background color \t\t[2] change the Foreground color");
                string selectedOption = Console.ReadLine();
                foreach (var color in Enum.GetNames(typeof(ConsoleColor)))
                    Console.WriteLine($"{color}");
                Console.Write("Please Enter the selected color name:");
                string colorName = Console.ReadLine();
                ConsoleColor selectedColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName, true);
                if (selectedOption == "1")
                {
                    Console.BackgroundColor = selectedColor;
                }
                else if (selectedOption == "2")
                {
                    Console.ForegroundColor = selectedColor;
                }
                else
                {
                    Console.WriteLine("Invalid Option !.");
                }
            }

        }

    }
}



