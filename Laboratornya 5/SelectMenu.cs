using System;

namespace Menu
{
    static internal class SelectMenu
    {
        public static void clearConsole()
        {
            Console.WriteLine("Нажмите любую клавижу что бы очистить консоль и перейти к выбору девайса.");
            Console.ReadKey();
            Console.Clear();
        }
        public static void selectMenu()
        {
            string[] SelectElectronicDevice = { "Персональный компьютер", "Ноутбук" };

            Console.WriteLine("Выберите устройство (введите цифру):");
            for (var i = 0; i < SelectElectronicDevice.Length; i++)
            {
                Console.WriteLine($"{i+1}. {SelectElectronicDevice[i]}");
            }

            int choice;
            while (true)
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Выбран Персональный компьютер.");
                            return; 
                        case 2:
                            Console.WriteLine("Выбран Ноутбук.");
                            return;
                        default:
                            Console.WriteLine("Ошибка: выбранная операция не найдена.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введите целое число.");
                }
            }
        }
    }
}
