using System;
using Class.PersonalComputers;
using Class.Laptops;
using SelectMenu.MenuLaptop;
using SelectMenu.MenuPersonalComputer;


namespace SelectMenu.General
{
    internal class GeneralSelectionMenu
    {
        public static void clearConsole()
        {
            Console.Clear();
            Console.WriteLine("Консоль очищена");
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

                if (char.IsDigit(keyChar))
                {
                    choice = int.Parse(keyChar.ToString());
                    switch (choice)
                    {
                        case 1:
                            GeneralSelectionMenu.clearConsole();
                            Console.WriteLine("Выбран Персональный компьютер.");
                            SelectMenuPersonalComputer.selectPersonalComputer(computer);
                            break;
                        case 2:
                            
                            try{
                                Console.WriteLine("Выбран Ноутбук.");
                                SelectMenuLaptop.selectMenuLaptop(laptop);
                                break;
                            }
                            catch(Exception ex) { 
                                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                                break;
                            }
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


