bool keepGoing = true;

do
{
    Console.WriteLine("Enter an integer between 1 and 100: ");
    string entry = Console.ReadLine();
    int num = int.Parse(entry);

   

    if (num % 2 == 0 && num >= 2 && num <= 24)
        Console.WriteLine("Even and less than 25.");
    else if (num % 2 == 0 && num >= 26 && num <= 60)
        Console.WriteLine("Even and between 26 and 60 inclusive.");
    else if (num % 2 == 0 && num > 60)
        Console.WriteLine("Even and greater than 60.");
    else if (num < 60)
        Console.WriteLine("Odd and less than 60.");
    else if (num > 60)
        Console.WriteLine("Odd and greater than 60.");

    bool valid = false;

    do
    {
        Console.Write("Would you like to go again? (y/n) ");
        entry = Console.ReadLine().ToLower();                     
        if (entry == "n" || entry == "no")
        {
            valid = true;
            keepGoing = false;
        }
        else if (entry == "y" || entry == "yes")
        {
            valid = true;
        }
    } while (valid == false);

} while (keepGoing);