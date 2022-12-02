Console.Clear();

Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)

    Console.WriteLine($"Максимум равен: {a}\nМинимум равен: {b}");

else 

    Console.WriteLine($"Максимум равен: {b}\nМинимум равен: {a}");
