Console.Write ("Введите координаты X1: ");
int x1 = int.Parse (Console.ReadLine ());

Console.Write ("Введите координаты Y1: ");
int y1 = int.Parse (Console.ReadLine ());

Console.Write ("Введите координаты X2: ");
int x2 = int.Parse (Console.ReadLine ());

Console.Write ("Введите координаты Y2: ");
int y2 = int.Parse (Console.ReadLine ());

 

double dist = Math.Sqrt (Math.Pow (x2 - x1, 2) + Math.Pow (y2 -y1, 2));
Console.WriteLine ($"Расстояние между точками {dist:f2}");
