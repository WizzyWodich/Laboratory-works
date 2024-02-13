using System;
using Class.Laptops;
using Class.PersonalComputers;
using SelectMenu.General;

namespace SelectMenu.MenuLaptop
{
    internal class SelectMenuLaptop
    {
        public static void selectMenuLaptop (PersonalComputer personalComputer, Laptop laptop)
        {
            string[] ActionSelection = { "Калькулятор", "Тестовая строка", "Выход из програмы", "Начальное меню" };

            Console.WriteLine("Выберите действие (введите цифру):");
            for (var i = 0; i < ActionSelection.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {ActionSelection[i]}");
            }

            while (true)
            {
                try 
                {
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            GeneralSelectionMenu.clearConsole();
                            try
                            {
                                laptop.Calculator(personalComputer, laptop);
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                                break;
                            }
                        case "2":
                            try
                            {
                                laptop.Scheduler();
                                Console.ReadLine();
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                                break;
                            }
                        case "3":
                            Environment.Exit(0);
                            return;
                        case "4":
                            GeneralSelectionMenu.clearConsole();
                            GeneralSelectionMenu.selectMenu(personalComputer, laptop);
                            break;
                        default:
                            Console.WriteLine("Ошибка: выбранная операция не найдена.");
                            break;
                    }
                }
                catch(FormatException){
                    Console.WriteLine("Ошибка: введите цифру.");
                }
                finally{
                    Console.WriteLine("Спасибо что воспользовались методом. Удачи");
                }
            }
        }
    }
}
