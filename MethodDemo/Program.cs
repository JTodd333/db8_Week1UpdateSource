
int first = TimesTwo(5);
Console.WriteLine(first);

int second = SomeNumber();
Console.WriteLine(second);

double area = CircleArea(3);
Console.WriteLine(area);

double area2 = TriangleArea(3, 3);
Console.WriteLine(area2);

PrintArea(10);

static int TimesTwo(int num)
{
    //ConsoleWriteLine(first); Can't do this because first is outside the function's scope.
    //The variables num and result have a scope of this function only.
    int result = num * 2;
    return result;
}

static int SomeNumber()
{
    return 20;
}

static double CircleArea(double radius)
{
    return Math.PI * radius * radius;
}

static double TriangleArea(int height, int width) //could also say double instead of ints to force it
{
    return height * width / 2.0; //Add .0 to 2 to force the calculation to be double (was using all ints before)
}

static void PrintArea (double radius)  //returns void means returns nothing.
{
    double area = CircleArea(radius);
    Console.WriteLine(area);
    //return var   wouldnt work since a void. Could only do return to leave function
}