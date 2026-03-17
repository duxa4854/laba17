System.Console.WriteLine("Таблицв умножения");
Console.Write("Введите число для таблицы умножения");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Таблица умножения дл {number}: ");
for (int i = 1; i <= 10; i++)
{
    int result = number * i;
    System.Console.WriteLine($"{number}x {i} = {result}");
}
Console.WriteLine("Конец программы");