bool keepGoing = true;

do
{
    //requests user to input a number.
    Console.WriteLine("Please enter an integer: ");
    string entry = Console.ReadLine();
    int num = int.Parse(entry);

    //checks for a positive # & continues code, otherwise prompts instructions and if to continue.
    if (num > 0)
    {
        Console.WriteLine("Number\t\t Squared\t Cubed ");
        Console.WriteLine("=======\t\t =======\t =======");
    }
    else
        Console.WriteLine("Please enter positive number of 1 or greater:");

    //this is the math portion of the program, generates the square and cube of entry
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i}\t\t  {i * i}\t\t {i * i * i}");
    }

    //Asking the user if they would like to enter another number
    bool valid = false;
    do
    {
        Console.Write("Would you like to enter another number? (y/n): ");
        entry = Console.ReadLine().ToLower();
        if (entry == "n")
        {
            valid = true;
            keepGoing = false;
        }
        else if (entry == "y")
        {
            valid = true;
        }
    } while (valid == false);
}while (keepGoing);