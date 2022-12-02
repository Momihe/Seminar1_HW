Console.Clear();

Console.Write("Введите число для проверки четности: ");

int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
    Console.WriteLine($"Число {a} - четное ");
else 
    Console.WriteLine($"Число {a} - не четное ");