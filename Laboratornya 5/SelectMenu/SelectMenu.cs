using System;
using PersonalComputers;
using Laptops;



namespace Menu
{
    internal class SelectMenu
    {
        public static void clearConsole()
        {
            Console.WriteLine("Нажмите любую клавижу что бы очистить консоль и перейти далее.");
            Console.ReadKey();
            Console.Clear();
        }

        public static void selectMenu(Laptop laptop, PersonalComputer computer)
        {
            string[] SelectElectronicDevice = { "Персональный компьютер", "Ноутбук" };

            Console.WriteLine("Выберите устройство (введите цифру):");
            for (var i = 0; i < SelectElectronicDevice.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {SelectElectronicDevice[i]}");
            }

            int choice;

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                char keyChar = keyInfo.KeyChar;

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Выход из прграмы.");
                    break;
                }

                else if (char.IsDigit(keyChar))
                {
                    choice = int.Parse(keyChar.ToString());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Выбран Персональный компьютер.");
                            return;
                        case 2:
                            SelectMenu.clearConsole();
                            Console.WriteLine("Выбран Ноутбук.");
                            MenuLaptop.SelectMenuLaptop(laptop);
                            return;
                        default:
                            Console.WriteLine("Ошибка: выбранная операция не найдена.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введите цифру.");
                }
            }
        }
    }


    internal class MenuLaptop
    {
        public static void SelectMenuLaptop(Laptop laptop)
        {
            string[] SelectElectronicDevice = { "Калькулятор", "Тестовая строка" };

            Console.WriteLine("Выберите действие (введите цифру):");
            for (var i = 0; i < SelectElectronicDevice.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {SelectElectronicDevice[i]}");
            }

            int choice;

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                char keyChar = keyInfo.KeyChar;

                if (char.IsDigit(keyChar))
                {
                    choice = int.Parse(keyChar.ToString());
                    switch (choice)
                    {
                        case 1:
                            SelectMenu.clearConsole();
                            laptop.Calculator();
                            return;
                        case 2:
                            Console.WriteLine("Выбраны файлы.");
                            return;
                        default:
                            Console.WriteLine("Ошибка: выбранная операция не найдена.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введите цифру.");
                }
            }
        }
    }
}


