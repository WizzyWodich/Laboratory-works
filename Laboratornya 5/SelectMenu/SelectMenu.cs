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

        public static void selectMenu(PersonalComputer personalComputer, Laptop laptop )
        {
            string[] SelectElectronicDevice = { "Персональный компьютер", "Ноутбук", "Выход из програмы" };

            Console.WriteLine("Выберите устройство (введите цифру):");

            for (var i = 0; i < SelectElectronicDevice.Length; i++)
                Console.WriteLine($"{i + 1}. {SelectElectronicDevice[i]}");
            

            // Главное меню выбора 
            while (true)
            {
                try
                {
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            try{
                                GeneralSelectionMenu.clearConsole();
                                Console.WriteLine("Выбран Персональный компьютер.");
                                SelectMenuPersonalComputer.selectPersonalComputer(personalComputer, laptop);
                                break;
                            }
                            catch(Exception ex){
                                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                                break;
                            }
                        case "2":

                            try{
                                GeneralSelectionMenu.clearConsole();
                                Console.WriteLine("Выбран Ноутбук.");
                                SelectMenuLaptop.selectMenuLaptop(personalComputer, laptop);
                                break;
                            }
                            catch (Exception ex){
                                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                                break;
                            }
                        case "3":
                            Environment.Exit(0);
                            return;
                        default:
                        Console.WriteLine("Ошибка: выбранная операция не найдена.");
                        break;
                    }
                }
                catch (FormatException) {
                    Console.WriteLine("Ошибка: введите цифру.");
                }
                finally{
                    Console.WriteLine("Спасибо что воспользовались методом. Удачи");
                }
            }
        }
    }
}


