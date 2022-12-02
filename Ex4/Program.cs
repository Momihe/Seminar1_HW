Console.Clear();

Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
    Console.WriteLine($"Максимум: {a}");
else if (b > a && b > c)
    Console.WriteLine($"Максимум: {b}");
else if (c > a && c > b)
    Console.WriteLine($"Максимум: {c}");
