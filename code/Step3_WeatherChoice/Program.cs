using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Выбор одежды по погоде");
Console.Write("Введите текущую температуру (С): ");
int temperature = Convert.ToInt32(Console.ReadLine());

if (temperature >= 20)
{
    Console.WriteLine("Найдите лёгкую одежду");
}
else
{
    Console.WriteLine("Найдите тёплую одежду");
}
Console.WriteLine("Хорошего дня!");