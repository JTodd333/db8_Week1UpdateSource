Random ran = new Random();
 
for (int i=1; i<=25; i++)
{
    int num = ran.Next(1, 7);   //sets the min and max
    Console.WriteLine(num);
}
