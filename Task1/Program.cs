Console.Write ("Введите X: ");
int x = int.Parse (Console.ReadLine ());
Console.Write ("Введите Y: ");
int y = int.Parse (Console.ReadLine ());

if (x > 0 && y > 0)
{
    Console.Write ("1");
}

if (x < 0 && y > 0)
{
    Console.Write ("2");
}

if (x < 0 && y < 0)
{
    Console.Write ("3");
}

if (x > 0 && y < 0)
{
    Console.Write ("4");
}