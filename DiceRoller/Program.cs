Console.WriteLine("Welcome to the dice game!");
Console.WriteLine();

Console.WriteLine("How many sides would you like on your dice?");
string entry = Console.ReadLine();
int sides = int.Parse(entry);

bool keepGoing = true;

do
{
    Console.WriteLine("Press any key to roll the dice!");
    Console.ReadKey();
    if (sides == 6)
    {
        int roll6 = RandGen6(sides);
    }
    else
    {
        int roll = RandGen(sides);
    }




    static int RandGen6(int sides)
    {
        Random ran = new Random();
        int diceSide1 = ran.Next(1, 7);
        int diceSide2 = ran.Next(1, 7);
        Console.WriteLine($"{diceSide1}, {diceSide2}");
        if (diceSide1 == 1 && diceSide2 == 1)
        {
            Console.WriteLine("Snake Eyes! o_o");
        }
        else if ((diceSide1 == 1 && diceSide2 == 2) || (diceSide1 == 2 && diceSide2 == 1))
        {
            Console.WriteLine("Ace Deuce!");
        }
        else if ((diceSide1 == 6) && (diceSide2 == 6))
        {
            Console.WriteLine("Box Cars!");
        }
        else if ((diceSide1 + diceSide2 == 7) || (diceSide1 + diceSide2 == 11))
        {
            Console.WriteLine("WIN!");
        }
        if ((diceSide1 + diceSide2 == 2) || (diceSide1 + diceSide2 == 3) || (diceSide1 + diceSide2 == 12))
        {
            Console.WriteLine("Craps!");
        }

        return diceSide1 + diceSide2;

    }

    static int RandGen(int sides)
    {
        Random ran = new Random();
        int diceSide1 = ran.Next(1, (sides + 1));
        int diceSide2 = ran.Next(1, (sides + 1));
        Console.WriteLine($"{diceSide1}, {diceSide2}");
        return diceSide1;

    }

    bool valid = false;

    do
    {
        Console.Write("Would you like to roll again? (y/n) ");
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