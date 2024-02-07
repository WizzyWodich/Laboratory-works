using System;
using Computers;
using PersonalComputers;
using Laptops;
using Menu;

namespace Laboratornya_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalComputer computer = new PersonalComputer("PersonalComputer", "N2133b", "Windows 11", 64);
            computer.OutputInfo();
            

            Laptop laptop = new Laptop("Laptop", "Aser Nitro 7+", "Windows 10 Home", 64, 3200);
            laptop.OutputInfo();

            SelectMenu.clearConsole();
            SelectMenu.selectMenu();
            
             // Запись и считывание файла
             // Калькулятор
             // 
            Console.ReadLine();
        }
    }
}
