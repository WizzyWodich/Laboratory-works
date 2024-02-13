using System;
using Class.Computers;
using Class.PersonalComputers;
using Class.Laptops;
using SelectMenu.General;

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

            Console.ReadLine();
            GeneralSelectionMenu.clearConsole();
            GeneralSelectionMenu.selectMenu(computer, laptop);

            
            
             // Порядок на день
            
            Console.ReadLine();
        }
    }
}
