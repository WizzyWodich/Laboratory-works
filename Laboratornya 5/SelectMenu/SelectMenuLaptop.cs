using System;
using Class.Laptops;
using SelectMenu.General;

namespace SelectMenu.MenuLaptop
{
    internal class SelectMenuLaptop
    {
        public static void selectMenuLaptop(Laptop laptop)
        {
            string[] ActionSelection = { "Калькулятор", "Тестовая строка" };

            Console.WriteLine("Выберите действие (введите цифру):");
            for (var i = 0; i < ActionSelection.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {ActionSelection[i]}");
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
                            GeneralSelectionMenu.clearConsole();
                            try
                            {
                                laptop.Calculator();
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                                break;
                            }
                        case 2:
                            Console.WriteLine("TEsting.");
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
