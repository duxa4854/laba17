using System;

namespace WeatherClothing
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Програма выбора одежды по погоде");
            Console.WriteLine();

            Console.Write("Введите текущую температуру воздуха (С): ");

            if (double.TryParse(Console,ReadLine(),out double temperature))
            {
                Console.WriteLine();
                Console.WriteLine("Рекомендация по одежде:");
                if (temperature > 25)
                {
                    Console.WriteLine("Жаркая погода!");
                    Console.WriteLine("Рекомендуется:");
                    Console.WriteLine("• Футболка или майка");
                    Console.WriteLine("• Шорты или легкая юбка");
                    Console.WriteLine("• Головной убор (кепка, панама)");
                    Console.WriteLine("• Солнцезащитные очки");
                }
                else if (temperature > 15)
                {
                    Console.WriteLine("Теплая погода!");
                    Console.WriteLine("Рекомендуется:");
                    Console.WriteLine("• Легкая кофта или лонгслив");
                    Console.WriteLine("• Джинсы или брюки");
                    Console.WriteLine("• Легкая куртка или ветровка (по желанию)");
                }
                else if (temperature > 5)
                {
                    Console.WriteLine("Прохладная погода!");
                    Console.WriteLine("Рекомендуется:");
                    Console.WriteLine("• Свитер или толстовка");
                    Console.WriteLine("• Джинсы или теплые брюки");
                    Console.WriteLine("• Куртка или пальто");
                }
                else if (temperature > -10)
                {
                    Console.WriteLine("Холодная погода!");
                    Console.WriteLine("Рекомендуется:");
                    Console.WriteLine("• Теплый свитер");
                    Console.WriteLine("• Зимняя куртка или пуховик");
                    Console.WriteLine("• Шапка, шарф, перчатки");
                    Console.WriteLine("• Теплая обувь");
                }
                else
                {
                    Console.WriteLine("Очень холодно! (ниже -10°C)");
                    Console.WriteLine("Рекомендуется:");
                    Console.WriteLine("• Термобелье");
                    Console.WriteLine("• Несколько слоев одежды");
                    Console.WriteLine("• Очень теплая зимняя куртка");
                    Console.WriteLine("• Шапка, шарф, перчатки/варежки");
                    Console.WriteLine("• Теплая зимняя обувь");
                }
                
                Console.WriteLine();
                Console.WriteLine("Дополнительный совет:");
                if (temperature < 0)
                {
                    Console.WriteLine("Будьте осторожны - на дорогах может быть гололед!");
                }
                else if (temperature > 30)
                {
                    Console.WriteLine("Не забывайте пить больше воды и избегать долгого пребывания на солнце!");
                }
                else
                {
                    Console.WriteLine("Хорошего дня и приятной погоды!");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректное числовое значение температуры!");
            }
            
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
        }
    }
}