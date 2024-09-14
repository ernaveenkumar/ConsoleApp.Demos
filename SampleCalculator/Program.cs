// See https://aka.ms/new-console-template for more informationConsole.WriteLine("-Welcome to the sample calculator");

//Show calculatoe options

using System.Xml.Serialization;
int choice = 0;
int num1, num2, answer = 0;

while (choice != -1)
{
    Console.WriteLine("If enter any key to continue and enter -1 to exit");
    Console.WriteLine("Please select an option");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtration");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");

    try
    {
        choice = Convert.ToInt32(Console.ReadLine());
    }catch (Exception)
    {
        Console.WriteLine("Invalid input, press any key to continue");
        Console.ReadLine();
        Console.Clear();    
        continue;
    }
    

    if (choice == -1) {
        break;
    }
        
    Console.WriteLine("Please enter the firstNumber");
    try
    {
        num1 = Convert.ToInt32(Console.ReadLine());

    }
    catch (Exception)
    {
        Console.WriteLine("Invalid Input");
        continue;
    }
        

    Console.WriteLine("Please enter the secondNumber");
    try
    {
       num2 = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Invalid Output");
        throw;
    }

        answer = 0;
    
            switch (choice)
            {

                case 1:
                    Console.WriteLine("Addiition");
                    answer = num1 + num2;
                    break;
                case 2:
                    Console.WriteLine("Subtraction");
                    answer = num1 - num2;
                    break;
                case 3:
                    Console.WriteLine("Multiplicatiojn");
                    answer = num1 * num2;
                    break;
                case 4:

            try
            {
                Console.WriteLine("Division");
                answer = num1 / num2;
                break;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Number cannot be divided by zero");
            }
            catch (Exception) {
                throw;
            }
                break;
                default:
                    Console.WriteLine("Invalid choice");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
            }
        
        Console.WriteLine($"Output is : {answer}"); Console.WriteLine("Hello, World!");
} 

