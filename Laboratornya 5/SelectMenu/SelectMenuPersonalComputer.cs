using System;
using System.Linq.Expressions;
using Class.Laptops;
using Class.PersonalComputers;
using SelectMenu.General;


namespace SelectMenu.MenuPersonalComputer
{
    internal class SelectMenuPersonalComputer
    {
        public static void selectPersonalComputer(PersonalComputer personalComputer, Laptop laptop)
        {
            string[] ActionSelection = { "Работа с файлами", "Вызвать ошибку", "Выход из програмы", "Начальное меню" };

            while (true)
            {
                try 
                {
                    GeneralSelectionMenu.clearConsole();
                    Console.WriteLine("Выберите действие (введите цифру):");
                    for (var i = 0; i < ActionSelection.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {ActionSelection[i]}");
                    }

                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            try
                            {
                                personalComputer.Files(personalComputer, laptop);
                                break;
                            }
                            catch (IndexOutOfRangeException)
                            {
                                Console.WriteLine($"Ошибка. Файла не сушествует или за данным индексом нечего не закреплено.");
                                break;
                            }
                        case "2":
                            personalComputer.ThrowAnException();
                            Console.ReadLine();
                            break;
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
