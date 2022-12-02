Console.Clear();

Console.Write("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

int i = 2;

if (a < 2)
{
    Console.Write("Слишком мала. Писчши бойьше.");
}    
else
while (a >= i)
{
    Console.Write($"{i} ");
    i+=2;
}
