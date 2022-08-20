Console.Write ("Введите номер четверти от 1 до 4: ");
int num = int.Parse (Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("x > 0 и y > 0");
}
if (num == 2)
{
    Console.WriteLine("x < 0 и y > 0");
}
if (num == 3)
{
    Console.WriteLine("x < 0 и y < 0");
}
if (num == 4)
{
    Console.WriteLine("x > 0 и y < 0");
}