// Calling Main() to start my program
Main();

// Driver menu program that lets the user choose what calculation they want to make.
static void Main()
{
    Boolean isEnded = false;
    while (!isEnded)
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1. Draw Cat");
        Console.WriteLine("2. Add");
        Console.WriteLine("3. Subtract");
        Console.WriteLine("4. Multiply");
        Console.WriteLine("5. Divide");
        Console.WriteLine("6. Exit");
        Console.Write("Enter choice: ");
        string userInput = Console.ReadLine();
        Console.WriteLine(); // this is to make an empty line

        if (userInput == "1")
        {
            Drawcat();
        }
        else if (userInput == "2")
        {
            double x = Convert.ToDouble(Takeuserinput("Enter first number: "));
            double y = Convert.ToDouble(Takeuserinput("Enter second number: "));
            double sum = Sumoftwonumbers(x, y);
            Console.WriteLine(x + " + " + y + " = " + sum);
        }
        else if (userInput == "3")
        {
            double x = Convert.ToDouble(Takeuserinput("Enter first number: "));
            double y = Convert.ToDouble(Takeuserinput("Enter second number: "));
            double difference = Subtractionoftwonumbers(x, y);
            Console.WriteLine(x + " - " + y + " = " + difference);
        }
        else if (userInput == "4")
        {
            double x = Convert.ToDouble(Takeuserinput("Enter first number: "));
            double y = Convert.ToDouble(Takeuserinput("Enter second number: "));
            double multiply = Multiplicationoftwonumbers(x, y);
            Console.WriteLine(x + " * " + y + " = " + multiply);
        }
        else if (userInput == "5")
        {
            double x = Convert.ToDouble(Takeuserinput("Enter first number: "));
            double y = Convert.ToDouble(Takeuserinput("Enter second number: "));
            double divide = Divisionoftwonumbers(x, y);
            Console.WriteLine(x + " / " + y + " = " + divide);
        }
        else if (userInput == "6")
        {
            Console.WriteLine("Good bye!");
            isEnded = true;
        }
        else
        {
            Console.WriteLine("Please make a valid choice.");
        }

        Console.WriteLine(); // making another empty line
    }

    Console.ReadKey();

}

// Everything below this is a function that I will call in Main

// user input function that takes and returns the user's imput
static string Takeuserinput(string prompt)
{
    Console.Write(prompt);
    string input = Console.ReadLine();
    return input;
}

// Void function that displays a cat on the console
static void Drawcat()
{
    Console.WriteLine("  A___A");
    Console.WriteLine(" ( o o )");
    Console.WriteLine("-==_Y_==-");
    Console.WriteLine("   `-'");
}

// This is a function that takes two numbers as paramaters adds them together and returns the sum of the two numbers.
static double Sumoftwonumbers(double x, double y)
{
    return x + y;
}

// This is a function that takes two numbers as paramaters subtracts them and returns the difference of the two numbers.
static double Subtractionoftwonumbers(double a, double b)
{
    return a - b;
}

// This is a function that takes two numbers as paramaters multiplies them together and returns the product of the two numbers.
static double Multiplicationoftwonumbers(double c, double d)
{
    return c * d;
}

// This is a function that takes two numbers as paramaters, Divides them together and returns the quotent of the two numbers.
static double Divisionoftwonumbers(double e, double f)
{
    return e / f;
}