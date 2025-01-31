static float GetValidNumber(string prompt)
{
    float number;
    while (true)
    {
        Console.Write(prompt);
        string input = Console.ReadLine();

        if (float.TryParse(input, out number))
        {
            return number; // Successfully parsed, return the number
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}

Console.WriteLine("Welcome to this basic calculator \nMade by: N1KX-Program");
    
//Inputing numbers
float number1 = GetValidNumber("Please input the first number: ");
float number2 = GetValidNumber("Please input the second number: ");

//Creating a condition for a loop
bool cond1 = false;

Repeat: //Label that the loop comes back to
    //Inputing the type of operation
    Console.WriteLine("Please input type of operation you would like to do: \nAvailable options: \n'+' - addition \n'-' - subtraction \n'*' - multiplication \n'/' - division \n(Use symbols)");
    string operation = Console.ReadLine(); //Reads the input of the user

do { 
    switch (operation)
    {
        case "+":
            Console.WriteLine($"Result: {number1 + number2}");
            cond1 = true;
            break;

        case "-":
            Console.WriteLine($"Result: {number1 - number2}");
            cond1 = true;
            break;

        case "*":
            Console.WriteLine($"Result: {number1 * number2}");
            cond1 = true;
            break;

        case "/":
            if (number2 != 0)
            {
                Console.WriteLine($"Result: {number1 / number2}");
                cond1 = true;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                cond1 = false;
            }
            break;

        default:
            Console.WriteLine("Invalid input. Please enter a valid operator. \n");
            cond1 = false;
            goto Repeat; //Comes back to the label
        
    }
} while (cond1 == false);