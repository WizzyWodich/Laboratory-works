using System;
using Class.PersonalComputers;
using SelectMenu.General;


namespace SelectMenu.MenuPersonalComputer
{
    internal class SelectMenuPersonalComputer
    {
        public static void selectPersonalComputer(PersonalComputer personalComputer)
        {
            string[] ActionSelection = { "Работа с файлами", "Testing" };

            while (true)
            {
                GeneralSelectionMenu.clearConsole();
                Console.WriteLine("Выберите действие (введите цифру):");
                for (var i = 0; i < ActionSelection.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {ActionSelection[i]}");
                }

                int choice;

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                char keyChar = keyInfo.KeyChar;

                if (char.IsDigit(keyChar))
                {
                    choice = int.Parse(keyChar.ToString());
                    switch (choice)
                    {
                        case 1:
                            try
                            {
                                personalComputer.Files();
                                break;
                            }
                            catch (IndexOutOfRangeException)
                            {
                                Console.WriteLine($"Ошибка. Файла не сушествует или за данным индексом нечего не закреплено.");
                                break;
                            }
                        case 2:
                            Console.WriteLine("TEsting.");
                            break;
                        case 3:
                            Environment.Exit(0);
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
